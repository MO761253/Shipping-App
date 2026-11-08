
namespace DeliveryCompany
{
    partial class FrmShipTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShipTracking));
            this.label1 = new System.Windows.Forms.Label();
            this.ShipIDtxt = new System.Windows.Forms.TextBox();
            this.ShipSearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Shipment ID";
            // 
            // ShipIDtxt
            // 
            this.ShipIDtxt.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipIDtxt.Location = new System.Drawing.Point(253, 111);
            this.ShipIDtxt.Multiline = true;
            this.ShipIDtxt.Name = "ShipIDtxt";
            this.ShipIDtxt.Size = new System.Drawing.Size(252, 31);
            this.ShipIDtxt.TabIndex = 1;
            this.ShipIDtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShipIDtxt_KeyPress);
            this.ShipIDtxt.Validating += new System.ComponentModel.CancelEventHandler(this.ShipIDtxt_Validating);
            // 
            // ShipSearchBtn
            // 
            this.ShipSearchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShipSearchBtn.BackgroundImage")));
            this.ShipSearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShipSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ShipSearchBtn.Location = new System.Drawing.Point(526, 106);
            this.ShipSearchBtn.Name = "ShipSearchBtn";
            this.ShipSearchBtn.Size = new System.Drawing.Size(44, 39);
            this.ShipSearchBtn.TabIndex = 3;
            this.ShipSearchBtn.UseVisualStyleBackColor = true;
            this.ShipSearchBtn.Click += new System.EventHandler(this.ShipSearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(177, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 240);
            this.panel1.TabIndex = 4;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmShipTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShipSearchBtn);
            this.Controls.Add(this.ShipIDtxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmShipTracking";
            this.ShowIcon = false;
            this.Text = "Shipment Tracking";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShipIDtxt;
        private System.Windows.Forms.Button ShipSearchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}