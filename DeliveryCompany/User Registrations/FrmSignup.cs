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
    public partial class FrmSignup : Form
    {
        public FrmSignup()
        {
            InitializeComponent();
        }
        public delegate void Send_email_and_password_back(object sender, string email, string password);
        public event Send_email_and_password_back senddataback;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("you Can't Leave a Field Empty");
                return;
            }
            if (clsuser.Does_Email_Exist(emailtxt.Text.Trim()))
            {
                MessageBox.Show("This email already exsits");
                return;
            }
            if (passwordtxt.Text.Trim() != confirmpass.Text.Trim())
            {
                MessageBox.Show("password confirmation is not equal to password");
                return;
            }
            string password = myTools.EncryptPassword(passwordtxt.Text.Trim());
            if(clsuser.Add_New_User(firstnametxt.Text.Trim(),secondnametxt.Text.Trim(),Lastnametxt.Text.Trim()
                , usernametxt.Text.Trim(),password, phonetxt.Text.Trim(), emailtxt.Text.Trim()))
            {
                MessageBox.Show("User Added Successfully");
                senddataback?.Invoke(this, emailtxt.Text.Trim(), passwordtxt.Text.Trim());
                this.Close();
                return;
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordtxt.UseSystemPasswordChar = true;
                confirmpass.UseSystemPasswordChar = true;
            }
            else
            {
                passwordtxt.UseSystemPasswordChar = false;
                confirmpass.UseSystemPasswordChar = false;
            }
        }
        private void AcceptOnlyDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AcceptOnlyLeters(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (!char.IsLetter(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void PreventWhiteSpace(object sender,KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void AcceptLettersAndDigitsWithoutSpaces(object sender,KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Validate_TextBox(object sender,CancelEventArgs e)
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
