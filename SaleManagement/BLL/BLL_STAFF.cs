using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_STAFF
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_STAFF _Instance;
        public static BLL_STAFF Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_STAFF();
                }
                return _Instance;
            }
            private set { }
        }
        // Lấy danh sách các vị trí nhân viên từ DB
        public List<string> GetListPosition()
        {
            List<string> list = new List<string>();
            foreach (tblNhanVien staff in DB.tblNhanViens)
            {
                list.Add(staff.ViTri);
            }
            return list;
        }
        // add new staff
        public void FuncAddNewStaff(tblNhanVien staff)
        {
            DB.tblNhanViens.Add(staff);
            DB.SaveChanges();
        }
        // edit staff
        public void FuncEditStaff(tblNhanVien staff)
        {
            var getStaff = DB.tblNhanViens.Find(staff.MaNhanVien);
            getStaff.TenNhanVien = staff.TenNhanVien;
            getStaff.ViTri = staff.ViTri;
            getStaff.NgaySinh = staff.NgaySinh;
            getStaff.GioiTinh = staff.GioiTinh;
            getStaff.SoDienThoai = staff.SoDienThoai;
            getStaff.DiaChi = staff.DiaChi;
            getStaff.Luong = staff.Luong;
            DB.SaveChanges();
        }
        // remove staff
        public void FuncDeleteStaff(List<string> listIdStaff)
        {
            foreach (string i in listIdStaff)
            {
                foreach (tblNhanVien staff in DB.tblNhanViens)
                {
                    if (staff.MaNhanVien == i)
                    {
                        DB.tblNhanViens.Remove(staff);
                        break;
                    }
                }
                DB.SaveChanges();
            }
        }
        // search name
        public void FuncSearchName(DataGridView dgv, string name)
        {
            var getStaff = DB.tblNhanViens.Where(p => p.TenNhanVien.Contains(name)).Select(p => new
            {
                p.MaNhanVien,
                p.TenNhanVien,
                p.ViTri,
                p.NgaySinh,
                p.GioiTinh,
                p.SoDienThoai,
                p.DiaChi,
                p.Luong
            });
            dgv.DataSource = getStaff.ToList();
        }
        // search id
        public void FuncSearchID(DataGridView dgv, string id)
        {
            var getStaff = DB.tblNhanViens.Where(p => p.MaNhanVien.Contains(id)).Select(p => new
            {
                p.MaNhanVien,
                p.TenNhanVien,
                p.ViTri,
                p.NgaySinh,
                p.GioiTinh,
                p.SoDienThoai,
                p.DiaChi,
                p.Luong
            });
            dgv.DataSource = getStaff.ToList();
        }
        // Trả về mã số khách hàng mới khi thực hiện chức năng thêm
        public string GetNewIdStaff()
        {
            string idStaff = "";
            List<tblNhanVien> list = DB.tblNhanViens.ToList();
            if (list.Count == 0)
            {
                idStaff = "NV0001";
            }
            else
            {
                // Nếu đã có khách hàng trong danh sách,
                // LAST: Trả về số cuối của mã khách hàng, vd: KH1 -> 1
                int lastId = Convert.ToInt32(list[list.Count - 1].MaNhanVien.Remove(0, 2));
                if (lastId + 1 < 10)
                {
                    idStaff = "NV000" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 100)
                {
                    idStaff = "NV00" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 1000)
                {
                    idStaff = "NV0" + (lastId + 1).ToString();
                }
            }
            return idStaff;
        }
    }
}
