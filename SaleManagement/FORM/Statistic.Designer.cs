﻿
namespace SaleManagement.FORM
{
    partial class FrmStatistic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label6 = new System.Windows.Forms.Label();
            this.chartPRODUCT_QTY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartMONEY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartSCALE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbTYPEOFPRODUCT = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLOAD = new System.Windows.Forms.Button();
            this.dpTO = new System.Windows.Forms.DateTimePicker();
            this.dpFROM = new System.Windows.Forms.DateTimePicker();
            this.btnINFO = new System.Windows.Forms.Button();
            this.lbTIME = new System.Windows.Forms.Label();
            this.btnSTATISTIC = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPRODUCT_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMONEY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSCALE)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(359, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 23);
            this.label6.TabIndex = 121;
            this.label6.Text = "Thống kê ";
            // 
            // chartPRODUCT_QTY
            // 
            this.chartPRODUCT_QTY.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chartPRODUCT_QTY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPRODUCT_QTY.Legends.Add(legend1);
            this.chartPRODUCT_QTY.Location = new System.Drawing.Point(11, 106);
            this.chartPRODUCT_QTY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPRODUCT_QTY.Name = "chartPRODUCT_QTY";
            this.chartPRODUCT_QTY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartPRODUCT_QTY.Series.Add(series1);
            this.chartPRODUCT_QTY.Size = new System.Drawing.Size(537, 231);
            this.chartPRODUCT_QTY.TabIndex = 124;
            this.chartPRODUCT_QTY.Text = "chart1";
            // 
            // chartMONEY
            // 
            this.chartMONEY.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.chartMONEY.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMONEY.Legends.Add(legend2);
            this.chartMONEY.Location = new System.Drawing.Point(553, 106);
            this.chartMONEY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartMONEY.Name = "chartMONEY";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelBackColor = System.Drawing.Color.Black;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartMONEY.Series.Add(series2);
            this.chartMONEY.Size = new System.Drawing.Size(544, 231);
            this.chartMONEY.TabIndex = 125;
            this.chartMONEY.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(582, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 23);
            this.label2.TabIndex = 123;
            this.label2.Text = "Số tiền bán được của từng loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 23);
            this.label1.TabIndex = 122;
            this.label1.Text = "Số sản phẩm của từng loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 23);
            this.label3.TabIndex = 131;
            this.label3.Text = "So sánh tỉ lệ bán được của từng loại(%)";
            // 
            // chartSCALE
            // 
            this.chartSCALE.BackColor = System.Drawing.SystemColors.Control;
            chartArea3.Name = "ChartArea1";
            this.chartSCALE.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartSCALE.Legends.Add(legend3);
            this.chartSCALE.Location = new System.Drawing.Point(432, 350);
            this.chartSCALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSCALE.Name = "chartSCALE";
            this.chartSCALE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.BackImageTransparentColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Color = System.Drawing.Color.White;
            series3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.LabelBackColor = System.Drawing.Color.Black;
            series3.LabelForeColor = System.Drawing.Color.White;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartSCALE.Series.Add(series3);
            this.chartSCALE.Size = new System.Drawing.Size(522, 194);
            this.chartSCALE.TabIndex = 132;
            this.chartSCALE.Text = "chart1";
            // 
            // cbbTYPEOFPRODUCT
            // 
            this.cbbTYPEOFPRODUCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPEOFPRODUCT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPEOFPRODUCT.FormattingEnabled = true;
            this.cbbTYPEOFPRODUCT.Location = new System.Drawing.Point(624, 44);
            this.cbbTYPEOFPRODUCT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTYPEOFPRODUCT.Name = "cbbTYPEOFPRODUCT";
            this.cbbTYPEOFPRODUCT.Size = new System.Drawing.Size(251, 24);
            this.cbbTYPEOFPRODUCT.TabIndex = 138;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLOAD);
            this.groupBox1.Controls.Add(this.dpTO);
            this.groupBox1.Controls.Add(this.dpFROM);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 386);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(305, 156);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(47, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 18);
            this.label10.TabIndex = 140;
            this.label10.Text = "Đến ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(43, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 18);
            this.label8.TabIndex = 139;
            this.label8.Text = "Từ ngày";
            // 
            // btnLOAD
            // 
            this.btnLOAD.BackColor = System.Drawing.SystemColors.Control;
            this.btnLOAD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLOAD.FlatAppearance.BorderSize = 0;
            this.btnLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOAD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOAD.ForeColor = System.Drawing.Color.White;
            this.btnLOAD.Image = global::SaleManagement.Properties.Resources.sinchronize_32__1_;
            this.btnLOAD.Location = new System.Drawing.Point(201, 74);
            this.btnLOAD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(48, 35);
            this.btnLOAD.TabIndex = 137;
            this.btnLOAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLOAD.UseVisualStyleBackColor = false;
            this.btnLOAD.Click += new System.EventHandler(this.btnLOAD_Click);
            // 
            // dpTO
            // 
            this.dpTO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTO.Location = new System.Drawing.Point(46, 118);
            this.dpTO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpTO.Name = "dpTO";
            this.dpTO.Size = new System.Drawing.Size(139, 26);
            this.dpTO.TabIndex = 138;
            // 
            // dpFROM
            // 
            this.dpFROM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFROM.Location = new System.Drawing.Point(46, 56);
            this.dpFROM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpFROM.Name = "dpFROM";
            this.dpFROM.Size = new System.Drawing.Size(139, 26);
            this.dpFROM.TabIndex = 137;
            // 
            // btnINFO
            // 
            this.btnINFO.BackColor = System.Drawing.Color.SteelBlue;
            this.btnINFO.FlatAppearance.BorderSize = 0;
            this.btnINFO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnINFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINFO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFO.ForeColor = System.Drawing.Color.White;
            this.btnINFO.Location = new System.Drawing.Point(880, 34);
            this.btnINFO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnINFO.Name = "btnINFO";
            this.btnINFO.Size = new System.Drawing.Size(217, 38);
            this.btnINFO.TabIndex = 140;
            this.btnINFO.Text = "Thông tin loại hàng hóa";
            this.btnINFO.UseVisualStyleBackColor = false;
            this.btnINFO.Click += new System.EventHandler(this.btnINFO_Click);
            // 
            // lbTIME
            // 
            this.lbTIME.AutoSize = true;
            this.lbTIME.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTIME.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTIME.Location = new System.Drawing.Point(621, 323);
            this.lbTIME.Name = "lbTIME";
            this.lbTIME.Size = new System.Drawing.Size(0, 16);
            this.lbTIME.TabIndex = 141;
            // 
            // btnSTATISTIC
            // 
            this.btnSTATISTIC.BackColor = System.Drawing.Color.Tomato;
            this.btnSTATISTIC.FlatAppearance.BorderSize = 0;
            this.btnSTATISTIC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSTATISTIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTATISTIC.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTATISTIC.ForeColor = System.Drawing.Color.White;
            this.btnSTATISTIC.Location = new System.Drawing.Point(308, 37);
            this.btnSTATISTIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSTATISTIC.Name = "btnSTATISTIC";
            this.btnSTATISTIC.Size = new System.Drawing.Size(217, 38);
            this.btnSTATISTIC.TabIndex = 142;
            this.btnSTATISTIC.Text = "Thống kê doanh thu";
            this.btnSTATISTIC.UseVisualStyleBackColor = false;
            this.btnSTATISTIC.Click += new System.EventHandler(this.btnSTATISTIC_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(11, 6);
            this.btnHOME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(164, 51);
            this.btnHOME.TabIndex = 130;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnSTATISTIC);
            this.Controls.Add(this.lbTIME);
            this.Controls.Add(this.btnINFO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbbTYPEOFPRODUCT);
            this.Controls.Add(this.chartSCALE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.chartMONEY);
            this.Controls.Add(this.chartPRODUCT_QTY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.chartPRODUCT_QTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMONEY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSCALE)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPRODUCT_QTY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMONEY;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSCALE;
        private System.Windows.Forms.Button btnLOAD;
        private System.Windows.Forms.ComboBox cbbTYPEOFPRODUCT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpTO;
        private System.Windows.Forms.DateTimePicker dpFROM;
        private System.Windows.Forms.Button btnINFO;
        private System.Windows.Forms.Label lbTIME;
        private System.Windows.Forms.Button btnSTATISTIC;
    }
}