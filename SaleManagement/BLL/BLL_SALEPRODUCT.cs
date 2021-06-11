using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.BLL
{
    class BLL_SALEPRODUCT
    {
        private SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_SALEPRODUCT _Instance;
        public static BLL_SALEPRODUCT Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_SALEPRODUCT();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_SALEPRODUCT() { }
        public tblChiTietHoaDonBanHang getDetailInvoice(DataRow data, string idInvoice)
        {
            return new tblChiTietHoaDonBanHang
            {
                MaHoaDonBan = idInvoice,
                MaHangHoa = data["MaHangHoa"].ToString(),
                SoLuong = Convert.ToInt32(data["SoLuong"].ToString()),
                DonGia = Convert.ToDouble(data["DonGia(VNĐ)"].ToString()),
                GiamGia = Convert.ToDouble(data["KhuyenMai(%)"].ToString()),
                TongTien = Convert.ToDouble(data["ThanhTien(VNĐ)"].ToString())
            };
        }
        // Load data for DGVProduct
        public void LoadDataProduct(DataGridView dgv)
        {
            var product = DB.tblHangHoas.Select(p => new {
                p.MaHangHoa,
                p.TenHangHoa,
                p.SoLuong,
                p.GiaBan
            });
            dgv.DataSource = product.ToList();
        }
        // Tạo tbl Hóa đơn
        public DataTable TableInvoice()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("MaHangHoa", typeof(string)),
                new DataColumn("TenHangHoa",typeof(string)),
                new DataColumn("SoLuong",typeof(int)),
                new DataColumn("DonGia(VNĐ)",typeof(string)),
                new DataColumn("KhuyenMai(%)",typeof(double)),
                new DataColumn("ThanhTien(VNĐ)",typeof(string))
            });
            return dataTable;
        }
         // Thêm hàng hóa vào hóa đơn
        public void FuncAddProduct(DataTable data, params object[] obj)
        {
            int quantity;
            double salePrice;
            bool isHas = true; // kiểm tra hàng hóa đã có trong hóa đơn hay chưa. Nếu có rồi thì update số lượng, nếu chưa thì add new
            foreach (DataRow i in data.Rows)
            {
                salePrice = Convert.ToDouble(i["ThanhTien(VNĐ)"].ToString());
                quantity = Convert.ToInt32(i["SoLuong"].ToString());
                if (i["MaHangHoa"].ToString() == obj[0].ToString())
                {
                    isHas = false; // hàng hóa đã có
                    quantity += Convert.ToInt32(obj[2].ToString());
                    salePrice += Convert.ToDouble(obj[5].ToString()); 
                    i["SoLuong"] = quantity.ToString(); // thay đổi số lượng khi thêm hàng vào
                    i["ThanhTien(VNĐ)"] = String.Format("{0:n0}", salePrice); // chuyển định dạng số tiền, vd: 2000 -> 2.000
                }
            }
            if (isHas) // hàng hóa chưa có
            {
                data.Rows.Add(new object[] { obj[0], obj[1], obj[2], String.Format("{0:n0}", obj[3]), obj[4], String.Format("{0:n0}", obj[5]) });
            }
        }
        // Xóa hàng hóa khỏi hóa đơn
        public void FuncDeleteProduct(List<string> ListIdProduct, DataTable dataTable)
        {
            try
            {
                foreach (string idProduct in ListIdProduct)
                {
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        if (dataRow["MaHangHoa"].ToString() == idProduct)
                        {
                            dataTable.Rows.Remove(dataRow);
                        }
                    }
                    dataTable.AcceptChanges();
                }
            }
            catch (Exception){}
        }
        // search product
        public void FuncSearchProduct(DataGridView dgv, string information)
        {
            if (information == "Nhập tên hoặc mã hàng hóa" || string.IsNullOrEmpty(information))
            {
                LoadDataProduct(dgv);
            }
            else
            {
                var product = DB.tblHangHoas.Where(p => p.TenHangHoa.Contains(information) || p.MaHangHoa.Contains(information)).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan
                });
                dgv.DataSource = product.ToList();
            }
        }
        // payment for invoice
        public void FuncPayment(tblHoaDonBanHang newInvoice, DataTable dataTable)
        {
            DB.tblHoaDonBanHangs.Add(newInvoice);
            DB.SaveChanges();// thêm đơn hàng vào DB
            foreach (DataRow dataRow in dataTable.Rows)
            {
                DB.tblChiTietHoaDonBanHangs.Add(getDetailInvoice(dataRow, newInvoice.MaHoaDonBan));
                DB.SaveChanges();// thêm hóa đơn bán hàng chi tiết
                var product = DB.tblHangHoas.Find(dataRow["MaHangHoa"].ToString());
                product.SoLuong -= Convert.ToInt32(dataRow["SoLuong"].ToString());
                DB.SaveChanges();// thay đổi số lượng hàng hóa sau khi thanh toán
            }
        }
        // Tổng số tiền của hóa đơn
        public double getTotalMoney(DataTable dataTable)
        {
            double totalMoney = 0;
            foreach(DataRow dataRow in dataTable.Rows)
            {
                totalMoney += Convert.ToDouble(dataRow["ThanhTien(VNĐ)"].ToString());
            }
            return totalMoney;
        }
        // Tổng thanh toán của hóa đơn
        public double getIntoMoney(DataTable dataTable, double discount)
        {
            if (discount == 0)
            {
                return getTotalMoney(dataTable);
            }
            else
            {
                return getTotalMoney(dataTable) - discount;
            }
        }
        // Tổng số lượng của tất cả hàng hóa
        public int getTotalQuantityProduct(DataTable dataTable)
        {
            int quantity = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                quantity += Convert.ToInt32(dataRow["SoLuong"].ToString());
            }
            return quantity;
        }
        // Số lượng hàng hóa (nếu cùng tên thì tính là 1)
        public int getTotalProduct(DataTable DATA)
        {
            int value = 0;
            foreach (DataRow data in DATA.Rows)
            {
                value++;
            }
            return value;
        }
        // Trả về mã hóa đơn mới
        public string getNewIdInvoice()
        {
            string idInvoice = "";
            List<tblHoaDonBanHang> list = DB.tblHoaDonBanHangs.ToList();
            if (list.Count == 0)
            {
                idInvoice = "HDB0001";
            }
            else
            {
                int lastId = Convert.ToInt32(list[list.Count - 1].MaHoaDonBan.Remove(0, 3));
                if (lastId + 1 < 10)
                {
                    idInvoice = "HDB000" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 100)
                {
                    idInvoice = "HDB00" + (lastId + 1).ToString();
                }
                else if (lastId + 1 < 1000)
                {
                    idInvoice = "HDB0"+ (lastId + 1).ToString(); 
                }
            }
            return idInvoice;
        }
    }
}
