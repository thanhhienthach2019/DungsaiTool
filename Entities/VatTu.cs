using System.Data;

namespace Entities
{
    public class VatTu
    {
        public VatTu()
        {
        }

        public VatTu(DataRow row)
        {
            this.NhomVT = row["NhomVT"].ToString();
            this.MC = row["MC"].ToString();
        }

        public string NhomVT { get; set; }
        public string MC { get; set; }
    }
}