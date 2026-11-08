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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword(string email)
        {
            InitializeComponent();
            _email = email;
        }
        string _email;
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (Npasstxt.Text.Trim() != COpasstxt.Text.Trim())
            {
                MessageBox.Show("You Should Confirm Password Correctly");
                return;
            }
            if (clsuser.Update_User_Password(_email, myTools.EncryptPassword(COpasstxt.Text.Trim())))
            {
                MessageBox.Show("Password Is Updated Successfully");
                this.Close();
                return;
            }
            MessageBox.Show("Error,Something Went Wrong");
        }
    }
}
