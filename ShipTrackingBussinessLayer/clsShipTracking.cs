using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShipTrackingDataLayer;
namespace ShipTrackingBussinessLayer
{
    public class clsShipTracking
    {
        public int trackingID { get; }
        public int shipID { get; }
        public string location { get; }
        public string description { get; }
        public string shipmentstatus { get; }
        public DateTime updatedAt { get; }
        private clsShipTracking(int trackingID,int shipID,string location,string description,
            string shipmentstatus,DateTime updatedat)
        {
            this.shipID = shipID;
            this.trackingID = trackingID;
            this.location = location;
            this.description = description;
            this.shipmentstatus = shipmentstatus;
            this.updatedAt = updatedat;
        }
        public static bool Insert_ShipTracking_Info(int shipID)
        {
            return shipTrackingDatalayer.Insert_ShipTracking_Info(shipID);
        }
        public static bool Cancel_ShipTracking(int shipID)
        {
            if (shipTrackingDatalayer.Does_ShipID_Exist(shipID))
            {
                return shipTrackingDatalayer.Cancel_ShipTracking(shipID);
            }
            return true;
        }
        public static bool Delete_CancelledShipsTracking()
        {
             return shipTrackingDatalayer.Delete_CancelledShipsTracking();
        }
        public static clsShipTracking Get_ShipTracking_Info_ByShipID(int shipID,int userID)
        {
            int trackingID = -1;
            string location = "", description = "", shipstatus = "";
            DateTime updatedat=DateTime.MinValue;
            if (shipTrackingDatalayer.Get_ShipTracking_Info_ByShipID(userID,shipID,ref trackingID,ref location,ref description,ref shipstatus,ref updatedat))
            {
                return new clsShipTracking(trackingID, shipID, location, description, shipstatus, updatedat);
            }
            return null;
        }
        public static bool Does_ShipID_Exist(int shipID,int userID)
        {
            return shipTrackingDatalayer.Does_ShipID_Exist(shipID,userID);
        }
    }
}
