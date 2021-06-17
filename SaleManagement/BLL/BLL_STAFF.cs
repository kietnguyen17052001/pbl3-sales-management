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
        private SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
        // Set combobox staff
        public List<CBBItem> getCbbStaff()
        {
            List<CBBItem> listCbbStaff = new List<CBBItem>();
            foreach (tblNhanVien staff in DB.tblNhanViens)
            {
                listCbbStaff.Add(new CBBItem { VALUE = staff.MaNhanVien, TEXT = staff.TenNhanVien });
            }
            return listCbbStaff;
        }
        // Get item by idStaff
        public string getStaffById(string idStaff)
        {
            string staff = null;
            foreach(CBBItem item in getCbbStaff())
            {
                if(idStaff == item.VALUE)
                {
                    staff = item.ToString();
                    break;
                }
            }
            return staff;
        }
        // Lấy danh sách các vị trí nhân viên từ DB
        public List<string> getListPosition()
        {
            string[] arrayPosition = {"Thu ngân", "Bán hàng", "Kho"};
            List<string> listPosition = new List<string>();
            foreach(string position in arrayPosition)
            {
                listPosition.Add(position);
            }
            return listPosition;
        }
        // load data staff
        public void LoadDataStaff(DataGridView dgv, int index, string position)
        {
            if (index == 0)
            {
                var getStaff = DB.tblNhanViens.Select(p => new {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong,
                    p.MatKhau
                });
                dgv.DataSource = getStaff.ToList();
            }
            else
            {
                var getStaff = DB.tblNhanViens.Where(p => p.ViTri == position).Select(p => new {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong,
                    p.MatKhau
                });
                dgv.DataSource = getStaff.ToList();
            }
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
            getStaff.MatKhau = staff.MatKhau;
            DB.SaveChanges();
        }
        // remove staff
        public void FuncDeleteStaff(List<string> listIdStaff)
        {
            foreach (string idStaff in listIdStaff)
            {
                foreach (tblNhanVien staff in DB.tblNhanViens)
                {
                    if (staff.MaNhanVien == idStaff)
                    {
                        DB.tblNhanViens.Remove(staff);
                        break;
                    }
                }
                DB.SaveChanges();
            }
        }
        // search staff
        public void FuncSearchStaff(DataGridView dgv, string information)
        {
            if (information == "Nhập mã hoặc tên nhân viên" || String.IsNullOrEmpty(information))
            {
                LoadDataStaff(dgv,0,null);
            }
            else
            {
                var getStaff = DB.tblNhanViens.Where(p => p.TenNhanVien.Contains(information) || p.MaNhanVien.Contains(information)).Select(p => new
                {
                    p.MaNhanVien,
                    p.TenNhanVien,
                    p.ViTri,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong,
                    p.MatKhau
                });
                dgv.DataSource = getStaff.ToList();
            }
        }
        // get quantity staff
        public int getQuantityStaff(DataGridView dgv)
        {
            return dgv.Rows.Count;
        }
        // Trả về mã số khách hàng mới khi thực hiện chức năng thêm
        public string getNewIdStaff()
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
