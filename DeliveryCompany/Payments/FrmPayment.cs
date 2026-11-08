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
using PaymentBussinessLayer;
using ShipTrackingBussinessLayer;
namespace DeliveryCompany
{
    public partial class FrmPayment : Form
    {
        public FrmPayment(int shipID)
        {
            InitializeComponent();
            _shipID = shipID;
            shipment = clsShipment.Get_Shipment_By_shipID(shipID);
        }
        clsShipment shipment;
        int _shipID = -1;
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void _RadioBtn_Click(object sender,EventArgs e)
        {
            if (RcreditCard.Checked)
            {
                groupBox1.Visible = true;
            }
            else
                groupBox1.Visible = false;
        }
        private void FrmPayment_Load(object sender, EventArgs e)
        {
            ShipIDlbl.Text = _shipID.ToString();
            serviceTypelbl.Text = "Normal";
            Tamountlbl.Text = shipment.TotalAmount.ToString();
            groupBox1.Visible = false;
            CloseBtn.Focus();
            textBox3.MaxLength = 3;
            textBox4.MaxLength = 2;
            textBox5.MaxLength = 2;
            textBox2.MaxLength = 16;
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Enter Correct Info");
                return;
            }
            if (!Rcash.Checked && !RcreditCard.Checked)
            {
                MessageBox.Show("Choose A Payment Method");
                return;
            }
            string paymentmethod = (Rcash.Checked) ? Rcash.Text.Trim() : RcreditCard.Text.Trim();
            if (paymentBussinesslayer.AddNewBill(_shipID, shipment.TotalAmount, paymentmethod)&&clsShipTracking.Insert_ShipTracking_Info(_shipID)&&clsShipment.Update_ship_Status(_shipID))
            {
                MessageBox.Show("The Shipment Is Paid Successfully");
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
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (Rcash.Checked)
                return;
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This Field Shouldn't Be Empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
            if (Convert.ToInt32(txt.Text.Trim()) >12|| Convert.ToInt32(txt.Text.Trim())<=0)
            {
                MessageBox.Show("Enter a valid Month");
                return;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (Rcash.Checked)
                return;
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This Field Shouldn't Be Empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
            if (txt.Text.Length != 16)
            {
                MessageBox.Show("Must Be 16 Numbers");
                return;
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (Rcash.Checked)
                return;
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
            if (txt.Text.Length != 2)
            {
                errorProvider1.SetError(txt, "Invalid Number");
                return;
            }
            if((Convert.ToInt32(txt.Text.Trim())>((DateTime.Now.Year+10)-2000))||(Convert.ToInt32(txt.Text.Trim()) < (DateTime.Now.Year-2000)))
            {
                MessageBox.Show("Enter a valid Year");
                return;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (Rcash.Checked)
                return;
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This Field Shouldn't Be Empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
            if (txt.Text.Length != 3)
            {
                MessageBox.Show("Must Be 3 Numbers");
                return;
            }
            
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Rcash.Checked)
                return;
            TextBox txt = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, "This Field Shouldn't Be Empty");
                return;
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }
    }
}
