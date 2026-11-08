using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using mysqlconnection;
using MyTools;
namespace ShipTrackingDataLayer
{
    public class shipTrackingDatalayer
    {
        public static bool Insert_ShipTracking_Info(int shipID)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"insert into shipmentstracking(shipmentID,shipmentstatusID,location,description,updatedat)
                        values(@shipID,@shipstatusID,@location,@desc,@updatedAt)";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    command.Parameters.AddWithValue("@location", "Giza");
                    command.Parameters.AddWithValue("@desc", "Shipment Has Been Confirmed");
                    command.Parameters.AddWithValue("@updatedat", DateTime.Now);
                    command.Parameters.AddWithValue("@shipstatusID", 2);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Insert Ship Tracking Info", ex.Message); }
                    return false;
                }
            }
        }
        public static bool Cancel_ShipTracking(int shipID)
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update shipmentstracking
                               set shipmentstatusID=7 where shipmentID=@shipID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch (Exception ex) { myTools.Register_Error("Cancel ShipmentsTracking", ex.Message); return false; }
                }

            }
        }
        public static bool Delete_CancelledShipsTracking()
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"delete from shipmentstracking where shipmentstatusID=7";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch (Exception ex) { myTools.Register_Error("Delete cancelled shipsTracking", ex.Message); return false; }
                }
            }
        }
        public static bool Get_ShipTracking_Info_ByShipID(int userID,int shipID,ref int trackingID,ref string location,
             ref string description,ref string shipstatus,ref DateTime updatedAt)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select top 1 st.trackingID,st.shipmentID,st.location,st.description,st.updatedAt
                        ,(select statusname from shipmentstatuses where shipmentstatusID=st.shipmentstatusID)as shipmentstatus
                         from shipmentstracking st join shipments on st.shipmentID=shipments.shipmentID
                            where st.shipmentID=@shipID and shipments.customerID=@userID order by trackingID desc";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    command.Parameters.AddWithValue("@userID", userID);
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            if (reader.Read())
                            {
                                trackingID = (int)reader["trackingID"];
                                location = (string)reader["location"];
                                description = (string)reader["description"];
                                shipstatus = (string)reader["shipmentstatus"];
                                updatedAt = Convert.ToDateTime(reader["updatedat"]);
                                return true;
                            }
                        }
                        catch(Exception ex) { myTools.Register_Error("Get ShipTracking Info By shipID", ex.Message); }
                    }
                    return false;
                }
            }
        }
        public static bool Does_ShipID_Exist(int shipID,int userID)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select found=1 from shipmentstracking st join shipments on st.shipmentID=shipments.shipmentID
                            where st.shipmentID=@shipID and shipments.customerID=@userID";
                using (SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    command.Parameters.AddWithValue("@userID", userID);
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                                return true;
                        }
                        catch(Exception ex) { myTools.Register_Error("Does ShipID Exist", ex.Message); }
                    }
                }
                return false;
            }
        }
        public static bool Does_ShipID_Exist(int shipID)
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select found=1 from shipmentstracking where shipmentID=@shipID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            if (reader.HasRows)
                                return true;
                        }
                        catch (Exception ex) { myTools.Register_Error("Does ShipID Exist", ex.Message); }
                    }
                }
                return false;
            }
        }
    }
}
