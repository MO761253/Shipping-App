using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShipTrackingBussinessLayer;
namespace DeliveryCompany
{
    public partial class shipTrackInfoControl : UserControl
    {
        public shipTrackInfoControl(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }
        int _userID = -1;
        clsShipTracking shiptrackinginfo;
        private void _loadData()
        {
            ShipIDlbl.Text = shiptrackinginfo.shipID.ToString();
            TrackIDLbl.Text = shiptrackinginfo.trackingID.ToString();
            Locationlbl.Text = shiptrackinginfo.location;
            Descriptionlbl.Text = shiptrackinginfo.description;
            ShipStatuslbl.Text = shiptrackinginfo.shipmentstatus;
            UpdatedAtlbl.Text = shiptrackinginfo.updatedAt.ToString();
        }
        private void _RestoreDefaults()
        {
            ShipIDlbl.Text = "????";
            TrackIDLbl.Text = "????";
            Locationlbl.Text = "????";
            Descriptionlbl.Text = "????";
            ShipStatuslbl.Text = "????";
            UpdatedAtlbl.Text = "????";
        }
        public void FindShipmentByID(int shipID)
        {
            shiptrackinginfo = clsShipTracking.Get_ShipTracking_Info_ByShipID(shipID,_userID);
            if (shiptrackinginfo == null)
                return;
            _loadData();
        } 
    }
}
