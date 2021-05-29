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
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        string idInvoice, idProduct;
        int productQty, discount;
        double pricePro;
        public FrmAdd_NewProduct(string _idInvoice)
        {
            InitializeComponent();
            idInvoice = _idInvoice;
            lbID_PRODUCT.Text += " "+ _idInvoice;
            SetCBB();
            ShowProduct();
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProduct.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 8, FontStyle.Bold);
            dgvProduct.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            dgvProduct.Columns[0].HeaderText = "Mã h.hóa";
            dgvProduct.Columns[1].HeaderText = "Tên h.hóa";
            dgvProduct.Columns[2].HeaderText = "Số lượng";
            dgvProduct.Columns[3].HeaderText = "Giá bán";
        }
        public void SetCBB()
        {
            cbbTYPE_OF_PRODUCT.Items.Add(new CBBItem { VALUE = "0", TEXT = "Tất cả" });
            cbbTYPE_OF_PRODUCT.Items.AddRange(BLL_ITEMS.Instance.GetCBBTypeProduct().ToArray());
            cbbTYPE_OF_PRODUCT.SelectedIndex = 0;
        }
        public void ShowProduct()
        {
            if(cbbTYPE_OF_PRODUCT.SelectedIndex == 0)
            {
                var getProducts = DB.tblHangHoas.Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan,
                });
                dgvProduct.DataSource = getProducts.ToList();
            }
            else
            {
                var getProducts = DB.tblHangHoas.Where(p => p.MaLoaiHangHoa == ((CBBItem)cbbTYPE_OF_PRODUCT.SelectedItem).VALUE).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan,
                });
                dgvProduct.DataSource = getProducts.ToList();
            }
            txtDISCOUNT.Text = "0";
            txtQUANTITY.Text = "1";
        }
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }

        private void btnADD_PRODUCT_Click(object sender, EventArgs e)
        {
            idProduct = dgvProduct.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            productQty = Convert.ToInt32(txtQUANTITY.Text);
            pricePro = Convert.ToDouble(dgvProduct.SelectedRows[0].Cells["GiaBan"].Value.ToString());
            discount = Convert.ToInt32(txtDISCOUNT.Text);
            if (productQty > Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["SoLuong"].Value.ToString()))
            {
                lbSTATUS.Text = "KHÔNG ĐỦ SL";
            }
            else
            {
                lbSTATUS.Text = "";
                tblChiTietHoaDonBanHang invoiceDetail = new tblChiTietHoaDonBanHang();
                invoiceDetail.MaHoaDonBan = idInvoice;
                invoiceDetail.MaHangHoa = idProduct;
                invoiceDetail.SoLuong = productQty;
                invoiceDetail.DonGia = pricePro;
                invoiceDetail.GiamGia = discount;
                invoiceDetail.TongTien = pricePro * productQty - pricePro * productQty * discount/100;
                DB.tblChiTietHoaDonBanHangs.Add(invoiceDetail);
                var product = DB.tblHangHoas.Find(idProduct);
                product.SoLuong -= productQty;
                var invoice = DB.tblHoaDonBanHangs.Find(idInvoice);
                invoice.SoTien += invoiceDetail.TongTien;
                DB.SaveChanges();
                DialogResult dR = MessageBox.Show("Thêm thành công hàng hóa. Bạn có muốn tiếp tục thêm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dR == DialogResult.Yes)
                {
                    ShowProduct();
                }
                else
                {
                    this.Close();
                }
            }
        }
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            string information = txtSEARCH.Text.Trim();
            var product = DB.tblHangHoas.Where(p => p.MaHangHoa.Contains(information) || p.TenHangHoa.Contains(information)).Select(p => new {
                p.MaHangHoa,
                p.TenHangHoa,
                p.SoLuong,
                p.GiaBan,
            });
            dgvProduct.DataSource = product.ToList();
        }

        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập mã hoặc tên hàng hóa")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }

        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập mã hoặc tên hàng hóa";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQUANTITY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDISCOUNT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQUANTITY_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQUANTITY.Text))
            {
                txtQUANTITY.Text = "1";
            }
        }
        private void txtDISCOUNT_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDISCOUNT.Text))
            {
                txtDISCOUNT.Text = "0";
            }
        }
    }
}
