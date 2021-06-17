using SaleManagement.BLL;
using SaleManagement.Entity;
using SaleManagement.VIEW;
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
    public partial class FrmList_SaleInvoice : Form
    {
        private string idInvoice, idProduct, nameProduct;
        private int quantityProduct;
        private bool isAdmin;
        private string usernameLogin;
        public FrmList_SaleInvoice(bool _isAdmin, string _usernameLogin)
        {
            InitializeComponent();
            isAdmin = _isAdmin;
            usernameLogin = _usernameLogin;
            if (isAdmin == false)
            {
                btnBACK.Enabled = btnEDIT.Enabled = btnDELETE.Enabled = btnSAVE.Enabled = false;
            }
            Disable(false);
            setCombobox();
            dpFROM.Value = BLL_LISTSALEINVOICE.Instance.getDate();
            LoadDataDGVs();
            FormatColumnHeader();
        }
        // Format ColumnHeader
        public void FormatColumnHeader()
        {
            // Set style for columnHeader dgvListInvoice and dgvInfo_Invoice
            dgvLIST_INVOICE.EnableHeadersVisualStyles = dgvINFO_INVOICE.EnableHeadersVisualStyles = false;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.BackColor = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.ForeColor = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.Font = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvLIST_INVOICE.ColumnHeadersDefaultCellStyle.Padding = dgvINFO_INVOICE.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // Set headerText for dgvList_Invoice
            dgvLIST_INVOICE.Columns[0].HeaderText = "Mã h.đơn";
            dgvLIST_INVOICE.Columns[1].HeaderText = "Ngày bán";
            dgvLIST_INVOICE.Columns[2].HeaderText = "Nhân viên";
            dgvLIST_INVOICE.Columns[3].HeaderText = "Khách hàng";
            dgvLIST_INVOICE.Columns[4].HeaderText = "Thành tiền(VNĐ)";
            dgvLIST_INVOICE.Columns[5].HeaderText = "Giảm giá(VNĐ)";
            // Set headertext for dgvInfo_Invoice
            dgvINFO_INVOICE.Columns[0].HeaderText = "Mã h.hóa";
            dgvINFO_INVOICE.Columns[1].HeaderText = "Tên h.hóa";
            dgvINFO_INVOICE.Columns[2].HeaderText = "Số lượng";
            dgvINFO_INVOICE.Columns[3].HeaderText = "Giá(VNĐ)";
            dgvINFO_INVOICE.Columns[4].HeaderText = "Giảm giá(%)";
            dgvINFO_INVOICE.Columns[5].HeaderText = "Tổng tiền(VNĐ)";
        }
        public void Disable(bool E)
        {
            dpDAY.Enabled = E;
            cbbCUSTOMER.Enabled = E;
            cbbSTAFF.Enabled = E;
        }
        private void btnHOME_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                FrmMain_Admin frm = new FrmMain_Admin(usernameLogin);
                frm.Show();
            }
            else
            {
                FrmMain_Member frm = new FrmMain_Member(usernameLogin);
                frm.Show();
            }
            this.Close();
        }
        // event CellClick in dgvListInvoice
        private void dgvLIST_INVOICE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idInvoice = dgvLIST_INVOICE.SelectedRows[0].Cells["MaHoaDonBan"].Value.ToString();
            txtID_INVOICE.Text = idInvoice;
            dpDAY.Value = Convert.ToDateTime(dgvLIST_INVOICE.SelectedRows[0].Cells["NgayBan"].Value.ToString());
            cbbSTAFF.Text = BLL_LISTSALEINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenNhanVien"].Value.ToString(), BLL_STAFF.Instance.getCbbStaff());
            cbbCUSTOMER.Text = BLL_LISTSALEINVOICE.Instance.getTextForCbb(dgvLIST_INVOICE.SelectedRows[0].Cells["TenKhachHang"].Value.ToString(), BLL_CUSTOMER.Instance.getCbbCustomer());
            txtPRICE_.Text = String.Format("{0:n0}", dgvLIST_INVOICE.SelectedRows[0].Cells["SoTien"].Value);
            txtDISCOUNT.Text = String.Format("{0:n0}", dgvLIST_INVOICE.SelectedRows[0].Cells["GiamGia"].Value);
            BLL_LISTSALEINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, idInvoice);
        }
        // set BackColor and Font for DGV
        private void dgvLIST_INVOICE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvLIST_INVOICE.DefaultCellStyle.BackColor = Color.Azure;
            dgvLIST_INVOICE.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }

        private void dgvINFO_INVOICE_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvINFO_INVOICE.DefaultCellStyle.BackColor = Color.OldLace;
            dgvINFO_INVOICE.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // set data for combobox
        public void setCombobox()
        {
<<<<<<< HEAD:SaleManagement/FORM/Manage_List_Invoice.cs
            cbbSTAFF_DETAIL.Items.Add(new CBBItem { VALUE = "0", TEXT = "Tất cả"});
            cbbSTAFF_DETAIL.Items.AddRange(BLL_SALEPRODUCT.Instance.GetCbb_Staff().ToArray());
            cbbSTAFF.Items.AddRange(BLL_SALEPRODUCT.Instance.GetCbb_Staff().ToArray());
            cbbCUSTOMER.Items.AddRange(BLL_SALEPRODUCT.Instance.GetCbb_Customer().ToArray());
            cbbSTAFF_DETAIL.SelectedIndex = 0;
=======
            cbbSTAFF.Items.AddRange(BLL_STAFF.Instance.getCbbStaff().ToArray());
            cbbCUSTOMER.Items.AddRange(BLL_CUSTOMER.Instance.getCbbCustomer().ToArray());
>>>>>>> 795067ba8acda540f708f304e54a63890968a871:SaleManagement/FORM/List_SaleInvoice.cs
        }
        // Liệt kê hóa đơn theo cbbStaff_Detail
        public void LoadDataDGVs()
        {
            BLL_LISTSALEINVOICE.Instance.FuncSearchInvoice(dgvLIST_INVOICE, dpFROM.Value, dpTO.Value, txtSEARCH.Text.Trim());
            BLL_LISTSALEINVOICE.Instance.LoadDataFrmDetail(dgvINFO_INVOICE, idInvoice);
            lbQuantity.Text = BLL_LISTSALEINVOICE.Instance.getQuantityInvoice(dgvLIST_INVOICE).ToString();
            lbTotalMoney.Text = String.Format("{0:n0}", BLL_LISTSALEINVOICE.Instance.getTotalMoney(dgvLIST_INVOICE));
        }
        // Search invoice
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            LoadDataDGVs();
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hóa đơn hoặc mã/ tên khách hàng")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hóa đơn hoặc mã/ tên khách hàng";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
        // Export Excel
        private void btnEXCEL_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "ListInvoice";
            for(int i = 1; i <= dgvLIST_INVOICE.Columns.Count; i++)
            {
                worksheet.Cells[1, i] = dgvLIST_INVOICE.Columns[i - 1].HeaderText;
            }
            for(int i = 0; i < dgvLIST_INVOICE.Rows.Count; i++)
            {
                for(int j = 0; j < dgvLIST_INVOICE.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgvLIST_INVOICE.Rows[i].Cells[j].Value.ToString();
                }
            }
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "List Invoice";
            saveFileDialog.DefaultExt = ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            Disable(true);
        }
        // Save changes
        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                BLL_LISTSALEINVOICE.Instance.FuncEditInvoice(idInvoice, dpDAY.Value, ((CBBItem)cbbSTAFF.SelectedItem).VALUE, ((CBBItem)cbbCUSTOMER.SelectedItem).VALUE);
                MessageBox.Show("Sửa thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataDGVs();
                Disable(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Sửa thất bại hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Delete invoice
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> listIdInvoice = new List<string>();
            DataGridViewSelectedRowCollection data = dgvLIST_INVOICE.SelectedRows;
            foreach(DataGridViewRow dataGvr in data)
            {
                listIdInvoice.Add(dataGvr.Cells["MaHoaDonBan"].Value.ToString());
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn xóa hóa đơn này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BLL_LISTSALEINVOICE.Instance.FuncDeleteInvoice(listIdInvoice); // delete invoice
                LoadDataDGVs();
            }
        }
        // back to frmQuanLyDuLieu
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frm = new FrmManage_Data(usernameLogin);
            frm.Show();
            this.Close();
        }
        // Add product for invoice
        private void btnADD_PRODUCT_Click(object sender, EventArgs e)
        {
            FrmAdd_NewProduct frm = new FrmAdd_NewProduct(idInvoice);
            frm.Show();
            LoadDataDGVs();
        }
        // Func set new Quantity for product in invoice
        public void setNewQuantity(int newQuantity)
        {
            BLL_LISTSALEINVOICE.Instance.ChangeQuantityProduct(quantityProduct, newQuantity, idInvoice, idProduct);
            LoadDataDGVs();
        }
        // Edit quantity product
        private void btnEDIT_QUANTITY_Click(object sender, EventArgs e)
        {
            nameProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["TenHangHoa"].Value.ToString();
            quantityProduct = Convert.ToInt32(dgvINFO_INVOICE.SelectedRows[0].Cells["SoLuong"].Value.ToString());
            idProduct = dgvINFO_INVOICE.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            FrmEditQuantityProduct_ListInvoice frm = new FrmEditQuantityProduct_ListInvoice(idProduct, nameProduct, quantityProduct, true);
            frm.d += new FrmEditQuantityProduct_ListInvoice.myDEL(setNewQuantity);
            frm.Show();
        }
        // Load dgv when valuechange datetimepickers
        private void dpTO_ValueChanged(object sender, EventArgs e)
        {
            LoadDataDGVs();
        }
        // Delete product in invoice
        private void btnDELETE_PRODUCT_Click(object sender, EventArgs e)
        {
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvINFO_INVOICE.SelectedRows;
            foreach(DataGridViewRow dataGVR in data)
            {
                listIdProduct.Add(dataGVR.Cells["MaHangHoa"].Value.ToString());
            }
            DialogResult result = MessageBox.Show("Bạn chắc chắn hàng hóa này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                BLL_LISTSALEINVOICE.Instance.FuncDeleteProduct(listIdProduct, idInvoice); // delete product
                LoadDataDGVs();
            }        
        }
        private void txtID_INVOICE_TextChanged(object sender, EventArgs e)
        {
            lbIdInvoice.Text = idInvoice;
        }
    }
}
