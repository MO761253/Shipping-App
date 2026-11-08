using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using addressesBussinessLayer;
using shipmentbussinesslayer;
using packagebussinessLayer;
using ShipTrackingBussinessLayer;
namespace DeliveryCompany
{
    public partial class FrmAddShipment : Form
    {
        public FrmAddShipment(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }
        int packNum;
        int _userID=-1;
        int _addID=-1;
        int shipID = -1;
        PackageControl mypack;
        private void AddPackbtn_Click(object sender, EventArgs e)
        {
            PackageControl pack = new PackageControl();
            pack.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(pack);
            mypack = pack;
            packNum++;
            AddPackbtn.Enabled = false;
        }
        private bool _Get_AddID()
        {
            string addType = (HomeRb.Checked) ? HomeRb.Text.Trim() : (WorkRb.Checked) ? WorkRb.Text.Trim() : OtherRb.Text.Trim();
            if (clsaddresses.IsTheChosenAddressTypeExisted(_userID, addType))
            {
                _addID = clsaddresses.Get_AddID_ByAddressType(addType, _userID);
                return true;
            }
            MessageBox.Show("address is not found,add address from that type");
            return false;
        }
        private void _DisableControls()
        {
            sendernametxt.Enabled = false;
            Rphonetxt.Enabled = false;
            Receivernametxt.Enabled = false;
            DADtxt.Enabled = false;
            HomeRb.Enabled = false;
            WorkRb.Enabled = false;
            OtherRb.Enabled = false;
            AddPackbtn.Enabled = false;
        }
        private void SaveShipmentbtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("You Can't Leave a Field Empty");
                return;
            }
            if (packNum == 0)
            {
                MessageBox.Show("you should create a package first");
                return;
            }
            if (!mypack.issaved)
            {
                MessageBox.Show("You Should Save The Package");
                return;
            }
            if (!HomeRb.Checked && !WorkRb.Checked && !OtherRb.Checked)
            {
                MessageBox.Show("You Should Choose Address Type");
                return;
            }
            if (!_Get_AddID())
            {
                return;
            }
            shipID = clsShipment.Add_New_Shipment(_userID, _addID, sendernametxt.Text.Trim(), Receivernametxt.Text.Trim(),
                Rphonetxt.Text.Trim(), DADtxt.Text.Trim(),clsPackage.GetTotalPackagesPriceFromList());
            if (shipID != -1)
            {
                if (mypack.packagesize != "" && mypack.despackagecontant != "" && mypack.packagetype != "")
                {
                    if (clsPackage.AddPackages(shipID))
                    {
                        MessageBox.Show("Shipment Saved Successfully");
                        SaveShipmentbtn.Enabled = false;
                        _DisableControls();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Error,Something went wrong");
                        return;
                    }
                }
                else
                    MessageBox.Show("You Should fill the package first");
            }
        }
        private void AcceptOnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AcceptOnlyLeters(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) &&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void DADtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Validate_TextBox(object sender,CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This Field Shouldn't Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }
    }
}
