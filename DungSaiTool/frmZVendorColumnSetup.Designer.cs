namespace DungSaiTool
{
    partial class frmZVendorColumnSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmZVendorColumnSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrArticle = new System.Windows.Forms.NumericUpDown();
            this.nmrVendor = new System.Windows.Forms.NumericUpDown();
            this.nmrSLDH = new System.Windows.Forms.NumericUpDown();
            this.nmrSLGH = new System.Windows.Forms.NumericUpDown();
            this.nmrMC = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nmrArticle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSLDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSLGH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Số lượng đặt hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng giao hàng";
            // 
            // nmrArticle
            // 
            this.nmrArticle.Location = new System.Drawing.Point(133, 20);
            this.nmrArticle.Name = "nmrArticle";
            this.nmrArticle.Size = new System.Drawing.Size(52, 20);
            this.nmrArticle.TabIndex = 1;
            // 
            // nmrVendor
            // 
            this.nmrVendor.Location = new System.Drawing.Point(133, 60);
            this.nmrVendor.Name = "nmrVendor";
            this.nmrVendor.Size = new System.Drawing.Size(52, 20);
            this.nmrVendor.TabIndex = 3;
            // 
            // nmrSLDH
            // 
            this.nmrSLDH.Location = new System.Drawing.Point(133, 140);
            this.nmrSLDH.Name = "nmrSLDH";
            this.nmrSLDH.Size = new System.Drawing.Size(52, 20);
            this.nmrSLDH.TabIndex = 7;
            // 
            // nmrSLGH
            // 
            this.nmrSLGH.Location = new System.Drawing.Point(133, 180);
            this.nmrSLGH.Name = "nmrSLGH";
            this.nmrSLGH.Size = new System.Drawing.Size(52, 20);
            this.nmrSLGH.TabIndex = 9;
            // 
            // nmrMC
            // 
            this.nmrMC.Location = new System.Drawing.Point(133, 100);
            this.nmrMC.Name = "nmrMC";
            this.nmrMC.Size = new System.Drawing.Size(52, 20);
            this.nmrMC.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "MC";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(207, 17);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 10;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(207, 57);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // frmZVendorColumnSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 221);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrMC);
            this.Controls.Add(this.nmrSLGH);
            this.Controls.Add(this.nmrSLDH);
            this.Controls.Add(this.nmrVendor);
            this.Controls.Add(this.nmrArticle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmZVendorColumnSetup";
            this.Text = "ZVendor Column Setup";
            this.Load += new System.EventHandler(this.frmZVendorColumnSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrArticle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSLDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSLGH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrArticle;
        private System.Windows.Forms.NumericUpDown nmrVendor;
        private System.Windows.Forms.NumericUpDown nmrSLDH;
        private System.Windows.Forms.NumericUpDown nmrSLGH;
        private System.Windows.Forms.NumericUpDown nmrMC;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
    }
}