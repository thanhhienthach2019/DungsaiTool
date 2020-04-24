using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Services
{
    public class ConvertDataZVendor
    {
        private int articleColumn;
        private int vendorColumn;
        private int mcColumn;
        private int soLuongDatHangColumn;
        private int soLuongGiaoHangColumn;

        public ConvertDataZVendor()
        {
            EditConfig settingConfig = new EditConfig();
            this.articleColumn = int.Parse(settingConfig.ReadSetting("ZVendor.ArticleColumn"));
            this.vendorColumn = int.Parse(settingConfig.ReadSetting("ZVendor.VendorColumn"));
            this.mcColumn = int.Parse(settingConfig.ReadSetting("ZVendor.MCColumn"));
            this.soLuongDatHangColumn = int.Parse(settingConfig.ReadSetting("ZVendor.SoLuongDatHangColumn"));
            this.soLuongGiaoHangColumn = int.Parse(settingConfig.ReadSetting("ZVendor.SoLuongGiaoHangColumn"));
        }

        public List<ZVendor> ConvertDataTableToZVendors(DataTable data)
        {
            List<ZVendor> zVendors = new List<ZVendor>();
            foreach (DataRow dataRow in data.Rows)
            {
                ZVendor zVendor = new ZVendor();
                zVendor.Article = dataRow[this.articleColumn].ToString();
                zVendor.Vendor = dataRow[this.vendorColumn].ToString();
                zVendor.MC = dataRow[this.mcColumn].ToString();
                zVendor.SoLuongDatHang = string.IsNullOrEmpty(dataRow[this.soLuongDatHangColumn].ToString()) ? 0 : float.Parse(dataRow[this.soLuongDatHangColumn].ToString());
                zVendor.SoLuongGiaoHang = string.IsNullOrEmpty(dataRow[this.soLuongGiaoHangColumn].ToString()) ? 0 : float.Parse(dataRow[this.soLuongGiaoHangColumn].ToString());
                zVendors.Add(zVendor);
            }
            return zVendors;
        }

        public DataTable ConvertZVendorsToDataTable(List<ZVendor> zVendors)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(ZVendor));
            DataTable data = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                data.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (ZVendor item in zVendors)
            {
                DataRow row = data.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                data.Rows.Add(row);
            }
            return data;
        }
    }
}