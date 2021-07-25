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
    public partial class FrmInvoice_ImportProduct : Form
    {
        private bool isAdmin;
        private DataTable dataTable = BLL_IMPORTPRODUCT.instance.TableInvoice();
        private string idProduct, idSupplier, usernameLogin;
        private double intoMoney, totalMoney;
        public FrmInvoice_ImportProduct(bool _isAdmin, string _usernameLogin)
        {
            InitializeComponent();
            isAdmin = _isAdmin;
            usernameLogin = _usernameLogin;
            if (isAdmin == false)
            {
                btnBACK.Enabled = false;
            }
            LoadData();
            FormatHeaderCell();
            setCbbStaff();
            txtIdInvoice.Text = BLL_IMPORTPRODUCT.instance.getNewIdInvoice();
        }
        public void setCbbStaff()
        {
            cbbStaff.Items.AddRange(BLL_STAFF.Instance.getCbbStaff().ToArray());
            if(isAdmin == false)
            {
                cbbStaff.Text = BLL_STAFF.Instance.getStaffById(usernameLogin);
            }
            else
            {
                cbbStaff.SelectedIndex = 0;
            }
        }
        // Load data for DGVs
        public void LoadData()
        {
            BLL_IMPORTPRODUCT.instance.LoadDataProduct(dgvInfoProduct);
            dgvInvoice.DataSource = dataTable;
        }
        public void ResetInvoice()
        {
            txtIdInvoice.Text = BLL_IMPORTPRODUCT.instance.getNewIdInvoice();
            txtIntoMoney.Text = txtTotalMoney.Text = txtPercent.Text = txtMoney.Text = "0";
            txtSupplier.Clear();
            txtQuantity.Text = "1";
            dataTable.Clear();
        }
        // Format headerCell for DGVs
        public void FormatHeaderCell()
        {
            dgvInfoProduct.EnableHeadersVisualStyles = dgvInvoice.EnableHeadersVisualStyles = false;
            dgvInfoProduct.ColumnHeadersDefaultCellStyle.BackColor = dgvInvoice.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvInfoProduct.ColumnHeadersDefaultCellStyle.ForeColor = dgvInvoice.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInfoProduct.ColumnHeadersDefaultCellStyle.Font = dgvInvoice.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvInfoProduct.ColumnHeadersDefaultCellStyle.Padding = dgvInvoice.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);

            dgvInfoProduct.Columns["MaHangHoa"].HeaderText = dgvInvoice.Columns["MaHangHoa"].HeaderText = "Mã h.hóa";
            dgvInfoProduct.Columns["TenHangHoa"].HeaderText = dgvInvoice.Columns["TenHangHoa"].HeaderText = "Tên h.hóa";
            dgvInfoProduct.Columns["SoLuong"].HeaderText = dgvInvoice.Columns["SoLuong"].HeaderText = "Số lượng";

            dgvInvoice.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dgvInvoice.Columns["TongTien"].HeaderText = "Tổng tiền";
        }
        // Format cell DGV
        private void dgvInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvInvoice.DefaultCellStyle.BackColor = Color.OldLace;
            dgvInvoice.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }

        // button Home -> back to frmSaleManagement
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                FrmMain_Admin frmMainAdmin = new FrmMain_Admin(usernameLogin);
                frmMainAdmin.Show();
            }
            else
            {
                FrmMain_Member frmMainMember = new FrmMain_Member(usernameLogin);
                frmMainMember.Show();
            }
            this.Close();
        }
        // ---------- Group Thông tin hàng hóa ----------
        // search product
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            BLL_IMPORTPRODUCT.instance.FuncSearchProduct(txtProduct.Text, dgvInfoProduct);
        }

        private void txtProduct_Enter(object sender, EventArgs e)
        {
            if (txtProduct.Text == "Nhập tên hàng hóa")
            {
                txtProduct.ForeColor = Color.Black;
                txtProduct.Text = "";
            }
        }

        private void txtProduct_Leave(object sender, EventArgs e)
        {
            if (txtProduct.Text == "")
            {
                txtProduct.ForeColor = Color.Silver;
                txtProduct.Text = "Nhập tên hàng hóa";
            }
        }
        // Format cell DGV
        private void dgvInfoProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvInfoProduct.DefaultCellStyle.BackColor = Color.Azure;
            dgvInfoProduct.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        public void NewProduct(string nameProduct)
        {
            BLL_IMPORTPRODUCT.instance.FuncSearchProduct(nameProduct, dgvInfoProduct);
        }
        // button Addnew product
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            FrmCreate_NewProduct frmCreateNewProduct = new FrmCreate_NewProduct();
            frmCreateNewProduct.d += new FrmCreate_NewProduct.myDel(NewProduct);
            frmCreateNewProduct.Show();
        }
        // Select product
        private void btnSelect_Click(object sender, EventArgs e)
        {
            idProduct = dgvInfoProduct.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            BLL_IMPORTPRODUCT.instance.SelectProduct(dataTable, idProduct, Convert.ToInt32(txtQuantity.Text));
            LoadData();
            setValue(Convert.ToDouble(txtMoney.Text), Convert.ToDouble(txtPercent.Text));
        }
        // ---------- Hóa đơn nhập hàng ----------
        // button Supplier: select supplier
        public void SelectSupplier(string _idSupplier, string nameSupplier)
        {
            idSupplier = _idSupplier;
            txtSupplier.Text = nameSupplier;
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FrmSelect_Supplier frm = new FrmSelect_Supplier();
            frm.d += new FrmSelect_Supplier.myDel(SelectSupplier);
            frm.Show();
        }
        // button Update quantity
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            BLL_IMPORTPRODUCT.instance.FuncUpdateProductQty(dataTable, dgvInvoice.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(), Convert.ToInt32(txtUpdateQuantity.Text));
            LoadData();
            setValue(Convert.ToDouble(txtMoney.Text), Convert.ToDouble(txtPercent.Text));
        }
        private void txtUpdateQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUpdateQuantity.Text))
            {
                txtUpdateQuantity.Text = "1";
            }
        }
        // button Delete product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> listIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvInvoice.SelectedRows;
            foreach(DataGridViewRow dgvRow in data)
            {
                listIdProduct.Add(dgvRow.Cells["MaHangHoa"].Value.ToString());
            }
            BLL_IMPORTPRODUCT.instance.FuncDeleteProduct(listIdProduct, dataTable);
            if(dataTable.Rows.Count == 0)
            {
                ResetInvoice();
            }
            else
            {
                setValue(Convert.ToDouble(txtMoney.Text), Convert.ToDouble(txtPercent.Text));
            }
        }
        // ---------- Thanh toán ----------
        public void setValue(double discountMoney, double discountPercent)
        {
            totalMoney = BLL_IMPORTPRODUCT.instance.getTotalMoney(dataTable);
            intoMoney = BLL_IMPORTPRODUCT.instance.getIntoMoney(dataTable, discountMoney, discountPercent);
            txtTotalMoney.Text = String.Format("{0:n0}", totalMoney);
            txtIntoMoney.Text = String.Format("{0:n0}", intoMoney);
        }
        // replace into money
        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtPercent.Text))
            {
                txtPercent.Text = "0";
            }
            if (Convert.ToInt32(txtPercent.Text) > 100)
            {
                txtPercent.Text = (Convert.ToInt32(txtPercent.Text) / 10).ToString();
            }
            setValue(Convert.ToDouble(txtMoney.Text), Convert.ToDouble(txtPercent.Text));
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMoney.Text))
            {
                txtMoney.Text = "0";
            }
            setValue(Convert.ToDouble(txtMoney.Text), Convert.ToDouble(txtPercent.Text));
        }
        // button Payment invoice
        private void btnPayment_Click(object sender, EventArgs e)
        {
            string message = "Thông tin lỗi:\n";
            tblHoaDonNhapHang invoice = new tblHoaDonNhapHang();
            invoice.MaHoaDonNhap = txtIdInvoice.Text;
            invoice.MaNhanVien = ((CBBItem)cbbStaff.SelectedItem).VALUE;
            invoice.NgayNhap = dpDayCreate.Value;
            invoice.MaNhaCungCap = idSupplier;
            invoice.SoTien = Math.Round(intoMoney);
            invoice.GiamGia = Math.Round((totalMoney - intoMoney));
            if (String.IsNullOrEmpty(invoice.MaNhaCungCap) || dataTable.Rows.Count == 0
                || Convert.ToDouble(txtIntoMoney.Text) < 0)
            {
                if (String.IsNullOrEmpty(invoice.MaNhaCungCap))
                {
                    message += "+ Nhà cung cấp trống\n";
                }
                if (dataTable.Rows.Count == 0)
                {
                    message += "+ Hóa đơn trống sản phẩm\n";
                }
                if (Convert.ToDouble(txtIntoMoney.Text) < 0)
                {
                    message += "+ Tiền thanh toán âm\n";
                }
                MessageBox.Show(message, "Lỗi tạo đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult answer = MessageBox.Show("Bạn chắc nhắn muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    BLL_IMPORTPRODUCT.instance.FuncPaymentInvoice(invoice, dataTable); // payment invoice
                    MessageBox.Show("Tạo thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ResetInvoice();
                }
            }
        }
        // button Print invoice
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("N3K STORE", new Font("Tahoma", 20, FontStyle.Bold), Brushes.Black, new Point(340, 50));
            e.Graphics.DrawString("54 NGUYỄN LƯƠNG BẰNG", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(280, 100));
            e.Graphics.DrawString("0911.888.999", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(350, 120));
            e.Graphics.DrawString("HÓA ĐƠN NHẬP HÀNG", new Font("Tahoma", 19, FontStyle.Bold), Brushes.Black, new Point(270, 180));
            e.Graphics.DrawString("Nhân viên: " + cbbStaff.SelectedItem.ToString(), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(260, 220));
            e.Graphics.DrawString("Nhà cung cấp: " + txtSupplier.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(260, 250));
            e.Graphics.DrawString("Số hóa đơn: " + txtIdInvoice.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(190, 300));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString("Tên sản phẩm", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("SL", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(360, 400));
            e.Graphics.DrawString("Giá nhập", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(440, 400));
            e.Graphics.DrawString("Thành tiền", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(580, 400));
            int distance = 400;
            string str;
            foreach (DataRow dr in dataTable.Rows)
            {
                distance += 50;
                str = "";
                if (dr["TenHangHoa"].ToString().Length > 30)
                {
                    str += dr["TenHangHoa"].ToString().Substring(31);
                    dr["TenHangHoa"] = dr["TenHangHoa"].ToString().Replace(str, "");
                }
                e.Graphics.DrawString(dr["TenHangHoa"].ToString() + "\n" + str, new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(10, distance));
                e.Graphics.DrawString(dr["SoLuong"].ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(370, distance));
                e.Graphics.DrawString(dr["GiaNhap"].ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(450, distance));
                e.Graphics.DrawString(dr["TongTien"].ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(590, distance));
            }
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50));
            e.Graphics.DrawString("Tổng tiền ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 2));
            e.Graphics.DrawString(txtTotalMoney.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 2));
            e.Graphics.DrawString("Giảm giá ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 3));
            e.Graphics.DrawString(String.Format("{0:n0}", totalMoney - intoMoney), new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 3));
            e.Graphics.DrawString("Tổng thanh toán ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 4));
            e.Graphics.DrawString(txtIntoMoney.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 4));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50 * 5));
            e.Graphics.DrawString("*** LƯU Ý: " + txtNote.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(50, distance + 50 * 6));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50 * 7));
            e.Graphics.DrawString("Cảm ơn và hẹn gặp lại!", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(250, distance + 50 * 8));
        }
        // print invoice
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0 || String.IsNullOrEmpty(txtSupplier.Text.Trim()))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        // back to frmManage_Data
        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmManage_Data frmManageData = new FrmManage_Data(usernameLogin);
            frmManageData.Show();
            this.Close();
        }
        // Note information
        private void txtNote_Enter(object sender, EventArgs e)
        {
            if(txtNote.Text == "Nhập thông tin ...")
            {
                txtNote.ForeColor = Color.Black;
                txtNote.Text = "";
            }
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.Text = "1";
            }
        }
        private void txtNote_Leave(object sender, EventArgs e)
        {
            if (txtNote.Text == "")
            {
                txtNote.ForeColor = Color.Silver;
                txtNote.Text = "Nhập thông tin ...";
            }
        }
        private void txtUpdateQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
