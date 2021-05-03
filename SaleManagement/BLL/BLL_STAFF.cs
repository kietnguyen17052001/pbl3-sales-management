using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_STAFF
    {
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
        public List<string> getList_Position()
        {
            List<string> LIST = new List<string>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach (tblNhanVien NHANVIEN in DB.tblNhanViens)
            {
                LIST.Add(NHANVIEN.ViTri);
            }
            return LIST;
        }
        // Trả về mã số khách hàng mới khi thực hiện chức năng thêm
        public string getNEWID_STAFF()
        {
            int ID; // số cuối trong mã khách hàng
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblNhanVien> LIST = DB.tblNhanViens.ToList();
            if (LIST.Count == 0)
            {
                ID = 1;
            }
            else
            {
                // Nếu đã có khách hàng trong danh sách,
                // LAST: Trả về số cuối của mã khách hàng, vd: KH1 -> 1
                int LAST = Convert.ToInt32(LIST[LIST.Count - 1].MaNhanVien.Remove(0, 2));
                ID = LAST + 1;
            }
            return "NV" + ID;
        }
    }
}
