using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_CUSTOMER
    {
        private static BLL_CUSTOMER _Instance;
        public static BLL_CUSTOMER Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_CUSTOMER();
                }
                return _Instance;
            }
            private set { }
        }
        public tblKhachHang getCUSTOMER_BYID(string ID_CUSTOMER)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblKhachHang GETKHACHHANG = new tblKhachHang();
            foreach (tblKhachHang KHACHHANG in DB.tblKhachHangs)
            {
                if (KHACHHANG.MaKhachHang == ID_CUSTOMER)
                {
                    GETKHACHHANG = KHACHHANG;
                }
            }
            return GETKHACHHANG;
        }
        public string getNEWID_CUSTOMER()
        {
            int ID;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblKhachHang> LIST = DB.tblKhachHangs.ToList();
            if(LIST.Count == 0)
            {
                ID = 1;
            }
            else
            {
                int LAST = Convert.ToInt32(LIST[LIST.Count - 1].MaKhachHang.Remove(0, 2));
                ID = LAST + 1;
            }
            return "KH" + ID;
        }
    }
}
