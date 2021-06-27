
namespace SaleManagement.FORM
{
    partial class FrmList_SaleInvoice
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
            this.txtPRICE_ = new System.Windows.Forms.TextBox();
            this.txtID_INVOICE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dpDAY = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvLIST_INVOICE = new System.Windows.Forms.DataGridView();
            this.dgvINFO_INVOICE = new System.Windows.Forms.DataGridView();
            this.lbInvoiceDetail = new System.Windows.Forms.Label();
            this.dpFROM = new System.Windows.Forms.DateTimePicker();
            this.dpTO = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.cbbCUSTOMER = new System.Windows.Forms.ComboBox();
            this.cbbSTAFF = new System.Windows.Forms.ComboBox();
            this.txtDISCOUNT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnEditQuantityProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnEditInvoice = new System.Windows.Forms.Button();
            this.btnFrmData = new System.Windows.Forms.Button();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.btnDeleteInvoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbIdInvoice = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_INVOICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINFO_INVOICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPRICE_
            // 
            this.txtPRICE_.BackColor = System.Drawing.SystemColors.Info;
            this.txtPRICE_.Enabled = false;
            this.txtPRICE_.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRICE_.ForeColor = System.Drawing.Color.Black;
            this.txtPRICE_.Location = new System.Drawing.Point(150, 297);
            this.txtPRICE_.Name = "txtPRICE_";
            this.txtPRICE_.Size = new System.Drawing.Size(236, 29);
            this.txtPRICE_.TabIndex = 96;
            // 
            // txtID_INVOICE
            // 
            this.txtID_INVOICE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtID_INVOICE.Enabled = false;
            this.txtID_INVOICE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_INVOICE.ForeColor = System.Drawing.Color.IndianRed;
            this.txtID_INVOICE.Location = new System.Drawing.Point(150, 136);
            this.txtID_INVOICE.Name = "txtID_INVOICE";
            this.txtID_INVOICE.Size = new System.Drawing.Size(237, 29);
            this.txtID_INVOICE.TabIndex = 93;
            this.txtID_INVOICE.TextChanged += new System.EventHandler(this.txtID_INVOICE_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 92;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 22);
            this.label3.TabIndex = 91;
            this.label3.Text = "Khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 90;
            this.label6.Text = "Thu ngân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 89;
            this.label7.Text = "Mã Đơn";
            // 
            // dpDAY
            // 
            this.dpDAY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDAY.Location = new System.Drawing.Point(150, 174);
            this.dpDAY.Name = "dpDAY";
            this.dpDAY.Size = new System.Drawing.Size(236, 29);
            this.dpDAY.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 106;
            this.label9.Text = "Ngày lập";
            // 
            // dgvLIST_INVOICE
            // 
            this.dgvLIST_INVOICE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLIST_INVOICE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLIST_INVOICE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLIST_INVOICE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLIST_INVOICE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLIST_INVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLIST_INVOICE.Location = new System.Drawing.Point(399, 136);
            this.dgvLIST_INVOICE.Name = "dgvLIST_INVOICE";
            this.dgvLIST_INVOICE.RowHeadersVisible = false;
            this.dgvLIST_INVOICE.RowHeadersWidth = 62;
            this.dgvLIST_INVOICE.RowTemplate.Height = 28;
            this.dgvLIST_INVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLIST_INVOICE.Size = new System.Drawing.Size(836, 239);
            this.dgvLIST_INVOICE.TabIndex = 108;
            this.dgvLIST_INVOICE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLIST_INVOICE_CellClick);
            this.dgvLIST_INVOICE.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLIST_INVOICE_CellFormatting);
            // 
            // dgvINFO_INVOICE
            // 
            this.dgvINFO_INVOICE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvINFO_INVOICE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvINFO_INVOICE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvINFO_INVOICE.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvINFO_INVOICE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvINFO_INVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINFO_INVOICE.Location = new System.Drawing.Point(399, 437);
            this.dgvINFO_INVOICE.Name = "dgvINFO_INVOICE";
            this.dgvINFO_INVOICE.RowHeadersVisible = false;
            this.dgvINFO_INVOICE.RowHeadersWidth = 62;
            this.dgvINFO_INVOICE.RowTemplate.Height = 28;
            this.dgvINFO_INVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvINFO_INVOICE.Size = new System.Drawing.Size(836, 184);
            this.dgvINFO_INVOICE.TabIndex = 111;
            this.dgvINFO_INVOICE.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvINFO_INVOICE_CellFormatting);
            // 
            // lbInvoiceDetail
            // 
            this.lbInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceDetail.AutoSize = true;
            this.lbInvoiceDetail.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoiceDetail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbInvoiceDetail.Location = new System.Drawing.Point(912, 397);
            this.lbInvoiceDetail.Name = "lbInvoiceDetail";
            this.lbInvoiceDetail.Size = new System.Drawing.Size(187, 27);
            this.lbInvoiceDetail.TabIndex = 112;
            this.lbInvoiceDetail.Text = "Chi tiết hóa đơn";
            this.lbInvoiceDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dpFROM
            // 
            this.dpFROM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFROM.Location = new System.Drawing.Point(409, 402);
            this.dpFROM.Name = "dpFROM";
            this.dpFROM.Size = new System.Drawing.Size(156, 29);
            this.dpFROM.TabIndex = 120;
            this.dpFROM.ValueChanged += new System.EventHandler(this.dpTO_ValueChanged);
            // 
            // dpTO
            // 
            this.dpTO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTO.Location = new System.Drawing.Point(595, 402);
            this.dpTO.Name = "dpTO";
            this.dpTO.Size = new System.Drawing.Size(156, 29);
            this.dpTO.TabIndex = 121;
            this.dpTO.ValueChanged += new System.EventHandler(this.dpTO_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 122;
            this.label2.Text = "Từ ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(626, 378);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 22);
            this.label10.TabIndex = 123;
            this.label10.Text = "Đến ngày";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(399, 93);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(382, 29);
            this.txtSEARCH.TabIndex = 125;
            this.txtSEARCH.Text = "Nhập mã hóa đơn hoặc mã/ tên khách hàng";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // cbbCUSTOMER
            // 
            this.cbbCUSTOMER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCUSTOMER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCUSTOMER.FormattingEnabled = true;
            this.cbbCUSTOMER.Location = new System.Drawing.Point(150, 254);
            this.cbbCUSTOMER.Name = "cbbCUSTOMER";
            this.cbbCUSTOMER.Size = new System.Drawing.Size(236, 30);
            this.cbbCUSTOMER.TabIndex = 126;
            // 
            // cbbSTAFF
            // 
            this.cbbSTAFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSTAFF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSTAFF.FormattingEnabled = true;
            this.cbbSTAFF.Location = new System.Drawing.Point(150, 214);
            this.cbbSTAFF.Name = "cbbSTAFF";
            this.cbbSTAFF.Size = new System.Drawing.Size(236, 30);
            this.cbbSTAFF.TabIndex = 127;
            // 
            // txtDISCOUNT
            // 
            this.txtDISCOUNT.BackColor = System.Drawing.SystemColors.Info;
            this.txtDISCOUNT.Enabled = false;
            this.txtDISCOUNT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDISCOUNT.ForeColor = System.Drawing.Color.Black;
            this.txtDISCOUNT.Location = new System.Drawing.Point(150, 337);
            this.txtDISCOUNT.Name = "txtDISCOUNT";
            this.txtDISCOUNT.Size = new System.Drawing.Size(236, 29);
            this.txtDISCOUNT.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 128;
            this.label12.Text = "Giảm giá";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(459, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 27);
            this.label1.TabIndex = 135;
            this.label1.Text = "Danh sách hóa đơn bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.btnHome.Location = new System.Drawing.Point(5, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 65);
            this.btnHome.TabIndex = 134;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Image = global::SaleManagement.Properties.Resources.product_24;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(829, 635);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(140, 48);
            this.btnAddProduct.TabIndex = 133;
            this.btnAddProduct.Text = "Thêm HH";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditQuantityProduct
            // 
            this.btnEditQuantityProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditQuantityProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditQuantityProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditQuantityProduct.FlatAppearance.BorderSize = 0;
            this.btnEditQuantityProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditQuantityProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditQuantityProduct.ForeColor = System.Drawing.Color.White;
            this.btnEditQuantityProduct.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEditQuantityProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditQuantityProduct.Location = new System.Drawing.Point(975, 634);
            this.btnEditQuantityProduct.Name = "btnEditQuantityProduct";
            this.btnEditQuantityProduct.Size = new System.Drawing.Size(129, 48);
            this.btnEditQuantityProduct.TabIndex = 132;
            this.btnEditQuantityProduct.Text = "Sửa SL";
            this.btnEditQuantityProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditQuantityProduct.UseVisualStyleBackColor = false;
            this.btnEditQuantityProduct.Click += new System.EventHandler(this.btnEditQuantityProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduct.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProduct.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.Location = new System.Drawing.Point(1110, 634);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(125, 47);
            this.btnDeleteProduct.TabIndex = 131;
            this.btnDeleteProduct.Text = "Xóa HH";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnExport
            // 
            this.btnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExport.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = global::SaleManagement.Properties.Resources.excel_3_24;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(840, 81);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(152, 48);
            this.btnExport.TabIndex = 118;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnEditInvoice
            // 
            this.btnEditInvoice.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditInvoice.FlatAppearance.BorderSize = 0;
            this.btnEditInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditInvoice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditInvoice.ForeColor = System.Drawing.Color.White;
            this.btnEditInvoice.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEditInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditInvoice.Location = new System.Drawing.Point(40, 403);
            this.btnEditInvoice.Name = "btnEditInvoice";
            this.btnEditInvoice.Size = new System.Drawing.Size(131, 61);
            this.btnEditInvoice.TabIndex = 101;
            this.btnEditInvoice.Text = "Sửa đơn";
            this.btnEditInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditInvoice.UseVisualStyleBackColor = false;
            this.btnEditInvoice.Click += new System.EventHandler(this.btnEditInvoice_Click);
            // 
            // btnFrmData
            // 
            this.btnFrmData.BackColor = System.Drawing.Color.SteelBlue;
            this.btnFrmData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFrmData.FlatAppearance.BorderSize = 0;
            this.btnFrmData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFrmData.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrmData.ForeColor = System.Drawing.Color.White;
            this.btnFrmData.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnFrmData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFrmData.Location = new System.Drawing.Point(1076, 5);
            this.btnFrmData.Name = "btnFrmData";
            this.btnFrmData.Size = new System.Drawing.Size(166, 65);
            this.btnFrmData.TabIndex = 105;
            this.btnFrmData.Text = "Quay lại";
            this.btnFrmData.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFrmData.UseVisualStyleBackColor = false;
            this.btnFrmData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSaveChange.FlatAppearance.BorderSize = 0;
            this.btnSaveChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChange.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChange.ForeColor = System.Drawing.Color.White;
            this.btnSaveChange.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSaveChange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChange.Location = new System.Drawing.Point(179, 403);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(132, 61);
            this.btnSaveChange.TabIndex = 103;
            this.btnSaveChange.Text = "Lưu";
            this.btnSaveChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveChange.UseVisualStyleBackColor = false;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // btnDeleteInvoice
            // 
            this.btnDeleteInvoice.BackColor = System.Drawing.Color.IndianRed;
            this.btnDeleteInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.FlatAppearance.BorderSize = 0;
            this.btnDeleteInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteInvoice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteInvoice.ForeColor = System.Drawing.Color.White;
            this.btnDeleteInvoice.Image = global::SaleManagement.Properties.Resources.delete_property_24;
            this.btnDeleteInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteInvoice.Location = new System.Drawing.Point(40, 470);
            this.btnDeleteInvoice.Name = "btnDeleteInvoice";
            this.btnDeleteInvoice.Size = new System.Drawing.Size(271, 59);
            this.btnDeleteInvoice.TabIndex = 102;
            this.btnDeleteInvoice.Text = "Xóa đơn bán hàng";
            this.btnDeleteInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteInvoice.UseVisualStyleBackColor = false;
            this.btnDeleteInvoice.Click += new System.EventHandler(this.btnDeleteInvoice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(787, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // lbIdInvoice
            // 
            this.lbIdInvoice.AutoSize = true;
            this.lbIdInvoice.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdInvoice.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbIdInvoice.Location = new System.Drawing.Point(1114, 397);
            this.lbIdInvoice.Name = "lbIdInvoice";
            this.lbIdInvoice.Size = new System.Drawing.Size(0, 27);
            this.lbIdInvoice.TabIndex = 137;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.lbQuantity.Location = new System.Drawing.Point(232, 572);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(0, 22);
            this.lbQuantity.TabIndex = 146;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(36, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 22);
            this.label8.TabIndex = 145;
            this.label8.Text = "Số lượng đơn hàng:";
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTotalMoney.Location = new System.Drawing.Point(232, 611);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(0, 22);
            this.lbTotalMoney.TabIndex = 148;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(36, 611);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 22);
            this.label11.TabIndex = 147;
            this.label11.Text = "Tổng tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(571, 407);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 22);
            this.label5.TabIndex = 176;
            this.label5.Text = "-";
            // 
            // FrmList_SaleInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 691);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTotalMoney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbIdInvoice);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnEditQuantityProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.txtDISCOUNT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbSTAFF);
            this.Controls.Add(this.cbbCUSTOMER);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpTO);
            this.Controls.Add(this.dpFROM);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lbInvoiceDetail);
            this.Controls.Add(this.dgvINFO_INVOICE);
            this.Controls.Add(this.dgvLIST_INVOICE);
            this.Controls.Add(this.dpDAY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEditInvoice);
            this.Controls.Add(this.btnFrmData);
            this.Controls.Add(this.btnSaveChange);
            this.Controls.Add(this.btnDeleteInvoice);
            this.Controls.Add(this.txtPRICE_);
            this.Controls.Add(this.txtID_INVOICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "FrmList_SaleInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_INVOICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINFO_INVOICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEditInvoice;
        private System.Windows.Forms.Button btnFrmData;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Button btnDeleteInvoice;
        private System.Windows.Forms.TextBox txtPRICE_;
        private System.Windows.Forms.TextBox txtID_INVOICE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpDAY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvLIST_INVOICE;
        private System.Windows.Forms.DataGridView dgvINFO_INVOICE;
        private System.Windows.Forms.Label lbInvoiceDetail;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DateTimePicker dpFROM;
        private System.Windows.Forms.DateTimePicker dpTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.ComboBox cbbCUSTOMER;
        private System.Windows.Forms.ComboBox cbbSTAFF;
        private System.Windows.Forms.TextBox txtDISCOUNT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditQuantityProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbIdInvoice;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
    }
}