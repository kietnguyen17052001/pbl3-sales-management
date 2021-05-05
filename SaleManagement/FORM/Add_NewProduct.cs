using SaleManagement.BLL;
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
        string idInvoice, idProduct;
        int productQty, discount;
        double pricePro;
        public delegate void myDEL(string idInvoice);
        public myDEL d { get; set; }
        public FrmAdd_NewProduct(string _idInvoice)
        {
            InitializeComponent();
            idInvoice = _idInvoice;
            lbID_PRODUCT.Text += " "+ _idInvoice;
            SetCBB();
        }
        public void SetCBB()
        {
            cbbTYPE_OF_PRODUCT.Items.Add(new CBBItem { VALUE = "0", TEXT = "Tất cả" });
            cbbTYPE_OF_PRODUCT.Items.AddRange(BLL_ITEMS.Instance.GetCBBTypeProduct().ToArray());
            cbbTYPE_OF_PRODUCT.SelectedIndex = 0;
            ShowProduct();
        }
        public void ShowProduct()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
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
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if(dgvProduct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn loại hàng hóa cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tblChiTietHoaDonBanHang invoiceDetail = new tblChiTietHoaDonBanHang();
                idProduct = dgvProduct.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
                productQty = Convert.ToInt32(txtQUANTITY.Text);
                pricePro = Convert.ToDouble(dgvProduct.SelectedRows[0].Cells["GiaBan"].Value.ToString());
                discount = Convert.ToInt32(txtDISCOUNT.Text);
                invoiceDetail.MaHoaDonBan = idInvoice;
                invoiceDetail.MaHangHoa = idProduct;
                invoiceDetail.SoLuong = productQty;
                invoiceDetail.DonGia = pricePro;
                invoiceDetail.GiamGia = discount;
                invoiceDetail.TongTien = pricePro * productQty - pricePro * productQty * discount;
                DB.tblChiTietHoaDonBanHangs.Add(invoiceDetail);
                var product = DB.tblHangHoas.Find(idProduct);
                product.SoLuong -= productQty;
                var invoice = DB.tblHoaDonBanHangs.Find(idInvoice);
                invoice.SoTien += invoiceDetail.TongTien;
                DB.SaveChanges();
                d(idInvoice);
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
        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQUANTITY_TextChanged(object sender, EventArgs e)
        {
            //if (Convert.ToInt32(txtQUANTITY.Text) > Convert.ToInt32(dgvProduct.SelectedRows[0].Cells["SoLuong"].Value.ToString()))
            //{
            //    txtQUANTITY.Text = (Convert.ToInt32(txtQUANTITY.Text) / 10).ToString();
            //}
        }
    }
}
