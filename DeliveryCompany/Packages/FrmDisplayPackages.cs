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
    public partial class FrmDisplayPackages : Form
    {
        public FrmDisplayPackages(int shipID,bool ispaid)
        {
            InitializeComponent();
            _shipID = shipID;
            _ispaid = ispaid;
        }
        int _shipID = 0;
        bool _ispaid;
        private void FrmDisplayPackages_Load(object sender, EventArgs e)
        {
            _Fill_DGV_With_packages();
        }
        private void _Fill_DGV_With_packages()
        {
            dataGridView1.DataSource = clsPackage.Get_Packages_By_ShipID(_shipID);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridView1.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0 && hit.ColumnIndex >= 0)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[hit.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }

        private void updatePackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdatepackage frm = new FrmUpdatepackage((int)dataGridView1.CurrentRow.Cells[0].Value,_shipID);
            frm.ShowDialog();
            _Fill_DGV_With_packages();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (_ispaid)
            {
                updatePackageToolStripMenuItem.Enabled = false;
                return;
            }
            updatePackageToolStripMenuItem.Enabled = true;
        }
    }
}
