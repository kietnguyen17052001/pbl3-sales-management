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
    public partial class FrmAdd_NewProduct : Form
    {
        private string idInvoice, idProduct;
        private int quantityProduct, discount;
        private double productPrice;
        private bool isListSale;
        public delegate void myDel(string _idInvoice);
        public myDel d { get; set; }
        public FrmAdd_NewProduct(string _idInvoice, bool _isListSale)
        {
            InitializeComponent();
            isListSale = _isListSale;
            idInvoice = _idInvoice;
            lbID_PRODUCT.Text += " "+ _idInvoice;
            if (isListSale) {
                btnAddNewProduct.Enabled = false;
            }
            else
            {
                btnAddNewProduct.Enabled = true;
                txtDiscount.Enabled = false;
            }
            LoadProduct();
            FormatColumnHeader();
        }
        public void FormatColumnHeader()
        {
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProduct.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 8, FontStyle.Bold);
            dgvProduct.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvProduct.Columns[0].HeaderText = "Mã h.hóa";
            dgvProduct.Columns[1].HeaderText = "Tên h.hóa";
            dgvProduct.Columns[2].HeaderText = "Số lượng";
            if (isListSale)
            {
                dgvProduct.Columns[3].HeaderText = "Giá bán";
            }
            else
            {
                dgvProduct.Columns[3].HeaderText = "Giá nhập";
            }
        }
        public void LoadProduct()
        {
            BLL_PRODUCT.Instance.LoadDataProductInFrmAddProduct(dgvProduct, isListSale);
        }
        // load product by nameProduct
        public void newProduct(string nameProduct)
        {
            BLL_PRODUCT.Instance.FuncSearchProductInFrmAddProduct(dgvProduct, nameProduct, isListSale);
        }
        // add new product
        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            FrmCreate_NewProduct frm = new FrmCreate_NewProduct();
            frm.d += new FrmCreate_NewProduct.myDel(newProduct);
            frm.Show();
        }
        // add product for invoice
        private void btnAddProductForInvoice_Click(object sender, EventArgs e)
        {
            idProduct = dgvProduct.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            quantityProduct = Convert.ToInt32(txtQuantity.Text.Trim());
            productPrice = Convert.ToDouble(dgvProduct.SelectedRows[0].Cells[3].Value.ToString());
            discount = Convert.ToInt32(txtDiscount.Text.Trim());
            switch (isListSale)
            {
                case true:
                    if (quantityProduct > Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["SoLuong"].Value.ToString()))
                    {
                        lbSTATUS.Text = "KHÔNG ĐỦ SL";
                    }
                    else
                    {
                        lbSTATUS.Text = "";

                        if (BLL_LISTSALEINVOICE.Instance.isHasProductInInvoice(idInvoice, idProduct))
                        {
                            MessageBox.Show("Hàng hóa đã tồn tại trong hóa đơn!", "Trùng hàng hóa",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tblChiTietHoaDonBanHang invoiceDetail = new tblChiTietHoaDonBanHang();
                            invoiceDetail.MaHoaDonBan = idInvoice;
                            invoiceDetail.MaHangHoa = idProduct;
                            invoiceDetail.SoLuong = quantityProduct;
                            invoiceDetail.DonGia = productPrice;
                            invoiceDetail.GiamGia = discount;
                            invoiceDetail.TongTien = productPrice * quantityProduct - productPrice * quantityProduct 
                                * discount / 100;
                            BLL_LISTSALEINVOICE.Instance.FuncAddProduct(invoiceDetail);
                            DialogResult answer = MessageBox.Show("Thêm thành công hàng hóa. Bạn có muốn tiếp tục thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (answer == DialogResult.Yes)
                            {
                                LoadProduct();
                            }
                            else
                            {
                                d(idInvoice);
                                this.Close();
                            }
                        }
                    }
                    break;
                case false:
                    if (BLL_LISTIMPORTINVOICE.Instance.isHasProductInInvoice(idInvoice, idProduct))
                    {
                        MessageBox.Show("Hàng hóa đã tồn tại trong hóa đơn!", "Trùng hàng hóa",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        tblChiTietHoaDonNhapHang invoicedetail = new tblChiTietHoaDonNhapHang();
                        invoicedetail.MaHoaDonNhap = idInvoice;
                        invoicedetail.MaHangHoa = idProduct;
                        invoicedetail.SoLuong = quantityProduct;
                        invoicedetail.GiaNhap = productPrice;
                        invoicedetail.TongTien = productPrice * quantityProduct;
                        BLL_LISTIMPORTINVOICE.Instance.FuncAddProduct(invoicedetail);
                        DialogResult answer = MessageBox.Show("Thêm thành công hàng hóa. Bạn có muốn tiếp tục thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (answer == DialogResult.Yes)
                        {
                            LoadProduct();
                        }
                        else
                        {
                            d(idInvoice);
                            this.Close();
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string information = txtSearch.Text.Trim();
            BLL_PRODUCT.Instance.FuncSearchProductInFrmAddProduct(dgvProduct, information, isListSale);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Nhập mã hoặc tên hàng hóa, loại hàng hóa")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Nhập mã hoặc tên hàng hóa, loại hàng hóa";
                txtSearch.ForeColor = Color.Silver;
            }
        }
        

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        // set backColor and Font for DGV
        private void dgvProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvProduct.DefaultCellStyle.BackColor = Color.OldLace;
            dgvProduct.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantity.Text))
            {
                txtQuantity.Text = "1";
            }
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text))
            {
                txtDiscount.Text = "0";
            }
        }
    }
}
