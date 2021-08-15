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
        private string usernameLogin;
        public FrmReport(string _usernameLogin)
        {
            InitializeComponent();
            usernameLogin = _usernameLogin;
            dpFROM.CustomFormat = dpTO.CustomFormat = "dd/MM/yyyy";
            dpFROM.Value = BLL_LISTSALEINVOICE.Instance.getDate();
            LoadData();
            FormatColumnHeader();
        }
        // Format column header
        public void FormatColumnHeader()
        {
            // Set style for ColumnHeader
            dgvREVENUE.EnableHeadersVisualStyles = false;
            dgvREVENUE.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvREVENUE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvREVENUE.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvREVENUE.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set headerText
            dgvREVENUE.Columns[0].HeaderText = "Mã h.hóa";
            dgvREVENUE.Columns[1].HeaderText = "Tên h.hóa";
            dgvREVENUE.Columns[2].HeaderText = "Ngày bán";
            dgvREVENUE.Columns[3].HeaderText = "Khách hàng";
            dgvREVENUE.Columns[4].HeaderText = "Số lượng";
            dgvREVENUE.Columns[5].HeaderText = "Giá nhập";
            dgvREVENUE.Columns[6].HeaderText = "Giá bán";
            dgvREVENUE.Columns[7].HeaderText = "Giảm giá(%)";
            dgvREVENUE.Columns[8].HeaderText = "Tổng tiền";
        }
        // show tblChiTiethoaDonBanHang theo time
        public void LoadData()
        {
            BLL_REPORT.Instance.LoadDataReport(dgvREVENUE, dpFROM.Value, dpTO.Value);
            getInformation();
        }
        public void getInformation()
        {
            DateTime dateStart = dpFROM.Value;
            DateTime dateEnd = dpTO.Value;
            lbSALES.Text = string.Format("{0:n0}", BLL_REPORT.Instance.getRevenue(dateStart, dateEnd));
            lbPROFIT.Text = string.Format("{0:n0}", BLL_REPORT.Instance.getProfit(dateStart, dateEnd));
            lbDISCOUNT.Text = string.Format("{0:n0}", BLL_REPORT.Instance.getDiscount(dateStart, dateEnd));
            lbPRODUCT_QTY.Text = string.Format("{0:n0}", BLL_REPORT.Instance.getQuantity(dateStart, dateEnd));
            lbINVOICE_QTY.Text = string.Format("{0:n0}", BLL_REPORT.Instance.getInvoice(dateStart, dateEnd));
        }
        // set backColor for dgv
        private void dgvREVENUE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvREVENUE.DefaultCellStyle.BackColor = Color.OldLace;
            dgvREVENUE.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // back to FrmQLBanHang
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernameLogin);
            frmMainAdmin.Show();
            this.Close();
        }
        // export file Excel
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
        // Load form when value change in datetimepickers
        private void dpTO_ValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
