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
    public partial class FrmAdressesMainScreen : Form
    {
        public FrmAdressesMainScreen(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }
        int _userID;
        private void _FillAddresses()
        {
            dataGridView1.DataSource = clsaddresses.Get_Addreses_In_MainScreen(_userID);
        }
        private void FrmAdressesMainScreen_Load(object sender, EventArgs e)
        {
            _FillAddresses();
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

        private void Addaddress_Click(object sender, EventArgs e)
        {
            FrmAddUpdateAddress frm = new FrmAddUpdateAddress(_userID);
            frm.ShowDialog();
            _FillAddresses();
        }

        private void updateAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateAddress frm = new FrmAddUpdateAddress((int)dataGridView1.CurrentRow.Cells[0].Value,"");
            frm.ShowDialog();
            _FillAddresses();
        }

        private void deleteAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if (clsaddresses.DeleteAddress(ID))
            {
                if(MessageBox.Show($"Are You Sure You Want To Delete Address With ID:{ID} ?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK){
                    MessageBox.Show("Address Is Deleted Successfully");
                    _FillAddresses();
                    return;
                }
            }
            MessageBox.Show("Error");
        }
    }
}
