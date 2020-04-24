using Entities;
using Services;
using System.Data;

namespace SQLiteHelper
{
    public class DungSaiNCCHelper
    {
        private SQLiteProvider _sQLiteProvider;

        public DungSaiNCCHelper()
        {
            _sQLiteProvider = new SQLiteProvider();
        }

        public bool XoaDuLieu()
        {
            return _sQLiteProvider.ExecuteNonQuery("DELETE FROM DungSaiNCC");
        }

        public bool ThemDuLieu(DungSaiNCC dungSaiNCC)
        {
            string[] names = new string[] { "@id", "@mancc", "@nhomvt", "@subquery" };
            object[] values = new object[] { dungSaiNCC.ID, dungSaiNCC.MaNCC, dungSaiNCC.NhomVT, dungSaiNCC.SubQuery };
            string query = "INSERT INTO DungSaiNCC(ID, MaNCC, NhomVT, SubQuery) VALUES(@id, @mancc, @nhomvt, @subquery)";
            return _sQLiteProvider.ExecuteNonQuery(query, names, values);
        }

        public string GetQuery(string maNCC, string mc)
        {
            string result;
            string[] names = new string[] { "@mancc", "@mc" };
            object[] values = new object[] { maNCC, mc };
            string query = "SELECT ds.SubQuery FROM DungSaiNCC ds WHERE ds.MaNCC = @mancc AND ds.NhomVT IN (SELECT vt.NhomVT FROM VatTu vt WHERE vt.NhomVT = ds.NhomVT AND vt.MC = @mc)";
            DataTable data = _sQLiteProvider.ExecuteQuery(query, names, values);
            result = data.Rows.Count > 0 ? data.Rows[0][0].ToString() : "";
            return result;
        }
    }
}