using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCompany
{
    public partial class FrmPackageSize : Form
    {
        public FrmPackageSize()
        {
            InitializeComponent();
        }
        public delegate void SendSizeBack(object sender, string size);
        public event SendSizeBack sendpackagesizeback;
        private void FrmPackageSize_Load(object sender, EventArgs e)
        {

        }
        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            sendpackagesizeback?.Invoke(this, btn.Text.Trim());
            this.Close();
        }
    }
}
