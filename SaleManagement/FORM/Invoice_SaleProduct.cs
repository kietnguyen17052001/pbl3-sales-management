﻿using SaleManagement.BLL;
using SaleManagement.Entity;
using SaleManagement.FORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.VIEW
{
    public partial class FrmBill : Form
    {
        int products = 1, allProduct = 0 , productQty = 0;
        string idProduct, nameProduct, idCustomer; //idCustomer cho chức năng Payment
        double productPrice = 0, 
            productDiscount = 0, 
            productsPrice = 0, 
            invoicePrice = 0, 
            invoiceDiscount = 0, 
            sendByCustomer = 0, 
            sendByStaff = 0, 
            totalMoney = 0;
        SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
        DataTable data = BLL_SALEPRODUCT.Instance.GetTbl_Order();
        public FrmBill()
        {
            InitializeComponent();
            setCombobox();
            rbID_ITEM.Checked = true;
            setDataForToolBox();
            var product = DB.tblHangHoas.Select(p => new {
                p.MaHangHoa,
                p.TenHangHoa,
                p.SoLuong,
                p.GiaBan
            });
            dgvInfoProduct.DataSource = product.ToList();
            dgvInvoice.DataSource = data;
            // set style for ColumnHeader dgvList and dgvSelect
            dgvInvoice.EnableHeadersVisualStyles = dgvInfoProduct.EnableHeadersVisualStyles = false;
            dgvInvoice.ColumnHeadersDefaultCellStyle.BackColor = dgvInfoProduct.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvInvoice.ColumnHeadersDefaultCellStyle.ForeColor = dgvInfoProduct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvInvoice.ColumnHeadersDefaultCellStyle.Font = dgvInfoProduct.ColumnHeadersDefaultCellStyle.Font = new Font("tahoma", 7, FontStyle.Bold);
            dgvInvoice.ColumnHeadersDefaultCellStyle.Padding = dgvInfoProduct.ColumnHeadersDefaultCellStyle.Padding = new Padding(5);
            // set heardertext for dgvList
            dgvInvoice.Columns[0].HeaderText = "Mã h.hóa";
            dgvInvoice.Columns[1].HeaderText = "Tên h.hóa";
            dgvInvoice.Columns[2].HeaderText = "Số lượng";
            dgvInvoice.Columns[3].HeaderText = "Giá(VNĐ)";
            dgvInvoice.Columns[4].HeaderText = "Khuyến mãi(%)";
            dgvInvoice.Columns[5].HeaderText = "Thành tiền(VNĐ)";
            // set heardertext for dgvselect
            dgvInfoProduct.Columns[0].HeaderText = "Mã h.hóa";
            dgvInfoProduct.Columns[1].HeaderText = "Tên h.hóa";
            dgvInfoProduct.Columns[2].HeaderText = "Số lượng";
            dgvInfoProduct.Columns[3].HeaderText = "Giá(VNĐ)";
        }
        // Thiết lập dữ liệu cho các textbox
        public void setDataForToolBox()
        {
            sendByCustomer = invoicePrice = BLL_SALEPRODUCT.Instance.getPrice_Invoice(data, invoiceDiscount); // tổng thanh toán đơn hàng
            totalMoney = BLL_SALEPRODUCT.Instance.GetTotal_Money(data); // tổng tiền đơn hàng
            productQty = BLL_SALEPRODUCT.Instance.getAll_ProQty(data); // Tổng số lượng hàng 
            allProduct = BLL_SALEPRODUCT.Instance.getAll_Product(data); // Tổng loại hàng
            txtID_INVOICE.Text = BLL_SALEPRODUCT.Instance.getNewIdInvoice(); // khởi tạo mã hóa đơn mới
            txtINVOICE_DISCOUNT.Text = String.Format("{0:n0}", invoiceDiscount);
            txtPRODUCT_DISCOUNT.Text = productDiscount.ToString();
            txtALL_PRODUCT_QTY.Text = productQty.ToString();
            txtPRODUCTS_QUANTITY.Text = allProduct.ToString();
            txtPRODUCT_QUANTITY_SELECY.Text = products.ToString();
            txtINVOICE_PRICE.Text = String.Format("{0:n0}", invoicePrice);
            txtTOTAL_MONEY.Text = String.Format("{0:n0}", totalMoney);
            txtSEND_BY_CUSTOMER.Text = String.Format("{0:n0}", sendByCustomer);
            txtSEND_BY_STAFF.Text = String.Format("{0:n0}", sendByStaff);
        }
        // set data for Cbb
        public void setCombobox()
        {
            cbbTYPE_OF_ITEMS.Items.Add("Tất cả");
            cbbSTAFF.Items.Add("None");
            cbbTYPE_OF_ITEMS.Items.AddRange(BLL_ITEMS.Instance.GetCBBTypeProduct().ToArray());
            cbbSTAFF.Items.AddRange(BLL_SALEPRODUCT.Instance.GetCbb_Staff().ToArray());
            cbbTYPE_OF_ITEMS.SelectedIndex = cbbSTAFF.SelectedIndex = 0;
        }
        // load data
        public void load()
        {
            data = BLL_SALEPRODUCT.Instance.GetTbl_Order();
            totalMoney = invoicePrice = sendByCustomer = sendByStaff = allProduct = productQty = 0;
            invoiceDiscount = 0;
            products = 1;
            productDiscount = 0;
            txtCUSTOMER.Text = "";
            cbbSTAFF.SelectedIndex = 0;
            btnDELETE.Enabled = true;
            btnADD.Enabled = true;
            btnEDIT.Enabled = true;
            dgvInvoice.DataSource = data;
            setDataForToolBox();
        }
        // Thiết lập giá trị cho txt Giảm giá và Tổng thanh toán sau khi giảm theo % 
        public void setDiscountPercent(string PERCENT)
        {
            sendByCustomer = invoicePrice = BLL_SALEPRODUCT.Instance.getPrice_Invoice(data, (BLL_SALEPRODUCT.Instance.GetTotal_Money(data) * Convert.ToDouble(PERCENT) / 100));
            invoiceDiscount = BLL_SALEPRODUCT.Instance.GetTotal_Money(data) * Convert.ToDouble(PERCENT) / 100;
            txtINVOICE_PRICE.Text = String.Format("{0:n0}", invoicePrice);
            txtINVOICE_DISCOUNT.Text = String.Format("{0:n0}", invoiceDiscount);
            txtSEND_BY_CUSTOMER.Text = String.Format("{0:n0}", sendByCustomer);
        }
        // Thiết lập giá trị cho txt Giảm giá và Tổng thanh toán sau khi giảm theo số tiền
        public void setDiscountMoney(string MONEY)
        {
            sendByCustomer = invoicePrice = BLL_SALEPRODUCT.Instance.getPrice_Invoice(data, Convert.ToDouble(MONEY));
            invoiceDiscount = Convert.ToDouble(MONEY);
            txtINVOICE_PRICE.Text = String.Format("{0:n0}", invoicePrice); // định dạng lại chuỗi, 2000 -> 2.000
            txtINVOICE_DISCOUNT.Text = String.Format("{0:n0}", invoiceDiscount);
            txtSEND_BY_CUSTOMER.Text = String.Format("{0:n0}", sendByCustomer);
        }
        // Lựa chọn khách hàng
        public void setCustomer(string idCus, string nameCus)
        {
            idCustomer = idCus;
            txtCUSTOMER.Text = nameCus;
        }
        public void ShowProduct()
        {
            if (cbbTYPE_OF_ITEMS.SelectedIndex == 0)
            {
                var product = DB.tblHangHoas.Select(p => new {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan
                });
                dgvInfoProduct.DataSource = product.ToList();
            }
            else
            {
                var product = DB.tblHangHoas.Where(p => p.MaLoaiHangHoa == ((CBBItem)cbbTYPE_OF_ITEMS.SelectedItem).VALUE).Select(p => new {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan
                });
                dgvInfoProduct.DataSource = product.ToList();
            }
        }
        // set backColor and Font for rows in DGV
        private void dgvInfoProduct_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvInfoProduct.DefaultCellStyle.BackColor = Color.Azure;
            dgvInfoProduct.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        private void dgvInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvInvoice.DefaultCellStyle.BackColor = Color.OldLace;
            dgvInvoice.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular);
        }
        // back to FrmQuanLyBanHang
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management FRM = new FrmSale_Management();
            FRM.Show();
            this.Close();
        }
        // Btn liệt kê hàng hóa theo loại hàng hóa
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }
        // search product
        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            if (rbID_ITEM.Checked == true)
            {
                BLL_SALEPRODUCT.Instance.FuncSearchId(dgvInfoProduct, txtSEARCH.Text);
            }
            else
            {
                BLL_SALEPRODUCT.Instance.FuncSearchName(dgvInfoProduct, txtSEARCH.Text);
            }
        }
        // add product
        private void btnADD_Click(object sender, EventArgs e)
        {
            idProduct = dgvInfoProduct.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(); // Mã hàng hóa
            nameProduct = dgvInfoProduct.SelectedRows[0].Cells["TenHangHoa"].Value.ToString(); // Tên hàng hóa
            products = Convert.ToInt32(txtPRODUCT_QUANTITY_SELECY.Text); // Số lượng hàng hóa từ txtAMOUNT_ITEM
            productPrice = Convert.ToDouble(dgvInfoProduct.SelectedRows[0].Cells["GiaBan"].Value.ToString()); // Giá hàng hóa
            productDiscount = Convert.ToDouble(txtPRODUCT_DISCOUNT.Text); // Giảm giá theo hàng hóa từ txtDISCOUNT_ITEM
            productsPrice = products * productPrice - products * productPrice * productDiscount / 100; // Tổng thanh toán trước khi giảm giá hóa đơn
            if (products > Convert.ToInt32(dgvInfoProduct.SelectedRows[0].Cells["SoLuong"].Value.ToString())) // Kiểm tra số lượng
            {
                MessageBox.Show("Không đủ số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BLL_SALEPRODUCT.Instance.AddItem(data, idProduct, nameProduct, products, productPrice, productDiscount, productsPrice);
                int remain = Convert.ToInt32(dgvInfoProduct.SelectedRows[0].Cells["SoLuong"].Value.ToString()) - products;
                dgvInfoProduct.SelectedRows[0].Cells["SoLuong"].Value = remain.ToString();// Giảm số lượng hàng hóa sau khi thêm
            }
            // Thông tin hóa đơn sau khi thêm hàng hóa
            setDataForToolBox();
        }
        // delete product
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> LIST = new List<string>();
            DataGridViewSelectedRowCollection dgvsrc = dgvInvoice.SelectedRows;
            foreach (DataGridViewRow i in dgvsrc)
            {
                LIST.Add(i.Cells[0].Value.ToString());
            }
            BLL_SALEPRODUCT.Instance.DelItem(LIST, data);
            // Dữ liệu hóa đơn sau khi xóa hàng hóa
            setDataForToolBox();
        }
        // add customer -> load form CREATE_NEWCUSTOMER -> choose or add new customer
        private void btnCUSTOMER_Click(object sender, EventArgs e)
        {
            FrmSelect_Customer frm = new FrmSelect_Customer(); // gọi form khách hàng để lựa chọn khách hàng cũ hoặc thêm khách mới
            frm.d += new FrmSelect_Customer.myDEL(setCustomer);
            frm.Show();
        }
        // Btn thanh toán
        private void btnPAYMENT_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("Không thể thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tblHoaDonBanHang newInvoice = new tblHoaDonBanHang();
                if (string.IsNullOrEmpty(txtID_INVOICE.Text) || invoicePrice == 0 || cbbSTAFF.SelectedIndex == 0 || string.IsNullOrEmpty(txtCUSTOMER.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    newInvoice.MaHoaDonBan = txtID_INVOICE.Text;
                    newInvoice.MaNhanVien = ((CBBItem)cbbSTAFF.SelectedItem).VALUE;
                    newInvoice.NgayBan = dpDAY.Value;
                    newInvoice.MaKhachHang = idCustomer;
                    newInvoice.SoTien = invoicePrice;
                    newInvoice.GiamGia = invoiceDiscount;
                    try
                    {
                        DialogResult dialogResult = MessageBox.Show("Bạn chắc nhắn muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            MessageBox.Show("Tạo thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BLL_SALEPRODUCT.Instance.FuncPayment(newInvoice, data); // payment invoice
                            ShowProduct();
                            load();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Tạo hóa đơn thất bại. Mã đơn bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }   
        }
        // load invoice
        private void btnLOAD_Click(object sender, EventArgs e)
        {
            load(); // load new invoice
        }
        // Btn giảm theo phần trăm, gọi form Discount_Percent
        private void btnDISCOUNT_PERCENT_Click(object sender, EventArgs e)
        {
            FrmDiscount_Percent FRM = new FrmDiscount_Percent();
            FRM.d += new FrmDiscount_Percent.myDEL(setDiscountPercent);
            FRM.Show();
        }
        private void txtDISCOUNT_ITEM_TextChanged(object sender, EventArgs e)
        {
            if (txtPRODUCT_DISCOUNT.Text == "")
            {
                txtPRODUCT_DISCOUNT.Text = "0";
            }
            if (Convert.ToInt32(txtPRODUCT_DISCOUNT.Text) > 100)
            {
                txtPRODUCT_DISCOUNT.Text = "100";
            }
        }
        private void txtAMOUNT_ITEM_TextChanged(object sender, EventArgs e)
        {
            if (txtPRODUCT_QUANTITY_SELECY.Text == "")
            {
                txtPRODUCT_QUANTITY_SELECY.Text = "1";
            }
        }
        // Btn giảm theo số tiền, gọi form Discount_Money
        private void btnDISCOUNT_MONEY_Click(object sender, EventArgs e)
        {
            FrmDiscount_Money FRM = new FrmDiscount_Money(totalMoney);
            FRM.d += new FrmDiscount_Money.myDEL(setDiscountMoney);
            FRM.Show();
        }
        // Btn in giao diện cho hóa đơn
        private void btnPRINT_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count == 0 || cbbSTAFF.SelectedIndex == 0 || string.IsNullOrEmpty(txtCUSTOMER.Text))
            {
                MessageBox.Show("Không thể thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }
        // GUI bill
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("N3K STORE", new Font("Tahoma", 20, FontStyle.Bold), Brushes.Black, new Point(340,50));
            e.Graphics.DrawString("54 NGUYỄN LƯƠNG BẰNG", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(280, 100));
            e.Graphics.DrawString("0911.888.999", new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(350, 120));
            e.Graphics.DrawString("HÓA ĐƠN TÍNH TIỀN", new Font("Tahoma", 19, FontStyle.Bold), Brushes.Black, new Point(290, 180));
            e.Graphics.DrawString("NVTN: "+ cbbSTAFF.SelectedItem.ToString(), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(300, 220));
            e.Graphics.DrawString("Khách hàng: "+ txtCUSTOMER.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(300, 250));
            e.Graphics.DrawString("Số Bill: "+ txtID_INVOICE.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString("Ngày: "+ DateTime.Now.ToString("dd/MM/yyyy HH:mm"), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(380, 300));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10,350));
            e.Graphics.DrawString("Tên sản phẩm" , new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("SL", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(360, 400));
            e.Graphics.DrawString("Đơn giá", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(440, 400));
            e.Graphics.DrawString("K/Mãi", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(580, 400));
            e.Graphics.DrawString("Thành tiền", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(700, 400));
            int distance = 400;
            string str;
            foreach(DataRow dr in data.Rows)
            {
                distance += 50;
                str = "";
                if(dr["TenhangHoa"].ToString().Length > 30)
                {
                    str += dr["TenHangHoa"].ToString().Substring(31);
                    dr["TenHangHoa"] = dr["TenHangHoa"].ToString().Replace(str, "");
                }
                e.Graphics.DrawString(dr["TenHangHoa"].ToString() + "\n" + str, new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(10, distance));
                e.Graphics.DrawString(dr["SoLuong"].ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(370, distance));
                e.Graphics.DrawString(dr["DonGia(VNĐ)"].ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(450, distance));
                e.Graphics.DrawString(dr["KhuyenMai(%)"].ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(590, distance));
                e.Graphics.DrawString(dr["ThanhTien(VNĐ)"].ToString(), new Font("Tahoma", 14, FontStyle.Regular), Brushes.Black, new Point(710, distance));
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance+50));
            e.Graphics.DrawString("Tổng tiền ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*2));
            e.Graphics.DrawString(txtTOTAL_MONEY.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*2));
            e.Graphics.DrawString("Giảm giá ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*3));
            e.Graphics.DrawString(txtINVOICE_DISCOUNT.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*3));
            e.Graphics.DrawString("Tổng thanh toán ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*4));
            e.Graphics.DrawString(txtINVOICE_PRICE.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*4));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50*5));
            e.Graphics.DrawString("*** LƯU Ý: " + txtNOTE.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(50, distance + 50*6));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50*7));
            e.Graphics.DrawString("Cảm ơn và hẹn gặp lại quý khách!", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(250, distance + 50 * 8));
        }
        // set new quantity for product
        public void setNewQtyForProduct(int newQty)
        {
            dgvInvoice.SelectedRows[0].Cells["SoLuong"].Value = newQty;
            double newPrice = (productPrice * newQty - productPrice * newQty * productDiscount / 100);
            dgvInvoice.SelectedRows[0].Cells["ThanhTien(VNĐ)"].Value = String.Format("{0:n0}",newPrice);
            setDataForToolBox();
        }
        // edit quantity product
        private void btnEDIT_Click(object sender, EventArgs e)
        {
            FrmEditQty_CreateInvoice frm = new FrmEditQty_CreateInvoice(idProduct);
            frm.d += new FrmEditQty_CreateInvoice.myDEL(setNewQtyForProduct);
            frm.Show();
        }
        // back to frmQuanLyDuLieu
        private void btnBACK_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc chắn quay lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                FrmManage_Data frm = new FrmManage_Data();
                frm.Show();
                this.Close();
            }
            else
            {
                return;
            }
        }
        private void txtNOTE_Leave(object sender, EventArgs e)
        {
            if(txtNOTE.Text == "")
            {
                txtNOTE.Text = "Nhập thông tin ...";
                txtNOTE.ForeColor = Color.Silver;
            }
        }
        private void txtNOTE_Enter(object sender, EventArgs e)
        {
            if (txtNOTE.Text == "Nhập thông tin ...")
            {
                txtNOTE.Text = "";
                txtNOTE.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Enter(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "Nhập thông tin cần tìm kiếm")
            {
                txtSEARCH.Text = "";
                txtSEARCH.ForeColor = Color.Black;
            }
        }
        private void txtSEARCH_Leave(object sender, EventArgs e)
        {
            if (txtSEARCH.Text == "")
            {
                txtSEARCH.Text = "Nhập thông tin cần tìm kiếm";
                txtSEARCH.ForeColor = Color.Silver;
            }
        }
        private void txtAMOUNT_ITEM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtDISCOUNT_ITEM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtSEND_BY_CUSTOMER_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        // Số tiền khách hàng trả
        private void txtSEND_BY_CUSTOMER_TextChanged(object sender, EventArgs e)
        {
            if(txtSEND_BY_CUSTOMER.Text == "")
            {
                txtSEND_BY_CUSTOMER.Text = "0";
            }
            sendByCustomer = Convert.ToDouble(txtSEND_BY_CUSTOMER.Text);
            sendByStaff = sendByCustomer - invoicePrice;
            txtSEND_BY_STAFF.Text = String.Format("{0:n0}", sendByStaff);
        }
    }
}
