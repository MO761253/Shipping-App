using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Win32;
using System.Security.Cryptography;
namespace MyTools
{
    public class myTools
    {
        private static string keypath = @"HKEY_CURRENT_USER\Software\User_Registration";
        public static void Register_Error(string sourcename,string exMessage)
        {
            try
            {
                if (!EventLog.SourceExists(sourcename))
                {
                    EventLog.CreateEventSource(sourcename,"Application");
                }
                EventLog.WriteEntry(sourcename, exMessage, EventLogEntryType.Error);
            }
            catch (System.Security.SecurityException)
            {
                EventLog.WriteEntry("Application", $"{sourcename}:{exMessage}", EventLogEntryType.Error);
            }
        }
        public static void Remember_user_Registration(string email,string password)
        {
            try
            {
                Registry.SetValue(keypath,"UserEmail",email);
                Registry.SetValue(keypath, "UserPassword", password);
            }
            catch(Exception ex) { Register_Error("UserRegistration", ex.Message); }
        }
        public static bool Get_User_Registration_Info(ref string email,ref string password)
        {
            try
            {
                email = Registry.GetValue(keypath, "UserEmail", null) as string;
                password = Registry.GetValue(keypath, "UserPassword", null) as string;
                if(email!=null && password != null)
                {
                    return true;
                }
            }
            catch(Exception ex) { Register_Error("Get_User_Info", ex.Message); }
            return false ;
        }
        public static bool Delete_User_Registration_Info()
        {
            try
            {
                using(RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using(RegistryKey key = baseKey.OpenSubKey(@"Software\User_Registration", true))
                    {
                        if(key != null)
                        {
                            key.DeleteValue("UserEmail");
                            key.DeleteValue("UserPassword");
                            return true;
                        }
                    }
                }
            }
            catch(Exception ex) { Register_Error("DeleteUserRegistration", ex.Message); }
            return false;
        }
        public static string EncryptPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashbytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashbytes).Replace("-", "").ToLower();
            }
        }
    }
}
