
namespace DeliveryCompany
{
    partial class FrmShipmentsMainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShipmentsMainScreen));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.displayPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddShipmentBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DelCancelledShipsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 211);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(298, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shipments";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayPackagesToolStripMenuItem,
            this.updateShipmentToolStripMenuItem,
            this.cancelShipmentToolStripMenuItem,
            this.payShipmentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(191, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // displayPackagesToolStripMenuItem
            // 
            this.displayPackagesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("displayPackagesToolStripMenuItem.Image")));
            this.displayPackagesToolStripMenuItem.Name = "displayPackagesToolStripMenuItem";
            this.displayPackagesToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.displayPackagesToolStripMenuItem.Text = "Display packages";
            this.displayPackagesToolStripMenuItem.Click += new System.EventHandler(this.displayPackagesToolStripMenuItem_Click);
            // 
            // updateShipmentToolStripMenuItem
            // 
            this.updateShipmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateShipmentToolStripMenuItem.Image")));
            this.updateShipmentToolStripMenuItem.Name = "updateShipmentToolStripMenuItem";
            this.updateShipmentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.updateShipmentToolStripMenuItem.Text = "Update Shipment Info";
            this.updateShipmentToolStripMenuItem.Click += new System.EventHandler(this.updateShipmentToolStripMenuItem_Click);
            // 
            // cancelShipmentToolStripMenuItem
            // 
            this.cancelShipmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelShipmentToolStripMenuItem.Image")));
            this.cancelShipmentToolStripMenuItem.Name = "cancelShipmentToolStripMenuItem";
            this.cancelShipmentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cancelShipmentToolStripMenuItem.Text = "Cancel Shipment";
            this.cancelShipmentToolStripMenuItem.Click += new System.EventHandler(this.cancelShipmentToolStripMenuItem_Click);
            // 
            // payShipmentToolStripMenuItem
            // 
            this.payShipmentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("payShipmentToolStripMenuItem.Image")));
            this.payShipmentToolStripMenuItem.Name = "payShipmentToolStripMenuItem";
            this.payShipmentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.payShipmentToolStripMenuItem.Text = "Pay Shipment";
            this.payShipmentToolStripMenuItem.Click += new System.EventHandler(this.payShipmentToolStripMenuItem_Click);
            // 
            // AddShipmentBtn
            // 
            this.AddShipmentBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddShipmentBtn.BackgroundImage")));
            this.AddShipmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddShipmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddShipmentBtn.Location = new System.Drawing.Point(722, 177);
            this.AddShipmentBtn.Name = "AddShipmentBtn";
            this.AddShipmentBtn.Size = new System.Drawing.Size(66, 56);
            this.AddShipmentBtn.TabIndex = 3;
            this.AddShipmentBtn.UseVisualStyleBackColor = true;
            this.AddShipmentBtn.Click += new System.EventHandler(this.AddShipBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(266, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 134);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // DelCancelledShipsBtn
            // 
            this.DelCancelledShipsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DelCancelledShipsBtn.ForeColor = System.Drawing.Color.Crimson;
            this.DelCancelledShipsBtn.Location = new System.Drawing.Point(12, 197);
            this.DelCancelledShipsBtn.Name = "DelCancelledShipsBtn";
            this.DelCancelledShipsBtn.Size = new System.Drawing.Size(114, 36);
            this.DelCancelledShipsBtn.TabIndex = 4;
            this.DelCancelledShipsBtn.Text = "Delete All Cancelled Shipments";
            this.DelCancelledShipsBtn.UseVisualStyleBackColor = true;
            this.DelCancelledShipsBtn.Click += new System.EventHandler(this.DelCancelledShipsBtn_Click);
            // 
            // FrmShipmentsMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelCancelledShipsBtn);
            this.Controls.Add(this.AddShipmentBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmShipmentsMainScreen";
            this.ShowIcon = false;
            this.Text = "Shipment";
            this.Load += new System.EventHandler(this.FrmShipmentsMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddShipmentBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem displayPackagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateShipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelShipmentToolStripMenuItem;
        private System.Windows.Forms.Button DelCancelledShipsBtn;
        private System.Windows.Forms.ToolStripMenuItem payShipmentToolStripMenuItem;
    }
}