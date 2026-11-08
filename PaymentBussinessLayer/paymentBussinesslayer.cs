using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using PaymentDataLayer;
namespace PaymentBussinessLayer
{
    public class paymentBussinesslayer
    {
        public static bool AddNewBill(int shipID, decimal Amount, string paymentmethod)
        {
            return paymentDatalayer.AddNewBill(shipID, Amount, paymentmethod);
        }
        public static bool Does_ShipBill_Exist(int shipID)
        {
            return paymentDatalayer.Does_ShipBill_Exist(shipID);
        }
        public static DataTable Get_All_UserBills(int userID)
        {
            return paymentDatalayer.Get_All_UserBills(userID);
        }
        public static bool Delete_ShipBill(int shipID)
        {
            if (Does_ShipBill_Exist(shipID))
            {
                return paymentDatalayer.Delete_ShipBill(shipID);
            }
            return true;
        }
    }
}
