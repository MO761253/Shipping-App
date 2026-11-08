using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyTools;
using userbusssinesslayer;
namespace DeliveryCompany
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            string email = "", password = "";
            if (myTools.Get_User_Registration_Info(ref email,ref password))
            {
                emailtxt.Text = email;
                Passwordtxt.Text = password;
                checkBox1.Checked = true;
            }
            else
            {
                emailtxt.Text = "";
                Passwordtxt.Text = "";
                checkBox1.Checked = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Passwordtxt.UseSystemPasswordChar = true;
            cancelbtn.Focus();
        }
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSignup frm = new FrmSignup();
            frm.senddataback += frmSignUp_DataBack;
            frm.ShowDialog();
        }
        private void frmSignUp_DataBack(object sender,string email,string password)
        {
            emailtxt.Text = email;
            Passwordtxt.Text = password;
        }
        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (emailtxt.Text.Trim() == "")
            {
                MessageBox.Show("Enter Email Address");
                return;
            }
            if (Passwordtxt.Text.Trim() == "")
            {
                MessageBox.Show("Enter Password");
                return;
            }
            bool isExisted = clsuser.Does_User_Exist(emailtxt.Text.Trim(),myTools.EncryptPassword(Passwordtxt.Text.Trim()));
            if (!isExisted)
            {
                MessageBox.Show("invalid email/password");
                return;
            }
            if (checkBox1.Checked&&isExisted)
            {
                myTools.Remember_user_Registration(emailtxt.Text.Trim(), Passwordtxt.Text.Trim());
            }
            else { myTools.Delete_User_Registration_Info();}
            this.Hide();
            FrmDashboard frm = new FrmDashboard(emailtxt.Text.Trim(), Passwordtxt.Text.Trim());
            frm.ShowDialog();
        }
        private void PreventWhiteSpace(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
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
    }
}
