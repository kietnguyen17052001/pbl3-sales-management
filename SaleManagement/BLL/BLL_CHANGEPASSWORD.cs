using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_CHANGEPASSWORD
    {
        private BLL_CHANGEPASSWORD() { }
        private static BLL_CHANGEPASSWORD _Instance;
        public static BLL_CHANGEPASSWORD Instance 
        { 
            get
            {
                if(_Instance == null)
                {
                    _Instance = new BLL_CHANGEPASSWORD();
                }
                return _Instance;
            }
            private set { }  
        }
        public bool ChangePassword(string name, string oldPass, string newPass)
        {
            SALEMANAGEMENT_DB db = new SALEMANAGEMENT_DB();
            var user = db.tblTaiKhoans.Find(name);
            if(user.MatKhau != oldPass)
            {
                MessageBox.Show("Mật khẩu cũ không trùng khớp");
                return false;
            }
            else
            {
                user.MatKhau = newPass;
                db.SaveChanges();
                MessageBox.Show("Đổi mật khẩu thành công");
                return true;
            }
        }
    }
}
