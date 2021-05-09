
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
            this.btnBACK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chartSCALE = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnLOAD = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dpTO = new System.Windows.Forms.DateTimePicker();
            this.dpFROM = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartPRODUCT_QTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMONEY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSCALE)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(203, 14);
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
            this.chartPRODUCT_QTY.Location = new System.Drawing.Point(12, 135);
            this.chartPRODUCT_QTY.Name = "chartPRODUCT_QTY";
            this.chartPRODUCT_QTY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.LabelBackColor = System.Drawing.Color.Black;
            series4.LabelForeColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.Name = "Số sản phẩm";
            this.chartPRODUCT_QTY.Series.Add(series4);
            this.chartPRODUCT_QTY.Size = new System.Drawing.Size(604, 298);
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
            this.chartMONEY.Location = new System.Drawing.Point(622, 135);
            this.chartMONEY.Name = "chartMONEY";
            series5.ChartArea = "ChartArea1";
            series5.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series5.LabelBackColor = System.Drawing.Color.Black;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Legend = "Legend1";
            series5.Name = "Số tiền";
            this.chartMONEY.Series.Add(series5);
            this.chartMONEY.Size = new System.Drawing.Size(612, 298);
            this.chartMONEY.TabIndex = 125;
            this.chartMONEY.Text = "chart2";
            // 
            // btnBACK
            // 
            this.btnBACK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBACK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBACK.FlatAppearance.BorderSize = 0;
            this.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBACK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.Color.White;
            this.btnBACK.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBACK.Location = new System.Drawing.Point(1094, 3);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(140, 47);
            this.btnBACK.TabIndex = 130;
            this.btnBACK.Text = "Quay lại";
            this.btnBACK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBACK.UseVisualStyleBackColor = false;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(655, 90);
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
            this.label1.Location = new System.Drawing.Point(46, 90);
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
            this.label3.Location = new System.Drawing.Point(46, 477);
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
            series6.Name = "Tỉ lệ %";
            this.chartSCALE.Series.Add(series6);
            this.chartSCALE.Size = new System.Drawing.Size(572, 242);
            this.chartSCALE.TabIndex = 132;
            this.chartSCALE.Text = "chart1";
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
            this.btnLOAD.Location = new System.Drawing.Point(990, 29);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(60, 64);
            this.btnLOAD.TabIndex = 137;
            this.btnLOAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLOAD.UseVisualStyleBackColor = false;
            this.btnLOAD.Click += new System.EventHandler(this.btnLOAD_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(859, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 136;
            this.label10.Text = "Đến ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(684, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 21);
            this.label8.TabIndex = 135;
            this.label8.Text = "Từ ngày";
            // 
            // dpTO
            // 
            this.dpTO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTO.Location = new System.Drawing.Point(828, 45);
            this.dpTO.Name = "dpTO";
            this.dpTO.Size = new System.Drawing.Size(156, 28);
            this.dpTO.TabIndex = 134;
            // 
            // dpFROM
            // 
            this.dpFROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFROM.Location = new System.Drawing.Point(650, 45);
            this.dpFROM.Name = "dpFROM";
            this.dpFROM.Size = new System.Drawing.Size(156, 28);
            this.dpFROM.TabIndex = 133;
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 691);
            this.Controls.Add(this.btnLOAD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dpTO);
            this.Controls.Add(this.dpFROM);
            this.Controls.Add(this.chartSCALE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBACK);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPRODUCT_QTY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMONEY;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSCALE;
        private System.Windows.Forms.Button btnLOAD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dpTO;
        private System.Windows.Forms.DateTimePicker dpFROM;
    }
}