using DungSaiTool.Extensions;
using Entities;
using Services;
using SQLiteHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DungSaiTool
{
    public partial class frmZVendorImport : Form
    {
        private ConvertDataZVendor _convertData;
        private ZVendorHelper _zVendorHelper;
        private List<ZVendor> zVendors;

        public frmZVendorImport()
        {
            InitializeComponent();
            _zVendorHelper = new ZVendorHelper();
            _convertData = new ConvertDataZVendor();
            zVendors = new List<ZVendor>();
        }

        private void btnImportFilePath_Click(object sender, EventArgs e)
        {
            LoadWaitFrm.Loading(this, () =>
             {
                 OpenFileDialog openFileDialog = new OpenFileDialog();
                 DialogResult dialogResult = openFileDialog.ShowDialog();
                 txtImportFilePath.Text = openFileDialog.FileName;
                 if (string.IsNullOrEmpty(txtImportFilePath.Text))
                 {
                     MessageBox.Show("Thiếu đường dẫn mở file!", "Thông báo");
                 }
                 else
                 {
                     zVendors = _zVendorHelper.GetAll(txtImportFilePath.Text);
                 }
             }, "Import");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            LoadWaitFrm.Loading(this, () =>
             {
                 if (zVendors.Count > 0)
                 {
                     TinhDungSai(ref zVendors);
                     ExportExcel(_convertData.ConvertZVendorsToDataTable(zVendors));
                 }
                 else
                 {
                     MessageBox.Show("Không tìm thấy dữ liệu, vui lòng kiểm tra lại!", "Thông báo");
                 }
             }, "Export");
        }

        private void TinhDungSai(ref List<ZVendor> zVendors)
        {
            int rs;
            foreach (ZVendor zVendor in zVendors)
            {
                rs = _zVendorHelper.TinhDungSai(zVendor);
                zVendor.Status = UpdateDSStatus(rs);
            }
        }

        private string UpdateDSStatus(int rs)
        {
            string status = "";
            switch (rs)
            {
                case -2:
                    status = "Không tìm thấy";
                    break;

                case -1:
                    status = "Ngoài dung sai(thiếu)";
                    break;

                case 0:
                    status = "Trong dung sai";
                    break;

                case 1:
                    status = "Ngoài dung sai(dư)";
                    break;
            }
            return status;
        }

        private void ExportExcel(DataTable data)
        {
            string fileName;
            SaveFileDialog fileDialog = new SaveFileDialog() { Filter = "Excel files (*.xlsx)|*.xlsx" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = fileDialog.FileName;
                CreateExcelFile.CreateExcelDocument(data, fileName);
            }
        }
    }
}