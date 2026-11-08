using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataAccessLayer;
using addressesBussinessLayer;
namespace userbusssinesslayer
{
    public class clsuser
    {
       public string fname { get; set; }
       public string sname { get; set; }
       public string lname { get; set; }
       public string phone { get; set; }
       public  string username { get; set; }
       public string email { get; set; }
       public string password { get; set; }
       public int numofaddresses { get; set; }
       public int numofshipments { get; set; }
       public int completedshipments { get; set; }
       public int activeshipments { get; set; }
       public int userID { get; }
       public clsaddresses address;
        private clsuser(int userID,string fname,string sname,string lname,string phone,string username,string email,
            string password,int numofaddresses,int numofshipments,int completedshipments,int activeshipments)
        {
            this.userID = userID;
            this.fname = fname;
            this.sname = sname;
            this.lname = lname;
            this.username = username;
            this.email = email;
            this.phone = phone;
            this.password = password;
            this.numofaddresses = numofaddresses;
            this.numofshipments = numofshipments;
            this.completedshipments = completedshipments;
            this.activeshipments = activeshipments;
        }
        public static bool Add_New_User(string firstname, string secondname, string lastname, string username,
            string password, string phone, string email)
        {
           return  clsuserdata.Add_New_User(firstname, secondname, lastname, username,
             password, phone, email);
        }
        public static clsuser GetUser(string email,string password)
        {
            string fname = "", Sname = "", Lname = "", phone = "", username = "";
            int numofshipments=0, numofaddresses=0,completedshipments=0,userID=0,activeshipments=0;
            if(clsuserdata.GetUserInfo(email,password,ref userID,ref fname,ref Sname,ref Lname,ref username,ref phone,ref numofaddresses,ref numofshipments,ref completedshipments,ref activeshipments))
            {
                return new clsuser(userID,fname,Sname,Lname,phone,username,email,password,numofaddresses,numofshipments,completedshipments,activeshipments);
            }
            return null;
        }
        public static bool Does_User_Exist(string email, string password)
        {
            return clsuserdata.DoesUserExist(email, password);
        }
        public static bool Update_User_Password(string email,string password)
        {
            return clsuserdata.Update_User_Password(email,password);
        }
        public static bool Does_Email_Exist(string email)
        {
            return clsuserdata.Does_Email_Exist(email);
        }
    }
}
