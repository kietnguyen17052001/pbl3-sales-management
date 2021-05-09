using SaleManagement.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.FORM
{
    public partial class FrmReport : Form
    {
        public FrmReport()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            InitializeComponent();
            var getDayMin = DB.tblHoaDonBanHangs.Min(p => p.NgayBan);
            dpFROM.Value = getDayMin.Value;
            ShowList();
        }
        public void ShowList()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            // liet ke danh sach
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dpFROM.Value && p.tblHoaDonBanHang.NgayBan <= dpTO.Value).Select(p => new { 
                p.MaHangHoa,
                p.tblHangHoa.TenHangHoa,
                p.tblHoaDonBanHang.NgayBan,
                p.tblHoaDonBanHang.tblKhachHang.TenKhachHang,
                p.SoLuong,
                p.DonGia,
                p.GiamGia,
                p.TongTien
            });
            dgvREVENUE.DataSource = list.ToList();
            GetInformation();
        }
        public void GetInformation()
        {
            lbSALES.Text = string.Format("{0:n0}", GetRevenue(dpFROM.Value,dpTO.Value));
            lbPROFIT.Text = string.Format("{0:n0}", GetProfit(dpFROM.Value, dpTO.Value));
            lbDISCOUNT.Text = string.Format("{0:n0}", GetDiscount(dpFROM.Value, dpTO.Value));
            lbPRODUCT_QTY.Text = string.Format("{0:n0}", GetQuantity(dpFROM.Value, dpTO.Value));
            lbINVOICE_QTY.Text = string.Format("{0:n0}", GetInvoice(dpFROM.Value, dpTO.Value));
        }
        // load lại danh sách theo thời gian
        private void btnLOAD_Click(object sender, EventArgs e)
        {
            ShowList();
            GetInformation();
        }
        // doanh số
        public double GetRevenue(DateTime dateMin, DateTime dateMax)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            double revenue = 0;
            foreach (tblChiTietHoaDonBanHang invoice_detail in list)
            {
                revenue += (double)invoice_detail.TongTien;
            }
            return revenue;
        }
        // lợi nhuận
        public double GetProfit(DateTime dateMin, DateTime dateMax)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            double profit = 0;
            foreach (tblChiTietHoaDonBanHang invoice_detail in list)
            {
                profit += (double)(invoice_detail.TongTien - invoice_detail.SoLuong * invoice_detail.tblHangHoa.GiaNhap);
            }
            return profit;
        }
        // giảm giá
        public double GetDiscount(DateTime dateMin, DateTime dateMax)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            double discount = 0;
            foreach(tblChiTietHoaDonBanHang invoice_detail in list)
            {
                discount += (double)((invoice_detail.GiamGia / 100) * (invoice_detail.DonGia * invoice_detail.SoLuong));
            }
            return discount;
        }
        // sản phẩm
        public int GetQuantity(DateTime dateMin, DateTime dateMax)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var list = DB.tblChiTietHoaDonBanHangs.Where(p => p.tblHoaDonBanHang.NgayBan >= dateMin && p.tblHoaDonBanHang.NgayBan <= dateMax);
            int quantity = 0;
            foreach (tblChiTietHoaDonBanHang invoice_detail in list)
            {
                quantity += (int)invoice_detail.SoLuong;
            }
            return quantity;
        }
        // hóa đơn
        public int GetInvoice(DateTime dateMin, DateTime dateMax)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            var list = DB.tblHoaDonBanHangs.Where(p => p.NgayBan >= dateMin && p.NgayBan <= dateMax);
            int count = 0;
            foreach (tblHoaDonBanHang invoice in list)
            {
                count ++;
            }
            return count;
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmSale_Management frm = new FrmSale_Management();
            frm.Show();
            this.Close();
        }

        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Report";
            for (int i = 1; i <= dgvREVENUE.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvREVENUE.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < dgvREVENUE.Rows.Count; i++)
            {
                for (int j = 0; j < dgvREVENUE.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvREVENUE.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Report";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }
    }
}
