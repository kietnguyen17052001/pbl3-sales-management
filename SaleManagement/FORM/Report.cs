using SaleManagement.BLL;
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
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        public FrmReport()
        {
            InitializeComponent();
            var getDayMin = DB.tblHoaDonBanHangs.Min(p => p.NgayBan);
            if (getDayMin == null)
            {
                dpFROM.Value = DateTime.Now;
            }
            else
            {
                dpFROM.Value = getDayMin.Value;
            }
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
            DateTime dateMin = dpFROM.Value;
            DateTime dateMax = dpTO.Value;
            lbSALES.Text = string.Format("{0:n0}", BLL_REPORT.Instance.GetRevenue(dateMin, dateMax));
            lbPROFIT.Text = string.Format("{0:n0}", BLL_REPORT.Instance.GetProfit(dateMin, dateMax));
            lbDISCOUNT.Text = string.Format("{0:n0}", BLL_REPORT.Instance.GetDiscount(dateMin, dateMax));
            lbPRODUCT_QTY.Text = string.Format("{0:n0}", BLL_REPORT.Instance.GetQuantity(dateMin, dateMax));
            lbINVOICE_QTY.Text = string.Format("{0:n0}", BLL_REPORT.Instance.GetInvoice(dateMin, dateMax));
        }
        // load lại danh sách theo thời gian
        private void btnLOAD_Click(object sender, EventArgs e)
        {
            ShowList();
            GetInformation();
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
