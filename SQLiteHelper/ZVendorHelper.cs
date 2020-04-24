using Entities;
using Services;
using System.Collections.Generic;
using System.Data;

namespace SQLiteHelper
{
    public class ZVendorHelper
    {
        private ImportExcel _importExcel;
        private ConvertDataZVendor _convertDataZVendor;
        private DungSaiNCCHelper _dungSaiNCCHelper;
        private Provider _provider;
        private SQLiteProvider _sQLiteProvider;

        public ZVendorHelper()
        {
            _importExcel = new ImportExcel();
            _convertDataZVendor = new ConvertDataZVendor();
            _provider = new Provider();
            _dungSaiNCCHelper = new DungSaiNCCHelper();
            _sQLiteProvider = new SQLiteProvider();
        }

        public List<ZVendor> GetAll(string path)
        {
            return _convertDataZVendor.ConvertDataTableToZVendors(_importExcel.ConvertExcelToDataTable(path));
        }

        public int TinhDungSai(ZVendor zVendor)
        {
            int result;
            float chenhLech, chenhLechPT;
            string query;

            query = _dungSaiNCCHelper.GetQuery(zVendor.Vendor, zVendor.MC);
            chenhLech = zVendor.SoLuongGiaoHang - zVendor.SoLuongDatHang;
            chenhLechPT = chenhLech / zVendor.SoLuongDatHang * 100;

            string[] names = new string[] { "@article", "@vendor", "@mc", "@sldh", "@slgh", "@cl", "@clpt" };
            object[] values = new object[] { zVendor.Article, zVendor.Vendor, zVendor.MC, zVendor.SoLuongDatHang, zVendor.SoLuongGiaoHang, chenhLech, chenhLechPT };
            DataTable data = _sQLiteProvider.ExecuteQuery(query, names, values);

            result = data.Rows.Count > 0 ? int.Parse(data.Rows[0][0].ToString()) : -2;
            return result;
        }
    }
}