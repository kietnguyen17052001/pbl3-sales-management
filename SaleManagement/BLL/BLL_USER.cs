using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_USER
    {
        private N3KTeamEntities db = new N3KTeamEntities();
        private static BLL_USER _Instance;
        public static BLL_USER Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_USER();
                }
                return _Instance;
            }
            private set { }
        }
        // List role
        public List<string> listRole()
        {
            List<string> list = new List<string>();
            list.AddRange(new string[] { "Admin", "Member" });
            return list;
        }
        // cbb staff
        public List<CBBItem> listStaff()
        {
            List<CBBItem> list = new List<CBBItem>();
            foreach(tblNguoiDung user in db.tblNguoiDungs.Where(p => p.ChucVu == "Member").ToList())
            {
                list.Add(new CBBItem { VALUE = user.MaNguoiDung, TEXT = user.TenNguoiDung });
            }
            return list;
        }
        // get staff by idStaff
        public string getStaffById(string idStaff)
        {
            string staff = null;
            foreach(CBBItem item in listStaff())
            {
                if(item.VALUE == idStaff)
                {
                    staff = item.ToString();
                }
            }
            return staff;
        }
        // Kiểm tra mã nguời dùng đã tồn tại hay chưa
        public bool isIdExist(string idUser)
        {
            var user = db.tblNguoiDungs.Find(idUser);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // load data User
        public void LoadDataUser(DataGridView dgv)
        {
            var getUser = db.tblNguoiDungs.Select(p => new
            {
                p.MaNguoiDung,
                p.TenNguoiDung,
                p.ChucVu,
                p.NgaySinh,
                p.GioiTinh,
                p.Email,
                p.SoDienThoai,
                p.DiaChi,
                p.Luong,
            });
            dgv.DataSource = getUser.ToList();
        }
        // add new User
        public void FuncAddNewUser(tblNguoiDung User)
        {
            db.tblNguoiDungs.Add(User);
            db.SaveChanges();
        }
        // edit User
        public void FuncEditUser(tblNguoiDung user)
        {
            var getUser = db.tblNguoiDungs.Find(user.MaNguoiDung);
            getUser.TenNguoiDung = user.TenNguoiDung;
            getUser.ChucVu = user.ChucVu;
            getUser.NgaySinh = user.NgaySinh;
            getUser.GioiTinh = user.GioiTinh;
            getUser.Email = user.Email;
            getUser.SoDienThoai = user.SoDienThoai;
            getUser.DiaChi = user.DiaChi;
            getUser.Luong = user.Luong;
            db.SaveChanges();
        }
        // remove User
        public void FuncDeleteUser(List<string> listIdUser)
        {
            var user = new tblNguoiDung();
            foreach (string idUser in listIdUser)
            {
                user = db.tblNguoiDungs.Find(idUser);
                db.tblNguoiDungs.Remove(user);
                db.SaveChanges();
            }
        }
        // search User
        public void FuncSearchUser(DataGridView dgv, string information)
        {
            if (information == "Nhập mã hoặc tên" || String.IsNullOrEmpty(information))
            {
                LoadDataUser(dgv);
            }
            else
            {
                var getUser = db.tblNguoiDungs.Where(p => p.TenNguoiDung.Contains(information) || p.TenNguoiDung.Contains(information)).Select(p => new
                {
                    p.MaNguoiDung,
                    p.TenNguoiDung,
                    p.ChucVu,
                    p.NgaySinh,
                    p.GioiTinh,
                    p.Email,
                    p.SoDienThoai,
                    p.DiaChi,
                    p.Luong,
                });
                dgv.DataSource = getUser.ToList();
            }
        }
        // get quantity User
        public int getQuantityUser(DataGridView dgv)
        {
            return dgv.Rows.Count;
        }
        // Trả về mã số khách hàng mới khi thực hiện chức năng thêm
        public string getNewIdUser()
        {
            string idUser = "";
            List<tblNguoiDung> list = db.tblNguoiDungs.Where(p => p.ChucVu == "Member").ToList();
            if (list.Count == 0)
            {
                idUser = "NV0001";
            }
            else
            {
                // Nếu đã có khách hàng trong danh sách,
                // LAST: Trả về số cuối của mã khách hàng, vd: KH1 -> 1
                int lastId = Convert.ToInt32(list[list.Count - 1].MaNguoiDung.Remove(0, 2));
                if (lastId + 1 < 10)
                {
                    idUser = "NV000" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 100)
                {
                    idUser = "NV00" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 1000)
                {
                    idUser = "NV0" + (lastId + 1).ToString();
                }
                else
                {
                    idUser = "NV" + (lastId + 1).ToString();
                }
            }
            return idUser;
        }
    }
}
