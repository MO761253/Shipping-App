
namespace DeliveryCompany
{
    partial class FrmAddUpdateAddress
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.citytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.areatxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.streettxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BuildingNumtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.postalcodetxt = new System.Windows.Forms.TextBox();
            this.cbgovernorates = new System.Windows.Forms.ComboBox();
            this.HomeRb = new System.Windows.Forms.RadioButton();
            this.WorkRb = new System.Windows.Forms.RadioButton();
            this.OtherRb = new System.Windows.Forms.RadioButton();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.addressBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Governorate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "City";
            // 
            // citytxt
            // 
            this.citytxt.Location = new System.Drawing.Point(124, 116);
            this.citytxt.Name = "citytxt";
            this.citytxt.Size = new System.Drawing.Size(121, 20);
            this.citytxt.TabIndex = 3;
            this.citytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyLeters);
            this.citytxt.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Area";
            // 
            // areatxt
            // 
            this.areatxt.Location = new System.Drawing.Point(354, 72);
            this.areatxt.Name = "areatxt";
            this.areatxt.Size = new System.Drawing.Size(155, 20);
            this.areatxt.TabIndex = 5;
            this.areatxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyLeters);
            this.areatxt.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Street";
            // 
            // streettxt
            // 
            this.streettxt.Location = new System.Drawing.Point(354, 116);
            this.streettxt.Name = "streettxt";
            this.streettxt.Size = new System.Drawing.Size(155, 20);
            this.streettxt.TabIndex = 7;
            this.streettxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.streettxt_KeyPress);
            this.streettxt.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Building Number";
            // 
            // BuildingNumtxt
            // 
            this.BuildingNumtxt.Location = new System.Drawing.Point(409, 161);
            this.BuildingNumtxt.Name = "BuildingNumtxt";
            this.BuildingNumtxt.Size = new System.Drawing.Size(100, 20);
            this.BuildingNumtxt.TabIndex = 9;
            this.BuildingNumtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyDigits);
            this.BuildingNumtxt.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Postal Code";
            // 
            // postalcodetxt
            // 
            this.postalcodetxt.Location = new System.Drawing.Point(124, 158);
            this.postalcodetxt.Name = "postalcodetxt";
            this.postalcodetxt.Size = new System.Drawing.Size(121, 20);
            this.postalcodetxt.TabIndex = 11;
            this.postalcodetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyDigits);
            // 
            // cbgovernorates
            // 
            this.cbgovernorates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgovernorates.FormattingEnabled = true;
            this.cbgovernorates.Location = new System.Drawing.Point(124, 72);
            this.cbgovernorates.Name = "cbgovernorates";
            this.cbgovernorates.Size = new System.Drawing.Size(121, 21);
            this.cbgovernorates.TabIndex = 12;
            // 
            // HomeRb
            // 
            this.HomeRb.AutoSize = true;
            this.HomeRb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeRb.Location = new System.Drawing.Point(41, 222);
            this.HomeRb.Name = "HomeRb";
            this.HomeRb.Size = new System.Drawing.Size(68, 22);
            this.HomeRb.TabIndex = 13;
            this.HomeRb.TabStop = true;
            this.HomeRb.Text = "Home";
            this.HomeRb.UseVisualStyleBackColor = true;
            // 
            // WorkRb
            // 
            this.WorkRb.AutoSize = true;
            this.WorkRb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkRb.Location = new System.Drawing.Point(134, 222);
            this.WorkRb.Name = "WorkRb";
            this.WorkRb.Size = new System.Drawing.Size(66, 22);
            this.WorkRb.TabIndex = 14;
            this.WorkRb.TabStop = true;
            this.WorkRb.Text = "Work";
            this.WorkRb.UseVisualStyleBackColor = true;
            // 
            // OtherRb
            // 
            this.OtherRb.AutoSize = true;
            this.OtherRb.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherRb.Location = new System.Drawing.Point(41, 255);
            this.OtherRb.Name = "OtherRb";
            this.OtherRb.Size = new System.Drawing.Size(69, 22);
            this.OtherRb.TabIndex = 15;
            this.OtherRb.TabStop = true;
            this.OtherRb.Text = "Other";
            this.OtherRb.UseVisualStyleBackColor = true;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(397, 254);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 23);
            this.CancelBtn.TabIndex = 16;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // addressBtn
            // 
            this.addressBtn.Location = new System.Drawing.Point(397, 215);
            this.addressBtn.Name = "addressBtn";
            this.addressBtn.Size = new System.Drawing.Size(98, 23);
            this.addressBtn.TabIndex = 17;
            this.addressBtn.Text = "Add Address";
            this.addressBtn.UseVisualStyleBackColor = true;
            this.addressBtn.Click += new System.EventHandler(this.addressBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAddUpdateAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 301);
            this.Controls.Add(this.addressBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.OtherRb);
            this.Controls.Add(this.WorkRb);
            this.Controls.Add(this.HomeRb);
            this.Controls.Add(this.cbgovernorates);
            this.Controls.Add(this.postalcodetxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BuildingNumtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.streettxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.areatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.citytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddUpdateAddress";
            this.ShowIcon = false;
            this.Text = "Add Address";
            this.Load += new System.EventHandler(this.FrmAddAddress_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox citytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox areatxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox streettxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BuildingNumtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox postalcodetxt;
        private System.Windows.Forms.ComboBox cbgovernorates;
        private System.Windows.Forms.RadioButton HomeRb;
        private System.Windows.Forms.RadioButton WorkRb;
        private System.Windows.Forms.RadioButton OtherRb;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button addressBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}