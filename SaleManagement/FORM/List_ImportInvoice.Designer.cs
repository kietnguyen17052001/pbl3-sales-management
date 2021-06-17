
namespace SaleManagement.FORM
{
    partial class FrmList_ImportInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbbSTAFF = new System.Windows.Forms.ComboBox();
            this.cbbSUPPLIER = new System.Windows.Forms.ComboBox();
            this.dpDAY = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPRICE = new System.Windows.Forms.TextBox();
            this.txtID_INVOICE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.txtDISCOUNT = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvLIST_INVOICE = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.btnHOME = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpTO = new System.Windows.Forms.DateTimePicker();
            this.dpFROM = new System.Windows.Forms.DateTimePicker();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.dgvINFO_INVOICE = new System.Windows.Forms.DataGridView();
            this.btnADD_PRODUCT = new System.Windows.Forms.Button();
            this.btnEDIT_QUANTITY = new System.Windows.Forms.Button();
            this.btnDELETE_PRODUCT = new System.Windows.Forms.Button();
            this.lbIdInvoice = new System.Windows.Forms.Label();
            this.lbInvoiceDetail = new System.Windows.Forms.Label();
            this.lbTotalMoney = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_INVOICE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINFO_INVOICE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(417, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 31);
            this.label1.TabIndex = 136;
            this.label1.Text = "Danh sách hóa đơn nhập hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbbSTAFF
            // 
            this.cbbSTAFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSTAFF.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSTAFF.FormattingEnabled = true;
            this.cbbSTAFF.Location = new System.Drawing.Point(124, 185);
            this.cbbSTAFF.Name = "cbbSTAFF";
            this.cbbSTAFF.Size = new System.Drawing.Size(246, 30);
            this.cbbSTAFF.TabIndex = 146;
            // 
            // cbbSUPPLIER
            // 
            this.cbbSUPPLIER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSUPPLIER.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSUPPLIER.FormattingEnabled = true;
            this.cbbSUPPLIER.Location = new System.Drawing.Point(124, 225);
            this.cbbSUPPLIER.Name = "cbbSUPPLIER";
            this.cbbSUPPLIER.Size = new System.Drawing.Size(246, 30);
            this.cbbSUPPLIER.TabIndex = 145;
            // 
            // dpDAY
            // 
            this.dpDAY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDAY.Location = new System.Drawing.Point(124, 145);
            this.dpDAY.Name = "dpDAY";
            this.dpDAY.Size = new System.Drawing.Size(246, 29);
            this.dpDAY.TabIndex = 144;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 143;
            this.label9.Text = "Ngày lập";
            // 
            // txtPRICE
            // 
            this.txtPRICE.Enabled = false;
            this.txtPRICE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRICE.ForeColor = System.Drawing.Color.Black;
            this.txtPRICE.Location = new System.Drawing.Point(124, 305);
            this.txtPRICE.Name = "txtPRICE";
            this.txtPRICE.Size = new System.Drawing.Size(246, 29);
            this.txtPRICE.TabIndex = 142;
            // 
            // txtID_INVOICE
            // 
            this.txtID_INVOICE.Enabled = false;
            this.txtID_INVOICE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_INVOICE.Location = new System.Drawing.Point(124, 107);
            this.txtID_INVOICE.Name = "txtID_INVOICE";
            this.txtID_INVOICE.Size = new System.Drawing.Size(247, 29);
            this.txtID_INVOICE.TabIndex = 141;
            this.txtID_INVOICE.TextChanged += new System.EventHandler(this.txtID_INVOICE_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 140;
            this.label4.Text = "Tổng tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 139;
            this.label3.Text = "Nhà CC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 22);
            this.label6.TabIndex = 138;
            this.label6.Text = "Nhân viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 22);
            this.label7.TabIndex = 137;
            this.label7.Text = "Mã Đơn";
            // 
            // btnEDIT
            // 
            this.btnEDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEDIT.FlatAppearance.BorderSize = 0;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.White;
            this.btnEDIT.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(33, 375);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(131, 61);
            this.btnEDIT.TabIndex = 149;
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
            this.btnBACK.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.Color.White;
            this.btnBACK.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBACK.Location = new System.Drawing.Point(1092, 4);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(152, 59);
            this.btnBACK.TabIndex = 152;
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
            this.btnSAVE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.ForeColor = System.Drawing.Color.White;
            this.btnSAVE.Image = global::SaleManagement.Properties.Resources.save_as_24;
            this.btnSAVE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSAVE.Location = new System.Drawing.Point(172, 375);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(132, 61);
            this.btnSAVE.TabIndex = 151;
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
            this.btnDELETE.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = global::SaleManagement.Properties.Resources.delete_property_24;
            this.btnDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE.Location = new System.Drawing.Point(33, 445);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(271, 59);
            this.btnDELETE.TabIndex = 150;
            this.btnDELETE.Text = "Xóa đơn nhập hàng";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtDISCOUNT
            // 
            this.txtDISCOUNT.Enabled = false;
            this.txtDISCOUNT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDISCOUNT.ForeColor = System.Drawing.Color.Black;
            this.txtDISCOUNT.Location = new System.Drawing.Point(124, 266);
            this.txtDISCOUNT.Name = "txtDISCOUNT";
            this.txtDISCOUNT.Size = new System.Drawing.Size(246, 29);
            this.txtDISCOUNT.TabIndex = 154;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 22);
            this.label12.TabIndex = 153;
            this.label12.Text = "Giảm giá";
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
            this.dgvLIST_INVOICE.Location = new System.Drawing.Point(377, 107);
            this.dgvLIST_INVOICE.Name = "dgvLIST_INVOICE";
            this.dgvLIST_INVOICE.RowHeadersVisible = false;
            this.dgvLIST_INVOICE.RowHeadersWidth = 62;
            this.dgvLIST_INVOICE.RowTemplate.Height = 28;
            this.dgvLIST_INVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLIST_INVOICE.Size = new System.Drawing.Size(858, 271);
            this.dgvLIST_INVOICE.TabIndex = 155;
            this.dgvLIST_INVOICE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLIST_INVOICE_CellClick);
            this.dgvLIST_INVOICE.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLIST_INVOICE_CellFormatting);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(765, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(47, 47);
            this.pictureBox1.TabIndex = 157;
            this.pictureBox1.TabStop = false;
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(377, 65);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(382, 29);
            this.txtSEARCH.TabIndex = 156;
            this.txtSEARCH.Text = "Nhập mã hóa đơn hoặc mã/ tên nhà c.cấp";
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // btnHOME
            // 
            this.btnHOME.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(5, 4);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 65);
            this.btnHOME.TabIndex = 158;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(587, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 22);
            this.label10.TabIndex = 162;
            this.label10.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 161;
            this.label2.Text = "Từ ngày";
            // 
            // dpTO
            // 
            this.dpTO.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpTO.Location = new System.Drawing.Point(556, 407);
            this.dpTO.Name = "dpTO";
            this.dpTO.Size = new System.Drawing.Size(156, 29);
            this.dpTO.TabIndex = 160;
            this.dpTO.ValueChanged += new System.EventHandler(this.dpTO_ValueChanged);
            // 
            // dpFROM
            // 
            this.dpFROM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFROM.Location = new System.Drawing.Point(376, 407);
            this.dpFROM.Name = "dpFROM";
            this.dpFROM.Size = new System.Drawing.Size(156, 29);
            this.dpFROM.TabIndex = 159;
            this.dpFROM.ValueChanged += new System.EventHandler(this.dpTO_ValueChanged);
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEXCEL.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEXCEL.FlatAppearance.BorderSize = 0;
            this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXCEL.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXCEL.ForeColor = System.Drawing.Color.White;
            this.btnEXCEL.Image = global::SaleManagement.Properties.Resources.excel_3_24;
            this.btnEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXCEL.Location = new System.Drawing.Point(818, 53);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(152, 48);
            this.btnEXCEL.TabIndex = 163;
            this.btnEXCEL.Text = "Xuất Excel";
            this.btnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
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
            this.dgvINFO_INVOICE.Location = new System.Drawing.Point(376, 445);
            this.dgvINFO_INVOICE.Name = "dgvINFO_INVOICE";
            this.dgvINFO_INVOICE.RowHeadersVisible = false;
            this.dgvINFO_INVOICE.RowHeadersWidth = 62;
            this.dgvINFO_INVOICE.RowTemplate.Height = 28;
            this.dgvINFO_INVOICE.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvINFO_INVOICE.Size = new System.Drawing.Size(859, 184);
            this.dgvINFO_INVOICE.TabIndex = 164;
            this.dgvINFO_INVOICE.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvINFO_INVOICE_CellFormatting);
            // 
            // btnADD_PRODUCT
            // 
            this.btnADD_PRODUCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnADD_PRODUCT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD_PRODUCT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD_PRODUCT.FlatAppearance.BorderSize = 0;
            this.btnADD_PRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD_PRODUCT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.btnADD_PRODUCT.Image = global::SaleManagement.Properties.Resources.product_24;
            this.btnADD_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD_PRODUCT.Location = new System.Drawing.Point(834, 635);
            this.btnADD_PRODUCT.Name = "btnADD_PRODUCT";
            this.btnADD_PRODUCT.Size = new System.Drawing.Size(140, 48);
            this.btnADD_PRODUCT.TabIndex = 168;
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
            this.btnEDIT_QUANTITY.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT_QUANTITY.ForeColor = System.Drawing.Color.White;
            this.btnEDIT_QUANTITY.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEDIT_QUANTITY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT_QUANTITY.Location = new System.Drawing.Point(980, 634);
            this.btnEDIT_QUANTITY.Name = "btnEDIT_QUANTITY";
            this.btnEDIT_QUANTITY.Size = new System.Drawing.Size(129, 48);
            this.btnEDIT_QUANTITY.TabIndex = 167;
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
            this.btnDELETE_PRODUCT.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE_PRODUCT.ForeColor = System.Drawing.Color.White;
            this.btnDELETE_PRODUCT.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnDELETE_PRODUCT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE_PRODUCT.Location = new System.Drawing.Point(1115, 635);
            this.btnDELETE_PRODUCT.Name = "btnDELETE_PRODUCT";
            this.btnDELETE_PRODUCT.Size = new System.Drawing.Size(120, 46);
            this.btnDELETE_PRODUCT.TabIndex = 166;
            this.btnDELETE_PRODUCT.Text = "Xóa HH";
            this.btnDELETE_PRODUCT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE_PRODUCT.UseVisualStyleBackColor = false;
            this.btnDELETE_PRODUCT.Click += new System.EventHandler(this.btnDELETE_PRODUCT_Click);
            // 
            // lbIdInvoice
            // 
            this.lbIdInvoice.AutoSize = true;
            this.lbIdInvoice.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdInvoice.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbIdInvoice.Location = new System.Drawing.Point(1108, 408);
            this.lbIdInvoice.Name = "lbIdInvoice";
            this.lbIdInvoice.Size = new System.Drawing.Size(0, 27);
            this.lbIdInvoice.TabIndex = 170;
            // 
            // lbInvoiceDetail
            // 
            this.lbInvoiceDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInvoiceDetail.AutoSize = true;
            this.lbInvoiceDetail.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvoiceDetail.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbInvoiceDetail.Location = new System.Drawing.Point(906, 408);
            this.lbInvoiceDetail.Name = "lbInvoiceDetail";
            this.lbInvoiceDetail.Size = new System.Drawing.Size(187, 27);
            this.lbInvoiceDetail.TabIndex = 169;
            this.lbInvoiceDetail.Text = "Chi tiết hóa đơn";
            this.lbInvoiceDetail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalMoney
            // 
            this.lbTotalMoney.AutoSize = true;
            this.lbTotalMoney.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalMoney.ForeColor = System.Drawing.Color.IndianRed;
            this.lbTotalMoney.Location = new System.Drawing.Point(225, 582);
            this.lbTotalMoney.Name = "lbTotalMoney";
            this.lbTotalMoney.Size = new System.Drawing.Size(0, 22);
            this.lbTotalMoney.TabIndex = 174;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(29, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 22);
            this.label11.TabIndex = 173;
            this.label11.Text = "Tổng tiền:";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.IndianRed;
            this.lbQuantity.Location = new System.Drawing.Point(225, 543);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(0, 22);
            this.lbQuantity.TabIndex = 172;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(29, 543);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 22);
            this.label8.TabIndex = 171;
            this.label8.Text = "Số lượng đơn hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(535, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 22);
            this.label5.TabIndex = 175;
            this.label5.Text = "-";
            // 
            // FrmList_ImportInvoice
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
            this.Controls.Add(this.lbInvoiceDetail);
            this.Controls.Add(this.btnADD_PRODUCT);
            this.Controls.Add(this.btnEDIT_QUANTITY);
            this.Controls.Add(this.btnDELETE_PRODUCT);
            this.Controls.Add(this.dgvINFO_INVOICE);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dpTO);
            this.Controls.Add(this.dpFROM);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.dgvLIST_INVOICE);
            this.Controls.Add(this.txtDISCOUNT);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.cbbSTAFF);
            this.Controls.Add(this.cbbSUPPLIER);
            this.Controls.Add(this.dpDAY);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPRICE);
            this.Controls.Add(this.txtID_INVOICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "FrmList_ImportInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hóa đơn nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST_INVOICE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvINFO_INVOICE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbSTAFF;
        private System.Windows.Forms.ComboBox cbbSUPPLIER;
        private System.Windows.Forms.DateTimePicker dpDAY;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPRICE;
        private System.Windows.Forms.TextBox txtID_INVOICE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtDISCOUNT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvLIST_INVOICE;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dpTO;
        private System.Windows.Forms.DateTimePicker dpFROM;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.DataGridView dgvINFO_INVOICE;
        private System.Windows.Forms.Button btnADD_PRODUCT;
        private System.Windows.Forms.Button btnEDIT_QUANTITY;
        private System.Windows.Forms.Button btnDELETE_PRODUCT;
        private System.Windows.Forms.Label lbIdInvoice;
        private System.Windows.Forms.Label lbInvoiceDetail;
        private System.Windows.Forms.Label lbTotalMoney;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
    }
}