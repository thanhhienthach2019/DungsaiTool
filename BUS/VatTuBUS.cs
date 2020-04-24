using DAL;
using Entities;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class VatTuBUS
    {
        private VatTuDAL _vatTuDAL;

        public VatTuBUS()
        {
            _vatTuDAL = new VatTuDAL();
        }

        public List<VatTu> GetAllVT()
        {
            List<VatTu> vatTus = new List<VatTu>();
            DataTable data = _vatTuDAL.GetAllVT();
            foreach (DataRow item in data.Rows)
            {
                VatTu vatTu = new VatTu(item);
                vatTus.Add(vatTu);
            }
            return vatTus;
        }
    }
}