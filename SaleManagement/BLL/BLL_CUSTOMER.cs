using SaleManagement.Entity;
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
        public tblKhachHang GetCustomer_ById(string idCustomer)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblKhachHang getCustomer = new tblKhachHang();
            foreach (tblKhachHang customer in DB.tblKhachHangs)
            {
                if (customer.MaKhachHang == idCustomer)
                {
                    getCustomer = customer;
                }
            }
            return getCustomer;
        }
        public string GetNewIdCustomer()
        {
            int id;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblKhachHang> list = DB.tblKhachHangs.ToList();
            if(list.Count == 0)
            {
                id = 1;
            }
            else
            {
                int lastId = Convert.ToInt32(list[list.Count - 1].MaKhachHang.Remove(0, 2));
                id = lastId + 1;
            }
            return "KH" + id;
        }
    }
}
