using DAL;
using Entities;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class DungSaiNCCBUS
    {
        private DungSaiNCCDAL _dungSaiNCCDAL;

        public DungSaiNCCBUS()
        {
            _dungSaiNCCDAL = new DungSaiNCCDAL();
        }

        public List<DungSaiNCC> GetAllDungSai()
        {
            DataTable data = _dungSaiNCCDAL.GetAllDungSai();
            List<DungSaiNCC> dungSaiNCCs = new List<DungSaiNCC>();
            foreach (DataRow item in data.Rows)
            {
                dungSaiNCCs.Add(new DungSaiNCC(item));
            }
            return dungSaiNCCs;
        }

        public int InsertDungSai(string maNCC, string nhomVT, string subQuery)
        {
            DungSaiNCC dungSaiNCC = new DungSaiNCC();
            dungSaiNCC.MaNCC = maNCC;
            dungSaiNCC.NhomVT = nhomVT;
            dungSaiNCC.SubQuery = subQuery;
            return _dungSaiNCCDAL.InsertDungSai(dungSaiNCC);
        }

        public bool UpdateDungSai(int id, string maNCC, string nhomVT, string subQuery)
        {
            DungSaiNCC dungSaiNCC = new DungSaiNCC();
            dungSaiNCC.ID = id;
            dungSaiNCC.MaNCC = maNCC;
            dungSaiNCC.NhomVT = nhomVT;
            dungSaiNCC.SubQuery = subQuery;
            return _dungSaiNCCDAL.UpdateDungSai(dungSaiNCC);
        }

        public bool DeleteDungSai(int id)
        {
            return _dungSaiNCCDAL.DeleteDungSai(id);
        }
    }
}