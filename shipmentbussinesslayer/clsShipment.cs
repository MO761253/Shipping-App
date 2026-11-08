using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using shipmentDataLayer;
namespace shipmentbussinesslayer
{
    public class clsShipment
    {
        public string receivername { get; set; }
        public string sendername { get; set; }
        public string receiverphone { get; set; }
        public string description { get; set; }
        public string addressType { get; set; }
        public int customerID { get; set; }
        public decimal TotalAmount { get; }
        private clsShipment(int customerID,string receivername,string sendername,string receiverphone,string description,string addressType,decimal totalamount)
        {
            this.customerID = customerID;
            this.addressType = addressType;
            this.description = description;
            this.receivername = receivername;
            this.sendername = sendername;
            this.receiverphone = receiverphone;
            this.TotalAmount = totalamount;
        }
        public static int Add_New_Shipment(int customerID, int AddID, string sendername, string receivername,
            string receiverphone, string delAddDes,decimal totalprice)
        {
            return ShipmentDatalayer.Add_New_Shipment( customerID,AddID,sendername,receivername,
             receiverphone,  delAddDes,totalprice);
        }
        public static DataTable GetUserShipments(int userID)
        {
            return ShipmentDatalayer.GetUserShipments(userID);
        }
        public static clsShipment Get_Shipment_By_shipID(int shipID)
        {
            string receivername = "", receiverphone = "", sendername = "", description = "", addresstype = "";
            int customerID = -1;
            decimal TotalAmount = -1;
            if(ShipmentDatalayer.Get_Shipment_By_shipID(shipID,ref customerID,ref receivername,ref receiverphone,ref sendername,ref description,ref addresstype,ref TotalAmount))
            {
                return new clsShipment(customerID,receivername, sendername, receiverphone, description, addresstype,TotalAmount);
            }
            return null;
        }
        public static bool Update_Shipment(int shipID, int addID, string receivername, string sendername, string desc, string receiverphone)
        {
            return ShipmentDatalayer.Update_Shipment(shipID, addID, receivername, sendername, desc, receiverphone);
        }
        public static bool Cancel_Shipment(int ShipID)
        {
            return ShipmentDatalayer.Cancel_Shipment(ShipID);
        }
        public static bool Delete_CancelledShipments()
        {
            return ShipmentDatalayer.Delete_CancelledSipments();
        }
        public static bool Is_There_AnyCancelledShips()
        {
            return ShipmentDatalayer.Is_There_AnyCancelledShips();
        }
        public static bool Update_ship_Status(int shipID)
        {
            return ShipmentDatalayer.Update_ship_Status(shipID);
        }
        public static bool Is_Shipment_Cancelled(int shipID)
        {
            return ShipmentDatalayer.Is_Shipment_Cancelled(shipID);
        }
        public static bool Update_Shipment_Total_Price(int shipID,decimal TotalPrice)
        {
            return ShipmentDatalayer.Update_Shipment_Total_Price(shipID, TotalPrice);
        }
    }
}
