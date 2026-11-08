using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using userbusssinesslayer;
using addressesBussinessLayer;
namespace DeliveryCompany
{
    public partial class FrmAccountInfo : Form
    {
        public FrmAccountInfo(clsuser currentuser)
        {
            InitializeComponent();
            _currentuser = currentuser;
        }
        clsuser _currentuser;
        private void FrmAccountInfo_Load(object sender, EventArgs e)
        {
            Fill_AccountInfo();
        }
        private void Fill_AccountInfo()
        {
            Namelbl.Text = _currentuser.fname + " " + _currentuser.sname;
            emaiLlbl.Text = _currentuser.email;
            phonelbl.Text = _currentuser.phone;
            Usernamelbl.Text = _currentuser.username;
            _currentuser.address = clsaddresses.Get_User_Addresses(_currentuser.userID);
            Hlbl.Visible = (_currentuser.address.Home != "") ? true : false;
            Wlbl.Visible = (_currentuser.address.Work != "") ? true : false;
            Olbl.Visible = (_currentuser.address.Other != "") ? true : false;
            Homelbl.Text=_currentuser.address.Home;
            worklbl.Text = _currentuser.address.Work;
            Otherlbl.Text = _currentuser.address.Other;
        }

        private void ChangePassBtn_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm = new FrmChangePassword(_currentuser.email);
            frm.ShowDialog();
        }
    }
}
