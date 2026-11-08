using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaymentBussinessLayer;
namespace DeliveryCompany
{
    public partial class FrmShipInvoices : Form
    {
        public FrmShipInvoices(int userID)
        {
            InitializeComponent();
            _userID=userID;
        }
        int _userID = -1;
        private void FrmShipInvoices_Load(object sender, EventArgs e)
        {
            _loadData();
        }
        private void _loadData()
        {
            dataGridView1.DataSource = paymentBussinesslayer.Get_All_UserBills(_userID);
        }
    }
}
