using Entities;
using Services;
using System.Data;

namespace DAL
{
    public class DungSaiNCCDAL
    {
        private Provider _provider;

        public DungSaiNCCDAL()
        {
            _provider = new Provider();
        }

        public DataTable GetAllDungSai()
        {
            return _provider.ExecuteQuery("Proc_GetAllDungSai");
        }

        public int InsertDungSai(DungSaiNCC dungSaiNCC)
        {
            string[] names = new string[] { "@mancc", "@nhomvt", "@subquery" };
            object[] values = new object[] { dungSaiNCC.MaNCC, dungSaiNCC.NhomVT, dungSaiNCC.SubQuery };
            string[] namesOut = new string[] { "@id" };
            object[] valuesOut = new object[] { SqlDbType.Int };
            _provider.ExecuteNonQuery("Proc_InsertDungSai", names, values, namesOut, ref valuesOut);
            return !string.IsNullOrEmpty(valuesOut[0].ToString()) ? (int)valuesOut[0] : 0;
        }

        public bool UpdateDungSai(DungSaiNCC dungSaiNCC)
        {
            string[] names = new string[] { "@id", "@mancc", "@nhomvt", "@subquery" };
            object[] values = new object[] { dungSaiNCC.ID, dungSaiNCC.MaNCC, dungSaiNCC.NhomVT, dungSaiNCC.SubQuery };
            return _provider.ExecuteNonQuery("Proc_UpdateDungSai", names, values);
        }

        public bool DeleteDungSai(int id)
        {
            string[] names = new string[] { "@id" };
            object[] values = new object[] { id };
            return _provider.ExecuteNonQuery("Proc_DeleteDungSai", names, values);
        }
    }
}