using Services;
using System.Data;

namespace DAL
{
    public class VatTuDAL
    {
        private Provider _provider;

        public VatTuDAL()
        {
            _provider = new Provider();
        }

        public DataTable GetAllVT()
        {
            return _provider.ExecuteQuery("Proc_GetALLVT");
        }
    }
}