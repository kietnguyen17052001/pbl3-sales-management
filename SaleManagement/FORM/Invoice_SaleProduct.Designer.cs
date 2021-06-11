
namespace SaleManagement.VIEW
{
    partial class FrmInvoice_SaleProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoice_SaleProduct));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSelectProduct = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDiscountPercent = new System.Windows.Forms.TextBox();
            this.dgvInfoProduct = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantityOfSelect = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.btnSelectCustomer = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditQuantity = new System.Windows.Forms.Button();
            this.txtTotalQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.cbbStaff = new System.Windows.Forms.ComboBox();
            this.txtIdInvoice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPriceInvoice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtReturnMoney = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCustomerPay = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnLoadInvoice = new System.Windows.Forms.Button();
            this.btnDiscountMoney = new System.Windows.Forms.Button();
            this.btnDiscountPercent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtProduct);
            this.groupBox1.Controls.Add(this.btnSelectProduct);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDiscountPercent);
            this.groupBox1.Controls.Add(this.dgvInfoProduct);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtQuantityOfSelect);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 480);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(426, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 138;
            this.pictureBox1.TabStop = false;
            // 
            // txtProduct
            // 
            this.txtProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.ForeColor = System.Drawing.Color.Silver;
            this.txtProduct.Location = new System.Drawing.Point(6, 46);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(414, 29);
            this.txtProduct.TabIndex = 116;
            this.txtProduct.Text = "Nhập tên hoặc mã hàng hóa";
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            this.txtProduct.Enter += new System.EventHandler(this.txtProduct_Enter);
            this.txtProduct.Leave += new System.EventHandler(this.txtProduct_Leave);
            // 
            // btnSelectProduct
            // 
            this.btnSelectProduct.BackColor = System.Drawing.SystemColors.Control;
            this.btnSelectProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectProduct.FlatAppearance.BorderSize = 0;
            this.btnSelectProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSelectProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectProduct.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectProduct.ForeColor = System.Drawing.Color.White;
            this.btnSelectProduct.Image = global::SaleManagement.Properties.Resources.right;
            this.btnSelectProduct.Location = new System.Drawing.Point(485, 262);
            this.btnSelectProduct.Name = "btnSelectProduct";
            this.btnSelectProduct.Size = new System.Drawing.Size(49, 50);
            this.btnSelectProduct.TabIndex = 55;
            this.btnSelectProduct.UseVisualStyleBackColor = false;
            this.btnSelectProduct.Click += new System.EventHandler(this.btnSelectProduct_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(529, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 19);
            this.label13.TabIndex = 63;
            this.label13.Text = "%";
            // 
            // txtDiscountPercent
            // 
            this.txtDiscountPercent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDiscountPercent.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercent.Location = new System.Drawing.Point(484, 219);
            this.txtDiscountPercent.Name = "txtDiscountPercent";
            this.txtDiscountPercent.Size = new System.Drawing.Size(44, 27);
            this.txtDiscountPercent.TabIndex = 26;
            this.txtDiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPercent.TextChanged += new System.EventHandler(this.txtDISCOUNT_ITEM_TextChanged);
            this.txtDiscountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRODUCT_DISCOUNT_KeyPress);
            // 
            // dgvInfoProduct
            // 
            this.dgvInfoProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInfoProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInfoProduct.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInfoProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInfoProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoProduct.GridColor = System.Drawing.Color.Silver;
            this.dgvInfoProduct.Location = new System.Drawing.Point(6, 96);
            this.dgvInfoProduct.Name = "dgvInfoProduct";
            this.dgvInfoProduct.RowHeadersVisible = false;
            this.dgvInfoProduct.RowHeadersWidth = 62;
            this.dgvInfoProduct.RowTemplate.Height = 28;
            this.dgvInfoProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfoProduct.Size = new System.Drawing.Size(466, 371);
            this.dgvInfoProduct.TabIndex = 36;
            this.dgvInfoProduct.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInfoProduct_CellFormatting);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(480, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "K.Mãi";
            // 
            // txtQuantityOfSelect
            // 
            this.txtQuantityOfSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantityOfSelect.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityOfSelect.Location = new System.Drawing.Point(484, 158);
            this.txtQuantityOfSelect.Name = "txtQuantityOfSelect";
            this.txtQuantityOfSelect.Size = new System.Drawing.Size(44, 27);
            this.txtQuantityOfSelect.TabIndex = 24;
            this.txtQuantityOfSelect.Text = "1";
            this.txtQuantityOfSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantityOfSelect.TextChanged += new System.EventHandler(this.txtAMOUNT_ITEM_TextChanged);
            this.txtQuantityOfSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRODUCT_DISCOUNT_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(473, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Số lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dpDate);
            this.groupBox2.Controls.Add(this.txtCustomer);
            this.groupBox2.Controls.Add(this.btnSelectCustomer);
            this.groupBox2.Controls.Add(this.btnDeleteProduct);
            this.groupBox2.Controls.Add(this.btnEditQuantity);
            this.groupBox2.Controls.Add(this.txtTotalQuantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTotalProduct);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvInvoice);
            this.groupBox2.Controls.Add(this.cbbStaff);
            this.groupBox2.Controls.Add(this.txtIdInvoice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(567, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 480);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hóa đơn bán hàng";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 122;
            this.label4.Text = "Ngày lập";
            // 
            // dpDate
            // 
            this.dpDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate.Location = new System.Drawing.Point(124, 75);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(172, 29);
            this.dpDate.TabIndex = 123;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCustomer.Enabled = false;
            this.txtCustomer.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Location = new System.Drawing.Point(421, 75);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(187, 29);
            this.txtCustomer.TabIndex = 82;
            // 
            // btnSelectCustomer
            // 
            this.btnSelectCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSelectCustomer.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSelectCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSelectCustomer.FlatAppearance.BorderSize = 0;
            this.btnSelectCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectCustomer.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelectCustomer.Image = global::SaleManagement.Properties.Resources.user_5_24;
            this.btnSelectCustomer.Location = new System.Drawing.Point(614, 68);
            this.btnSelectCustomer.Name = "btnSelectCustomer";
            this.btnSelectCustomer.Size = new System.Drawing.Size(57, 43);
            this.btnSelectCustomer.TabIndex = 81;
            this.btnSelectCustomer.UseVisualStyleBackColor = false;
            this.btnSelectCustomer.Click += new System.EventHandler(this.btnSelectCustomer_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(560, 422);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(102, 48);
            this.btnDeleteProduct.TabIndex = 64;
            this.btnDeleteProduct.Text = "Xóa";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditQuantity
            // 
            this.btnEditQuantity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEditQuantity.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditQuantity.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditQuantity.FlatAppearance.BorderSize = 0;
            this.btnEditQuantity.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuantity.ForeColor = System.Drawing.Color.White;
            this.btnEditQuantity.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEditQuantity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditQuantity.Location = new System.Drawing.Point(443, 422);
            this.btnEditQuantity.Name = "btnEditQuantity";
            this.btnEditQuantity.Size = new System.Drawing.Size(111, 48);
            this.btnEditQuantity.TabIndex = 63;
            this.btnEditQuantity.Text = "Sửa";
            this.btnEditQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditQuantity.UseVisualStyleBackColor = false;
            this.btnEditQuantity.Click += new System.EventHandler(this.btnEditQuantity_Click);
            // 
            // txtTotalQuantity
            // 
            this.txtTotalQuantity.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalQuantity.Enabled = false;
            this.txtTotalQuantity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalQuantity.Location = new System.Drawing.Point(311, 439);
            this.txtTotalQuantity.Name = "txtTotalQuantity";
            this.txtTotalQuantity.Size = new System.Drawing.Size(45, 28);
            this.txtTotalQuantity.TabIndex = 41;
            this.txtTotalQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "Số lượng";
            // 
            // txtTotalProduct
            // 
            this.txtTotalProduct.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalProduct.Enabled = false;
            this.txtTotalProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalProduct.Location = new System.Drawing.Point(143, 439);
            this.txtTotalProduct.Name = "txtTotalProduct";
            this.txtTotalProduct.Size = new System.Drawing.Size(49, 28);
            this.txtTotalProduct.TabIndex = 39;
            this.txtTotalProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Số hàng hóa";
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInvoice.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.GridColor = System.Drawing.Color.Silver;
            this.dgvInvoice.Location = new System.Drawing.Point(15, 118);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersVisible = false;
            this.dgvInvoice.RowHeadersWidth = 62;
            this.dgvInvoice.RowTemplate.Height = 28;
            this.dgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoice.Size = new System.Drawing.Size(656, 297);
            this.dgvInvoice.TabIndex = 37;
            this.dgvInvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvInvoice_CellFormatting);
            // 
            // cbbStaff
            // 
            this.cbbStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStaff.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStaff.FormattingEnabled = true;
            this.cbbStaff.Location = new System.Drawing.Point(421, 28);
            this.cbbStaff.Name = "cbbStaff";
            this.cbbStaff.Size = new System.Drawing.Size(247, 30);
            this.cbbStaff.TabIndex = 28;
            // 
            // txtIdInvoice
            // 
            this.txtIdInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIdInvoice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdInvoice.Location = new System.Drawing.Point(124, 35);
            this.txtIdInvoice.Name = "txtIdInvoice";
            this.txtIdInvoice.Size = new System.Drawing.Size(171, 29);
            this.txtIdInvoice.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nhân viên";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã hóa đơn";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(263, 604);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 19);
            this.label15.TabIndex = 68;
            this.label15.Text = "VNĐ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 558);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 19);
            this.label14.TabIndex = 67;
            this.label14.Text = "VNĐ";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDiscount.Location = new System.Drawing.Point(118, 599);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(139, 29);
            this.txtDiscount.TabIndex = 66;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 65;
            this.label6.Text = "Giảm ";
            // 
            // txtTotalMoney
            // 
            this.txtTotalMoney.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTotalMoney.Enabled = false;
            this.txtTotalMoney.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalMoney.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtTotalMoney.Location = new System.Drawing.Point(118, 553);
            this.txtTotalMoney.Name = "txtTotalMoney";
            this.txtTotalMoney.Size = new System.Drawing.Size(139, 29);
            this.txtTotalMoney.TabIndex = 64;
            this.txtTotalMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tổng cộng";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(550, 601);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 19);
            this.label16.TabIndex = 73;
            this.label16.Text = "VNĐ";
            // 
            // txtPriceInvoice
            // 
            this.txtPriceInvoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPriceInvoice.Enabled = false;
            this.txtPriceInvoice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceInvoice.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPriceInvoice.Location = new System.Drawing.Point(417, 597);
            this.txtPriceInvoice.Name = "txtPriceInvoice";
            this.txtPriceInvoice.Size = new System.Drawing.Size(125, 29);
            this.txtPriceInvoice.TabIndex = 72;
            this.txtPriceInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(312, 600);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 22);
            this.label17.TabIndex = 71;
            this.label17.Text = "Thành tiền";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(884, 601);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 19);
            this.label18.TabIndex = 79;
            this.label18.Text = "VNĐ";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(884, 555);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 19);
            this.label19.TabIndex = 78;
            this.label19.Text = "VNĐ";
            // 
            // txtReturnMoney
            // 
            this.txtReturnMoney.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtReturnMoney.Enabled = false;
            this.txtReturnMoney.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReturnMoney.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtReturnMoney.Location = new System.Drawing.Point(739, 597);
            this.txtReturnMoney.Name = "txtReturnMoney";
            this.txtReturnMoney.Size = new System.Drawing.Size(139, 29);
            this.txtReturnMoney.TabIndex = 77;
            this.txtReturnMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(600, 599);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(141, 22);
            this.label20.TabIndex = 76;
            this.label20.Text = "Tiền trả khách";
            // 
            // txtCustomerPay
            // 
            this.txtCustomerPay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtCustomerPay.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPay.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCustomerPay.Location = new System.Drawing.Point(739, 551);
            this.txtCustomerPay.Name = "txtCustomerPay";
            this.txtCustomerPay.Size = new System.Drawing.Size(139, 29);
            this.txtCustomerPay.TabIndex = 75;
            this.txtCustomerPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomerPay.TextChanged += new System.EventHandler(this.txtSEND_BY_CUSTOMER_TextChanged);
            this.txtCustomerPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPRODUCT_DISCOUNT_KeyPress);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(600, 553);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(141, 22);
            this.label21.TabIndex = 74;
            this.label21.Text = "Tiền khách trả";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(954, 553);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 22);
            this.label22.TabIndex = 84;
            this.label22.Text = "Lưu ý";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNote.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.ForeColor = System.Drawing.Color.Silver;
            this.txtNote.Location = new System.Drawing.Point(1021, 552);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(223, 72);
            this.txtNote.TabIndex = 85;
            this.txtNote.Text = "Nhập thông tin ...";
            this.txtNote.Enter += new System.EventHandler(this.txtNOTE_Enter);
            this.txtNote.Leave += new System.EventHandler(this.txtNOTE_Leave);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(518, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 31);
            this.label1.TabIndex = 121;
            this.label1.Text = "Hóa đơn bán hàng";
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(1047, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 65);
            this.btnHome.TabIndex = 87;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = global::SaleManagement.Properties.Resources.printer_3_24;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(873, 638);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(202, 44);
            this.btnPrint.TabIndex = 86;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPayment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Image = global::SaleManagement.Properties.Resources.bank_cards_24;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(680, 639);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(187, 44);
            this.btnPayment.TabIndex = 83;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnLoadInvoice
            // 
            this.btnLoadInvoice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoadInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLoadInvoice.FlatAppearance.BorderSize = 0;
            this.btnLoadInvoice.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnLoadInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadInvoice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadInvoice.ForeColor = System.Drawing.Color.White;
            this.btnLoadInvoice.Image = global::SaleManagement.Properties.Resources.sinchronize_24;
            this.btnLoadInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadInvoice.Location = new System.Drawing.Point(1081, 638);
            this.btnLoadInvoice.Name = "btnLoadInvoice";
            this.btnLoadInvoice.Size = new System.Drawing.Size(163, 46);
            this.btnLoadInvoice.TabIndex = 81;
            this.btnLoadInvoice.Text = "Làm mới";
            this.btnLoadInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadInvoice.UseVisualStyleBackColor = false;
            this.btnLoadInvoice.Click += new System.EventHandler(this.btnLoadInvoice_Click);
            // 
            // btnDiscountMoney
            // 
            this.btnDiscountMoney.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiscountMoney.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiscountMoney.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiscountMoney.FlatAppearance.BorderSize = 0;
            this.btnDiscountMoney.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnDiscountMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountMoney.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountMoney.ForeColor = System.Drawing.Color.White;
            this.btnDiscountMoney.Image = global::SaleManagement.Properties.Resources.banknotes_24;
            this.btnDiscountMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscountMoney.Location = new System.Drawing.Point(177, 639);
            this.btnDiscountMoney.Name = "btnDiscountMoney";
            this.btnDiscountMoney.Size = new System.Drawing.Size(159, 43);
            this.btnDiscountMoney.TabIndex = 70;
            this.btnDiscountMoney.Text = "Giảm tiền";
            this.btnDiscountMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscountMoney.UseVisualStyleBackColor = false;
            this.btnDiscountMoney.Click += new System.EventHandler(this.btnDiscountMoney_Click);
            // 
            // btnDiscountPercent
            // 
            this.btnDiscountPercent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDiscountPercent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDiscountPercent.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDiscountPercent.FlatAppearance.BorderSize = 0;
            this.btnDiscountPercent.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnDiscountPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscountPercent.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountPercent.ForeColor = System.Drawing.Color.White;
            this.btnDiscountPercent.Image = global::SaleManagement.Properties.Resources.percentage_3_24;
            this.btnDiscountPercent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiscountPercent.Location = new System.Drawing.Point(14, 639);
            this.btnDiscountPercent.Name = "btnDiscountPercent";
            this.btnDiscountPercent.Size = new System.Drawing.Size(157, 43);
            this.btnDiscountPercent.TabIndex = 69;
            this.btnDiscountPercent.Text = "Giảm %";
            this.btnDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDiscountPercent.UseVisualStyleBackColor = false;
            this.btnDiscountPercent.Click += new System.EventHandler(this.btnDiscountPercent_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(6, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 46);
            this.btnBack.TabIndex = 122;
            this.btnBack.Text = "Quay lại";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmInvoice_SaleProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 691);
            this.ControlBox = false;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnPayment);
            this.Controls.Add(this.btnLoadInvoice);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtReturnMoney);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtCustomerPay);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPriceInvoice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnDiscountMoney);
            this.Controls.Add(this.btnDiscountPercent);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotalMoney);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInvoice_SaleProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDiscountPercent;
        private System.Windows.Forms.DataGridView dgvInfoProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantityOfSelect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSelectProduct;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.ComboBox cbbStaff;
        private System.Windows.Forms.TextBox txtIdInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditQuantity;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalMoney;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDiscountMoney;
        private System.Windows.Forms.Button btnDiscountPercent;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPriceInvoice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtReturnMoney;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCustomerPay;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnLoadInvoice;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnSelectCustomer;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Button btnBack;
    }
}