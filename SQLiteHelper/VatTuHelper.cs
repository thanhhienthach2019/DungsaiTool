using Entities;
using Services;

namespace SQLiteHelper
{
    public class VatTuHelper
    {
        private SQLiteProvider _sQLiteProvider;

        public VatTuHelper()
        {
            _sQLiteProvider = new SQLiteProvider();
        }

        public bool XoaDuLieu()
        {
            return _sQLiteProvider.ExecuteNonQuery("DELETE FROM VatTu");
        }

        public bool ThemDuLieu(VatTu vatTu)
        {
            bool res;
            string[] names = new string[] { "@nhomvt", "@mc" };
            object[] values = new object[] { vatTu.NhomVT, vatTu.MC };
            string query = "INSERT INTO VatTu(NhomVT, MC) VALUES(@nhomvt, @mc)";
            res = _sQLiteProvider.ExecuteNonQuery(query, names, values);
            return res;
        }
    }
}