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
    class BLL_LISTINVOICE
    {
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        private static BLL_LISTINVOICE _Instance;
        public static BLL_LISTINVOICE Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_LISTINVOICE();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_LISTINVOICE() { }
        // edit invoice
        public void FuncEditInvoice(tblHoaDonBanHang invoice)
        {
            var getInvoice = DB.tblHoaDonBanHangs.Find(invoice.MaHoaDonBan);
            getInvoice.NgayBan = invoice.NgayBan;
            getInvoice.MaNhanVien = invoice.MaNhanVien;
            getInvoice.MaKhachHang = invoice.MaKhachHang;
            DB.SaveChanges();
        }
        public void FuncDeleteInvoice(List<string> listIdInvoice)
        {
            foreach (string i in listIdInvoice)
            {
                foreach (tblHoaDonBanHang invoice in DB.tblHoaDonBanHangs) // xóa đơn hàng có mã đơn = i
                {
                    if (invoice.MaHoaDonBan == i)
                    {
                        DB.tblHoaDonBanHangs.Remove(invoice);
                        foreach (tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs) // xóa chi tiết đơn hàng có mã đơn = i
                        {
                            if (invoiceDetail.MaHoaDonBan == i)
                            {
                                DB.tblChiTietHoaDonBanHangs.Remove(invoiceDetail);
                                foreach (tblHangHoa product in DB.tblHangHoas) // thay đổi số lượng hàng hóa sau khi xóa chi tiết đơn hàng
                                {
                                    if (product.MaHangHoa == invoiceDetail.MaHangHoa)
                                    {
                                        product.SoLuong += (int)invoiceDetail.SoLuong;
                                    }
                                }
                            }
                        }
                    }
                }
                DB.SaveChanges();
            }
        }
        // delete product - invoice 
        public void FuncDeleteProduct(List<string> listIdProduct, string idInvoice)
        {
            foreach (string i in listIdProduct)
            {
                foreach (tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs)
                {
                    if (invoiceDetail.MaHoaDonBan == idInvoice && invoiceDetail.MaHangHoa == i)
                    {
                        DB.tblChiTietHoaDonBanHangs.Remove(invoiceDetail);
                        var product = DB.tblHangHoas.Find(i);
                        product.SoLuong += (int)invoiceDetail.SoLuong;
                    }
                }
                DB.SaveChanges();
            }
            var invoice = DB.tblHoaDonBanHangs.Find(idInvoice);
            invoice.SoTien = GetPriceInvoice(idInvoice);
            DB.SaveChanges();
        }
        // search invoice
        public void FuncSearchInvoice(DataGridView dgv, string content)
        {
            var listInvoice = DB.tblHoaDonBanHangs.Where(p => p.MaHoaDonBan.Contains(content) || p.MaKhachHang.Contains(content)
            || p.tblKhachHang.TenKhachHang.Contains(content)).Select(p => new {
                p.MaHoaDonBan,
                p.NgayBan,
                p.tblNhanVien.TenNhanVien,
                p.tblKhachHang.TenKhachHang,
                p.SoTien,
                p.GiamGia
            });
            dgv.DataSource = listInvoice.ToList();
        }
        public string GetStaff(string nameStaff)
        {
            string staff = "";
            foreach(CBBItem cbbitem in BLL_SALEPRODUCT.Instance.GetCbb_Staff())
            {
                if(cbbitem.TEXT == nameStaff)
                {
                    staff = cbbitem.ToString();
                    break;
                }
            }
            return staff;
        }
        public string GetCustomer(string nameCustomer)
        {
            string customer = "";
            foreach (CBBItem cbbitem in BLL_SALEPRODUCT.Instance.GetCbb_Customer())
            {
                if (cbbitem.TEXT == nameCustomer)
                {
                    customer = cbbitem.ToString();
                    break;
                }
            }
            return customer;
        }
        public double GetPriceInvoice(string idInvoice)
        {
            double price = 0;
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            foreach(tblChiTietHoaDonBanHang invoiceDetail in DB.tblChiTietHoaDonBanHangs)
            {
                if (invoiceDetail.MaHoaDonBan == idInvoice)
                {
                    price += Convert.ToDouble(invoiceDetail.TongTien);
                }
            }
            return price;
        }
        
    }
}
