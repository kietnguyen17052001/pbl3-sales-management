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
    public partial class FrmStatistic_Product : Form
    {
        private String idTypeOfProduct, usernamelogin;
        private DateTime dateMin, dateMax;
        public FrmStatistic_Product(DateTime _dateMin, DateTime _dateMax, string value, string text, string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            lbINFO.Text = text + " từ ngày " + _dateMin.ToShortDateString() + " đến ngày " + _dateMax.ToShortDateString();
            dateMin = _dateMin;
            dateMax = _dateMax;
            idTypeOfProduct = value;
            fillChart();
        }
        public void fillChart()
        {
            int quantity; // số lượng hiện tại của loại hàng hóa
            int allQuantity = 0;
            double allMoney = 0;
            double money; // số tiền bán được của loại hàng hóa
            int count = 0;
            foreach(tblHangHoa product in BLL_STATISTIC.instance.getListProductByIdTypeOfProduct(idTypeOfProduct))
            {
                quantity = 0;
                money = 0.0;
                foreach (tblChiTietHoaDonBanHang invoiceDetail in BLL_STATISTIC.instance.getListInvoiceDetail(dateMin, dateMax))
                {
                    if (invoiceDetail.MaHangHoa == product.MaHangHoa)
                    {
                        money += (double)invoiceDetail.TongTien;
                        quantity += (int)invoiceDetail.SoLuong;
                    }
                }
                charMONEY.Series["Số tiền bán được"].Points.AddXY(product.TenHangHoa, money);
                charMONEY.Series["Số tiền bán được"].Points[count].Label = money.ToString();
                chartPRODUCT_QTY.Series["Số sản phẩm bán được"].Points.AddXY(product.TenHangHoa, quantity);
                chartPRODUCT_QTY.Series["Số sản phẩm bán được"].Points[count].Label = quantity.ToString();
                allQuantity += quantity;
                allMoney += money;
                count++;
            }
            lbQUANTITY.Text = allQuantity.ToString();
            lbMONEY.Text = string.Format("{0:n0}", allMoney);
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmStatistic frm = new FrmStatistic(usernamelogin);
            frm.Show();
            this.Close();
        }
    }
}
