using Services;
using System;
using System.Windows.Forms;

namespace DungSaiTool
{
    public partial class frmZVendorColumnSetup : Form
    {
        private EditConfig _settingConfig;

        public frmZVendorColumnSetup()
        {
            InitializeComponent();
            _settingConfig = new EditConfig();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmZVendorColumnSetup_Load(object sender, EventArgs e)
        {
            nmrArticle.Value = int.Parse(_settingConfig.ReadSetting("ZVendor.ArticleColumn"));
            nmrVendor.Value = int.Parse(_settingConfig.ReadSetting("ZVendor.VendorColumn"));
            nmrMC.Value = int.Parse(_settingConfig.ReadSetting("ZVendor.MCColumn"));
            nmrSLDH.Value = int.Parse(_settingConfig.ReadSetting("ZVendor.SoLuongDatHangColumn"));
            nmrSLGH.Value = int.Parse(_settingConfig.ReadSetting("ZVendor.SoLuongGiaoHangColumn"));
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Lưu thiết lập hiện tại?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                _settingConfig.UpdateSettings("ZVendor.ArticleColumn", nmrArticle.Value.ToString());
                _settingConfig.UpdateSettings("ZVendor.VendorColumn", nmrVendor.Value.ToString());
                _settingConfig.UpdateSettings("ZVendor.MCColumn", nmrMC.Value.ToString());
                _settingConfig.UpdateSettings("ZVendor.SoLuongDatHangColumn", nmrSLDH.Value.ToString());
                _settingConfig.UpdateSettings("ZVendor.SoLuongGiaoHangColumn", nmrSLGH.Value.ToString());
            }
        }
    }
}