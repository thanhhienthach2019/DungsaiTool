namespace DungSaiTool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zVendorColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SyncDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SyncVTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(967, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.fileToolStripMenuItem.Text = "Run";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zVendorColumnsToolStripMenuItem,
            this.queryToolStripMenuItem,
            this.SyncDSToolStripMenuItem,
            this.SyncVTToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.setupToolStripMenuItem.Text = "Thiết lập";
            // 
            // zVendorColumnsToolStripMenuItem
            // 
            this.zVendorColumnsToolStripMenuItem.Name = "zVendorColumnsToolStripMenuItem";
            this.zVendorColumnsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.zVendorColumnsToolStripMenuItem.Text = "ZVendor Column";
            this.zVendorColumnsToolStripMenuItem.Click += new System.EventHandler(this.zVendorColumnsToolStripMenuItem_Click);
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.queryToolStripMenuItem.Text = "Query";
            this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
            // 
            // SyncDSToolStripMenuItem
            // 
            this.SyncDSToolStripMenuItem.Name = "SyncDSToolStripMenuItem";
            this.SyncDSToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.SyncDSToolStripMenuItem.Text = "Đồng Bộ Dung Sai";
            this.SyncDSToolStripMenuItem.Click += new System.EventHandler(this.SyncDSToolStripMenuItem_Click);
            // 
            // SyncVTToolStripMenuItem
            // 
            this.SyncVTToolStripMenuItem.Name = "SyncVTToolStripMenuItem";
            this.SyncVTToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.SyncVTToolStripMenuItem.Text = "Đồng Bộ Vật Tư";
            this.SyncVTToolStripMenuItem.Click += new System.EventHandler(this.SyncVTToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.exitToolStripMenuItem.Text = "Thoát";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 570);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "Dung Sai Tool";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zVendorColumnsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SyncDSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SyncVTToolStripMenuItem;
    }
}