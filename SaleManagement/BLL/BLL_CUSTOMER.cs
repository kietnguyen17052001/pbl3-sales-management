using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_CUSTOMER
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
        private BLL_CUSTOMER() { }
        public tblKhachHang GetCustomer_ById(string idCustomer)
        {
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
        // add new customer
        public void FuncAddNewCustomer(tblKhachHang customer)
        {
            DB.tblKhachHangs.Add(customer);
            DB.SaveChanges();
        }
        // edit customer
        public void FuncEditCustomer(tblKhachHang customer)
        {
            var query = DB.tblKhachHangs.Find(customer.MaKhachHang);
            query.TenKhachHang = customer.TenKhachHang;
            query.GioiTinh = customer.GioiTinh;
            query.SoDienThoai = customer.SoDienThoai;
            query.DiaChi = customer.DiaChi;
            DB.SaveChanges();
        }
        // remove customer
        public void FuncDeleteCustomer(List<string> listIdCustomer)
        {
            foreach (string i in listIdCustomer)
            {
                foreach (tblKhachHang customer in DB.tblKhachHangs)
                {
                    if (customer.MaKhachHang == i)
                    {
                        DB.tblKhachHangs.Remove(customer);
                        break;
                    }
                }
                DB.SaveChanges();
            }
        }
        // search name
        public void FuncSearchName(DataGridView dgv, string name)
        {
            var getCustomer = DB.tblKhachHangs.Where(p => p.TenKhachHang.Contains(name)).Select(p => new
            {
                p.MaKhachHang,
                p.TenKhachHang,
                p.GioiTinh,
                p.SoDienThoai,
                p.DiaChi
            });
            dgv.DataSource = getCustomer.ToList();
        }
        // search id
        public void FuncSearchID(DataGridView dgv, string id)
        {
            var getCustomer = DB.tblKhachHangs.Where(p => p.MaKhachHang.Contains(id)).Select(p => new
            {
                p.MaKhachHang,
                p.TenKhachHang,
                p.GioiTinh,
                p.SoDienThoai,
                p.DiaChi
            });
            dgv.DataSource = getCustomer.ToList();
        }
        // tạo mã khách hàng mới
        public string GetNewIdCustomer()
        {
            string idCustomer = "";
            int lastId;
            List<tblKhachHang> list = DB.tblKhachHangs.ToList();
            if(list.Count == 0)
            {
                idCustomer = "KH0001";
            }
            else
            {
                lastId = Convert.ToInt32(list[list.Count - 1].MaKhachHang.Remove(0, 2));
                if (lastId + 1 < 10)
                {
                    idCustomer = "KH000" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 100)
                {
                    idCustomer = "KH00" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 1000)
                {
                    idCustomer = "KH0" + (lastId + 1).ToString();
                }
            }
            return idCustomer;
        }
    }
}
