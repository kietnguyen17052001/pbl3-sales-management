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
        private N3KTeamEntities db = new N3KTeamEntities();
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
            var product = db.tblHangHoas.Select(p => new {
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
        // Kiểm tra xem số lượng thêm vào có phù hợp với số lượng trong kho hay không
        public bool isValidQuantityProduct(DataTable dataTable, string idProduct, int quantityAdd)
        {
            bool isValid = true;
            var product = db.tblHangHoas.Find(idProduct);
            if (isHasProductInInvoice(dataTable, idProduct)) // Đã có hàng hóa trong đơn
            {
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (dataRow["MaHangHoa"].ToString() == idProduct)
                    {
                        if ((Convert.ToInt32(dataRow["SoLuong"].ToString()) + quantityAdd) > product.SoLuong)
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
            }
            else // Chưa có hàng hóa trong đơn
            {
                if (quantityAdd > product.SoLuong)
                {
                    isValid = false;
                }
                else
                {
                    isValid = true;
                }
            }
            return isValid;
        }
        // Kiểm tra xem hàng hóa thêm đã có trong hóa đơn hay chưa
        public bool isHasProductInInvoice(DataTable dataTable, string idProduct)
        {
            bool isHasProduct = false;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if(dataRow["MaHangHoa"].ToString() == idProduct)
                {
                    isHasProduct = true;
                }
            }
            return isHasProduct;
        }
        // Thêm hàng hóa vào hóa đơn
        public void FuncAddProduct(DataTable dataTable, string idProduct, int quantityAdd, double discount)
        {
            bool isHas = false; // kiểm tra hàng hóa đã có trong hóa đơn hay chưa. Nếu có rồi thì update số lượng, nếu chưa thì add new
            var product = db.tblHangHoas.Find(idProduct);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if (dataRow["MaHangHoa"].ToString() == product.MaHangHoa)
                {
                    isHas = true; // hàng hóa đã có
                    dataRow["SoLuong"] = (Convert.ToInt32(dataRow["SoLuong"].ToString()) + quantityAdd).ToString(); // thay đổi số lượng khi thêm hàng vào
                    dataRow["ThanhTien(VNĐ)"] = String.Format("{0:n0}", Convert.ToDouble(dataRow["ThanhTien(VNĐ)"].ToString()) 
                        + (product.GiaBan * quantityAdd - (product.GiaBan * quantityAdd * discount) / 100)); // chuyển định dạng số tiền, vd: 2000 -> 2.000   
                }
            }
            if (isHas == false) // hàng hóa chưa có
            {
                dataTable.Rows.Add(
                    idProduct,
                    product.TenHangHoa,
                    quantityAdd,
                    String.Format("{0:n0}",product.GiaBan), 
                    discount, 
                    String.Format("{0:n0}", Convert.ToDouble(product.GiaBan * quantityAdd - (product.GiaBan * quantityAdd * discount) / 100)));
            }
        }
        // Xóa hàng hóa khỏi hóa đơn
        public void FuncDeleteProduct(List<string> listIdProduct, DataTable dataTable)
        {
            try
            {
                foreach (string idProduct in listIdProduct)
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
                var product = db.tblHangHoas.Where(p => p.TenHangHoa.Contains(information) || p.MaHangHoa.Contains(information)).Select(p => new
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
            db.tblHoaDonBanHangs.Add(newInvoice);
            db.SaveChanges();// thêm đơn hàng vào db
            foreach (DataRow dataRow in dataTable.Rows)
            {
                db.tblChiTietHoaDonBanHangs.Add(getDetailInvoice(dataRow, newInvoice.MaHoaDonBan));
                db.SaveChanges();// thêm hóa đơn bán hàng chi tiết
                var product = db.tblHangHoas.Find(dataRow["MaHangHoa"].ToString());
                product.SoLuong -= Convert.ToInt32(dataRow["SoLuong"].ToString());
                db.SaveChanges();// thay đổi số lượng hàng hóa sau khi thanh toán
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
        public int getTotalProduct(DataTable dataTable)
        {
            return dataTable.Rows.Count;
        }
        // Trả về mã hóa đơn mới
        public string getNewIdInvoice()
        {
            string idInvoice = "";
            List<tblHoaDonBanHang> list = db.tblHoaDonBanHangs.ToList();
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
                    idInvoice = "HDB0" + (lastId + 1).ToString(); 
                }
                else
                {
                    idInvoice = "HDB" + (lastId + 1).ToString();
                }
            }
            return idInvoice;
        }
    }
}
