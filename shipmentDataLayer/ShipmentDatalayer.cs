using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using mysqlconnection;
using MyTools;
namespace shipmentDataLayer
{
    public class ShipmentDatalayer
    {
        public static int Add_New_Shipment(int customerID,int AddID,string sendername,string receivername,
            string receiverphone,string delAddDes,decimal totalprice)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"insert into shipments(customerID,sendername,receivername,receiverphone,pickupaddressID
                            ,deliveryaddressdescription,shipmentstatusID,createdAt,estimateddeliverydate
                             ,actualdeliverydate,totalprice)values(@customerID,@sendername,@receivername,@receiverphone,@pickupaddressID
                            ,@deliveryaddressdescription,@shipmentstatusID,@createdAt,@estimateddeliverydate
                             ,@actualdeliverydate,@totalprice);
                               select SCOPE_IDENTITY();";
                using (SqlCommand command =new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@sendername", sendername);
                    command.Parameters.AddWithValue("@receivername", receivername);
                    command.Parameters.AddWithValue("@receiverphone", receiverphone);
                    command.Parameters.AddWithValue("@pickupaddressID", AddID);
                    command.Parameters.AddWithValue("@deliveryaddressdescription", delAddDes);
                    command.Parameters.AddWithValue("@createdat",DateTime.Now);
                    command.Parameters.AddWithValue("@estimateddeliverydate", DateTime.Now.AddDays(3));
                    command.Parameters.AddWithValue("@actualdeliverydate", DBNull.Value);
                    command.Parameters.AddWithValue("@totalprice", totalprice);
                    command.Parameters.AddWithValue("@shipmentstatusID",1);
                    try
                    {
                        object result = command.ExecuteScalar();
                        if(int.TryParse(result.ToString(),out int shipID))
                        {
                            return shipID;
                        }
                    }
                    catch(Exception ex) { myTools.Register_Error("Add New Shipment", ex.Message);return -1; }
                }
                return -1;
            }
        }
        public static DataTable GetUserShipments(int customerID)
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"Select shipmentID,sendername,receivername,receiverphone,(select addresstype from addresses where addressID=shipments.pickupaddressID)as pickupaddress,
                                deliveryaddressdescription,(select statusname from shipmentstatuses where shipmentstatusID=shipments.shipmentstatusID)as shipmentstatus
                              , createdat,estimateddeliverydate,actualdeliverydate,totalprice from shipments where customerID=@customerID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@customerID",customerID);
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if(reader.HasRows)
                            {
                                dt.Load(reader);
                                return dt;
                            }
                        }
                    }
                    catch(Exception ex) { myTools.Register_Error("Get User Shipments", ex.Message); }
                }
            }
            return null;
        }
        public static bool Get_Shipment_By_shipID(int shipID,ref int customerID,ref string receivername,ref string receiverphone,
            ref string sendername,ref string descrip,ref string AddressType,ref decimal TotalAmount)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select sendername,customerID,receivername,totalprice,receiverphone,deliveryaddressdescription,
                              (select addresstype from addresses where addressID=shipments.pickupaddressID) as addresstype
                           from shipments where shipmentID=@shipID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue(@"shipID", shipID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            if (reader.Read())
                            {
                                receivername = (string)reader["receivername"];
                                sendername = (string)reader["sendername"];
                                receiverphone = (string)reader["receiverphone"];
                                descrip = (string)reader["deliveryaddressdescription"];
                                AddressType = (string)reader["addresstype"];
                                customerID = (int)reader["customerID"];
                                TotalAmount = (decimal)reader["Totalprice"];
                                return true;
                            }
                        }
                        catch (Exception ex) { myTools.Register_Error("Get ship by shipID", ex.Message); }
                        return false;
                    }
                }
            }
        }
        public static bool Update_Shipment(int shipID,int addID,string receivername,string sendername,string desc,string receiverphone)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update shipments set sendername=@sendername,receivername=@receivername
                      ,receiverphone=@receiverphone,deliveryaddressdescription=@dad,pickupaddressID=@addID
                         where shipmentID=@shipID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@sendername", sendername);
                    command.Parameters.AddWithValue("@receivername", receivername);
                    command.Parameters.AddWithValue("@receiverphone", receiverphone);
                    command.Parameters.AddWithValue("@dad", desc);
                    command.Parameters.AddWithValue("@addID", addID);
                    command.Parameters.AddWithValue("@shipID", shipID);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Update shipment", ex.Message);return false; }
                }
                
            }
        }
        public static bool Cancel_Shipment(int ShipID)
        {
            using(SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update shipments
                               set shipmentstatusID=7 where shipmentID=@shipID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", ShipID);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Cancel Shipment", ex.Message);return false; }
                }

            }
        }
        public static bool Delete_CancelledSipments()
        {
            using(SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"delete from shipments where shipmentstatusID=7";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Delete cancelled ships", ex.Message);return false; }
                }
            }
        }
        public static bool Is_There_AnyCancelledShips()
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select found=1 from shipments where shipmentstatusID=7";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                return true;
                        }
                    }
                    catch (Exception ex) { myTools.Register_Error("Is There Any Cancelled Ships", ex.Message);}
                }
                return false;
            }
        }
        public static bool Is_Shipment_Cancelled(int shipID)
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select found=1 from shipments where shipmentstatusID=7 and shipmentID=@shipID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                return true;
                        }
                    }
                    catch (Exception ex) { myTools.Register_Error("Is Shipment Cancelled", ex.Message); }
                }
                return false;
            }
        }
        public static bool Update_ship_Status(int shipID)
        {
              using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update shipments set shipmentstatusID=@shipstatusID where shipmentID=@shipID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipstatusID", 2);
                    command.Parameters.AddWithValue("@shipID", shipID);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Update Ship Status in Shipments", ex.Message); }
                    return false;
                }
            }
        }
        public static bool Update_Shipment_Total_Price(int shipID,decimal totalprice)
        {
            using(SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update shipments set totalprice=@totalprice where shipmentID=@shipID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    command.Parameters.AddWithValue("@totalprice", totalprice);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Update Shipment Total Price", ex.Message); }
                }
                return false;
            }
        }
    }
}
