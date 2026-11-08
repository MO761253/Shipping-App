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
using ShipTrackingBussinessLayer;
using PaymentBussinessLayer;
namespace DeliveryCompany
{
    public partial class FrmShipmentsMainScreen : Form
    {
        public FrmShipmentsMainScreen(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }
        int _userID=-1;
        bool ispaid;
        private void AddShipBtn_Click(object sender, EventArgs e)
        {
            FrmAddShipment frm = new FrmAddShipment(_userID);
            frm.ShowDialog();
            _LoadData();
        }
        private void _LoadData()
        {
            dataGridView1.DataSource = clsShipment.GetUserShipments(_userID);
            DelCancelledShipsBtn.Visible = clsShipment.Is_There_AnyCancelledShips();
        }
        private void FrmShipmentsMainScreen_Load(object sender, EventArgs e)
        {
            _LoadData();
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
        private void displayPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisplayPackages frm = new FrmDisplayPackages((int)dataGridView1.CurrentRow.Cells[0].Value,ispaid);
            frm.ShowDialog();
            _LoadData();
        }
        private void updateShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateShipmentInfo frm = new FrmUpdateShipmentInfo((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }
        private void cancelShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int shipID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if (clsShipment.Cancel_Shipment(shipID))
            {
                if (clsShipTracking.Cancel_ShipTracking(shipID)&&paymentBussinesslayer.Delete_ShipBill(shipID))
                {
                    if (MessageBox.Show($"Are You Sure You Want To Delete Address With ID:{shipID} ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        MessageBox.Show("Shipment Cancelled Successfully");
                        _LoadData();
                        return;
                    }
                }
            }
            MessageBox.Show("Error,Something Went Wrong");
        }

        private void DelCancelledShipsBtn_Click(object sender, EventArgs e)
        {
            clsShipTracking.Delete_CancelledShipsTracking();
            if (clsShipment.Delete_CancelledShipments())
            {
                MessageBox.Show("Cancelled Shipments Deleted Successfully");
                _LoadData();
                return;
            }
            MessageBox.Show("Error,Something Went Wrong");
        }

        private void payShipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayment frm = new FrmPayment((int)dataGridView1.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _LoadData();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (clsShipment.Is_Shipment_Cancelled((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                payShipmentToolStripMenuItem.Enabled = false;
                updateShipmentToolStripMenuItem.Enabled = false;
                displayPackagesToolStripMenuItem.Enabled = false;
                cancelShipmentToolStripMenuItem.Enabled = false;
                return;
            }
            if (paymentBussinesslayer.Does_ShipBill_Exist((int)dataGridView1.CurrentRow.Cells[0].Value))
            {
                payShipmentToolStripMenuItem.Enabled = false;
                updateShipmentToolStripMenuItem.Enabled = false;
                displayPackagesToolStripMenuItem.Enabled = true;
                cancelShipmentToolStripMenuItem.Enabled = true;
                ispaid = true;
                return;
            }
            payShipmentToolStripMenuItem.Enabled = true;
            updateShipmentToolStripMenuItem.Enabled = true;
            displayPackagesToolStripMenuItem.Enabled = true;
            cancelShipmentToolStripMenuItem.Enabled = true;
            ispaid = false;
        }
    }
}
