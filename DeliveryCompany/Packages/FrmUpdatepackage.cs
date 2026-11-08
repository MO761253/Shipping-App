using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using packagebussinessLayer;
namespace DeliveryCompany
{
    public partial class FrmUpdatepackage : Form
    {
        public FrmUpdatepackage(int packID,int ShipID)
        {
            InitializeComponent();
             package = new PackageControl(packID,ShipID);
        }
        PackageControl package;
        private void FrmUpdatepackage_Load(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            package.Dock = DockStyle.Fill;
            panel1.Controls.Add(package);
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
