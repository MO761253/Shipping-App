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
    public partial class PackageControl : UserControl
    {
        public PackageControl()
        {
            InitializeComponent();
            savePackagebtn.Visible = true;
            ConfirmBtn.Visible = false;
        }
        public PackageControl(int PackID,int ShipID)
        {
            InitializeComponent();
            pack = clsPackage.Get_Package_By_PackID(PackID);
            _packID = PackID;
            _ShipID = ShipID;
            savePackagebtn.Visible = false;
            ConfirmBtn.Visible = true;
        }
        public string packagesize
        {
            get { return PackageSizetxt.Text.Trim(); }
        }
       public string despackagecontant
        {
            get { return DPCtxt.Text.Trim(); }
        }
        clsPackage pack=null;
        public bool isfragile { get { return Isfragilechk.Checked; } }
        public decimal PackagePrice{ get; set; }
        public string packagetype = "";
        decimal sizeprice = 0;
        decimal typeprice = 0;
        int _packID = -1;
        int _ShipID = -1;
        int packNum;
        RadioButton Rbtn;
        public bool issaved = false;
        private void Get_PackageType_Price()
        {
            typeprice = 0;
            switch (packagetype.Trim())
            {
                case "Medicine":
                     typeprice+= 150;
                    break;
                case "Electronics":
                    typeprice+= 200;
                    break;
                case "Clothing":
                    typeprice += 100;
                    break;
                case "HomeAppliances":
                    typeprice += 250;
                    break;
                case "Papers and Documents":
                    typeprice += 130;
                    break;
                case "Others":
                    typeprice+= 80;
                    break;
            }
        }
        private decimal Get_PackageSize_Price()
        {
            switch (PackageSizetxt.Text.Trim())
            {
                case "Document":
                    return 100;
                case "Small":
                    return 300;
                case "Medium":
                    return 500;
                case "Large":
                    return 800;
                case "Oversize":
                    return 1200;
                default:
                    return 0;
            }
        }
        private void radiobtnclick(object sender,EventArgs e)
        {
            PackagePrice -= typeprice;
            Rbtn=(RadioButton)sender;
            packagetype = Rbtn.Text.Trim();
            Get_PackageType_Price();
            PackagePrice += typeprice;
            pricelbl.Text = PackagePrice.ToString();
        }
        private void packagesizebtn_Click(object sender, EventArgs e)
        {
            FrmPackageSize frm = new FrmPackageSize();
            frm.sendpackagesizeback += frmpackagesize_databack;
            frm.ShowDialog();
        }
        private void frmpackagesize_databack(object sender,string packagesize)
        {
            PackagePrice -= sizeprice;
            PackageSizetxt.Text = packagesize;
            sizeprice = Get_PackageSize_Price();
            PackagePrice += sizeprice;
            pricelbl.Text = PackagePrice.ToString();
        }
        private void PackageControl_Load(object sender, EventArgs e)
        {
            if (pack == null)
                return;
            _LoadPackageInfo();
            sizeprice = Get_PackageSize_Price();
        }
        private void _LoadPackageInfo()
        {
            PackageSizetxt.Text = pack.PackageSize.ToString();
            packagetype = pack.packageType;
            DPCtxt.Text = pack.description.ToString();
            Isfragilechk.Checked = pack.isfragile;
            PackagePrice+=Get_PackageSize_Price();
            _determinePackageType(pack.packageType);
            pricelbl.Text = ((int)pack.declaredvalue).ToString();
        }
        private void _determinePackageType(string packtype)
        {
            switch (packtype.Trim()) 
            {
                case "HomeAppliances" :
                    HomeAppRB.Checked = true;
                    break;
                case "Medicine":
                    MedicineRB.Checked = true;
                    break;
                case "Clothing":
                    ClothingRB.Checked = true;
                    break;
                case "Electronics":
                    ElecRB.Checked = true;
                    break;
                case "Papers and Documents":
                    PADrB.Checked = true;
                    break;
                case "Others":
                    OthersRB.Checked = true;
                    break;

            }
        }
        private void PackageSizetxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PackageSizetxt.Text.Trim()))
            {
                e.Cancel = true;
                PackageSizetxt.Focus();
                errorProvider1.SetError(PackageSizetxt, "packageSize shouldn't be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(PackageSizetxt, "");
            }
        }
        private void _DisableRadioButtons()
        {
            HomeAppRB.Enabled = false;
            ElecRB.Enabled = false;
            MedicineRB.Enabled = false;
            ClothingRB.Enabled = false;
            PADrB.Enabled = false;
            OthersRB.Enabled = false;
        }
        private void _DisableControls()
        {
            savePackagebtn.Enabled = false;
            DPCtxt.Enabled = false;
            PackageSizetxt.Enabled = false;
            packagesizebtn.Enabled = false;
            Isfragilechk.Enabled = false;
        }
        private void savePackagebtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                return;
            }
            if (packagetype == "")
            {
                MessageBox.Show("choose package type");
                return;
            }
            clsPackage pack = new clsPackage(packagetype, PackageSizetxt.Text.Trim(), DPCtxt.Text.Trim(), PackagePrice, isfragile);
            clsPackage.Add_Package_ToList(pack);
            packNum++;
            issaved =true;
            MessageBox.Show("Package Saved Successfully");
            if (MessageBox.Show("Do You Want To Add another package?", "Add Another Package", MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (packNum == 3)
                {
                    MessageBox.Show("you have already added 3 packages,you can't add more");
                    _DisableControls();
                    _DisableRadioButtons();
                    return;
                }
                PackageSizetxt.Text = "";
                DPCtxt.Text = "";
                packagetype = "";
                Isfragilechk.Checked = false;
                Rbtn.Checked = false;
                typeprice = 0;
                issaved = false;
                sizeprice = 0;
                pricelbl.Text = "0";
                PackagePrice = 0;
                return;
            }
            _DisableControls();
            _DisableRadioButtons();
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("You Can't Leave a Field Empty");
                return;
            }
            if (packagetype == "")
            {
                MessageBox.Show("choose package type");
                return;
            }
            if (clsPackage.Update_Package(_packID, PackageSizetxt.Text.Trim(), packagetype, PackagePrice, isfragile, DPCtxt.Text.Trim()))
            {
                decimal totalprice = clsPackage.Get_Packages_Prices_By_ShipID(_ShipID);
                if (shipmentbussinesslayer.clsShipment.Update_Shipment_Total_Price(_ShipID, totalprice))
                {
                    MessageBox.Show("Package Updated Successfully");
                    _DisableControls();
                    _DisableRadioButtons();
                    ConfirmBtn.Enabled = false;
                    return;
                }
            }
             MessageBox.Show("Error,Something went Wrong");
        }

        private void DPCtxt_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DPCtxt.Text))
            {
                e.Cancel = true;
                DPCtxt.Focus();
                errorProvider1.SetError(DPCtxt, "packageSize shouldn't be empty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(DPCtxt, "");
            }
        }
        private void DPCtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
