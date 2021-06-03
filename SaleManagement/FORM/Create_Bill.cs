using SaleManagement.BLL;
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
        int AMOUNT_ITEMs = 1, ALL_AMOUNT_ITEMs = 0 , ITEMs = 0;
        string ID_ITEM, ITEM;
        double PRICE_ITEM = 0, 
                DISCOUNT_ITEM = 0, 
                PRICE_ITEMs = 0, 
                PRICE_BILL = 0, 
                DISCOUNT_BILL = 0, 
                SEND_BY_CUSTOMER = 0, 
                SEND_BY_STAFF = 0, 
                TOTAL_MONEY = 0;
        DataTable DATA = BLL_CREATEBILL.Instance.getTblORDER();
        public FrmBill()
        {
            InitializeComponent();
            setCBB();
            dgvLIST.DataSource = DATA;
            rbID_ITEM.Checked = true;
            setDATA_FOR_TXT();
        }
        // Thiết lập dữ liệu cho các textbox
        public void setDATA_FOR_TXT()
        {
            SEND_BY_CUSTOMER = PRICE_BILL = BLL_CREATEBILL.Instance.getPriceBill(DATA, DISCOUNT_BILL);
            TOTAL_MONEY = BLL_CREATEBILL.Instance.getTotalMoney(DATA);
            ALL_AMOUNT_ITEMs = BLL_CREATEBILL.Instance.getAllAmount(DATA);
            ITEMs = BLL_CREATEBILL.Instance.getAllItems(DATA);
            txtID_BILL.Text = BLL_CREATEBILL.Instance.getNEWID_BILL();
            txtDISCOUNT_BILL.Text = String.Format("{0:n0}", DISCOUNT_BILL);
            txtDISCOUNT_ITEM.Text = DISCOUNT_ITEM.ToString();
            txtALL_AMOUNT_ITEMs.Text = ALL_AMOUNT_ITEMs.ToString();
            txtITEMs.Text = ITEMs.ToString();
            txtAMOUNT_ITEM.Text = AMOUNT_ITEMs.ToString();
            txtPRICE_BILL.Text = String.Format("{0:n0}", PRICE_BILL); ;
            txtTOTAL_MONEY.Text = String.Format("{0:n0}", TOTAL_MONEY); ;
            txtSEND_BY_CUSTOMER.Text = String.Format("{0:n0}", SEND_BY_CUSTOMER); ;
            txtSEND_BY_STAFF.Text = String.Format("{0:n0}", SEND_BY_STAFF); ;
        }
        // Thiết lập dữ liệu cho các CBB
        public void setCBB()
        {
            cbbTYPE_OF_ITEMS.Items.Add("None");
            cbbSTAFF.Items.Add("None");
            cbbCUSTOMER.Items.Add("None");
            cbbTYPE_OF_ITEMS.Items.AddRange(BLL_ITEMS.Instance.getCBB_TYPEOFITEMS().ToArray());
            cbbSTAFF.Items.AddRange(BLL_CREATEBILL.Instance.getCBB_STAFF().ToArray());
            cbbCUSTOMER.Items.AddRange(BLL_CREATEBILL.Instance.getCBB_CUSTOMER().ToArray());
            cbbCUSTOMER.SelectedIndex = cbbSTAFF.SelectedIndex = cbbTYPE_OF_ITEMS.SelectedIndex = 0;
        }
        // Load lại dữ liệu trobg Form 
        public void load()
        {
            DATA = BLL_CREATEBILL.Instance.getTblORDER();
            TOTAL_MONEY = PRICE_BILL = SEND_BY_CUSTOMER = SEND_BY_STAFF = ALL_AMOUNT_ITEMs = ITEMs = 0;
            DISCOUNT_BILL = 0;
            AMOUNT_ITEMs = 1;
            DISCOUNT_ITEM = 0;
            setDATA_FOR_TXT();
            btnDELETE.Enabled = true;
            btnADD.Enabled = true;
            btnEDIT.Enabled = true;
            dgvLIST.DataSource = DATA;
        }
        // Thiết lập giá trị cho txt Giảm giá và Tổng thanh toán sau khi giảm theo % 
        public void setDiscountPercent(string PERCENT)
        {
            SEND_BY_CUSTOMER = PRICE_BILL = BLL_CREATEBILL.Instance.getPriceBill(DATA, (BLL_CREATEBILL.Instance.getTotalMoney(DATA) * Convert.ToDouble(PERCENT) / 100));
            DISCOUNT_BILL = BLL_CREATEBILL.Instance.getTotalMoney(DATA) * Convert.ToDouble(PERCENT) / 100;
            txtPRICE_BILL.Text = String.Format("{0:n0}", PRICE_BILL);
            txtDISCOUNT_BILL.Text = String.Format("{0:n0}", DISCOUNT_BILL);
            txtSEND_BY_CUSTOMER.Text = String.Format("{0:n0}", SEND_BY_CUSTOMER);
        }
        // Thiết lập giá trị cho txt Giảm giá và Tổng thanh toán sau khi giảm theo số tiền
        public void setDiscountMoney(string MONEY)
        {
            SEND_BY_CUSTOMER = PRICE_BILL = BLL_CREATEBILL.Instance.getPriceBill(DATA, Convert.ToDouble(MONEY));
            DISCOUNT_BILL = Convert.ToDouble(MONEY);
            txtPRICE_BILL.Text = String.Format("{0:n0}", PRICE_BILL); // định dạng lại chuỗi, 2000 -> 2.000
            txtDISCOUNT_BILL.Text = String.Format("{0:n0}", DISCOUNT_BILL);
            txtSEND_BY_CUSTOMER.Text = String.Format("{0:n0}", SEND_BY_CUSTOMER);
        }
        
        public void showITEMs()
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if (cbbTYPE_OF_ITEMS.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var item = DB.tblHangHoas.Where(p => p.MaLoaiHangHoa == ((CBBItem)cbbTYPE_OF_ITEMS.SelectedItem).VALUE).Select(p => new {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan
                });
                dgvSELECT.DataSource = item.ToList();
            }
        }
        public void addCUSTOMER(string ID, string NAME)
        {
            cbbCUSTOMER.Items.Add(new CBBItem { VALUE = ID, TEXT = NAME });
        }
        // Quay trở lại trang chủ
        private void btnHOME_Click(object sender, EventArgs e)
        {
            FrmSale_Management FRM = new FrmSale_Management();
            FRM.Show();
            this.Close();
        }
        // Btn liệt kê hàng hóa theo loại hàng hóa
        private void btnSHOW_Click(object sender, EventArgs e)
        {
            showITEMs();
        }
        // Tìm kiếm hàng hóa theo mã hoặc tên hàng hóa
        private void btnSEARCH_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            if (rbID_ITEM.Checked == true)
            {
                var items = DB.tblHangHoas.Where(p => p.MaHangHoa.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan
                });
                dgvSELECT.DataSource = items.ToList();
            }
            else
            {
                var items = DB.tblHangHoas.Where(p => p.TenHangHoa.ToLower().Contains(txtSEARCH.Text.ToLower())).Select(p => new
                {
                    p.MaHangHoa,
                    p.TenHangHoa,
                    p.SoLuong,
                    p.GiaBan
                });
                dgvSELECT.DataSource = items.ToList();
            }
        }
        // Btn thêm hàng hóa vào hóa đơn
        private void btnADD_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            ID_ITEM = dgvSELECT.SelectedRows[0].Cells["MaHangHoa"].Value.ToString(); // Mã hàng hóa
            ITEM = dgvSELECT.SelectedRows[0].Cells["TenHangHoa"].Value.ToString(); // Tên hàng hóa
            AMOUNT_ITEMs = Convert.ToInt32(txtAMOUNT_ITEM.Text); // Số lượng hàng hóa từ txtAMOUNT_ITEM
            PRICE_ITEM = Convert.ToDouble(dgvSELECT.SelectedRows[0].Cells["GiaBan"].Value.ToString()); // Giá hàng hóa
            DISCOUNT_ITEM = Convert.ToDouble(txtDISCOUNT_ITEM.Text); // Giảm giá theo hàng hóa từ txtDISCOUNT_ITEM
            PRICE_ITEMs = AMOUNT_ITEMs * PRICE_ITEM - AMOUNT_ITEMs * PRICE_ITEM * DISCOUNT_ITEM / 100; // Tổng thanh toán trước khi giảm giá hóa đơn
            if (AMOUNT_ITEMs > Convert.ToInt32(dgvSELECT.SelectedRows[0].Cells["SoLuong"].Value.ToString())) // Kiểm tra số lượng
            {
                MessageBox.Show("Không đủ số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BLL_CREATEBILL.Instance.addITEMs(DATA, ID_ITEM, ITEM, AMOUNT_ITEMs, PRICE_ITEM, DISCOUNT_ITEM, PRICE_ITEMs);
                int remain = Convert.ToInt32(dgvSELECT.SelectedRows[0].Cells["SoLuong"].Value.ToString()) - AMOUNT_ITEMs;
                dgvSELECT.SelectedRows[0].Cells["SoLuong"].Value = remain.ToString();// Giảm số lượng hàng hóa sau khi thêm
                //var item = DB.tblHangHoas.Find(ID_ITEM);
                //item.SoLuong = remain;
                //showITEMs();
            }
            // Thông tin hóa đơn sau khi thêm hàng hóa
            setDATA_FOR_TXT();
        }
        // Btn xóa hàng hóa khỏi hóa đơn
        private void btnDELETE_Click(object sender, EventArgs e)
        {
            List<string> LIST = new List<string>();
            DataGridViewSelectedRowCollection dgvsrc = dgvLIST.SelectedRows;
            foreach (DataGridViewRow i in dgvsrc)
            {
                LIST.Add(i.Cells[0].Value.ToString());
            }
            BLL_CREATEBILL.Instance.delITEMS(LIST, DATA);
            // Dữ liệu hóa đơn sau khi xóa hàng hóa
            setDATA_FOR_TXT();
        }
        // Btn thêm mới khách hàng -> load form CREATE_NEWCUSTOMER -> điền thông tin khách hàng -> thông tin được lưu vào DB
        private void btnADDCUSTOMER_Click(object sender, EventArgs e)
        {
            FrmCreate_NewCustomer FRM = new FrmCreate_NewCustomer();
            FRM.d += new FrmCreate_NewCustomer.myDEL(addCUSTOMER);
            FRM.Show();
        }
        // Btn thanh toán
        private void btnPAYMENT_Click(object sender, EventArgs e)
        {
            SALEMANAGEMENT_DB DB = new SALEMANAGEMENT_DB();
            tblHoaDonBanHang NEWBILL = new tblHoaDonBanHang();
            if (txtID_BILL.Text == "" || PRICE_BILL == 0 || cbbCUSTOMER.SelectedIndex == 0 || cbbSTAFF.SelectedIndex == 0 ||
                cbbSTAFF.SelectedIndex == 0 || cbbCUSTOMER.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                NEWBILL.MaHoaDonBan = txtID_BILL.Text;
                NEWBILL.MaNhanVien = ((CBBItem)cbbSTAFF.SelectedItem).VALUE;
                NEWBILL.NgayBan = dpDAY.Value;
                NEWBILL.MaKhachHang = ((CBBItem)cbbCUSTOMER.SelectedItem).VALUE;
                NEWBILL.SoTien = PRICE_BILL;
                try
                {
                    MessageBox.Show("Tạo thành công hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DB.tblHoaDonBanHangs.Add(NEWBILL);
                    DB.SaveChanges();
                    foreach (DataRow data in DATA.Rows)
                    {
                        var item = DB.tblHangHoas.Find(data["MaHangHoa"].ToString());
                        item.SoLuong -= Convert.ToInt32(data["SoLuong"].ToString());
                        DB.SaveChanges();
                    } 
                    load();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tạo hóa đơn thất bại. Mã đơn bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Btn Hủy bỏ, làm mới hóa đơn
        private void btnLOAD_Click(object sender, EventArgs e)
        {
            load(); // load lại dữ liệu về trạng thái ban đầu
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
            if (txtDISCOUNT_ITEM.Text == "")
            {
                txtDISCOUNT_ITEM.Text = "0";
            }
            if (Convert.ToInt32(txtDISCOUNT_ITEM.Text) > 100)
            {
                txtDISCOUNT_ITEM.Text = "100";
            }
        }
        private void txtAMOUNT_ITEM_TextChanged(object sender, EventArgs e)
        {
            if (txtAMOUNT_ITEM.Text == "")
            {
                txtAMOUNT_ITEM.Text = "1";
            }
        }
        // Btn giảm theo số tiền, gọi form Discount_Money
        private void btnDISCOUNT_MONEY_Click(object sender, EventArgs e)
        {
            FrmDiscount_Money FRM = new FrmDiscount_Money(TOTAL_MONEY);
            FRM.d += new FrmDiscount_Money.myDEL(setDiscountMoney);
            FRM.Show();
        }

        private void btnPRINT_Click(object sender, EventArgs e)
        {
            if (DATA.Rows.Count == 0)
            {
                MessageBox.Show("Không thể thực hiện chức năng này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("N3K STORE", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(340,50));
            e.Graphics.DrawString("54 NGUYỄN LƯƠNG BẰNG", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(280, 100));
            e.Graphics.DrawString("0911.888.999", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(350, 120));
            e.Graphics.DrawString("HÓA ĐƠN TÍNH TIỀN", new Font("Arial", 19, FontStyle.Bold), Brushes.Black, new Point(290, 180));
            e.Graphics.DrawString("NVTN: "+ cbbSTAFF.SelectedItem.ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(330, 220));
            e.Graphics.DrawString("Khách hàng: "+ cbbCUSTOMER.SelectedItem.ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(300, 250));
            e.Graphics.DrawString("Số Bill: "+ txtID_BILL.Text, new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(200, 300));
            e.Graphics.DrawString("Ngày: "+ DateTime.Now.ToString("dd/MM/yyyy HH:mm"), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(380, 300));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10,350));
            e.Graphics.DrawString("Tên sản phẩm" , new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(10, 400));
            e.Graphics.DrawString("SL", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(360, 400));
            e.Graphics.DrawString("Đơn giá", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(440, 400));
            e.Graphics.DrawString("K/Mãi", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(580, 400));
            e.Graphics.DrawString("Thành tiền", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(700, 400));
            int distance = 400;
            string str;
            foreach(DataRow dr in DATA.Rows)
            {
                distance += 50;
                str = "";
                if(dr["TenhangHoa"].ToString().Length > 30)
                {
                    str += dr["TenHangHoa"].ToString().Substring(31);
                    dr["TenHangHoa"] = dr["TenHangHoa"].ToString().Replace(str, "");
                }
                e.Graphics.DrawString(dr["TenHangHoa"].ToString() + "\n" + str, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, distance));
                e.Graphics.DrawString(dr["SoLuong"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(370, distance));
                e.Graphics.DrawString(dr["DonGia(VNĐ)"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(450, distance));
                e.Graphics.DrawString(dr["KhuyenMai(%)"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(590, distance));
                e.Graphics.DrawString(dr["ThanhTien(VNĐ)"].ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(710, distance));
            }
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance+50));
            e.Graphics.DrawString("Tổng tiền ", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*2));
            e.Graphics.DrawString(txtTOTAL_MONEY.Text + " VNĐ", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*2));
            e.Graphics.DrawString("Giảm giá ", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*3));
            e.Graphics.DrawString(txtDISCOUNT_BILL.Text + " VNĐ", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*3));
            e.Graphics.DrawString("Tổng thanh toán ", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(400, distance + 50*4));
            e.Graphics.DrawString(txtPRICE_BILL.Text + " VNĐ", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(630, distance + 50*4));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50*5));
            e.Graphics.DrawString("*** LƯU Ý: " + txtNOTE.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(50, distance + 50*6));
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(10, distance + 50*7));
            e.Graphics.DrawString("Cảm ơn và hẹn gặp lại quý khách!", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(250, distance + 50 * 8));
        }

        private void dgvSELECT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Btn quay lại
        private void btnBACK_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn chắc chắn quay lại?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                FrmManage_Data FRM = new FrmManage_Data();
                FRM.Show();
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
        // Số tiền trả lại khách hàng
        private void txtSEND_BY_STAFF_TextChanged(object sender, EventArgs e)
        {
            
        }
        // Số tiền khách hàng trả
        private void txtSEND_BY_CUSTOMER_TextChanged(object sender, EventArgs e)
        {
            if(txtSEND_BY_CUSTOMER.Text == "")
            {
                txtSEND_BY_CUSTOMER.Text = "0";
            }
            SEND_BY_CUSTOMER = Convert.ToDouble(txtSEND_BY_CUSTOMER.Text);
            SEND_BY_STAFF = SEND_BY_CUSTOMER - PRICE_BILL;
            txtSEND_BY_STAFF.Text = String.Format("{0:n0}", SEND_BY_STAFF);
        }
    }
}
