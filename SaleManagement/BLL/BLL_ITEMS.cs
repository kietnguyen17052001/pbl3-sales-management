using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_ITEMS
    {
        private static BLL_ITEMS _Instance;
        public static BLL_ITEMS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ITEMS();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ITEMS(){}
        // Lấy danh sách loại hàng hóa đổ vào CBB
        public List<CBBItem> getCBB_TYPEOFITEMS()
        {
            List<CBBItem> LIST = new List<CBBItem>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach(tblLoaiHangHoa LOAIHANGHOA in DB.tblLoaiHangHoas)
            {
                LIST.Add(new CBBItem { VALUE = LOAIHANGHOA.MaLoaiHangHoa, TEXT = LOAIHANGHOA.TenLoaiHangHoa });
            }
            return LIST;
        }
        // Lấy danh sách nhà cung cấp đổ vào CBB
        public List<CBBItem> getCBB_SUPPLIERS()
        {
            List<CBBItem> LIST = new List<CBBItem>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach (tblNhaCungCap NHACUNGCAP in DB.tblNhaCungCaps)
            {
                LIST.Add(new CBBItem { VALUE = NHACUNGCAP.MaNhaCungCap, TEXT = NHACUNGCAP.TenNhaCungCap });
            }
            return LIST;
        }
        // Lấy danh sách nhà sản xuất đổ vào CBB
        public List<CBBItem> getCBB_PRODUCERS()
        {
            List<CBBItem> LIST = new List<CBBItem>();
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach (tblNhaSanXuat NHASANXUAT in DB.tblNhaSanXuats)
            {
                LIST.Add(new CBBItem { VALUE = NHASANXUAT.MaNhaSanXuat, TEXT = NHASANXUAT.TenNhaSanXuat });
            }
            return LIST;
        }
        // Trả về mã hàng hóa mới khi thực hiện chức năng thêm 
        public string getNEWID_ITEM(string ITEM)
        {
            int ID, LAST; // last: kí tự cuối trong mã hàng hóa, vd BG1 -> 1
            string FIRST = ""; // fisrt: 2 kí tự đầu trong mã loại hàng hóa, vd BG0X -> BG 
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<string> LISTSAVEID = new List<string>();
            foreach (tblHangHoa HANGHOA in DB.tblHangHoas)
            {
                if (HANGHOA.MaLoaiHangHoa == ITEM)
                {
                    LISTSAVEID.Add(HANGHOA.MaHangHoa);
                }
            }
            if (LISTSAVEID.Count == 0)
            {
                ID = 1;
            }
            else
            {
                LAST = Convert.ToInt32(LISTSAVEID[LISTSAVEID.Count -1 ].Substring(LISTSAVEID[LISTSAVEID.Count - 1].Length - 1)); // số cuối trong mã hàng hóa
                FIRST = LISTSAVEID[LISTSAVEID.Count - 1].Remove(LISTSAVEID[LISTSAVEID.Count - 1].LastIndexOf(LAST.ToString()), 1);
                ID = LAST + 1;
            }
            return FIRST + ID;
        }
        // Trả về loại hàng hóa, nhà cung cấp, nhà sản xuất từ dgvITEMS
        public string getTEXT(string NAME, List<CBBItem> LIST)
        {
            string TYPE_OF_ITEM = "";
            foreach(CBBItem item in LIST)
            {
                if(item.TEXT == NAME)
                {
                    TYPE_OF_ITEM = item.ToString();
                }
            }
            return TYPE_OF_ITEM;
        }
    }
}
