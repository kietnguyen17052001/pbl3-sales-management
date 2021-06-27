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
        private SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
        // get user
        public tblTaiKhoan getUser(string username)
        {
            return DB.tblTaiKhoans.Find(username);
        }
        public void FuncAddAccount(tblTaiKhoan account)
        {
            DB.tblTaiKhoans.Add(account);
            DB.SaveChanges();
        }
        public void ChangePasswordStaff(tblTaiKhoan _account)
        {
            var account = DB.tblTaiKhoans.Find(_account.MaNguoiDung);
            account.MatKhau = _account.MatKhau;
            DB.SaveChanges();
        }
        public bool ChangePasswordAdmin(string userNameLogin, string oldPass, string newPass)
        {
            var account = DB.tblTaiKhoans.Find(userNameLogin);
            if (account.MatKhau != oldPass)
            {
                return false;
            }
            else
            {
                account.MatKhau = newPass;
                DB.SaveChanges();
                return true;
            }
        }
    }
}
