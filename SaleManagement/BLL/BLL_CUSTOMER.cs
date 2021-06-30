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
        private N3KTeamEntities db = new N3KTeamEntities();
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
        public List<CBBItem> getCbbCustomer()
        {
            List<CBBItem> cbbCustomer = new List<CBBItem>();
            foreach(tblKhachHang customer in db.tblKhachHangs)
            {
                cbbCustomer.Add(new CBBItem { VALUE = customer.MaKhachHang, TEXT = customer.TenKhachHang });
            }
            return cbbCustomer;
        }
        public tblKhachHang getCustomer_ById(string idCustomer)
        {
            return db.tblKhachHangs.Find(idCustomer);
        }
        // load data customer 
        public void LoadData(DataGridView dgv)
        {
            var customer = db.tblKhachHangs.Select(p => new
            {
                p.MaKhachHang,
                p.TenKhachHang,
                p.GioiTinh,
                p.SoDienThoai,
                p.DiaChi
            });
            dgv.DataSource = customer.ToList();
        }
        // add new customer
        public void FuncAddNewCustomer(tblKhachHang customer)
        {
            db.tblKhachHangs.Add(customer);
            db.SaveChanges();
        }
        // edit customer
        public void FuncEditCustomer(tblKhachHang _customer)
        {
            var customer = db.tblKhachHangs.Find(_customer.MaKhachHang);
            customer.TenKhachHang = _customer.TenKhachHang;
            customer.GioiTinh = _customer.GioiTinh;
            customer.SoDienThoai = _customer.SoDienThoai;
            customer.DiaChi = _customer.DiaChi;
            db.SaveChanges();
        }
        // remove customer
        public void FuncDeleteCustomer(List<string> listIdCustomer)
        {
            var customer = new tblKhachHang();
            foreach (string idCustomer in listIdCustomer)
            {
                customer = db.tblKhachHangs.Find(idCustomer);
                db.tblKhachHangs.Remove(customer);
                db.SaveChanges();
            }
        }
        // search customer
        public void FuncSearchCustomer(DataGridView dgv, string information)
        {
            if(information == "Nhập mã hoặc tên khách hàng" || String.IsNullOrEmpty(information))
            {
                LoadData(dgv);
            }
            else
            {
                var getCustomer = db.tblKhachHangs.Where(p => p.TenKhachHang.Contains(information) || p.MaKhachHang.Contains(information)).Select(p => new
                {
                    p.MaKhachHang,
                    p.TenKhachHang,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi
                });
                dgv.DataSource = getCustomer.ToList();
            }
        }
        // get quantity customer
        public int getQuantityCustomer(DataGridView dgv)
        {
            return dgv.Rows.Count;
        }
        // tạo mã khách hàng mới
        public string getNewIdCustomer()
        {
            string idCustomer = "";
            int lastId;
            List<tblKhachHang> list = db.tblKhachHangs.ToList();
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
