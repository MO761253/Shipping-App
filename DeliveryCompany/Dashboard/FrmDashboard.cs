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
using MyTools;
namespace DeliveryCompany
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard(string email,string password)
        {
            InitializeComponent();
            _email = email;
            _password = myTools.EncryptPassword(password);
        }
        string _email = "", _password = "";
        private clsuser _currentuser;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            _loadData();
        }
        private void _loadData()
        {
            _currentuser = clsuser.GetUser(_email, _password);
            namelbl.Text = _currentuser.fname;
            TotAddresseslbl.Text = _currentuser.numofaddresses.ToString();
            Totalshipmentslbl.Text = _currentuser.numofshipments.ToString();
            completedshipmentslbl.Text = _currentuser.completedshipments.ToString();
            totalactiveshipmentslbl.Text = _currentuser.activeshipments.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FrmAdressesMainScreen frm = new FrmAdressesMainScreen(_currentuser.userID);
            frm.ShowDialog();
            _loadData();
        }

        private void userinfobtn_Click(object sender, EventArgs e)
        {
            FrmAccountInfo frm = new FrmAccountInfo(_currentuser);
            frm.ShowDialog();
        }

        private void createorderBtn_Click(object sender, EventArgs e)
        {
            FrmShipmentsMainScreen f = new FrmShipmentsMainScreen(_currentuser.userID);
            f.ShowDialog();
            _loadData();
        }

        private void shipInvoicesBtn_Click(object sender, EventArgs e)
        {
            FrmShipInvoices frm = new FrmShipInvoices(_currentuser.userID);
            frm.ShowDialog();
        }

        private void CloseProgBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrackShipBtn_Click(object sender, EventArgs e)
        {
            FrmShipTracking frm = new FrmShipTracking(_currentuser.userID);
            frm.ShowDialog();
        }
    }
}
