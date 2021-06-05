
namespace SaleManagement.FORM
{
    partial class FrmAdd_NewProduct
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
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnADD_PRODUCT = new System.Windows.Forms.Button();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.cbbTYPE_OF_PRODUCT = new System.Windows.Forms.ComboBox();
            this.lbID_PRODUCT = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQUANTITY = new System.Windows.Forms.TextBox();
            this.txtDISCOUNT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSTATUS = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(735, 303);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(146, 46);
            this.btnCANCEL.TabIndex = 96;
            this.btnCANCEL.Text = "Hủy bỏ";
            this.btnCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnADD_PRODUCT
            // 
            this.btnADD_PRODUCT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD_PRODUCT.FlatAppearance.BorderSize = 0;
            this.btnADD_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD_PRODUCT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.btnADD_PRODUCT.Image = global::SaleManagement.Properties.Resources.product_24;
            this.btnADD_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD_PRODUCT.Location = new System.Drawing.Point(735, 241);
            this.btnADD_PRODUCT.Name = "btnADD_PRODUCT";
            this.btnADD_PRODUCT.Size = new System.Drawing.Size(146, 48);
            this.btnADD_PRODUCT.TabIndex = 134;
            this.btnADD_PRODUCT.Text = "Thêm HH";
            this.btnADD_PRODUCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD_PRODUCT.UseVisualStyleBackColor = false;
            this.btnADD_PRODUCT.Click += new System.EventHandler(this.btnADD_PRODUCT_Click);
            // 
            // btnSHOW
            // 
            this.btnSHOW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSHOW.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSHOW.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSHOW.FlatAppearance.BorderSize = 0;
            this.btnSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHOW.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHOW.ForeColor = System.Drawing.Color.White;
            this.btnSHOW.Image = global::SaleManagement.Properties.Resources.activity_feed_24;
            this.btnSHOW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHOW.Location = new System.Drawing.Point(590, 34);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(119, 48);
            this.btnSHOW.TabIndex = 135;
            this.btnSHOW.Text = "Liệt kê";
            this.btnSHOW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.btnSHOW_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(12, 88);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 62;
            this.dgvProduct.RowTemplate.Height = 28;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(697, 279);
            this.dgvProduct.TabIndex = 136;
            this.dgvProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProduct_CellFormatting);
            // 
            // cbbTYPE_OF_PRODUCT
            // 
            this.cbbTYPE_OF_PRODUCT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbTYPE_OF_PRODUCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPE_OF_PRODUCT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPE_OF_PRODUCT.FormattingEnabled = true;
            this.cbbTYPE_OF_PRODUCT.Location = new System.Drawing.Point(317, 45);
            this.cbbTYPE_OF_PRODUCT.Name = "cbbTYPE_OF_PRODUCT";
            this.cbbTYPE_OF_PRODUCT.Size = new System.Drawing.Size(267, 30);
            this.cbbTYPE_OF_PRODUCT.TabIndex = 137;
            // 
            // lbID_PRODUCT
            // 
            this.lbID_PRODUCT.AutoSize = true;
            this.lbID_PRODUCT.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID_PRODUCT.Location = new System.Drawing.Point(12, 45);
            this.lbID_PRODUCT.Name = "lbID_PRODUCT";
            this.lbID_PRODUCT.Size = new System.Drawing.Size(141, 29);
            this.lbID_PRODUCT.TabIndex = 138;
            this.lbID_PRODUCT.Text = "Mã hóa đơn";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(12, 394);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(309, 29);
            this.txtSEARCH.TabIndex = 140;
            this.txtSEARCH.Text = "Nhập mã hoặc tên hàng hóa";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(715, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 29);
            this.label1.TabIndex = 141;
            this.label1.Text = "SL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 29);
            this.label2.TabIndex = 142;
            this.label2.Text = "K/Mãi";
            // 
            // txtQUANTITY
            // 
            this.txtQUANTITY.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUANTITY.Location = new System.Drawing.Point(797, 93);
            this.txtQUANTITY.Name = "txtQUANTITY";
            this.txtQUANTITY.Size = new System.Drawing.Size(59, 27);
            this.txtQUANTITY.TabIndex = 143;
            this.txtQUANTITY.TextChanged += new System.EventHandler(this.txtQUANTITY_TextChanged);
            this.txtQUANTITY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQUANTITY_KeyPress);
            // 
            // txtDISCOUNT
            // 
            this.txtDISCOUNT.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDISCOUNT.Location = new System.Drawing.Point(797, 141);
            this.txtDISCOUNT.Name = "txtDISCOUNT";
            this.txtDISCOUNT.Size = new System.Drawing.Size(59, 27);
            this.txtDISCOUNT.TabIndex = 144;
            this.txtDISCOUNT.TextChanged += new System.EventHandler(this.txtDISCOUNT_TextChanged);
            this.txtDISCOUNT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDISCOUNT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(862, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 29);
            this.label3.TabIndex = 145;
            this.label3.Text = "%";
            // 
            // lbSTATUS
            // 
            this.lbSTATUS.AutoSize = true;
            this.lbSTATUS.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSTATUS.Location = new System.Drawing.Point(715, 44);
            this.lbSTATUS.Name = "lbSTATUS";
            this.lbSTATUS.Size = new System.Drawing.Size(0, 27);
            this.lbSTATUS.TabIndex = 146;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(327, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAdd_NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbSTATUS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDISCOUNT);
            this.Controls.Add(this.txtQUANTITY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.lbID_PRODUCT);
            this.Controls.Add(this.cbbTYPE_OF_PRODUCT);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.btnADD_PRODUCT);
            this.Controls.Add(this.btnCANCEL);
            this.Name = "FrmAdd_NewProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hàng hóa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnADD_PRODUCT;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.ComboBox cbbTYPE_OF_PRODUCT;
        private System.Windows.Forms.Label lbID_PRODUCT;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQUANTITY;
        private System.Windows.Forms.TextBox txtDISCOUNT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSTATUS;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}