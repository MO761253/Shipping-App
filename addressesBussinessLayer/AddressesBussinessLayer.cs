using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using addressesdatalayer;
namespace addressesBussinessLayer
{
    public class clsaddresses
    {
        public string Home { get; set; }
        public string Work { get; set; }
        public string Other { get; set; }
        private clsaddresses(string home,string Work,string Other)
        {
            Home = home;
            this.Work = Work;
            this.Other=Other;
        }
        public static DataTable GetGovernorates()
        {
            return Addressdatalayer.GetGovernorates();
        }
        public static bool Add_New_Address(int userID, string governorate, string city, string area, string street
             , int Bnumber, string postalcode,string addresstype)
        {
            return Addressdatalayer.Add_New_Address(userID, governorate, city, area, street, Bnumber, postalcode, addresstype);
        }
        public static clsaddresses Get_User_Addresses(int userid)
        {
            string home="", work="", other="";
            SortedDictionary<string,string> addresses = Addressdatalayer.GetUserAddresses(userid);
            if (addresses!=null)
            {
                if (addresses.ContainsKey("Home"))
                {
                    home = addresses["Home"];
                }
                if (addresses.ContainsKey("Work"))
                {
                    work = addresses["Work"];
                }
                if (addresses.ContainsKey("Other"))
                {
                    other = addresses["Other"];
                }
                return new clsaddresses(home, work, other);
            }
            return null;
        }
        public static DataTable Get_Addreses_In_MainScreen(int userID)
        {
            return Addressdatalayer.GetAddressesInMainScreen(userID);
        }
        public static Dictionary<string,string> Get_Address_By_ID(int addID)
        {
            return Addressdatalayer.Get_Address_By_AddID(addID);
        }
        public static bool DeleteAddress(int AddID)
        {
            return Addressdatalayer.DeleteAddress(AddID);
        }
        public static bool UpdateAddress(int AddressID, string governorate, string area, string city, string street,
            string buildingnumber, string postalcode, string addresstype)
        {
            return Addressdatalayer.UpdateAddress(AddressID, governorate, area, city, street,
             buildingnumber, postalcode, addresstype);
        }
        public static bool IsTheChosenAddressTypeExisted(int userID, string addresstype)
        {
            return Addressdatalayer.IsTheChosenAddressTypeExisted(userID, addresstype);
        }
        public static int Get_AddID_ByAddressType(string addtype,int userID)
        {
            return Addressdatalayer.Get_AddID_ByAddType(userID, addtype);
        }
    }
}
