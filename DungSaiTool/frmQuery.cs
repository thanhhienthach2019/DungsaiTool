using BUS;
using DevExpress.XtraGrid.Views.Grid;
using Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DungSaiTool
{
    public partial class frmQuery : Form
    {
        private DungSaiNCCBUS _dungSaiNCCBUS;
        private int checkUpdateStatus;
        private int dsID;

        private enum UpdateStatus
        {
            NONE = 0,
            INSERT = 1,
            UPDATE = 2
        }

        public frmQuery()
        {
            InitializeComponent();
            _dungSaiNCCBUS = new DungSaiNCCBUS();
            checkUpdateStatus = (int)UpdateStatus.NONE;
        }

        private void frmQuery_Load(object sender, EventArgs e)
        {
            LoadDtgvQuery();
            EnableTextBox();
        }

        private void EnableTextBox(bool maNCCStatus = false, bool nhomVTStatus = false, bool queryStatus = false)
        {
            txtMaNCC.Enabled = maNCCStatus;
            txtNhomVT.Enabled = nhomVTStatus;
            txtQuery.Enabled = queryStatus;
        }

        private void ClearTextBox()
        {
            txtMaNCC.Clear();
            txtNhomVT.Clear();
            txtQuery.Clear();
        }

        private void LoadDtgvQuery()
        {
            List<DungSaiNCC> dungSaiNCCs = _dungSaiNCCBUS.GetAllDungSai();
            grcQuery.DataSource = dungSaiNCCs;
            grvQuery.Columns["ID"].BestFit();
            grvQuery.Columns["MaNCC"].BestFit();
            grvQuery.Columns["NhomVT"].BestFit();
        }

        private void grvQuery_RowClick(object sender, RowClickEventArgs e)
        {
            if (checkUpdateStatus == (int)UpdateStatus.NONE)
            {
                dsID = (int)grvQuery.GetRowCellValue(grvQuery.FocusedRowHandle, grvQuery.Columns["ID"]);
                txtMaNCC.Text = grvQuery.GetRowCellValue(grvQuery.FocusedRowHandle, grvQuery.Columns["MaNCC"]).ToString();
                txtNhomVT.Text = grvQuery.GetRowCellValue(grvQuery.FocusedRowHandle, grvQuery.Columns["NhomVT"]).ToString();
                txtQuery.Text = grvQuery.GetRowCellValue(grvQuery.FocusedRowHandle, grvQuery.Columns["SubQuery"]).ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmThem_Click(object sender, EventArgs e)
        {
            if (checkUpdateStatus == (int)UpdateStatus.NONE)
            {
                checkUpdateStatus = (int)UpdateStatus.INSERT;
                EnableTextBox(true, true, true);
                ClearTextBox();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkUpdateStatus == (int)UpdateStatus.NONE)
            {
                checkUpdateStatus = (int)UpdateStatus.UPDATE;
                EnableTextBox(true, true, true);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dsID > 0 && checkUpdateStatus == (int)UpdateStatus.NONE)
            {
                if (MessageBox.Show(string.Format("Xóa mã có id {0}?", dsID), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    DeleteDungSaiNCC(dsID);
                    ClearTextBox();
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkUpdateStatus != (int)UpdateStatus.NONE)
            {
                string maNCC, nhomVT, subQuery;
                maNCC = txtMaNCC.Text;
                nhomVT = txtNhomVT.Text;
                subQuery = txtQuery.Text;
                if (checkUpdateStatus == (int)UpdateStatus.INSERT)
                {
                    InsertDungSaiNCC(maNCC, nhomVT, subQuery);
                }
                else if (checkUpdateStatus == (int)UpdateStatus.UPDATE)
                {
                    UpdateDungSaiNCC(dsID, maNCC, nhomVT, subQuery);
                }
                checkUpdateStatus = (int)UpdateStatus.NONE;
                EnableTextBox();
            }
        }

        private void InsertDungSaiNCC(string maNCC, string nhomVT, string subQuery)
        {
            int id = _dungSaiNCCBUS.InsertDungSai(maNCC, nhomVT, subQuery);
            if (id > 0)
            {
                dsID = id;
                LoadDtgvQuery();
                MessageBox.Show("Thêm thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Thêm không thành công!", "Thông báo");
            }
        }

        private void UpdateDungSaiNCC(int id, string maNCC, string nhomVT, string subQuery)
        {
            bool res = false;
            res = _dungSaiNCCBUS.UpdateDungSai(id, maNCC, nhomVT, subQuery);
            if (res)
            {
                LoadDtgvQuery();
                MessageBox.Show("Sửa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Sửa không thành công!", "Thông báo");
            }
        }

        private void DeleteDungSaiNCC(int id)
        {
            bool res = false;
            res = _dungSaiNCCBUS.DeleteDungSai(id);
            if (res)
            {
                LoadDtgvQuery();
                MessageBox.Show("Xóa thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Xóa không thành công!", "Thông báo");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            checkUpdateStatus = (int)UpdateStatus.NONE;
            EnableTextBox();
        }
    }
}