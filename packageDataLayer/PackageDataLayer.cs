using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTools;
using mysqlconnection;
using System.Data;
namespace packageDataLayer
{
    public class PackageDataLayer
    {
        public static bool Add_New_Package(int ShipID,string packageType,string packagesize,string packagedescrip
            ,decimal declaredvalue,bool isfragile)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"insert into packages(shipmentID,packagetype,packagesize,description,declaredvalue,isfragile)
                           values(@shipID,@packagetype,@packagesize,@description,@declaredvalue,@isfragile)";
                using (SqlCommand command =new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", ShipID);
                    command.Parameters.AddWithValue("@packagetype", packageType);
                    command.Parameters.AddWithValue("@packagesize", packagesize);
                    command.Parameters.AddWithValue("@description", packagedescrip);
                    command.Parameters.AddWithValue("@declaredvalue", declaredvalue);
                    command.Parameters.AddWithValue("@isfragile", isfragile);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Add Package", ex.Message);return false; }
                }
            }
        }
        public static DataTable Get_Packages_By_ShipID(int shipID)
        {
            DataTable dt = new DataTable();
            using(SqlConnection connection =new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = "select *from packages where shipmentID=@shipID";
                using(SqlCommand command =new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
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
                    catch(Exception ex)
                    {
                        myTools.Register_Error("Get packs by shipID", ex.Message);
                        return null;
                    }
                }
            }
            return null;
        }
        public static List<decimal> Get_Packages_Prices_By_ShipID(int shipID)
        {
            List<decimal> packagesprices = new List<decimal>();
            using (SqlConnection connection = new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = "select declaredvalue from packages where shipmentID=@shipID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@shipID", shipID);
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                packagesprices.Add((decimal)reader["declaredvalue"]);
                            }
                            return packagesprices;
                        }
                    }
                    catch (Exception ex)
                    {
                        myTools.Register_Error("Get packs Prices by shipID", ex.Message);
                    }
                }
            }
            return null;
        }
        public static bool Get_Package_By_PackID(int PackID, ref string packtype, ref string packagesize, ref string packDesc,
            ref decimal declaredvalue,ref bool isfragile)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = "select packagetype,packagesize,description,declaredvalue,isfragile from packages where packageID=@packID";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@packID", PackID);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        try
                        {
                            if (reader.Read())
                            {
                                packtype = (string)reader["packagetype"];
                                packDesc = (string)reader["description"];
                                packagesize = (string)reader["packagesize"];
                                declaredvalue = (decimal)reader["declaredvalue"];
                                isfragile = (bool)reader["isfragile"];
                                return true;
                            }
                        }
                        catch(Exception ex) { myTools.Register_Error("Get Pack By packID", ex.Message); }
                    }
                }
                return false;
            }
        }
        public static bool Update_Package(int packageID,string packagesize,string packagetype,decimal declaredvalue,bool isfragile,string desc)
        {
            using(SqlConnection connection=new SqlConnection(myconnection.C))
            {
                connection.Open();
                string query = @"update packages
                                set packagetype=@packtype,packagesize=@packsize,description=@desc,declaredvalue=@decval,isfragile=@isfrag 
                                 where packageID=@packID";
                using(SqlCommand command=new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@packtype", packagetype);
                    command.Parameters.AddWithValue("@packsize", packagesize);
                    command.Parameters.AddWithValue("@desc", desc);
                    command.Parameters.AddWithValue("@decval", declaredvalue);
                    command.Parameters.AddWithValue("@isfrag", isfragile);
                    command.Parameters.AddWithValue("@packID", packageID);
                    try
                    {
                        int rowsaffected = command.ExecuteNonQuery();
                        return rowsaffected > 0;
                    }
                    catch(Exception ex) { myTools.Register_Error("Update Pack", ex.Message); }
                }
                return false;
            }
        }
    }
}
