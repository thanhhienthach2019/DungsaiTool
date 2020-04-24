namespace DungSaiTool
{
    partial class frmZVendorImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZVendorImport));
            this.label1 = new System.Windows.Forms.Label();
            this.txtImportFilePath = new System.Windows.Forms.TextBox();
            this.btnImportFilePath = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuLy = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn mở file";
            // 
            // txtImportFilePath
            // 
            this.txtImportFilePath.Location = new System.Drawing.Point(140, 30);
            this.txtImportFilePath.Name = "txtImportFilePath";
            this.txtImportFilePath.Size = new System.Drawing.Size(277, 20);
            this.txtImportFilePath.TabIndex = 2;
            // 
            // btnImportFilePath
            // 
            this.btnImportFilePath.Location = new System.Drawing.Point(423, 28);
            this.btnImportFilePath.Name = "btnImportFilePath";
            this.btnImportFilePath.Size = new System.Drawing.Size(27, 23);
            this.btnImportFilePath.TabIndex = 4;
            this.btnImportFilePath.Text = "...";
            this.btnImportFilePath.Click += new System.EventHandler(this.btnImportFilePath_Click);
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(162, 78);
            this.btnXuLy.Name = "btnXuLy";
            this.btnXuLy.Size = new System.Drawing.Size(104, 23);
            this.btnXuLy.TabIndex = 6;
            this.btnXuLy.Text = "Xử lý";
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(293, 78);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmZVendorImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 173);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuLy);
            this.Controls.Add(this.btnImportFilePath);
            this.Controls.Add(this.txtImportFilePath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZVendorImport";
            this.Text = "Import ZVendor File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImportFilePath;
        private DevExpress.XtraEditors.SimpleButton btnImportFilePath;
        private DevExpress.XtraEditors.SimpleButton btnXuLy;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}