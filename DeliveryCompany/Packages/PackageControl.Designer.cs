
namespace DeliveryCompany
{
    partial class PackageControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PackageSizetxt = new System.Windows.Forms.TextBox();
            this.packagesizebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HomeAppRB = new System.Windows.Forms.RadioButton();
            this.ElecRB = new System.Windows.Forms.RadioButton();
            this.MedicineRB = new System.Windows.Forms.RadioButton();
            this.ClothingRB = new System.Windows.Forms.RadioButton();
            this.PADrB = new System.Windows.Forms.RadioButton();
            this.OthersRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.DPCtxt = new System.Windows.Forms.TextBox();
            this.Isfragilechk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pricelbl = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.savePackagebtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PackageSizetxt
            // 
            this.PackageSizetxt.Location = new System.Drawing.Point(23, 31);
            this.PackageSizetxt.Name = "PackageSizetxt";
            this.PackageSizetxt.ReadOnly = true;
            this.PackageSizetxt.Size = new System.Drawing.Size(100, 20);
            this.PackageSizetxt.TabIndex = 0;
            this.PackageSizetxt.Validating += new System.ComponentModel.CancelEventHandler(this.PackageSizetxt_Validating);
            // 
            // packagesizebtn
            // 
            this.packagesizebtn.Location = new System.Drawing.Point(139, 21);
            this.packagesizebtn.Name = "packagesizebtn";
            this.packagesizebtn.Size = new System.Drawing.Size(76, 38);
            this.packagesizebtn.TabIndex = 1;
            this.packagesizebtn.Text = "Select PackageSize";
            this.packagesizebtn.UseVisualStyleBackColor = true;
            this.packagesizebtn.Click += new System.EventHandler(this.packagesizebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose PackageType";
            // 
            // HomeAppRB
            // 
            this.HomeAppRB.AutoSize = true;
            this.HomeAppRB.Location = new System.Drawing.Point(35, 106);
            this.HomeAppRB.Name = "HomeAppRB";
            this.HomeAppRB.Size = new System.Drawing.Size(103, 17);
            this.HomeAppRB.TabIndex = 3;
            this.HomeAppRB.TabStop = true;
            this.HomeAppRB.Text = "HomeAppliances";
            this.HomeAppRB.UseVisualStyleBackColor = true;
            this.HomeAppRB.Click += new System.EventHandler(this.radiobtnclick);
            // 
            // ElecRB
            // 
            this.ElecRB.AutoSize = true;
            this.ElecRB.Location = new System.Drawing.Point(35, 129);
            this.ElecRB.Name = "ElecRB";
            this.ElecRB.Size = new System.Drawing.Size(76, 17);
            this.ElecRB.TabIndex = 4;
            this.ElecRB.TabStop = true;
            this.ElecRB.Text = "Electronics";
            this.ElecRB.UseVisualStyleBackColor = true;
            this.ElecRB.Click += new System.EventHandler(this.radiobtnclick);
            // 
            // MedicineRB
            // 
            this.MedicineRB.AutoSize = true;
            this.MedicineRB.Location = new System.Drawing.Point(35, 152);
            this.MedicineRB.Name = "MedicineRB";
            this.MedicineRB.Size = new System.Drawing.Size(66, 17);
            this.MedicineRB.TabIndex = 5;
            this.MedicineRB.TabStop = true;
            this.MedicineRB.Text = "Medicine";
            this.MedicineRB.UseVisualStyleBackColor = true;
            this.MedicineRB.Click += new System.EventHandler(this.radiobtnclick);
            // 
            // ClothingRB
            // 
            this.ClothingRB.AutoSize = true;
            this.ClothingRB.Location = new System.Drawing.Point(151, 106);
            this.ClothingRB.Name = "ClothingRB";
            this.ClothingRB.Size = new System.Drawing.Size(64, 17);
            this.ClothingRB.TabIndex = 6;
            this.ClothingRB.TabStop = true;
            this.ClothingRB.Text = "Clothing";
            this.ClothingRB.UseVisualStyleBackColor = true;
            this.ClothingRB.Click += new System.EventHandler(this.radiobtnclick);
            // 
            // PADrB
            // 
            this.PADrB.AutoSize = true;
            this.PADrB.Location = new System.Drawing.Point(151, 129);
            this.PADrB.Name = "PADrB";
            this.PADrB.Size = new System.Drawing.Size(135, 17);
            this.PADrB.TabIndex = 7;
            this.PADrB.TabStop = true;
            this.PADrB.Text = "Papers and Documents";
            this.PADrB.UseVisualStyleBackColor = true;
            this.PADrB.Click += new System.EventHandler(this.radiobtnclick);
            // 
            // OthersRB
            // 
            this.OthersRB.AutoSize = true;
            this.OthersRB.Location = new System.Drawing.Point(151, 152);
            this.OthersRB.Name = "OthersRB";
            this.OthersRB.Size = new System.Drawing.Size(58, 17);
            this.OthersRB.TabIndex = 8;
            this.OthersRB.TabStop = true;
            this.OthersRB.Text = "Others";
            this.OthersRB.UseVisualStyleBackColor = true;
            this.OthersRB.Click += new System.EventHandler(this.radiobtnclick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Describe Package Content";
            // 
            // DPCtxt
            // 
            this.DPCtxt.Location = new System.Drawing.Point(11, 211);
            this.DPCtxt.Multiline = true;
            this.DPCtxt.Name = "DPCtxt";
            this.DPCtxt.Size = new System.Drawing.Size(164, 80);
            this.DPCtxt.TabIndex = 10;
            this.DPCtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DPCtxt_KeyPress);
            this.DPCtxt.Validating += new System.ComponentModel.CancelEventHandler(this.DPCtxt_Validating);
            // 
            // Isfragilechk
            // 
            this.Isfragilechk.AutoSize = true;
            this.Isfragilechk.Location = new System.Drawing.Point(98, 297);
            this.Isfragilechk.Name = "Isfragilechk";
            this.Isfragilechk.Size = new System.Drawing.Size(70, 17);
            this.Isfragilechk.TabIndex = 11;
            this.Isfragilechk.Text = "Is Fragile";
            this.Isfragilechk.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "EGP";
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.Location = new System.Drawing.Point(19, 317);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(22, 23);
            this.pricelbl.TabIndex = 13;
            this.pricelbl.Text = "0";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // savePackagebtn
            // 
            this.savePackagebtn.Location = new System.Drawing.Point(191, 226);
            this.savePackagebtn.Name = "savePackagebtn";
            this.savePackagebtn.Size = new System.Drawing.Size(75, 37);
            this.savePackagebtn.TabIndex = 14;
            this.savePackagebtn.Text = "Save Package";
            this.savePackagebtn.UseVisualStyleBackColor = true;
            this.savePackagebtn.Click += new System.EventHandler(this.savePackagebtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(191, 317);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(75, 23);
            this.ConfirmBtn.TabIndex = 15;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // PackageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.savePackagebtn);
            this.Controls.Add(this.pricelbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Isfragilechk);
            this.Controls.Add(this.DPCtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OthersRB);
            this.Controls.Add(this.PADrB);
            this.Controls.Add(this.ClothingRB);
            this.Controls.Add(this.MedicineRB);
            this.Controls.Add(this.ElecRB);
            this.Controls.Add(this.HomeAppRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.packagesizebtn);
            this.Controls.Add(this.PackageSizetxt);
            this.Name = "PackageControl";
            this.Size = new System.Drawing.Size(283, 372);
            this.Load += new System.EventHandler(this.PackageControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PackageSizetxt;
        private System.Windows.Forms.Button packagesizebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton HomeAppRB;
        private System.Windows.Forms.RadioButton ElecRB;
        private System.Windows.Forms.RadioButton MedicineRB;
        private System.Windows.Forms.RadioButton ClothingRB;
        private System.Windows.Forms.RadioButton PADrB;
        private System.Windows.Forms.RadioButton OthersRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DPCtxt;
        private System.Windows.Forms.CheckBox Isfragilechk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button savePackagebtn;
        private System.Windows.Forms.Button ConfirmBtn;
    }
}
