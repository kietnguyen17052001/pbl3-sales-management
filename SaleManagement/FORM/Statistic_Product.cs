﻿using SaleManagement.BLL;
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
        private DateTime dateStart, dateEnd;
        public FrmStatistic_Product(DateTime _dateStart, DateTime _dateEnd, string value, string text, string _usernamelogin)
        {
            InitializeComponent();
            usernamelogin = _usernamelogin;
            lbINFO.Text = text + " từ ngày " + _dateStart.ToShortDateString() + " đến ngày " + _dateEnd.ToShortDateString();
            dateStart = _dateStart;
            dateEnd = _dateEnd;
            idTypeOfProduct = value;
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
            lbMONEY.Text = string.Format("{0:n0}", totalSellMoney);
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            FrmStatistic frm = new FrmStatistic(usernamelogin);
            frm.Show();
            this.Close();
        }
    }
}
