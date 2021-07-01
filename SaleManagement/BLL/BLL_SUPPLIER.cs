using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_SUPPLIER
    {
        private N3KTeamEntities db = new N3KTeamEntities();
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
        // get combobox supplier
        public List<CBBItem> ListSupplier()
        {
            List<CBBItem> ListCbb = new List<CBBItem>();
            foreach(tblNhaCungCap supplier in db.tblNhaCungCaps)
            {
                ListCbb.Add(new CBBItem { VALUE = supplier.MaNhaCungCap, TEXT = supplier.TenNhaCungCap });
            }
            return ListCbb;
        }
        // load data form database
        public void ShowData(DataGridView dgv)
        {
            var getListSupplier = db.tblNhaCungCaps.Select(p => new
            {
                p.MaNhaCungCap,
                p.TenNhaCungCap,
                p.DiaChi,
                p.Email,
                p.Fax,
                p.SoDienThoai,
                p.MaSoThue
            });
            dgv.DataSource = getListSupplier.ToList();
        }
        // add new supplier
        public void FuncAddNewSupplier(tblNhaCungCap supplier)
        {
            db.tblNhaCungCaps.Add(supplier);
            db.SaveChanges();
        }
        // edit supplier
        public void FuncEditSupplier(tblNhaCungCap supplier)
        {
            var getSupplier = db.tblNhaCungCaps.Find(supplier.MaNhaCungCap);
            getSupplier.TenNhaCungCap = supplier.TenNhaCungCap;
            getSupplier.DiaChi = supplier.DiaChi;
            getSupplier.Email = supplier.Email;
            getSupplier.Fax = supplier.Fax;
            getSupplier.SoDienThoai = supplier.SoDienThoai;
            getSupplier.MaSoThue = supplier.MaSoThue;
            db.SaveChanges();
        }
        // delete supplier
        public void FuncDeleteSupplier(List<string> listID)
        {
            var supplier = new tblNhaCungCap();
            foreach(string idSupplier in listID)
            {
                supplier = db.tblNhaCungCaps.Find(idSupplier);
                db.tblNhaCungCaps.Remove(supplier);
                db.SaveChanges();
            }
        }
        // search supplier
        public void FuncSearchSupplier(DataGridView dgv, string information)
        {
            if(information == "Nhập tên hoặc mã nhà cung cấp" || string.IsNullOrEmpty(information))
            {
                ShowData(dgv);
            }
            else
            {
                var getSupplier = db.tblNhaCungCaps.Where(p => p.MaNhaCungCap.Contains(information) || p.TenNhaCungCap.Contains(information)).Select(p => new
                {
                    p.MaNhaCungCap,
                    p.TenNhaCungCap,
                    p.DiaChi,
                    p.Email,
                    p.Fax,
                    p.SoDienThoai,
                    p.MaSoThue
                });
                dgv.DataSource = getSupplier.ToList();
            }
        }
        // get quantity supplier
        public int getQuantitySupplier(DataGridView dgv)
        {
            return dgv.Rows.Count;
        }
        // get new id supplier
        public string getNewIdSupplier()
        {
            string idSupplier;
            List<tblNhaCungCap> list = db.tblNhaCungCaps.ToList();
            if (list.Count == 0)
            {
                idSupplier = "NCC001";
            }
            else
            {
                int last = Convert.ToInt32(list[list.Count - 1].MaNhaCungCap.Remove(0, 3));
                if (last + 1 < 10)
                {
                    idSupplier = "NCC00" + (last + 1);
                }
                else if (last + 1 < 100)
                {
                    idSupplier = "NCC0" + (last + 1);
                }
                else
                {
                    idSupplier = "NCC" + (last + 1);
                }
            }
            return idSupplier;
        }
    }
}
