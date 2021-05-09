using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_PRODUCER
    {
        private static BLL_PRODUCER _Instance;
        public static BLL_PRODUCER Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_PRODUCER();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_PRODUCER() { }
        public string getNEWID_PRODUCER()
        {
            int ID;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblNhaSanXuat> LIST = DB.tblNhaSanXuats.ToList();
            if (LIST.Count == 0)
            {
                ID = 1;
            }
            else
            {
                int LAST = Convert.ToInt32(LIST[LIST.Count - 1].MaNhaSanXuat.Remove(0, 3));
                ID = LAST + 1;
            }
            return "NSX" + ID;
        }
    }
}
