using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using mysqlconnection;
using MyTools;
namespace addressesdatalayer
{
    public class Addressdatalayer
    {
        public static DataTable GetGovernorates()
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = "select Governoratename from governorates";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                            return dt;
                        }
                    }
                    catch (Exception ex) { myTools.Register_Error("GetGovernorates", ex.Message); }
                }
            }
            return null;
        }
        public static bool Add_New_Address(int userID, string governorate, string city, string area, string street,
            int buildingnum, string postalcode, string addresstype)
        {
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"insert into addresses(userID,governorateID,city,area,street,buildingnumber,
                 postalcode,addresstype)values(@userID,@govID,@city,@area,@street,@buildingnumber,@postalcode,@addresstype)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@govID", governorate);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@area", area);
                    command.Parameters.AddWithValue("@street", street);
                    command.Parameters.AddWithValue("@buildingnumber", buildingnum);
                    command.Parameters.AddWithValue("@postalcode", postalcode);
                    command.Parameters.AddWithValue("@addresstype", addresstype);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch (Exception ex) { myTools.Register_Error("add Address", ex.Message); }
                }
            }
            return false;
        }
        public static SortedDictionary<string,string> GetUserAddresses(int userID)
        {
            SortedDictionary<string,string> addresses = new SortedDictionary<string, string>();
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select ((select governoratename from governorates where governorateID=addresses.governorateID)+','+city+','+area+','+street)as address,addresstype from addresses where
                     userID = @userID order by addresstype";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("userID", userID);
                    
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                addresses.Add((string)reader["addresstype"],(string)reader["address"]);
                            }
                            return addresses;
                        }
                    }
                    catch (Exception ex)
                    {
                        myTools.Register_Error("Get Address", ex.Message);
                    }
                    return null;
                }
            }
        }
        public static DataTable GetAddressesInMainScreen(int userID)
        {
            DataTable addresses = new DataTable();
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select* from addresses where
                     userID = @userID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("userID", userID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows) addresses.Load(reader);
                            return addresses;
                        }
                    }
                    catch (Exception ex)
                    {
                        myTools.Register_Error("Get Address", ex.Message);
                    }
                    return null;
                }
            }
        }
        public static bool UpdateAddress(int addressID,string governorate,string area,string city,string street,
            string buildingnumber,string postalcode,string addresstype)
        {
            using(SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update addresses 
                              set governorateID=@governorateID,area=@area,city=@city,street=@street,
                                 buildingnumber=@buildingnumber,postalcode=@postalcode,addressType=@addresstype
                                where addressID=@addressID";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@addressID", addressID);
                    command.Parameters.AddWithValue("@governorateID", governorate);
                    command.Parameters.AddWithValue("@area", area);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@street", street);
                    command.Parameters.AddWithValue("@buildingnumber", buildingnumber);
                    command.Parameters.AddWithValue("@postalcode", postalcode);
                    command.Parameters.AddWithValue("@addresstype", addresstype);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("UpdateAddress", ex.Message); }
                    return false;
                }
            }
        }
        public static Dictionary<string,string> Get_Address_By_AddID(int addressID)
        {
            Dictionary<string, string> addressinfo = new Dictionary<string, string>();
            using(SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = "select *from addresses where addressID=@addressID";
                using(SqlCommand command =new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("addressID", addressID);
                    using(SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            addressinfo.Add("governorateID", (string)reader["governorateID"]);
                            addressinfo.Add("area", (string)reader["area"]);
                            addressinfo.Add("city", (string)reader["city"]);
                            addressinfo.Add("street", (string)reader["street"]);
                            addressinfo.Add("buildingnumber", (string)reader["buildingnumber"]);
                            addressinfo.Add("postalcode", (string)reader["postalcode"]);
                            addressinfo.Add("addresstype", (string)reader["addresstype"]);
                            addressinfo.Add("UserID",Convert.ToString(reader["userID"]));
                            return addressinfo;
                        }
                    }
                }
            }
            return null;
        }
        public static bool DeleteAddress(int AddID)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                string query = "delete from addresses where addressID=@addressID";
                connection.Open();
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("addressID", AddID);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Delete Address", ex.Message); }
                    return false;
                }
            }
        }
        public static bool IsTheChosenAddressTypeExisted(int userID,string addresstype)
        {
            using(SqlConnection connection =new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = "select found=1 from addresses where userID=@userID and addresstype=@addresstype";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@addresstype", addresstype);
                    try
                    {
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return true;
                            }
                        }
                    }
                    catch(Exception ex) { myTools.Register_Error("Is The Chosen addressType existed", ex.Message); }
                    return false;
                }
            }
        }
        public static int Get_AddID_ByAddType(int userID,string addType)
        {
            using(SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"select addressID from addresses where userID=@userID and Addresstype=@addtype";
                using(SqlCommand command =new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userID", userID);
                    command.Parameters.AddWithValue("@addtype", addType);
                    try
                    {
                        object result = command.ExecuteScalar();
                        if(int.TryParse(result.ToString(),out int AddID))
                        {
                            return AddID;
                        }
                    }
                    catch(Exception ex)
                    { myTools.Register_Error("Get AddID By AddType", ex.Message); return -1; }
                    }
                return -1;
            }
        }
       
    }
}