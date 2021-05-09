using SaleManagement.Entity;
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
        public List<string> GetListPosition()
        {
            List<string> list = new List<string>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach (tblNhanVien staff in DB.tblNhanViens)
            {
                list.Add(staff.ViTri);
            }
            return list;
        }
        // Trả về mã số khách hàng mới khi thực hiện chức năng thêm
        public string GetNewIdStaff()
        {
            int id; // số cuối trong mã khách hàng
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblNhanVien> list = DB.tblNhanViens.ToList();
            if (list.Count == 0)
            {
                id = 1;
            }
            else
            {
                // Nếu đã có khách hàng trong danh sách,
                // LAST: Trả về số cuối của mã khách hàng, vd: KH1 -> 1
                int lastId = Convert.ToInt32(list[list.Count - 1].MaNhanVien.Remove(0, 2));
                id = lastId + 1;
            }
            return "NV" + id;
        }
    }
}
