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
        private string idTypeOfProduct, usernameLogin;
        private DateTime dateStart, dateEnd;
        public FrmStatistic_Product(DateTime _dateStart, DateTime _dateEnd, string _idTypeOfProduct, string nameTypeOfProduct, string _usernameLogin)
        {
            InitializeComponent();
            usernameLogin = _usernameLogin;
            lbINFO.Text = nameTypeOfProduct + " từ ngày " + _dateStart.ToString("dd/MM/yyyy") + " đến ngày " + _dateEnd.ToString("dd/MM/yyyy");
            dateStart = _dateStart;
            dateEnd = _dateEnd;
            idTypeOfProduct = _idTypeOfProduct;
            fillChart();
        }
        public void fillChart()
        {
            int sellQuantityProduct; 
            int totalSellQuantityProduct = 0;
            double totalSellMoney = 0;
            double sellMoney;
            int count = 0;
            foreach(tblHangHoa product in BLL_STATISTIC.instance.getListProductByIdTypeOfProduct(idTypeOfProduct))
            {
                sellQuantityProduct = BLL_STATISTIC.instance.getSellQuantityOfEachProduct(product, dateStart, dateEnd);
                sellMoney = BLL_STATISTIC.instance.getSellMoneyOfEachProduct(product, dateStart, dateEnd);
                charMONEY.Series["Số tiền bán được"].Points.AddXY(product.TenHangHoa, sellMoney);
                charMONEY.Series["Số tiền bán được"].Points[count].Label = sellMoney.ToString();
                chartPRODUCT_QTY.Series["Số sản phẩm bán được"].Points.AddXY(product.TenHangHoa, sellQuantityProduct);
                chartPRODUCT_QTY.Series["Số sản phẩm bán được"].Points[count].Label = sellQuantityProduct.ToString();
                totalSellQuantityProduct += sellQuantityProduct;
                totalSellMoney += sellMoney;
                count++;
            }
            lbQUANTITY.Text = totalSellQuantityProduct.ToString();
            lbMONEY.Text = String.Format("{0:n0}", totalSellMoney);
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmStatistic frmStatistic = new FrmStatistic(usernameLogin);
            frmStatistic.Show();
            this.Close();
        }
    }
}
