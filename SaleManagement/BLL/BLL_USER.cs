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
        // id user exist ?
        //public bool isIdExist(string idUser)
        //{
        //    var user = db.tblNguoiDungs.ToList().Where(p => BLL_ACCOUNT.Instance.encryptPassword(p.MaNguoiDung) == BLL_ACCOUNT.Instance.encryptPassword(idUser));
        //    return (user != null) ? true : false; 
        //} 
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
        // get new id user
        public string getNewIdUser(string role)
        {
            List<tblNguoiDung> list = db.tblNguoiDungs.Where(p => p.ChucVu == role).ToList();
            string idUser = "";
            string key = null;
            if (role == "Admin")
            {
                key = "AD";
            }
            else
            {
                key = "NV";
            }
            if (list.Count == 0)
            {
                idUser = key + "0001";
            }
            else
            {
                int lastId = Convert.ToInt32(list[list.Count - 1].MaNguoiDung.Remove(0, 2));
                if (lastId + 1 < 10)
                {
                    idUser = key + "000" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 100)
                {
                    idUser = key + "00" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 1000)
                {
                    idUser = key + "0" + (lastId + 1).ToString();
                }
                else
                {
                    idUser = key + (lastId + 1).ToString();
                }
            }
            return idUser;
        }
    }
}
