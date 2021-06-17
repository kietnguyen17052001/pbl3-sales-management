
namespace SaleManagement.FORM
{
    partial class FrmSelect_Customer
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.dgvLISTCUSTOMER = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gbGENDER = new System.Windows.Forms.GroupBox();
            this.rbFEMALE = new System.Windows.Forms.RadioButton();
            this.rbMALE = new System.Windows.Forms.RadioButton();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtNAME_CUSTOMER = new System.Windows.Forms.TextBox();
            this.txtID_CUSTOMER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSELECT = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTCUSTOMER)).BeginInit();
            this.gbGENDER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(777, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 26);
            this.label2.TabIndex = 152;
            this.label2.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(335, 56);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(316, 29);
            this.txtSEARCH.TabIndex = 146;
            this.txtSEARCH.Text = "Nhập mã hoặc tên khách hàng";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // dgvLISTCUSTOMER
            // 
            this.dgvLISTCUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTCUSTOMER.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLISTCUSTOMER.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLISTCUSTOMER.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLISTCUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTCUSTOMER.Location = new System.Drawing.Point(334, 99);
            this.dgvLISTCUSTOMER.Name = "dgvLISTCUSTOMER";
            this.dgvLISTCUSTOMER.RowHeadersVisible = false;
            this.dgvLISTCUSTOMER.RowHeadersWidth = 62;
            this.dgvLISTCUSTOMER.RowTemplate.Height = 28;
            this.dgvLISTCUSTOMER.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTCUSTOMER.Size = new System.Drawing.Size(726, 473);
            this.dgvLISTCUSTOMER.TabIndex = 144;
            this.dgvLISTCUSTOMER.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLISTCUSTOMER_CellClick);
            this.dgvLISTCUSTOMER.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLISTCUSTOMER_CellFormatting);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 31);
            this.label1.TabIndex = 143;
            this.label1.Text = "Khách hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbGENDER
            // 
            this.gbGENDER.Controls.Add(this.rbFEMALE);
            this.gbGENDER.Controls.Add(this.rbMALE);
            this.gbGENDER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGENDER.Location = new System.Drawing.Point(20, 311);
            this.gbGENDER.Name = "gbGENDER";
            this.gbGENDER.Size = new System.Drawing.Size(295, 114);
            this.gbGENDER.TabIndex = 142;
            this.gbGENDER.TabStop = false;
            this.gbGENDER.Text = "Giới tính";
            // 
            // rbFEMALE
            // 
            this.rbFEMALE.AutoSize = true;
            this.rbFEMALE.Location = new System.Drawing.Point(65, 65);
            this.rbFEMALE.Name = "rbFEMALE";
            this.rbFEMALE.Size = new System.Drawing.Size(62, 26);
            this.rbFEMALE.TabIndex = 1;
            this.rbFEMALE.TabStop = true;
            this.rbFEMALE.Text = "Nữ";
            this.rbFEMALE.UseVisualStyleBackColor = true;
            // 
            // rbMALE
            // 
            this.rbMALE.AutoSize = true;
            this.rbMALE.Location = new System.Drawing.Point(65, 25);
            this.rbMALE.Name = "rbMALE";
            this.rbMALE.Size = new System.Drawing.Size(77, 26);
            this.rbMALE.TabIndex = 0;
            this.rbMALE.TabStop = true;
            this.rbMALE.Text = "Nam";
            this.rbMALE.UseVisualStyleBackColor = true;
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDRESS.ForeColor = System.Drawing.Color.Black;
            this.txtADDRESS.Location = new System.Drawing.Point(124, 261);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(191, 29);
            this.txtADDRESS.TabIndex = 141;
            // 
            // txtPHONE
            // 
            this.txtPHONE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHONE.ForeColor = System.Drawing.Color.Black;
            this.txtPHONE.Location = new System.Drawing.Point(124, 210);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(191, 29);
            this.txtPHONE.TabIndex = 140;
            // 
            // txtNAME_CUSTOMER
            // 
            this.txtNAME_CUSTOMER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_CUSTOMER.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_CUSTOMER.Location = new System.Drawing.Point(124, 155);
            this.txtNAME_CUSTOMER.Name = "txtNAME_CUSTOMER";
            this.txtNAME_CUSTOMER.Size = new System.Drawing.Size(191, 29);
            this.txtNAME_CUSTOMER.TabIndex = 139;
            // 
            // txtID_CUSTOMER
            // 
            this.txtID_CUSTOMER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_CUSTOMER.Location = new System.Drawing.Point(124, 99);
            this.txtID_CUSTOMER.Name = "txtID_CUSTOMER";
            this.txtID_CUSTOMER.Size = new System.Drawing.Size(191, 29);
            this.txtID_CUSTOMER.TabIndex = 138;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 22);
            this.label4.TabIndex = 137;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 136;
            this.label3.Text = "Số ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 135;
            this.label6.Text = "Tên KH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 22);
            this.label7.TabIndex = 134;
            this.label7.Text = "Mã KH";
            // 
            // btnSELECT
            // 
            this.btnSELECT.BackColor = System.Drawing.Color.Tomato;
            this.btnSELECT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSELECT.FlatAppearance.BorderSize = 0;
            this.btnSELECT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSELECT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSELECT.ForeColor = System.Drawing.Color.White;
            this.btnSELECT.Image = global::SaleManagement.Properties.Resources.checked_user_24;
            this.btnSELECT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSELECT.Location = new System.Drawing.Point(38, 511);
            this.btnSELECT.Name = "btnSELECT";
            this.btnSELECT.Size = new System.Drawing.Size(248, 61);
            this.btnSELECT.TabIndex = 153;
            this.btnSELECT.Text = "Chọn khách hàng";
            this.btnSELECT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSELECT.UseVisualStyleBackColor = false;
            this.btnSELECT.Click += new System.EventHandler(this.btnSELECT_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::SaleManagement.Properties.Resources.add_user_24;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(37, 444);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(122, 61);
            this.btnADD.TabIndex = 149;
            this.btnADD.Text = "Thêm";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(165, 444);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(121, 61);
            this.btnSAVE.TabIndex = 150;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(657, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSelect_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 618);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSELECT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.dgvLISTCUSTOMER);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbGENDER);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtPHONE);
            this.Controls.Add(this.txtNAME_CUSTOMER);
            this.Controls.Add(this.txtID_CUSTOMER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "FrmSelect_Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn khách hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTCUSTOMER)).EndInit();
            this.gbGENDER.ResumeLayout(false);
            this.gbGENDER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSELECT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.DataGridView dgvLISTCUSTOMER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbGENDER;
        private System.Windows.Forms.RadioButton rbFEMALE;
        private System.Windows.Forms.RadioButton rbMALE;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtNAME_CUSTOMER;
        private System.Windows.Forms.TextBox txtID_CUSTOMER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}