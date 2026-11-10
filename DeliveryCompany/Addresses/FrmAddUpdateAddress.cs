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
namespace DeliveryCompany
{
    public partial class FrmAddUpdateAddress : Form
    {
        public FrmAddUpdateAddress(int userID)
        {
            InitializeComponent();
            Mode = enMode.add;
            _userID = userID;
            this.Text = "Add Address";
        }
        public FrmAddUpdateAddress(int AddID,string addresstype="")
        {
            InitializeComponent();
            Mode = enMode.update;
            _addID = AddID;
            addressBtn.Text = "Update Address";
            this.Text = "Update Address";
        }
        int _userID = -1;
        int _addID = -1;
        Dictionary<string, string> addressinfo;
        string _addressType;
        private void FrmAddAddress_Load(object sender, EventArgs e)
        {
            _fillcbgovernorates();
            if (Mode == enMode.update)
                _GetAddressInfo();
        }
        private void _fillcbgovernorates()
        {
            cbgovernorates.DataSource = clsaddresses.GetGovernorates();
            cbgovernorates.DisplayMember = "GovernorateName";
            cbgovernorates.ValueMember = "GovernorateID";
            cbgovernorates.SelectedIndex = 0;
        }
        private void _GetAddressInfo()
        {
            addressinfo = clsaddresses.Get_Address_By_ID(_addID);
            if (addressinfo == null)
            {
                MessageBox.Show("There is no address");
                return;
            }
            _GetUserGovernorateInCb();
            _userID = Convert.ToInt32(addressinfo["UserID"]);
            citytxt.Text = addressinfo["city"];
            streettxt.Text = addressinfo["street"];
            areatxt.Text = addressinfo["area"];
            BuildingNumtxt.Text = addressinfo["buildingnumber"];
            postalcodetxt.Text = addressinfo["postalcode"];
            if (addressinfo["addresstype"] == "Home")
            {
                HomeRb.Checked = true;
                _addressType = "Home";
            }
            else if (addressinfo["addresstype"] == "Work")
            {
                WorkRb.Checked = true;
                _addressType = "Work";
            }
            else
            {
                OtherRb.Checked = true;
                _addressType = "Other";
            }
        }
        private void _GetUserGovernorateInCb()
        {
            cbgovernorates.SelectedValue = Convert.ToInt32(addressinfo["governorateID"]);
        }
        enum enMode { add,update};
        enMode Mode;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool Check_Add_Type()
        {
            if (HomeRb.Checked)
            {
                if (clsaddresses.IsTheChosenAddressTypeExisted(_userID, "Home"))
                {
                    if (_addressType == "Home" && Mode == enMode.update) return true;
                    MessageBox.Show("There is already a Home Address");
                    HomeRb.Checked = false;
                    return false;
                }
                _addressType = HomeRb.Text.Trim();
            }
            else if (WorkRb.Checked)
            {
                if (clsaddresses.IsTheChosenAddressTypeExisted(_userID, "Work"))
                {
                    if (_addressType == "Work" && Mode == enMode.update) return true;
                    MessageBox.Show("There is already a Work Address");
                    WorkRb.Checked = false;
                    return false;
                }
                _addressType = WorkRb.Text.Trim();
            }
            else
            {
                if (clsaddresses.IsTheChosenAddressTypeExisted(_userID, "Other"))
                {
                    if (_addressType == "Other" && Mode == enMode.update) return true;
                    MessageBox.Show("There is already an Other Address");
                    OtherRb.Checked = false;
                    return false;
                }
                _addressType = OtherRb.Text.Trim();
            }
            return true;
        }
        private void addressBtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return; 
            }
            if (!HomeRb.Checked && !OtherRb.Checked && !WorkRb.Checked)
            {
                MessageBox.Show("Select An address Type");
                return;
            }
            if (!Check_Add_Type())
            {
                return;
            }
            if (Mode == enMode.add)
            {
                if (clsaddresses.Add_New_Address(_userID, (cbgovernorates.SelectedValue).ToString(), citytxt.Text.Trim()
                     , areatxt.Text.Trim(), streettxt.Text.Trim(), Convert.ToInt32(BuildingNumtxt.Text.Trim())
                     , postalcodetxt.Text.Trim(), _addressType))
                {
                    MessageBox.Show("Address Has Been Added Successfully");
                    this.Close();
                }
            }
            else {
             if (clsaddresses.UpdateAddress(_addID, (cbgovernorates.SelectedValue).ToString(),
                    areatxt.Text.Trim(), citytxt.Text.Trim(), streettxt.Text.Trim(), BuildingNumtxt.Text.Trim()
                    , postalcodetxt.Text.Trim(), _addressType))
                {
                    MessageBox.Show("Address Has Been Updated Successfully");
                    this.Close();
                }
            }
            
        }
        private void AcceptOnlyDigits(object sender,KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        private void AcceptOnlyLeters(object sender,KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if(e.KeyChar==' '&&tb.Text.Length>0&&tb.SelectionStart>0&&tb.Text[tb.SelectionStart-1]!=' ')
            {
                return;
            }
            e.Handled = true;
        }
        private void TextBox_Validating(object sender,CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This Field is Required");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }
        private void streettxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            if (e.KeyChar == ' ' && tb.Text.Length > 0 && tb.SelectionStart > 0 && tb.Text[tb.SelectionStart - 1] != ' ')
            {
                return;
            }
            e.Handled = true;
        }
    }
}
