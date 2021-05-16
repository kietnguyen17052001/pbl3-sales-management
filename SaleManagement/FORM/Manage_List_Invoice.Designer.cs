
namespace SaleManagement.FORM
{
    partial class FrmManage_List_Invoice
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
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPRICE = new System.Windows.Forms.TextBox();
            this.txtAMOUNT = new System.Windows.Forms.TextBox();
            this.cbbSTAFF_DETAIL = new System.Windows.Forms.ComboBox();
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
            this.btnHOME = new System.Windows.Forms.Button();
            this.btnADD_PRODUCT = new System.Windows.Forms.Button();
            this.btnEDIT_QUANTITY = new System.Windows.Forms.Button();
            this.btnDELETE_PRODUCT = new System.Windows.Forms.Button();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_INVOICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINFO_INVOICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPRICE_
            // 
            this.txtPRICE_.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRICE_.ForeColor = System.Drawing.Color.Black;
            this.txtPRICE_.Location = new System.Drawing.Point(144, 297);
            this.txtPRICE_.Name = "txtPRICE_";
            this.txtPRICE_.Size = new System.Drawing.Size(236, 28);
            this.txtPRICE_.TabIndex = 96;
            // 
            // txtID_INVOICE
            // 
            this.txtID_INVOICE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_INVOICE.Location = new System.Drawing.Point(144, 136);
            this.txtID_INVOICE.Name = "txtID_INVOICE";
            this.txtID_INVOICE.Size = new System.Drawing.Size(237, 28);
            this.txtID_INVOICE.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = "Khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 21);
            this.label6.TabIndex = 90;
            this.label6.Text = "Thu ngân";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 21);
            this.label7.TabIndex = 89;
            this.label7.Text = "Mã Đơn";
            // 
            // dpDAY
            // 
            this.dpDAY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDAY.Location = new System.Drawing.Point(144, 174);
            this.dpDAY.Name = "dpDAY";
            this.dpDAY.Size = new System.Drawing.Size(236, 28);
            this.dpDAY.TabIndex = 107;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 21);
            this.label9.TabIndex = 106;
            this.label9.Text = "Ngày lập";
            // 
            // dgvLIST_INVOICE
            // 
            this.dgvLIST_INVOICE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLIST_INVOICE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLIST_INVOICE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLIST_INVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLIST_INVOICE.Location = new System.Drawing.Point(399, 136);
            this.dgvLIST_INVOICE.Name = "dgvLIST_INVOICE";
            this.dgvLIST_INVOICE.RowHeadersWidth = 62;
            this.dgvLIST_INVOICE.RowTemplate.Height = 28;
            this.dgvLIST_INVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLIST_INVOICE.Size = new System.Drawing.Size(836, 242);
            this.dgvLIST_INVOICE.TabIndex = 108;
            this.dgvLIST_INVOICE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLIST_INVOICE_CellClick);
            // 
            // dgvINFO_INVOICE
            // 
            this.dgvINFO_INVOICE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvINFO_INVOICE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvINFO_INVOICE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvINFO_INVOICE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvINFO_INVOICE.Location = new System.Drawing.Point(399, 437);
            this.dgvINFO_INVOICE.Name = "dgvINFO_INVOICE";
            this.dgvINFO_INVOICE.RowHeadersWidth = 62;
            this.dgvINFO_INVOICE.RowTemplate.Height = 28;
            this.dgvINFO_INVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvINFO_INVOICE.Size = new System.Drawing.Size(836, 184);
            this.dgvINFO_INVOICE.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(983, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 26);
            this.label5.TabIndex = 112;
            this.label5.Text = "THÔNG TIN ĐƠN HÀNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(23, 635);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 29);
            this.label8.TabIndex = 115;
            this.label8.Text = "Tổng tiền";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(23, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 29);
            this.label11.TabIndex = 113;
            this.label11.Text = "Số lượng đơn";
            // 
            // txtPRICE
            // 
            this.txtPRICE.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRICE.ForeColor = System.Drawing.Color.IndianRed;
            this.txtPRICE.Location = new System.Drawing.Point(202, 634);
            this.txtPRICE.Name = "txtPRICE";
            this.txtPRICE.Size = new System.Drawing.Size(179, 35);
            this.txtPRICE.TabIndex = 117;
            // 
            // txtAMOUNT
            // 
            this.txtAMOUNT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAMOUNT.ForeColor = System.Drawing.Color.IndianRed;
            this.txtAMOUNT.Location = new System.Drawing.Point(202, 586);
            this.txtAMOUNT.Name = "txtAMOUNT";
            this.txtAMOUNT.Size = new System.Drawing.Size(179, 35);
            this.txtAMOUNT.TabIndex = 116;
            // 
            // cbbSTAFF_DETAIL
            // 
            this.cbbSTAFF_DETAIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSTAFF_DETAIL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSTAFF_DETAIL.FormattingEnabled = true;
            this.cbbSTAFF_DETAIL.Location = new System.Drawing.Point(399, 93);
            this.cbbSTAFF_DETAIL.Name = "cbbSTAFF_DETAIL";
            this.cbbSTAFF_DETAIL.Size = new System.Drawing.Size(201, 29);
            this.cbbSTAFF_DETAIL.TabIndex = 119;
            // 
            // dpFROM
            // 
            this.dpFROM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFROM.Location = new System.Drawing.Point(748, 94);
            this.dpFROM.Name = "dpFROM";
            this.dpFROM.Size = new System.Drawing.Size(156, 28);
            this.dpFROM.TabIndex = 120;
            // 
            // dpTO
            // 
            this.dpTO.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTO.Location = new System.Drawing.Point(910, 94);
            this.dpTO.Name = "dpTO";
            this.dpTO.Size = new System.Drawing.Size(156, 28);
            this.dpTO.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(782, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 122;
            this.label2.Text = "Từ ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(941, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 21);
            this.label10.TabIndex = 123;
            this.label10.Text = "Đến ngày";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(399, 395);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(382, 28);
            this.txtSEARCH.TabIndex = 125;
            this.txtSEARCH.Text = "Nhập mã hóa đơn hoặc mã/ tên khách hàng";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // cbbCUSTOMER
            // 
            this.cbbCUSTOMER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCUSTOMER.FormattingEnabled = true;
            this.cbbCUSTOMER.Location = new System.Drawing.Point(144, 254);
            this.cbbCUSTOMER.Name = "cbbCUSTOMER";
            this.cbbCUSTOMER.Size = new System.Drawing.Size(236, 29);
            this.cbbCUSTOMER.TabIndex = 126;
            // 
            // cbbSTAFF
            // 
            this.cbbSTAFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSTAFF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSTAFF.FormattingEnabled = true;
            this.cbbSTAFF.Location = new System.Drawing.Point(144, 214);
            this.cbbSTAFF.Name = "cbbSTAFF";
            this.cbbSTAFF.Size = new System.Drawing.Size(236, 29);
            this.cbbSTAFF.TabIndex = 127;
            // 
            // txtDISCOUNT
            // 
            this.txtDISCOUNT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDISCOUNT.ForeColor = System.Drawing.Color.Black;
            this.txtDISCOUNT.Location = new System.Drawing.Point(144, 337);
            this.txtDISCOUNT.Name = "txtDISCOUNT";
            this.txtDISCOUNT.Size = new System.Drawing.Size(236, 28);
            this.txtDISCOUNT.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 21);
            this.label12.TabIndex = 128;
            this.label12.Text = "Giảm giá";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(456, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 31);
            this.label1.TabIndex = 135;
            this.label1.Text = "Danh sách hóa đơn bán hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnHOME
            // 
            this.btnHOME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(1038, 2);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 65);
            this.btnHOME.TabIndex = 134;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // btnADD_PRODUCT
            // 
            this.btnADD_PRODUCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD_PRODUCT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD_PRODUCT.FlatAppearance.BorderSize = 0;
            this.btnADD_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD_PRODUCT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.btnADD_PRODUCT.Image = global::SaleManagement.Properties.Resources.product_24;
            this.btnADD_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD_PRODUCT.Location = new System.Drawing.Point(838, 635);
            this.btnADD_PRODUCT.Name = "btnADD_PRODUCT";
            this.btnADD_PRODUCT.Size = new System.Drawing.Size(136, 48);
            this.btnADD_PRODUCT.TabIndex = 133;
            this.btnADD_PRODUCT.Text = "Thêm HH";
            this.btnADD_PRODUCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD_PRODUCT.UseVisualStyleBackColor = false;
            this.btnADD_PRODUCT.Click += new System.EventHandler(this.btnADD_PRODUCT_Click);
            // 
            // btnEDIT_QUANTITY
            // 
            this.btnEDIT_QUANTITY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEDIT_QUANTITY.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT_QUANTITY.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEDIT_QUANTITY.FlatAppearance.BorderSize = 0;
            this.btnEDIT_QUANTITY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT_QUANTITY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT_QUANTITY.ForeColor = System.Drawing.Color.White;
            this.btnEDIT_QUANTITY.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEDIT_QUANTITY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT_QUANTITY.Location = new System.Drawing.Point(980, 634);
            this.btnEDIT_QUANTITY.Name = "btnEDIT_QUANTITY";
            this.btnEDIT_QUANTITY.Size = new System.Drawing.Size(129, 48);
            this.btnEDIT_QUANTITY.TabIndex = 132;
            this.btnEDIT_QUANTITY.Text = "Sửa SL";
            this.btnEDIT_QUANTITY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT_QUANTITY.UseVisualStyleBackColor = false;
            this.btnEDIT_QUANTITY.Click += new System.EventHandler(this.btnEDIT_QUANTITY_Click);
            // 
            // btnDELETE_PRODUCT
            // 
            this.btnDELETE_PRODUCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDELETE_PRODUCT.BackColor = System.Drawing.Color.IndianRed;
            this.btnDELETE_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDELETE_PRODUCT.FlatAppearance.BorderSize = 0;
            this.btnDELETE_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE_PRODUCT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.btnDELETE_PRODUCT.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnDELETE_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE_PRODUCT.Location = new System.Drawing.Point(1115, 635);
            this.btnDELETE_PRODUCT.Name = "btnDELETE_PRODUCT";
            this.btnDELETE_PRODUCT.Size = new System.Drawing.Size(120, 46);
            this.btnDELETE_PRODUCT.TabIndex = 131;
            this.btnDELETE_PRODUCT.Text = "Xóa HH";
            this.btnDELETE_PRODUCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE_PRODUCT.UseVisualStyleBackColor = false;
            this.btnDELETE_PRODUCT.Click += new System.EventHandler(this.btnDELETE_PRODUCT_Click);
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEXCEL.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEXCEL.FlatAppearance.BorderSize = 0;
            this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXCEL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXCEL.ForeColor = System.Drawing.Color.White;
            this.btnEXCEL.Image = global::SaleManagement.Properties.Resources.excel_3_24;
            this.btnEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXCEL.Location = new System.Drawing.Point(1081, 82);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(154, 48);
            this.btnEXCEL.TabIndex = 118;
            this.btnEXCEL.Text = "Xuất Excel";
            this.btnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // btnSHOW
            // 
            this.btnSHOW.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSHOW.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSHOW.FlatAppearance.BorderSize = 0;
            this.btnSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHOW.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHOW.ForeColor = System.Drawing.Color.White;
            this.btnSHOW.Image = global::SaleManagement.Properties.Resources.activity_feed_24;
            this.btnSHOW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHOW.Location = new System.Drawing.Point(610, 82);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(119, 48);
            this.btnSHOW.TabIndex = 110;
            this.btnSHOW.Text = "Liệt kê";
            this.btnSHOW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.btnSHOW_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEDIT.FlatAppearance.BorderSize = 0;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.White;
            this.btnEDIT.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(63, 409);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(131, 61);
            this.btnEDIT.TabIndex = 101;
            this.btnEDIT.Text = "Sửa đơn";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = false;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
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
            this.btnBACK.Location = new System.Drawing.Point(202, 479);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(125, 59);
            this.btnBACK.TabIndex = 105;
            this.btnBACK.Text = "Quay lại";
            this.btnBACK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBACK.UseVisualStyleBackColor = false;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSAVE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(202, 409);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(125, 61);
            this.btnSAVE.TabIndex = 103;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.BackColor = System.Drawing.Color.IndianRed;
            this.btnDELETE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDELETE.FlatAppearance.BorderSize = 0;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = global::SaleManagement.Properties.Resources.delete_property_24;
            this.btnDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE.Location = new System.Drawing.Point(63, 479);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(132, 59);
            this.btnDELETE.TabIndex = 102;
            this.btnDELETE.Text = "Xóa đơn";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(787, 384);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 136;
            this.pictureBox1.TabStop = false;
            // 
            // FrmManage_List_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 691);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.btnADD_PRODUCT);
            this.Controls.Add(this.btnEDIT_QUANTITY);
            this.Controls.Add(this.btnDELETE_PRODUCT);
            this.Controls.Add(this.txtDISCOUNT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbbSTAFF);
            this.Controls.Add(this.cbbCUSTOMER);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpTO);
            this.Controls.Add(this.dpFROM);
            this.Controls.Add(this.cbbSTAFF_DETAIL);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.txtPRICE);
            this.Controls.Add(this.txtAMOUNT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvINFO_INVOICE);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.dgvLIST_INVOICE);
            this.Controls.Add(this.dpDAY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.txtPRICE_);
            this.Controls.Add(this.txtID_INVOICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Name = "FrmManage_List_Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_List_Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_INVOICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINFO_INVOICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtPRICE_;
        private System.Windows.Forms.TextBox txtID_INVOICE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dpDAY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.DataGridView dgvLIST_INVOICE;
        private System.Windows.Forms.DataGridView dgvINFO_INVOICE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPRICE;
        private System.Windows.Forms.TextBox txtAMOUNT;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.ComboBox cbbSTAFF_DETAIL;
        private System.Windows.Forms.DateTimePicker dpFROM;
        private System.Windows.Forms.DateTimePicker dpTO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.ComboBox cbbCUSTOMER;
        private System.Windows.Forms.ComboBox cbbSTAFF;
        private System.Windows.Forms.TextBox txtDISCOUNT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDELETE_PRODUCT;
        private System.Windows.Forms.Button btnEDIT_QUANTITY;
        private System.Windows.Forms.Button btnADD_PRODUCT;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}