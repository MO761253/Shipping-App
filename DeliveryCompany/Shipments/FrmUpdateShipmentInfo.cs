using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using shipmentbussinesslayer;
using addressesBussinessLayer;
namespace DeliveryCompany
{
    public partial class FrmUpdateShipmentInfo : Form
    {
        public FrmUpdateShipmentInfo(int shipID)
        {
            InitializeComponent();
            shipmentinfo = clsShipment.Get_Shipment_By_shipID(shipID);
            _shipID = shipID;
        }
        clsShipment shipmentinfo=null;
        int _addID = -1;
        int _shipID = -1;
        private void _loadData()
        {
            Receivernametxt.Text = shipmentinfo.receivername;
            sendernametxt.Text = shipmentinfo.sendername;
            Rphonetxt.Text = shipmentinfo.receiverphone;
            DADtxt.Text = shipmentinfo.description;
            HomeRb.Checked = (shipmentinfo.addressType == "Home") ? true : false;
            WorkRb.Checked = (shipmentinfo.addressType == "Work") ? true : false;
            OtherRb.Checked = (shipmentinfo.addressType == "Other") ? true : false;
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmUpdateShipmentInfo_Load(object sender, EventArgs e)
        {
            if (shipmentinfo == null)
                return;
            _loadData();
        }
        private bool _Get_AddID()
        {
            string addType = (HomeRb.Checked) ? HomeRb.Text.Trim() : (WorkRb.Checked) ? WorkRb.Text.Trim() : OtherRb.Text.Trim();
            if (clsaddresses.IsTheChosenAddressTypeExisted(shipmentinfo.customerID, addType))
            {
                _addID = clsaddresses.Get_AddID_ByAddressType(addType, shipmentinfo.customerID);
                return true;
            }
            MessageBox.Show("address is not found,add address first from that type");
            return false;
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("you Can't Leave a Field Empty");
                return;
            }
            if (!HomeRb.Checked && !WorkRb.Checked && !OtherRb.Checked)
            {
                MessageBox.Show("You Should Choose Address Type");
                return;
            }
            if (!_Get_AddID())
                return;
            if (clsShipment.Update_Shipment(_shipID, _addID, Receivernametxt.Text.Trim(), sendernametxt.Text.Trim(), DADtxt.Text.Trim(), Rphonetxt.Text.Trim()))
            {
                MessageBox.Show("Shipment Updated Successfully");
                this.Close();
                return;
            }
            MessageBox.Show("Error,Something Went Wrong");
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
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Validate_TextBox(object sender, CancelEventArgs e)
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
        private void DADtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
