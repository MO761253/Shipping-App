
namespace DeliveryCompany
{
    partial class FrmUpdateShipmentInfo
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
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.OtherRb = new System.Windows.Forms.RadioButton();
            this.WorkRb = new System.Windows.Forms.RadioButton();
            this.HomeRb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.DADtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rphonetxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendernametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Receivernametxt = new System.Windows.Forms.TextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Location = new System.Drawing.Point(330, 230);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(86, 23);
            this.ConfirmBtn.TabIndex = 27;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // OtherRb
            // 
            this.OtherRb.AutoSize = true;
            this.OtherRb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherRb.Location = new System.Drawing.Point(339, 190);
            this.OtherRb.Name = "OtherRb";
            this.OtherRb.Size = new System.Drawing.Size(57, 17);
            this.OtherRb.TabIndex = 26;
            this.OtherRb.TabStop = true;
            this.OtherRb.Text = "Other";
            this.OtherRb.UseVisualStyleBackColor = true;
            // 
            // WorkRb
            // 
            this.WorkRb.AutoSize = true;
            this.WorkRb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkRb.Location = new System.Drawing.Point(377, 156);
            this.WorkRb.Name = "WorkRb";
            this.WorkRb.Size = new System.Drawing.Size(55, 17);
            this.WorkRb.TabIndex = 25;
            this.WorkRb.TabStop = true;
            this.WorkRb.Text = "Work";
            this.WorkRb.UseVisualStyleBackColor = true;
            // 
            // HomeRb
            // 
            this.HomeRb.AutoSize = true;
            this.HomeRb.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeRb.Location = new System.Drawing.Point(293, 156);
            this.HomeRb.Name = "HomeRb";
            this.HomeRb.Size = new System.Drawing.Size(58, 17);
            this.HomeRb.TabIndex = 24;
            this.HomeRb.TabStop = true;
            this.HomeRb.Text = "Home";
            this.HomeRb.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Choose Your Address ";
            // 
            // DADtxt
            // 
            this.DADtxt.Location = new System.Drawing.Point(28, 155);
            this.DADtxt.Multiline = true;
            this.DADtxt.Name = "DADtxt";
            this.DADtxt.Size = new System.Drawing.Size(196, 98);
            this.DADtxt.TabIndex = 22;
            this.DADtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DADtxt_KeyPress);
            this.DADtxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Delivery Address Description";
            // 
            // Rphonetxt
            // 
            this.Rphonetxt.Location = new System.Drawing.Point(377, 44);
            this.Rphonetxt.Name = "Rphonetxt";
            this.Rphonetxt.Size = new System.Drawing.Size(93, 20);
            this.Rphonetxt.TabIndex = 20;
            this.Rphonetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyDigits);
            this.Rphonetxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(262, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Receiver Phone";
            // 
            // sendernametxt
            // 
            this.sendernametxt.Location = new System.Drawing.Point(135, 77);
            this.sendernametxt.Name = "sendernametxt";
            this.sendernametxt.Size = new System.Drawing.Size(93, 20);
            this.sendernametxt.TabIndex = 18;
            this.sendernametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyLeters);
            this.sendernametxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Sender Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Receiver Name";
            // 
            // Receivernametxt
            // 
            this.Receivernametxt.Location = new System.Drawing.Point(135, 45);
            this.Receivernametxt.Name = "Receivernametxt";
            this.Receivernametxt.Size = new System.Drawing.Size(93, 20);
            this.Receivernametxt.TabIndex = 15;
            this.Receivernametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyLeters);
            this.Receivernametxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(330, 269);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 23);
            this.CancelBtn.TabIndex = 28;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUpdateShipmentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 316);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.OtherRb);
            this.Controls.Add(this.WorkRb);
            this.Controls.Add(this.HomeRb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DADtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Rphonetxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sendernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Receivernametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUpdateShipmentInfo";
            this.ShowIcon = false;
            this.Text = "Update Shipment Info";
            this.Load += new System.EventHandler(this.FrmUpdateShipmentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.RadioButton OtherRb;
        private System.Windows.Forms.RadioButton WorkRb;
        private System.Windows.Forms.RadioButton HomeRb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DADtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Rphonetxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sendernametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Receivernametxt;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}