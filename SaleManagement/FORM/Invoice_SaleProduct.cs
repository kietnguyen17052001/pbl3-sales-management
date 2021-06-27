using SaleManagement.BLL;
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
    public partial class FrmInvoice_SaleProduct : Form
    {
        private bool isAdmin;
        private string usernameLogin;
        private int qtyOfSelectProduct, allProduct, productQty;
        private string idProduct, idCustomer; //idCustomer cho chức năng Payment
        private double 
            productDiscount, 
            invoicePrice, 
            invoiceDiscount, 
            sendByCustomer, 
            sendByStaff, 
            totalMoney;
        private DataTable dataTable = BLL_SALEPRODUCT.Instance.TableInvoice();
        public FrmInvoice_SaleProduct(bool _isAdmin, string _usernameLogin)
        {  
            InitializeComponent();
            isAdmin = _isAdmin;
            usernameLogin = _usernameLogin;
            if (isAdmin == false)
            {
                btnBack.Enabled = false;
            }
            setComboboxStaff();
            setDataForToolBox();
            LoadDGVs();
            FormatHeader();
        }
        public void FormatHeader()
        {
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
            sendByCustomer = invoicePrice = BLL_SALEPRODUCT.Instance.getIntoMoney(dataTable, invoiceDiscount); // tổng thanh toán đơn hàng
            totalMoney = BLL_SALEPRODUCT.Instance.getTotalMoney(dataTable); // tổng tiền đơn hàng
            productQty = BLL_SALEPRODUCT.Instance.getTotalQuantityProduct(dataTable); // Tổng số lượng hàng 
            allProduct = BLL_SALEPRODUCT.Instance.getTotalProduct(dataTable); // Tổng loại hàng
            txtIdInvoice.Text = BLL_SALEPRODUCT.Instance.getNewIdInvoice(); // khởi tạo mã hóa đơn mới
            txtDiscount.Text = String.Format("{0:n0}", invoiceDiscount);
            txtProductDiscount.Text = "0";
            txtTotalQuantity.Text = productQty.ToString();
            txtTotalProduct.Text = allProduct.ToString();
            txtQuantityOfSelect.Text = "1";
            txtPriceInvoice.Text = String.Format("{0:n0}", invoicePrice);
            txtTotalMoney.Text = String.Format("{0:n0}", totalMoney);
            txtCustomerPay.Text = String.Format("{0:n0}", sendByCustomer);
            txtReturnMoney.Text = String.Format("{0:n0}", sendByStaff);
        }
        // set data for cbbStaff
        public void setComboboxStaff()
        {
            cbbStaff.Items.AddRange(BLL_STAFF.Instance.getCbbStaff().ToArray());
            if (isAdmin == false)
            {
                cbbStaff.Text = BLL_STAFF.Instance.getStaffById(usernameLogin);
            }
            else { cbbStaff.SelectedIndex = 0; }
        }
        // load dataTable
        public void ResetInvoice()
        {
            dataTable.Clear();
            totalMoney = invoicePrice = sendByCustomer = sendByStaff = allProduct = productQty = 0;
            invoiceDiscount = 0;
            qtyOfSelectProduct = 1;
            productDiscount = 0;
            txtCustomer.Clear();
            cbbStaff.SelectedIndex = 0;
            btnDeleteProduct.Enabled = true;
            btnSelectProduct.Enabled = true;
            btnEditQuantity.Enabled = true;;
            setDataForToolBox();
        }
        // Thiết lập giá trị cho txt Giảm giá và Tổng thanh toán sau khi giảm theo % 
        public void setDiscountPercent(string percent)
        {
            sendByCustomer = invoicePrice = Math.Round(BLL_SALEPRODUCT.Instance.getIntoMoney(dataTable, (BLL_SALEPRODUCT.Instance.getTotalMoney(dataTable) * Convert.ToDouble(percent) / 100)));
            invoiceDiscount = BLL_SALEPRODUCT.Instance.getTotalMoney(dataTable) * Convert.ToDouble(percent) / 100;
            txtPriceInvoice.Text = String.Format("{0:n0}", invoicePrice);
            txtDiscount.Text = String.Format("{0:n0}", invoiceDiscount);
            txtCustomerPay.Text = String.Format("{0:n0}", sendByCustomer);
        }
        // Thiết lập giá trị cho txt Giảm giá và Tổng thanh toán sau khi giảm theo số tiền
        public void setDiscountMoney(string money)
        {
            sendByCustomer = invoicePrice = BLL_SALEPRODUCT.Instance.getIntoMoney(dataTable, Convert.ToDouble(money));
            invoiceDiscount = Convert.ToDouble(money);
            txtPriceInvoice.Text = String.Format("{0:n0}", invoicePrice); // định dạng lại chuỗi, 2000 -> 2.000
            txtDiscount.Text = String.Format("{0:n0}", invoiceDiscount);
            txtCustomerPay.Text = String.Format("{0:n0}", sendByCustomer);
        }
        // Lựa chọn khách hàng
        public void setCustomer(string _idCustomer, string nameCustomer)
        {
            idCustomer = _idCustomer;
            txtCustomer.Text = nameCustomer;
        }
        public void LoadDGVs()
        {
            BLL_SALEPRODUCT.Instance.LoadDataProduct(dgvInfoProduct);
            dgvInvoice.DataSource = dataTable;
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
        private void btnHome_Click(object sender, EventArgs e)
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
        // search product
        private void txtProduct_TextChanged(object sender, EventArgs e)
        {
            BLL_SALEPRODUCT.Instance.FuncSearchProduct(dgvInfoProduct, txtProduct.Text.Trim());
        }
        // add product
        private void btnSelectProduct_Click(object sender, EventArgs e)
        {
            idProduct = dgvInfoProduct.SelectedRows[0].Cells["MaHangHoa"].Value.ToString();
            qtyOfSelectProduct = Convert.ToInt32(txtQuantityOfSelect.Text); // Số lượng hàng hóa từ txtQuantityOfSelect
            productDiscount = Convert.ToInt32(txtProductDiscount.Text);
            if (BLL_SALEPRODUCT.Instance.isValidQuantityProduct(dataTable, idProduct, qtyOfSelectProduct)) // Kiểm tra số lượng
            {
                BLL_SALEPRODUCT.Instance.FuncAddProduct(dataTable, idProduct, qtyOfSelectProduct, productDiscount);
            }
            else
            {
                MessageBox.Show("Không đủ số lượng hàng hóa để thêm vào đơn", "Lỗi thêm hàng hóa vào đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Thông tin hóa đơn sau khi thêm hàng hóa
            setDataForToolBox();
        }
        // delete product
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            List<string> ListIdProduct = new List<string>();
            DataGridViewSelectedRowCollection data = dgvInvoice.SelectedRows;
            foreach (DataGridViewRow dgvRow in data)
            {
                ListIdProduct.Add(dgvRow.Cells[0].Value.ToString());
            }
            BLL_SALEPRODUCT.Instance.FuncDeleteProduct(ListIdProduct, dataTable);
            // Dữ liệu hóa đơn sau khi xóa hàng hóa
            setDataForToolBox();
        }
        //add customer -> load form CREATE_NEWCUSTOMER -> choose or add new customer
        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            FrmSelect_Customer frm = new FrmSelect_Customer(); // gọi form khách hàng để lựa chọn khách hàng cũ hoặc thêm khách mới
            frm.d += new FrmSelect_Customer.myDEL(setCustomer);
            frm.Show();
        }
        //Btn thanh toán
        private void btnPayment_Click(object sender, EventArgs e)
        {
            string message = "Thông tin lỗi:\n";
            if (string.IsNullOrEmpty(txtIdInvoice.Text) 
                || string.IsNullOrEmpty(txtCustomer.Text)
                || (dataTable.Rows.Count == 0) || (sendByCustomer < invoicePrice))
            {
                if (string.IsNullOrEmpty(txtIdInvoice.Text))
                {
                    message += "+ Mã hóa đơn trống\n";
                }
                if (string.IsNullOrEmpty(txtCustomer.Text))
                {
                    message += "+ Khách hàng trống\n";
                }
                if (dataTable.Rows.Count == 0)
                {
                    message += "+ Hóa đơn trống sản phẩm\n";
                }
                if(sendByCustomer < invoicePrice)
                {
                    message += "+ Số tiền của khách hàng trả không hợp lệ\n";
                }
                MessageBox.Show(message, "Lỗi tạo đơn", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            else
            {
                tblHoaDonBanHang newInvoice = new tblHoaDonBanHang();
                newInvoice.MaHoaDonBan = txtIdInvoice.Text;
                newInvoice.MaNhanVien = ((CBBItem)cbbStaff.SelectedItem).VALUE;
                newInvoice.NgayBan = dpDate.Value;
                newInvoice.MaKhachHang = idCustomer;
                newInvoice.SoTien = Math.Round(invoicePrice);
                newInvoice.GiamGia = Math.Round(invoiceDiscount);
                DialogResult dialogResult = MessageBox.Show("Bạn chắc nhắn muốn thanh toán?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {     
                    try
                    {
                        BLL_SALEPRODUCT.Instance.FuncPayment(newInvoice, dataTable); // Payment invoice
                        MessageBox.Show("Tạo thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDGVs();
                        ResetInvoice();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Mã hóa đơn đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        // load invoice
        private void btnLoadInvoice_Click(object sender, EventArgs e)
        {
            ResetInvoice();// reset Invoice
        }
        // Btn giảm theo phần trăm, gọi form Discount_Percent
        private void btnDiscountPercent_Click(object sender, EventArgs e)
        {
            FrmDiscount_Percent frm = new FrmDiscount_Percent();
            frm.d += new FrmDiscount_Percent.myDEL(setDiscountPercent);
            frm.Show();
        }
        // Btn giảm theo số tiền, gọi form Discount_Money
        private void btnDiscountMoney_Click(object sender, EventArgs e)
        {
            FrmDiscount_Money frm = new FrmDiscount_Money(totalMoney);
            frm.d += new FrmDiscount_Money.myDEL(setDiscountMoney);
            frm.Show();
        }
        private void txtDISCOUNT_ITEM_TextChanged(object sender, EventArgs e)
        {
            if (txtProductDiscount.Text == "")
            {
                txtProductDiscount.Text = "0";
            }
            if (Convert.ToInt32(txtProductDiscount.Text) > 100)
            {
                txtProductDiscount.Text = "100";
            }
        }
        private void txtAMOUNT_ITEM_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantityOfSelect.Text == "")
            {
                txtQuantityOfSelect.Text = "1";
            }
        }

        private void txtPRODUCT_DISCOUNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        // Btn in giao diện cho hóa đơn
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0 || string.IsNullOrEmpty(txtCustomer.Text))
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            e.Graphics.DrawString("HÓA ĐƠN TÍNH TIỀN", new Font("Tahoma", 19, FontStyle.Bold), Brushes.Black, new Point(270, 180));
            e.Graphics.DrawString("NVTN: "+ cbbStaff.SelectedItem.ToString(), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(270, 220));
            e.Graphics.DrawString("Khách hàng: "+ txtCustomer.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(270, 250));
            e.Graphics.DrawString("Số hóa đơn: "+ txtIdInvoice.Text, new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString("Ngày: "+ DateTime.Now.ToString("dd/MM/yyyy HH:mm"), new Font("Tahoma", 17, FontStyle.Regular), Brushes.Black, new Point(450, 300));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10,350));
            e.Graphics.DrawString("Tên sản phẩm" , new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("SL", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(360, 400));
            e.Graphics.DrawString("Đơn giá", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(440, 400));
            e.Graphics.DrawString("K/Mãi", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(580, 400));
            e.Graphics.DrawString("Thành tiền", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(700, 400));
            int distance = 400;
            string str;
            foreach(DataRow dr in dataTable.Rows)
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
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance+50));
            e.Graphics.DrawString("Tổng tiền ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*2));
            e.Graphics.DrawString(txtTotalMoney.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*2));
            e.Graphics.DrawString("Giảm giá ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*3));
            e.Graphics.DrawString(txtDiscount.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*3));
            e.Graphics.DrawString("Tổng thanh toán ", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*4));
            e.Graphics.DrawString(txtPriceInvoice.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*4));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50*5));
            e.Graphics.DrawString("*** LƯU Ý: " + txtNote.Text, new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(50, distance + 50*6));
            e.Graphics.DrawString("- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50*7));
            e.Graphics.DrawString("Cảm ơn và hẹn gặp lại quý khách!", new Font("Tahoma", 17, FontStyle.Bold), Brushes.Black, new Point(250, distance + 50 * 8));
        }
        // set new quantity for product
        public void setNewQtyForProduct(int newQty)
        {
            dgvInvoice.SelectedRows[0].Cells["SoLuong"].Value = newQty;
            double newPrice = Convert.ToDouble(dgvInvoice.SelectedRows[0].Cells["DonGia(VNĐ)"].Value.ToString()) * newQty - 
                (Convert.ToDouble(dgvInvoice.SelectedRows[0].Cells["DonGia(VNĐ)"].Value.ToString()) * newQty * productDiscount) / 100;
            dgvInvoice.SelectedRows[0].Cells["ThanhTien(VNĐ)"].Value = String.Format("{0:n0}",newPrice);
            setDataForToolBox();
        }
        // edit quantity product
        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            FrmEditQuantity_InvoiceSaleProduct frm = new FrmEditQuantity_InvoiceSaleProduct(idProduct);
            frm.d += new FrmEditQuantity_InvoiceSaleProduct.myDel(setNewQtyForProduct);
            frm.Show();
        }
        // back to frmQuanLyDuLieu
        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmManage_Data frm = new FrmManage_Data(usernameLogin);
            frm.Show();
            this.Close();
        }
        private void txtNOTE_Leave(object sender, EventArgs e)
        {
            if(txtNote.Text == "")
            {
                txtNote.Text = "Nhập thông tin ...";
                txtNote.ForeColor = Color.Silver;
            }
        }
        private void txtNOTE_Enter(object sender, EventArgs e)
        {
            if (txtNote.Text == "Nhập thông tin ...")
            {
                txtNote.Text = "";
                txtNote.ForeColor = Color.Black;
            }
        }
        private void txtProduct_Enter(object sender, EventArgs e)
        {
            if (txtProduct.Text == "Nhập tên hoặc mã hàng hóa")
            {
                txtProduct.Text = "";
                txtProduct.ForeColor = Color.Black;
            }
        }
        private void txtProduct_Leave(object sender, EventArgs e)
        {
            if (txtProduct.Text == "")
            {
                txtProduct.Text = "Nhập tên hoặc mã hàng hóa";
                txtProduct.ForeColor = Color.Silver;
            }
        }
        // Số tiền khách hàng trả
        private void txtSEND_BY_CUSTOMER_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtCustomerPay.Text))
                {
                    sendByCustomer = 0;
                }
                else
                {
                    sendByCustomer = Convert.ToDouble(txtCustomerPay.Text);
                }
                sendByStaff = sendByCustomer - invoicePrice;
                txtReturnMoney.Text = String.Format("{0:n0}", sendByStaff);
            }
            catch(Exception)
            {
                MessageBox.Show("Cú pháp không chính xác", "Lỗi nhập tiền", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
