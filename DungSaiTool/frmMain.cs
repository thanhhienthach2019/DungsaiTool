using BUS;
using DungSaiTool.Extensions;
using Entities;
using Services;
using SQLiteHelper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DungSaiTool
{
    public partial class frmMain : Form
    {
        private DungSaiNCCBUS _dungSaiNCCBUS;
        private VatTuBUS _VatTuBUS;
        private ConvertDataZVendor _convertDataZVendor;
        private DungSaiNCCHelper _dungSaiNCCHelper;
        private VatTuHelper _VatTuHelper;
        private ZVendorHelper _zVendorHelper;

        public frmMain()
        {
            InitializeComponent();
            _dungSaiNCCBUS = new DungSaiNCCBUS();
            _VatTuBUS = new VatTuBUS();
            _convertDataZVendor = new ConvertDataZVendor();
            _dungSaiNCCHelper = new DungSaiNCCHelper();
            _VatTuHelper = new VatTuHelper();
            _zVendorHelper = new ZVendorHelper();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void zVendorColumnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string frmName = "frmZVendorColumnSetup";
            if (!CheckExistForm(frmName))
            {
                frmZVendorColumnSetup frm = new frmZVendorColumnSetup();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm(frmName);
            }
        }

        private bool CheckExistForm(string frmName)
        {
            bool check = false;
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == frmName)
                {
                    check = true;
                }
            }
            return check;
        }

        private void ActiveChildForm(string frmName)
        {
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == frmName)
                {
                    item.Activate();
                }
            }
        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string frmName = "frmQuery";
            if (!CheckExistForm(frmName))
            {
                frmQuery frm = new frmQuery();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm(frmName);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string frmName = "frmZVendorImport";
            if (!CheckExistForm(frmName))
            {
                frmZVendorImport frm = new frmZVendorImport();
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                ActiveChildForm(frmName);
            }
        }

        private void SyncDSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadWaitFrm.Loading(this, () =>
             {
                 List<DungSaiNCC> dungSaiNCCs = new List<DungSaiNCC>();
                 _dungSaiNCCHelper.XoaDuLieu();
                 dungSaiNCCs = _dungSaiNCCBUS.GetAllDungSai();
                 foreach (DungSaiNCC item in dungSaiNCCs)
                 {
                     _dungSaiNCCHelper.ThemDuLieu(item);
                 }
             }, "Đồng bộ dung sai");
        }

        private void SyncVTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadWaitFrm.Loading(this, () =>
            {
                List<VatTu> vatTus = new List<VatTu>();
                _VatTuHelper.XoaDuLieu();
                vatTus = _VatTuBUS.GetAllVT();
                foreach (VatTu item in vatTus)
                {
                    _VatTuHelper.ThemDuLieu(item);
                }
            }, "Đồng bộ vật tư");
        }
    }
}