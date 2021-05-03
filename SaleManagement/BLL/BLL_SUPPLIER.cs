using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_SUPPLIER
    {
        private static BLL_SUPPLIER _Instance;
        public static BLL_SUPPLIER Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SUPPLIER();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_SUPPLIER() { }
        public string getNEWID_SUPPLIER()
        {
            int ID;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblNhaCungCap> LIST = DB.tblNhaCungCaps.ToList();
            if ( LIST.Count == 0)
            {
                ID = 1;
            }
            else
            {
                int LAST = Convert.ToInt32(LIST[LIST.Count - 1].MaNhaCungCap.Remove(0, 3));
                ID = LAST + 1;
            }
            return "NCC" + ID;
        }
    }
}
