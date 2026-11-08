using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MyTools;
using mysqlconnection;
namespace UserDataAccessLayer
{
    public class clsuserdata
    {
        
        public static bool Add_New_User(string firstname,string secondname,string lastname,string username,
            string password,string phone,string email)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(myconnection.C))
                {
                    connection.Open();
                    string query = @"insert into users(firstname,secondname,lastname,username,password,phonenumber,email)
                   values(@firstname,@secondname,@lastname,@username,@password,@phonenumber,@email)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@firstname", firstname);
                        command.Parameters.AddWithValue("@secondname", secondname);
                        command.Parameters.AddWithValue("@lastname", lastname);
                        command.Parameters.AddWithValue("username", username);
                        command.Parameters.AddWithValue("password", password);
                        command.Parameters.AddWithValue("phonenumber", phone);
                        command.Parameters.AddWithValue("email", email);
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                }
            }
            catch(Exception ex) { myTools.Register_Error("AddNewUser",ex.Message); return false; }
        }
        public static bool GetUserInfo(string email, string password,ref int userID, ref string firstname, ref string secondname,
            ref string lastname, ref string username, ref string phone,ref int numofaddresses,ref int numofshipments,ref int completedshipments,ref int activeshipments)
        {
            try {
                using (SqlConnection connection = new SqlConnection(myconnection.C))
                {
                    connection.Open();
                    string query = @"select userID,firstname,secondname,lastname,username,phonenumber,
                        (select count(*) from addresses ad where ad.userId=users.userID)as numofaddresses,
                             (select count(*) from shipments sh where sh.customerID=users.userID) as numofshipments
                          ,(select count(*) from shipments sh where sh.customerId=users.userid and sh.shipmentstatusid =6) as 
                            completedshipments,(select count(*)from shipments sh where sh.customerID=users.userID and sh.shipmentstatusid between 1 and 5)as activeshipments 
                                 from users where email=@email and password=@password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("email", email);
                        command.Parameters.AddWithValue("password", password);
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            if (reader.Read())
                            {
                                userID = (int)reader["userID"];
                                firstname = (string)reader["firstname"];
                                secondname = (string)reader["secondname"];
                                lastname = (string)reader["lastname"];
                                username = (string)reader["username"];
                                phone = (string)reader["phonenumber"];
                                numofaddresses = (int)reader["numofaddresses"];
                                numofshipments = (int)reader["numofshipments"];
                                completedshipments = (int)reader["completedshipments"];
                                activeshipments = (int)reader["activeshipments"];
                                return true;
                            }
                        }
                    }
                }
            }
            catch(Exception ex) { myTools.Register_Error("GetUser", ex.Message); }
            return false;
        }
        public static bool DoesUserExist(string email,string password)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select found=1 from users where email=@email and password=@password";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    try
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                return true;
                        }
                    }
                    catch(Exception ex) { myTools.Register_Error("Does User Exist", ex.Message); }
                }
                return false;
            }
        }
        public static bool Does_Email_Exist(string email)
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select found=1 from users where email=@email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                return true;
                        }
                    }
                    catch (Exception ex) { myTools.Register_Error("Does Email Exist", ex.Message); }
                }
                return false;
            }
        }
        public static bool Update_User_Password(string email,string password)
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update users set password=@password where email=@email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@password", password);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch (Exception ex) { myTools.Register_Error("Update User Password", ex.Message); }
                }
                return false;
            }
        }
    }
}
