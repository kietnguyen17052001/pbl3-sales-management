using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleManagement.BLL
{
    class BLL_CREATEINVOICE
    {
        private static BLL_CREATEINVOICE _Instance;
        public static BLL_CREATEINVOICE Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_CREATEINVOICE();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_CREATEINVOICE() { }
        public tblChiTietHoaDonBanHang GetInvoice_Detail(DataRow data, string idInvoice)
        {
            return new tblChiTietHoaDonBanHang {
                MaHoaDonBan = idInvoice,
                MaHangHoa = data["MaHangHoa"].ToString(),
                SoLuong = Convert.ToInt32(data["SoLuong"].ToString()),
                DonGia = Convert.ToDouble(data["DonGia(VNĐ)"].ToString()),
                GiamGia = Convert.ToDouble(data["KhuyenMai(%)"].ToString()),
                TongTien = Convert.ToDouble(data["ThanhTien(VNĐ)"].ToString())
            };
        }
        // Thiết lập danh sách nhân viên thu ngân vào trong CBB_STAFF
        public List<CBBItem> GetCbb_Staff()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<CBBItem> list = new List<CBBItem>();
            foreach(tblNhanVien staff in DB.tblNhanViens.ToList())
            {
                if(staff.ViTri == "Thu ngân")
                {
                    list.Add(new CBBItem { VALUE = staff.MaNhanVien, TEXT = staff.TenNhanVien });
                }
            }
            return list;
        }
        // Thiết lập danh sách khách hàng vào trong CBB_CUSTOMER
        public List<CBBItem> GetCbb_Customer()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<CBBItem> list = new List<CBBItem>();
            foreach (tblKhachHang customer in DB.tblKhachHangs.ToList())
            {
                list.Add(new CBBItem { VALUE = customer.MaKhachHang, TEXT = customer.TenKhachHang });
            }
            return list;
        }
        // Tạo tbl Hóa đơn
        public DataTable GetTbl_Order()
        {
            DataTable data = new DataTable();
            data.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaHangHoa", typeof(string)),
                new DataColumn("TenHangHoa",typeof(string)),
                new DataColumn("SoLuong",typeof(int)),
                new DataColumn("DonGia(VNĐ)",typeof(string)),
                new DataColumn("KhuyenMai(%)",typeof(double)),
                new DataColumn("ThanhTien(VNĐ)",typeof(string))
            });
            return data;
        }
         // Thêm hàng hóa vào hóa đơn
        public void AddItem(DataTable data, params object[] obj)
        {
            int amount;
            double salePrice;
            bool isHas = true; // kiểm tra hàng hóa đã có trong hóa đơn hay chưa. Nếu có rồi thì update số lượng, nếu chưa thì add new
            foreach (DataRow i in data.Rows)
            {
                salePrice = Convert.ToDouble(i["ThanhTien(VNĐ)"].ToString());
                amount = Convert.ToInt32(i["SoLuong"].ToString());
                if (i["MaHangHoa"].ToString() == obj[0].ToString())
                {
                    isHas = false; // hàng hóa đã có
                    amount += Convert.ToInt32(obj[2].ToString());
                    salePrice += Convert.ToDouble(obj[5].ToString()); 
                    i["SoLuong"] = amount.ToString(); // thay đổi số lượng khi thêm hàng vào
                    i["ThanhTien(VNĐ)"] = String.Format("{0:n0}", salePrice); // chuyển định dạng số tiền, vd: 2000 -> 2.000
                }
            }
            if (isHas) // hàng hóa chưa có
            {
                data.Rows.Add(new object[] { obj[0], obj[1], obj[2], String.Format("{0:n0}", obj[3]), obj[4], String.Format("{0:n0}", obj[5]) });
            }
        }
        // Xóa hàng hóa khỏi hóa đơn
        public void DelItem(List<string> list, DataTable data)
        {
            try
            {
                foreach (string i in list)
                {
                    foreach (DataRow j in data.Rows)
                    {
                        if (j["MaHangHoa"].ToString() == i)
                        {
                            data.Rows.Remove(j);
                        }
                    }
                    data.AcceptChanges();
                }
            }
            catch (Exception)
            {

            }
        }
        // Tổng số tiền của hóa đơn
        public double GetTotal_Money(DataTable data)
        {
            double totalMoney = 0;
            foreach(DataRow dataRow in data.Rows)
            {
                totalMoney += Convert.ToDouble(dataRow["ThanhTien(VNĐ)"].ToString());
            }
            return totalMoney;
        }
        // Tổng thanh toán của hóa đơn
        public double getPrice_Invoice(DataTable data, double discount)
        {
            if (discount == 0)
            {
                return GetTotal_Money(data);
            }
            else
            {
                return GetTotal_Money(data) - discount;
            }
        }
        // Tổng số lượng của tất cả hàng hóa
        public int getAll_ProQty(DataTable data)
        {
            int allProQty = 0;
            foreach (DataRow dataRow in data.Rows)
            {
                allProQty += Convert.ToInt32(dataRow["SoLuong"].ToString());
            }
            return allProQty;
        }
        // Số lượng hàng hóa (nếu cùng tên thì tính là 1)
        public int getAll_Product(DataTable DATA)
        {
            int count = 0;
            foreach (DataRow data in DATA.Rows)
            {
                count++;
            }
            return count;
        }
        // Trả về mã hóa đơn mới
        public string GetNewID_Invoice()
        {
            int idInvoice;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            List<tblHoaDonBanHang> list = DB.tblHoaDonBanHangs.ToList();
            if (list.Count == 0)
            {
                idInvoice = 1;
            }
            else
            {
                int lastId = Convert.ToInt32(list[list.Count - 1].MaHoaDonBan.Remove(0, 2));
                idInvoice = lastId + 1;
            }
            return "HD" + idInvoice;
        }
    }
}
