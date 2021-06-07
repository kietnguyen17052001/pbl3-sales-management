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
    public partial class FrmInvoice_ImportProduct : Form
    {
        private bool isAdmin;
        private DataTable dataTable = BLL_IMPORTPRODUCT.instance.TableInvoice();
        private string idProduct, idSupplier;
        private double intoMoney, totalMoney;
        public FrmInvoice_ImportProduct(bool _isAdmin)
        {
            isAdmin = _isAdmin;
            InitializeComponent();
            LoadDGVs();
            FormatHeaderCell();
            setCbbStaff();
            txtIdInvoice.Text = BLL_IMPORTPRODUCT.instance.getNewIdInvoice();
        }
        public void setCbbStaff()
        {
            cbbStaff.Items.AddRange(BLL_STAFF.Instance.getCbbStaff().ToArray());
            cbbStaff.SelectedIndex = 0;
        }
        // Load data for DGVs
        public void LoadDGVs()
        {
            BLL_IMPORTPRODUCT.instance.LoadDataProduct(dgvInfoProduct);
            dgvInvoice.DataSource = dataTable;
        }
        public void LoadForm()
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
        // button Home -> back to frmSaleManagement
        private void btnHome_Click(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                FrmMain_Admin frm = new FrmMain_Admin();
                frm.Show();
            }
            else
            {
                FrmMain_Member frm = new FrmMain_Member();
                frm.Show();
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
            FrmCreate_NewProduct frm = new FrmCreate_NewProduct();
            frm.d += new FrmCreate_NewProduct.myDel(NewProduct);
            frm.Show();
        }
        // Select product
        private void btnSelect_Click(object sender, EventArgs e)
        {
            idProduct = dgvInfoProduct.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            BLL_IMPORTPRODUCT.instance.SelectProduct(dataTable, idProduct, Convert.ToInt32(txtQuantity.Text));
            LoadDGVs();
            setValue(true, 0);
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
            BLL_IMPORTPRODUCT.instance.FuncUpdateProductQty(dataTable, idProduct, Convert.ToInt32(txtUpdateQuantity.Text));
            LoadDGVs();
            setValue(true, 0);
        }
        private void txtUpdateQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUpdateQuantity.Text))
            {
                txtUpdateQuantity.Text = "1";
            }
        }
        // button Delete product
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<String> listIdProduct = new List<String>();
            DataGridViewSelectedRowCollection data = dgvInvoice.SelectedRows;
            foreach(DataGridViewRow dgvRow in data)
            {
                listIdProduct.Add(dgvRow.Cells["MaHangHoa"].Value.ToString());
            }
            BLL_IMPORTPRODUCT.instance.FuncDeleteProduct(listIdProduct, dataTable);
            setValue(true, 0);
        }
        // ---------- Thanh toán ----------
        public void setValue(bool isPercent, double value)
        {
            totalMoney = BLL_IMPORTPRODUCT.instance.getTotalMoney(dataTable);
            intoMoney = BLL_IMPORTPRODUCT.instance.getIntoMoney(dataTable, isPercent, value);
            txtTotalMoney.Text = String.Format("{0:n0}", totalMoney);
            txtIntoMoney.Text = String.Format("{0:n0}", intoMoney);
        }
        // replace into money
        private void txtPercent_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPercent.Text))
            {
                txtPercent.Text = "0";
            }
            setValue(true, Convert.ToDouble(txtPercent.Text));
        }

        private void txtMoney_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMoney.Text))
            {
                txtMoney.Text = "0";
            }
            setValue(false, Convert.ToDouble(txtMoney.Text));
        }
        // button Payment invoice
        private void btnPayment_Click(object sender, EventArgs e)
        {
            tblHoaDonNhapHang newInvoice = new tblHoaDonNhapHang();
            if (string.IsNullOrEmpty(txtIdInvoice.Text) || string.IsNullOrEmpty(txtSupplier.Text)
                || dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                newInvoice.MaHoaDonNhap = txtIdInvoice.Text;
                newInvoice.MaNhanVien = ((CBBItem)cbbStaff.SelectedItem).VALUE;
                newInvoice.NgayNhap = dpDayCreate.Value;
                newInvoice.MaNhaCungCap = idSupplier;
                newInvoice.SoTien = intoMoney;
                newInvoice.GiamGia = totalMoney - intoMoney;
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn chắc nhắn muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show("Tạo thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        BLL_IMPORTPRODUCT.instance.FuncPaymentInvoice(newInvoice, dataTable); // payment invoice
                        LoadDGVs();
                        LoadForm();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Tạo hóa đơn thất bại. Mã đơn bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // button Print invoice
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("N3K STORE", new Font("Tahoma", 20, FontStyle.Bold), Brushes.Black, new Point(340, 50));
            e.Graphics.DrawString("54 NGUYỄN LƯƠNG BẰNG", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(280, 100));
            e.Graphics.DrawString("0911.888.999", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(350, 120));
            e.Graphics.DrawString("HÓA ĐƠN THANH TOÁN", new Font("Tahoma", 19, FontStyle.Bold), Brushes.Black, new Point(290, 180));
            e.Graphics.DrawString("Nhân viên: " + cbbStaff.SelectedItem.ToString(), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(300, 220));
            e.Graphics.DrawString("Nhà cung cấp: " + txtSupplier.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(300, 250));
            e.Graphics.DrawString("Số hóa đơn: " + txtIdInvoice.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, 350));
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
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50));
            e.Graphics.DrawString("Tổng tiền ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 2));
            e.Graphics.DrawString(txtTotalMoney.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 2));
            e.Graphics.DrawString("Giảm giá ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 3));
            e.Graphics.DrawString(String.Format("{0:n0}", totalMoney - intoMoney), new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 3));
            e.Graphics.DrawString("Tổng thanh toán ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50 * 4));
            e.Graphics.DrawString(txtIntoMoney.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50 * 4));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50 * 5));
            e.Graphics.DrawString("*** LƯU Ý: " + txtNote.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(50, distance + 50 * 6));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50 * 7));
            e.Graphics.DrawString("Cảm ơn và hẹn gặp lại!", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(250, distance + 50 * 8));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0 || string.IsNullOrEmpty(txtSupplier.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        // Format cell DGV
        private void dgvInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvInvoice.DefaultCellStyle.BackColor = Color.OldLace;
            dgvInvoice.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
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
