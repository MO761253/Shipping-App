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
    public partial class FrmShipTracking : Form
    {
        public event Action<int> SearchByID;
        protected virtual void OnShipFound(int shipID)
        {
            Action<int> handler = SearchByID;
            if (handler != null)
            {
                handler(shipID);
            }
        }
        public FrmShipTracking(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }
        int _userID = -1;
        private void ShipSearchBtn_Click(object sender, EventArgs e)
        {
            if (!clsShipTracking.Does_ShipID_Exist(Convert.ToInt32(ShipIDtxt.Text.Trim()),_userID))
            {
                MessageBox.Show($"Shipment With Shipment ID {ShipIDtxt.Text} Is Not Found");
                return;
            }
            if (int.TryParse(ShipIDtxt.Text.Trim(), out int shipID)){
                panel1.Controls.Clear();
                shipTrackInfoControl ShipTrackingInfo = new shipTrackInfoControl(_userID);
                ShipTrackingInfo.Dock = DockStyle.Fill;
                panel1.Controls.Add(ShipTrackingInfo);
                ShipTrackingInfo.BringToFront();
                SearchByID += ShipTrackingInfo.FindShipmentByID;
                if (SearchByID != null)
                    OnShipFound(shipID);
            }
        }

        private void ShipIDtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }

        private void ShipIDtxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ShipIDtxt.Text))
            {
                e.Cancel = true;
                ShipIDtxt.Focus();
                errorProvider1.SetError(ShipIDtxt, "This Field is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(ShipIDtxt, "");
            }
        }
    }
}
