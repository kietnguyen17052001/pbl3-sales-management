using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
        // Encrypt password
        public string encryptPassword(string password)
        {
            string encrypt = "";
            // convert string to byte
            byte[] myPassword = ASCIIEncoding.ASCII.GetBytes(password);
            // encrypt
            byte[] hashPass = new MD5CryptoServiceProvider().ComputeHash(myPassword);
            foreach (byte _byte in hashPass)
            {
                encrypt += _byte.ToString();
            }
            return encrypt;
        }
        // Check login
        public bool checkAccount(string username, string password)
        {
            var user = db.tblNguoiDungs.ToList().Where(p => encryptPassword(p.MaNguoiDung) == encryptPassword(username)
            && p.MatKhau == encryptPassword(password)).SingleOrDefault();
            return (user != null) ? true : false;
        }
        // Check user
        public bool isAdmin(string username)
        {
            var user = db.tblNguoiDungs.ToList().Where(p => encryptPassword(p.MaNguoiDung) == encryptPassword(username)).SingleOrDefault();
            return (user.ChucVu == "Admin") ? true : false;
        }
        // Check username
        public bool checkUsername(string username)
        {
            var user = db.tblNguoiDungs.ToList().Where(p => encryptPassword(p.MaNguoiDung) == encryptPassword(username)).SingleOrDefault();
            return (user != null) ? true : false;
        }
        // Check email and phone
        public bool checkEmailAndPhone(string username, string email, string phone)
        {
            var user = db.tblNguoiDungs.Where(p => p.MaNguoiDung == username
            && p.Email == email && p.SoDienThoai == phone).SingleOrDefault();
            return (user != null) ? true : false;
        }
        // new password
        public void newPassword(string username, string newPassword)
        {
            var user = db.tblNguoiDungs.Find(username);
            user.MatKhau = encryptPassword(newPassword);
            db.SaveChanges();
        }
        // is valid old password ?
        public bool isValidOldPassword(string userName, string oldPassword)
        {
            var user = db.tblNguoiDungs.Find(userName);
            return (user.MatKhau == encryptPassword(oldPassword)) ? true : false;
        }
    }
}
