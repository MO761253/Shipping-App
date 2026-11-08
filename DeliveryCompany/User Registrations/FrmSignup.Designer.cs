
namespace DeliveryCompany
{
    partial class FrmSignup
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
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Lastnametxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.SignUpbtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // firstnametxt
            // 
            this.firstnametxt.Location = new System.Drawing.Point(115, 71);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(100, 20);
            this.firstnametxt.TabIndex = 1;
            this.firstnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyLeters);
            this.firstnametxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "First";
            // 
            // secondnametxt
            // 
            this.secondnametxt.Location = new System.Drawing.Point(237, 71);
            this.secondnametxt.Name = "secondnametxt";
            this.secondnametxt.Size = new System.Drawing.Size(100, 20);
            this.secondnametxt.TabIndex = 3;
            this.secondnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyLeters);
            this.secondnametxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(256, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Second";
            // 
            // Lastnametxt
            // 
            this.Lastnametxt.Location = new System.Drawing.Point(353, 70);
            this.Lastnametxt.Name = "Lastnametxt";
            this.Lastnametxt.Size = new System.Drawing.Size(100, 20);
            this.Lastnametxt.TabIndex = 5;
            this.Lastnametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyLeters);
            this.Lastnametxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Last";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(115, 119);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(100, 20);
            this.usernametxt.TabIndex = 7;
            this.usernametxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptLettersAndDigitsWithoutSpaces);
            this.usernametxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "UserName";
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(353, 116);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(100, 20);
            this.passwordtxt.TabIndex = 9;
            this.passwordtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventWhiteSpace);
            this.passwordtxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(275, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Confirm Password";
            // 
            // confirmpass
            // 
            this.confirmpass.Location = new System.Drawing.Point(353, 153);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(100, 20);
            this.confirmpass.TabIndex = 12;
            this.confirmpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventWhiteSpace);
            this.confirmpass.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email";
            // 
            // emailtxt
            // 
            this.emailtxt.Location = new System.Drawing.Point(115, 152);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(100, 20);
            this.emailtxt.TabIndex = 14;
            this.emailtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PreventWhiteSpace);
            this.emailtxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "PhoneNumber";
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(115, 184);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(100, 20);
            this.phonetxt.TabIndex = 16;
            this.phonetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AcceptOnlyDigits);
            this.phonetxt.Validating += new System.ComponentModel.CancelEventHandler(this.Validate_TextBox);
            // 
            // SignUpbtn
            // 
            this.SignUpbtn.Location = new System.Drawing.Point(368, 212);
            this.SignUpbtn.Name = "SignUpbtn";
            this.SignUpbtn.Size = new System.Drawing.Size(75, 23);
            this.SignUpbtn.TabIndex = 17;
            this.SignUpbtn.Text = "Sign Up";
            this.SignUpbtn.UseVisualStyleBackColor = true;
            this.SignUpbtn.Click += new System.EventHandler(this.SignUpbtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(368, 251);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 18;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(336, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Hide Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 286);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SignUpbtn);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lastnametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondnametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstnametxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmSignup";
            this.ShowIcon = false;
            this.Text = "Signup Screen";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Lastnametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Button SignUpbtn;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}