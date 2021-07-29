using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_ACCOUNT
    {
        private N3KTeamEntities db = new N3KTeamEntities();
        private static BLL_ACCOUNT _Instance;
        public static BLL_ACCOUNT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ACCOUNT();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ACCOUNT() { }
        // Check login
        public bool isLoginSuccessful(string username, string password)
        {
            var user = db.tblTaiKhoans.Find(username);
            if(user == null || user.MatKhau != password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Check user
        public bool isAdmin(string username)
        {
            var user = db.tblTaiKhoans.Find(username);
            if(user.ChucVu == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void FuncAddAccount(tblTaiKhoan account)
        {
            db.tblTaiKhoans.Add(account);
            db.SaveChanges();
        }
        // Thay đổi password nhân viên trong frmNhanVien
        public void ChangePasswordStaff(tblTaiKhoan _account)
        {
            var account = db.tblTaiKhoans.Find(_account.MaNguoiDung);
            account.MatKhau = _account.MatKhau;
            db.SaveChanges();
        }
        public bool ChangePasswordUser(bool isAdmin, string userNameLogin, string oldPass, string newPass)
        {
            var account = db.tblTaiKhoans.Find(userNameLogin);
            if (account.MatKhau != oldPass)
            {
                return false;
            }
            else
            {
                if (!isAdmin) // thay đổi password của nhân viên trong tblNhanVien
                {
                    var staff = db.tblNhanViens.Find(userNameLogin);
                    staff.MatKhau = newPass;
                }
                account.MatKhau = newPass; // thay đổi password của người dùng trong tblTaiKhoan
                db.SaveChanges();
                return true;
            }
        }
    }
}
