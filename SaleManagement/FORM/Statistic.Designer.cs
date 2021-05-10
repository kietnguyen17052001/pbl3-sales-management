
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.dpTO = new System.Windows.Forms.DateTimePicker();
            this.dpFROM = new System.Windows.Forms.DateTimePicker();
            this.btnINFO = new System.Windows.Forms.Button();
            this.lbTIME = new System.Windows.Forms.Label();
            this.btnSTATISTIC = new System.Windows.Forms.Button();
            this.btnLOAD = new System.Windows.Forms.Button();
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
            this.label6.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(313, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 31);
            this.label6.TabIndex = 121;
            this.label6.Text = "Thống kê loại sản phẩm";
            // 
            // chartPRODUCT_QTY
            // 
            this.chartPRODUCT_QTY.BackColor = System.Drawing.SystemColors.Control;
            chartArea4.Name = "ChartArea1";
            this.chartPRODUCT_QTY.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPRODUCT_QTY.Legends.Add(legend4);
            this.chartPRODUCT_QTY.Location = new System.Drawing.Point(12, 133);
            this.chartPRODUCT_QTY.Name = "chartPRODUCT_QTY";
            this.chartPRODUCT_QTY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.Black;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPRODUCT_QTY.Series.Add(series4);
            this.chartPRODUCT_QTY.Size = new System.Drawing.Size(604, 289);
            this.chartPRODUCT_QTY.TabIndex = 124;
            this.chartPRODUCT_QTY.Text = "chart1";
            // 
            // chartMONEY
            // 
            this.chartMONEY.BackColor = System.Drawing.SystemColors.Control;
            chartArea5.Name = "ChartArea1";
            this.chartMONEY.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartMONEY.Legends.Add(legend5);
            this.chartMONEY.Location = new System.Drawing.Point(622, 133);
            this.chartMONEY.Name = "chartMONEY";
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.LabelBackColor = System.Drawing.Color.Black;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartMONEY.Series.Add(series5);
            this.chartMONEY.Size = new System.Drawing.Size(612, 289);
            this.chartMONEY.TabIndex = 125;
            this.chartMONEY.Text = "chart2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(655, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 26);
            this.label2.TabIndex = 123;
            this.label2.Text = "Số tiền bán được của từng loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(46, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 26);
            this.label1.TabIndex = 122;
            this.label1.Text = "Số sản phẩm của từng loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 26);
            this.label3.TabIndex = 131;
            this.label3.Text = "So sánh tỉ lệ bán được của từng loại(%)";
            // 
            // chartSCALE
            // 
            this.chartSCALE.BackColor = System.Drawing.SystemColors.Control;
            chartArea6.Name = "ChartArea1";
            this.chartSCALE.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartSCALE.Legends.Add(legend6);
            this.chartSCALE.Location = new System.Drawing.Point(486, 437);
            this.chartSCALE.Name = "chartSCALE";
            this.chartSCALE.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series6.BackImageTransparentColor = System.Drawing.Color.White;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Color = System.Drawing.Color.White;
            series6.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series6.LabelBackColor = System.Drawing.Color.Black;
            series6.LabelForeColor = System.Drawing.Color.White;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartSCALE.Series.Add(series6);
            this.chartSCALE.Size = new System.Drawing.Size(576, 242);
            this.chartSCALE.TabIndex = 132;
            this.chartSCALE.Text = "chart1";
            // 
            // cbbTYPEOFPRODUCT
            // 
            this.cbbTYPEOFPRODUCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPEOFPRODUCT.FormattingEnabled = true;
            this.cbbTYPEOFPRODUCT.Location = new System.Drawing.Point(702, 55);
            this.cbbTYPEOFPRODUCT.Name = "cbbTYPEOFPRODUCT";
            this.cbbTYPEOFPRODUCT.Size = new System.Drawing.Size(282, 28);
            this.cbbTYPEOFPRODUCT.TabIndex = 138;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnLOAD);
            this.groupBox1.Controls.Add(this.dpTO);
            this.groupBox1.Controls.Add(this.dpFROM);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(51, 483);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 195);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(53, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 140;
            this.label10.Text = "Đến ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(48, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 139;
            this.label8.Text = "Từ ngày";
            // 
            // dpTO
            // 
            this.dpTO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTO.Location = new System.Drawing.Point(52, 148);
            this.dpTO.Name = "dpTO";
            this.dpTO.Size = new System.Drawing.Size(156, 28);
            this.dpTO.TabIndex = 138;
            // 
            // dpFROM
            // 
            this.dpFROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFROM.Location = new System.Drawing.Point(52, 70);
            this.dpFROM.Name = "dpFROM";
            this.dpFROM.Size = new System.Drawing.Size(156, 28);
            this.dpFROM.TabIndex = 137;
            // 
            // btnINFO
            // 
            this.btnINFO.BackColor = System.Drawing.Color.SteelBlue;
            this.btnINFO.FlatAppearance.BorderSize = 0;
            this.btnINFO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnINFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnINFO.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINFO.ForeColor = System.Drawing.Color.White;
            this.btnINFO.Location = new System.Drawing.Point(990, 43);
            this.btnINFO.Name = "btnINFO";
            this.btnINFO.Size = new System.Drawing.Size(244, 48);
            this.btnINFO.TabIndex = 140;
            this.btnINFO.Text = "Thông tin hàng hóa";
            this.btnINFO.UseVisualStyleBackColor = false;
            this.btnINFO.Click += new System.EventHandler(this.btnINFO_Click);
            // 
            // lbTIME
            // 
            this.lbTIME.AutoSize = true;
            this.lbTIME.Font = new System.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTIME.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbTIME.Location = new System.Drawing.Point(699, 404);
            this.lbTIME.Name = "lbTIME";
            this.lbTIME.Size = new System.Drawing.Size(0, 18);
            this.lbTIME.TabIndex = 141;
            // 
            // btnSTATISTIC
            // 
            this.btnSTATISTIC.BackColor = System.Drawing.Color.Tomato;
            this.btnSTATISTIC.FlatAppearance.BorderSize = 0;
            this.btnSTATISTIC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSTATISTIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSTATISTIC.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSTATISTIC.ForeColor = System.Drawing.Color.White;
            this.btnSTATISTIC.Location = new System.Drawing.Point(347, 46);
            this.btnSTATISTIC.Name = "btnSTATISTIC";
            this.btnSTATISTIC.Size = new System.Drawing.Size(244, 48);
            this.btnSTATISTIC.TabIndex = 142;
            this.btnSTATISTIC.Text = "Thống kê doanh thu";
            this.btnSTATISTIC.UseVisualStyleBackColor = false;
            this.btnSTATISTIC.Click += new System.EventHandler(this.btnSTATISTIC_Click);
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
            this.btnLOAD.Location = new System.Drawing.Point(226, 92);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(54, 44);
            this.btnLOAD.TabIndex = 137;
            this.btnLOAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLOAD.UseVisualStyleBackColor = false;
            this.btnLOAD.Click += new System.EventHandler(this.btnLOAD_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(12, 8);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(185, 64);
            this.btnHOME.TabIndex = 130;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 691);
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
            this.Name = "FrmStatistic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
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