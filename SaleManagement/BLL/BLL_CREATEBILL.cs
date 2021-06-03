using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_CREATEBILL
    {
        
        private static BLL_CREATEBILL _Instance;
        public static BLL_CREATEBILL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_CREATEBILL();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_CREATEBILL() { }
        // Thiết lập danh sách nhân viên thu ngân vào trong CBB_STAFF
        public List<CBBItem> getCBB_STAFF()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<CBBItem> LIST = new List<CBBItem>();
            foreach(tblNhanVien NHANVIEN in DB.tblNhanViens.ToList())
            {
                if(NHANVIEN.ViTri == "Thu ngân")
                {
                    LIST.Add(new CBBItem { VALUE = NHANVIEN.MaNhanVien, TEXT = NHANVIEN.TenNhanVien });
                }
            }
            return LIST;
        }
        // Thiết lập danh sách khách hàng vào trong CBB_CUSTOMER
        public List<CBBItem> getCBB_CUSTOMER()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<CBBItem> LIST = new List<CBBItem>();
            foreach (tblKhachHang KHACHHANG in DB.tblKhachHangs.ToList())
            {
                LIST.Add(new CBBItem { VALUE = KHACHHANG.MaKhachHang, TEXT = KHACHHANG.TenKhachHang });
            }
            return LIST;
        }
        // Tạo tbl Hóa đơn
        public DataTable getTblORDER()
        {
            DataTable DATA = new DataTable();
            DATA.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaHangHoa", typeof(string)),
                new DataColumn("TenHangHoa",typeof(string)),
                new DataColumn("SoLuong",typeof(int)),
                new DataColumn("DonGia(VNĐ)",typeof(string)),
                new DataColumn("KhuyenMai(%)",typeof(double)),
                new DataColumn("ThanhTien(VNĐ)",typeof(string))
            });
            return DATA;
        }
         // Thêm hàng hóa vào hóa đơn
        public void addITEMs(DataTable DATA, params object[] obj)
        {
            int AMOUNT;
            double MONEY_AFTERADD;
            bool CHECK = true; // kiểm tra hàng hóa đã có trong hóa đơn hay chưa. Nếu có rồi thì update số lượng, nếu chưa thì add new
            foreach (DataRow i in DATA.Rows)
            {
                MONEY_AFTERADD = Convert.ToDouble(i["ThanhTien(VNĐ)"].ToString());
                AMOUNT = Convert.ToInt32(i["SoLuong"].ToString());
                if (i["MaHangHoa"].ToString() == obj[0].ToString()) 
                {
                    CHECK = false; // hàng hóa đã có
                    AMOUNT += Convert.ToInt32(obj[2].ToString());
                    MONEY_AFTERADD += Convert.ToDouble(obj[5].ToString()); 
                    i["SoLuong"] = AMOUNT.ToString(); // thay đổi số lượng khi thêm hàng vào
                    i["ThanhTien(VNĐ)"] = String.Format("{0:n0}",MONEY_AFTERADD); // chuyển định dạng số tiền, vd: 2000 -> 2.000
                }
            }
            if (CHECK) // hàng hóa chưa có
            {
                DATA.Rows.Add(new object[] { obj[0], obj[1], obj[2], String.Format("{0:n0}", obj[3]), obj[4], String.Format("{0:n0}", obj[5]) });
            }
        }
        // Xóa hàng hóa khỏi hóa đơn
        public void delITEMS(List<string> LIST, DataTable DATA)
        {
            try
            {
                foreach (string i in LIST)
                {
                    foreach (DataRow j in DATA.Rows)
                    {
                        if (j["MaHangHoa"].ToString() == i)
                        {
                            DATA.Rows.Remove(j);
                        }
                    }
                    DATA.AcceptChanges();
                }
            }
            catch (Exception)
            {

            }
        }
        // Tổng số tiền của hóa đơn
        public double getTotalMoney(DataTable DATA)
        {
            double TOTAL_MONEY = 0;
            foreach(DataRow data in DATA.Rows)
            {
                TOTAL_MONEY += Convert.ToDouble(data["ThanhTien(VNĐ)"].ToString());
            }
            return TOTAL_MONEY;
        }
        // Tổng thanh toán của hóa đơn
        public double getPriceBill(DataTable DATA, double DISCOUNT)
        {
            if (DISCOUNT == 0)
            {
                return getTotalMoney(DATA);
            }
            else
            {
                return getTotalMoney(DATA) - DISCOUNT;
            }
        }
        // Tổng số lượng của tất cả hàng hóa
        public int getAllAmount(DataTable DATA)
        {
            int AMOUNT = 0;
            foreach (DataRow data in DATA.Rows)
            {
                AMOUNT += Convert.ToInt32(data["SoLuong"].ToString());
            }
            return AMOUNT;
        }
        // Số lượng hàng hóa (nếu cùng tên thì tính là 1)
        public int getAllItems(DataTable DATA)
        {
            int COUNT = 0;
            foreach (DataRow data in DATA.Rows)
            {
                COUNT++;
            }
            return COUNT;
        }
        // Trả về mã hóa đơn mới
        public string getNEWID_BILL()
        {
            int ID;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblHoaDonBanHang> LIST = DB.tblHoaDonBanHangs.ToList();
            if (LIST.Count == 0)
            {
                ID = 1;
            }
            else
            {
                int LAST = Convert.ToInt32(LIST[LIST.Count - 1].MaHoaDonBan.Remove(0, 2));
                ID = LAST + 1;
            }
            return "HD" + ID;
        }
    }
}
