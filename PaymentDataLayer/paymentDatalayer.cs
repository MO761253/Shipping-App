using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using mysqlconnection;
using MyTools;
using System.Data;
namespace PaymentDataLayer
{
    public class paymentDatalayer
    {
        public static bool AddNewBill(int shipID,decimal Amount,string paymentmethod)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"insert into payments(shipmentID,Amount,paymentmethod,paymentstatusID,paidat)
                            values(@shipID,@amount,@paymethod,@paystatusID,@paidat)";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    command.Parameters.AddWithValue("@amount", Amount);
                    command.Parameters.AddWithValue("@paidat", DateTime.Now);
                    command.Parameters.AddWithValue("@paymethod", paymentmethod);
                    command.Parameters.AddWithValue("@paystatusID", (paymentmethod == "Credit Card") ? 2 : 1);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Add New Bill", ex.Message); }
                    return false;
                }
            }
        }
        public static bool Does_ShipBill_Exist(int shipID)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select found=1 from payments where shipmentID=@shipID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    try
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.HasRows)
                                return true;
                        }
                    }
                    catch(Exception ex) { myTools.Register_Error("Does Ship Bill Exist ?", ex.Message); }
                }
                return false;
            }
        }
        public static DataTable Get_All_UserBills(int userID)
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select payments.paymentID,payments.shipmentID,payments.amount,payments.paymentmethod,
                            (select statusname from paymentstatuses where paymentstatusID=payments.paymentstatusID)as PaymentStatus,
                             PaidAt
                            from payments join shipments on payments.shipmentID=shipments.shipmentID
                           where shipments.customerID=@userID";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    try
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                                return dt;
                            }
                        }
                    }
                    catch(Exception ex) { myTools.Register_Error("Get All User's Bills", ex.Message); }
                    return null;
                }
            }
        }
        public static bool Delete_ShipBill(int shipID)
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"delete payments
                                where shipmentID=@shipID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch (Exception ex) { myTools.Register_Error("Delete_ShipBill", ex.Message); return false; }
                }

            }
        }
    }
}
