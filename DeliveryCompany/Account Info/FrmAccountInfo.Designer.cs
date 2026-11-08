
namespace DeliveryCompany
{
    partial class FrmAccountInfo
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
            this.emaiLlbl = new System.Windows.Forms.Label();
            this.phonelbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.UserinfoGB = new System.Windows.Forms.GroupBox();
            this.AddressesGb = new System.Windows.Forms.GroupBox();
            this.Otherlbl = new System.Windows.Forms.Label();
            this.Olbl = new System.Windows.Forms.Label();
            this.worklbl = new System.Windows.Forms.Label();
            this.Wlbl = new System.Windows.Forms.Label();
            this.Homelbl = new System.Windows.Forms.Label();
            this.Hlbl = new System.Windows.Forms.Label();
            this.ChangePassBtn = new System.Windows.Forms.Button();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.UserinfoGB.SuspendLayout();
            this.AddressesGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // emaiLlbl
            // 
            this.emaiLlbl.AutoSize = true;
            this.emaiLlbl.BackColor = System.Drawing.SystemColors.Control;
            this.emaiLlbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.emaiLlbl.Location = new System.Drawing.Point(19, 84);
            this.emaiLlbl.Name = "emaiLlbl";
            this.emaiLlbl.Size = new System.Drawing.Size(22, 13);
            this.emaiLlbl.TabIndex = 2;
            this.emaiLlbl.Text = "???";
            // 
            // phonelbl
            // 
            this.phonelbl.AutoSize = true;
            this.phonelbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelbl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.phonelbl.Location = new System.Drawing.Point(19, 56);
            this.phonelbl.Name = "phonelbl";
            this.phonelbl.Size = new System.Drawing.Size(25, 14);
            this.phonelbl.TabIndex = 1;
            this.phonelbl.Text = "???";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(19, 25);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(35, 18);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "???";
            // 
            // UserinfoGB
            // 
            this.UserinfoGB.Controls.Add(this.Usernamelbl);
            this.UserinfoGB.Controls.Add(this.Namelbl);
            this.UserinfoGB.Controls.Add(this.emaiLlbl);
            this.UserinfoGB.Controls.Add(this.phonelbl);
            this.UserinfoGB.Location = new System.Drawing.Point(26, 35);
            this.UserinfoGB.Name = "UserinfoGB";
            this.UserinfoGB.Size = new System.Drawing.Size(427, 135);
            this.UserinfoGB.TabIndex = 3;
            this.UserinfoGB.TabStop = false;
            this.UserinfoGB.Text = "UserInfo";
            // 
            // AddressesGb
            // 
            this.AddressesGb.Controls.Add(this.Otherlbl);
            this.AddressesGb.Controls.Add(this.Olbl);
            this.AddressesGb.Controls.Add(this.worklbl);
            this.AddressesGb.Controls.Add(this.Wlbl);
            this.AddressesGb.Controls.Add(this.Homelbl);
            this.AddressesGb.Controls.Add(this.Hlbl);
            this.AddressesGb.Location = new System.Drawing.Point(26, 193);
            this.AddressesGb.Name = "AddressesGb";
            this.AddressesGb.Size = new System.Drawing.Size(427, 155);
            this.AddressesGb.TabIndex = 4;
            this.AddressesGb.TabStop = false;
            this.AddressesGb.Text = "Addresses";
            // 
            // Otherlbl
            // 
            this.Otherlbl.AutoSize = true;
            this.Otherlbl.Location = new System.Drawing.Point(57, 109);
            this.Otherlbl.Name = "Otherlbl";
            this.Otherlbl.Size = new System.Drawing.Size(22, 13);
            this.Otherlbl.TabIndex = 5;
            this.Otherlbl.Text = "???";
            // 
            // Olbl
            // 
            this.Olbl.AutoSize = true;
            this.Olbl.Location = new System.Drawing.Point(6, 109);
            this.Olbl.Name = "Olbl";
            this.Olbl.Size = new System.Drawing.Size(45, 13);
            this.Olbl.TabIndex = 4;
            this.Olbl.Text = "Other : ";
            // 
            // worklbl
            // 
            this.worklbl.AutoSize = true;
            this.worklbl.Location = new System.Drawing.Point(57, 71);
            this.worklbl.Name = "worklbl";
            this.worklbl.Size = new System.Drawing.Size(22, 13);
            this.worklbl.TabIndex = 3;
            this.worklbl.Text = "???";
            // 
            // Wlbl
            // 
            this.Wlbl.AutoSize = true;
            this.Wlbl.Location = new System.Drawing.Point(9, 71);
            this.Wlbl.Name = "Wlbl";
            this.Wlbl.Size = new System.Drawing.Size(42, 13);
            this.Wlbl.TabIndex = 2;
            this.Wlbl.Text = "Work : ";
            // 
            // Homelbl
            // 
            this.Homelbl.AutoSize = true;
            this.Homelbl.Location = new System.Drawing.Point(57, 31);
            this.Homelbl.Name = "Homelbl";
            this.Homelbl.Size = new System.Drawing.Size(22, 13);
            this.Homelbl.TabIndex = 1;
            this.Homelbl.Text = "???";
            // 
            // Hlbl
            // 
            this.Hlbl.AutoSize = true;
            this.Hlbl.Location = new System.Drawing.Point(9, 31);
            this.Hlbl.Name = "Hlbl";
            this.Hlbl.Size = new System.Drawing.Size(44, 13);
            this.Hlbl.TabIndex = 0;
            this.Hlbl.Text = "Home : ";
            // 
            // ChangePassBtn
            // 
            this.ChangePassBtn.Location = new System.Drawing.Point(434, 368);
            this.ChangePassBtn.Name = "ChangePassBtn";
            this.ChangePassBtn.Size = new System.Drawing.Size(106, 23);
            this.ChangePassBtn.TabIndex = 5;
            this.ChangePassBtn.Text = "Change Password";
            this.ChangePassBtn.UseVisualStyleBackColor = true;
            this.ChangePassBtn.Click += new System.EventHandler(this.ChangePassBtn_Click);
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.SystemColors.Control;
            this.Usernamelbl.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Usernamelbl.Location = new System.Drawing.Point(19, 106);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(22, 13);
            this.Usernamelbl.TabIndex = 3;
            this.Usernamelbl.Text = "???";
            // 
            // FrmAccountInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 408);
            this.Controls.Add(this.ChangePassBtn);
            this.Controls.Add(this.AddressesGb);
            this.Controls.Add(this.UserinfoGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAccountInfo";
            this.ShowIcon = false;
            this.Text = "Account Info";
            this.Load += new System.EventHandler(this.FrmAccountInfo_Load);
            this.UserinfoGB.ResumeLayout(false);
            this.UserinfoGB.PerformLayout();
            this.AddressesGb.ResumeLayout(false);
            this.AddressesGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label emaiLlbl;
        private System.Windows.Forms.Label phonelbl;
        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.GroupBox UserinfoGB;
        private System.Windows.Forms.GroupBox AddressesGb;
        private System.Windows.Forms.Label Homelbl;
        private System.Windows.Forms.Label Hlbl;
        private System.Windows.Forms.Label worklbl;
        private System.Windows.Forms.Label Wlbl;
        private System.Windows.Forms.Label Otherlbl;
        private System.Windows.Forms.Label Olbl;
        private System.Windows.Forms.Button ChangePassBtn;
        private System.Windows.Forms.Label Usernamelbl;
    }
}