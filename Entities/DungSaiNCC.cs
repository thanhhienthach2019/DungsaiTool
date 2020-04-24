using System.Data;

namespace Entities
{
    public class DungSaiNCC
    {
        public DungSaiNCC()
        {
        }

        public DungSaiNCC(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.MaNCC = row["MaNCC"].ToString();
            this.NhomVT = row["NhomVT"].ToString();
            this.SubQuery = row["SubQuery"].ToString();
        }

        public int ID { get; set; }
        public string MaNCC { get; set; }
        public string NhomVT { get; set; }
        public string SubQuery { get; set; }
    }
}