
namespace SaleManagement.VIEW
{
    partial class FrmManage_Items
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
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLISTITEMS = new System.Windows.Forms.DataGridView();
            this.cbbSUPPLIERs = new System.Windows.Forms.ComboBox();
            this.cbbTYPE_OF_PRODUCT = new System.Windows.Forms.ComboBox();
            this.txtQUANTITY = new System.Windows.Forms.TextBox();
            this.txtNAME_PRODUCT = new System.Windows.Forms.TextBox();
            this.txtID_PRODUCT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSALE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBUY = new System.Windows.Forms.TextBox();
            this.cbbPRODUCERs = new System.Windows.Forms.ComboBox();
            this.gbMota = new System.Windows.Forms.GroupBox();
            this.txtDESCRIBE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbNAME_ITEM = new System.Windows.Forms.RadioButton();
            this.rbID_ITEM = new System.Windows.Forms.RadioButton();
            this.cbbTYPE_OF__PRODUCT_DETAIL = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.btnADDTYPE = new System.Windows.Forms.Button();
            this.btnADDSUPPLIER = new System.Windows.Forms.Button();
            this.btnADDPRODUCER = new System.Windows.Forms.Button();
            this.btnEXCEL = new System.Windows.Forms.Button();
            this.btnHOME = new System.Windows.Forms.Button();
            this.pbIMAGE = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnADDPIC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTITEMS)).BeginInit();
            this.gbMota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMAGE)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(812, 626);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(274, 28);
            this.txtSEARCH.TabIndex = 67;
            this.txtSEARCH.Text = "Nhập thông tin cần tìm kiếm";
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(973, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 26);
            this.label2.TabIndex = 62;
            this.label2.Text = "DANH SÁCH HÀNG HÓA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLISTITEMS
            // 
            this.dgvLISTITEMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTITEMS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLISTITEMS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLISTITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTITEMS.Location = new System.Drawing.Point(402, 108);
            this.dgvLISTITEMS.Name = "dgvLISTITEMS";
            this.dgvLISTITEMS.RowHeadersWidth = 62;
            this.dgvLISTITEMS.RowTemplate.Height = 28;
            this.dgvLISTITEMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLISTITEMS.Size = new System.Drawing.Size(836, 492);
            this.dgvLISTITEMS.TabIndex = 61;
            this.dgvLISTITEMS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLISTITEMS_CellClick);
            // 
            // cbbSUPPLIERs
            // 
            this.cbbSUPPLIERs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSUPPLIERs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSUPPLIERs.FormattingEnabled = true;
            this.cbbSUPPLIERs.Location = new System.Drawing.Point(133, 192);
            this.cbbSUPPLIERs.Name = "cbbSUPPLIERs";
            this.cbbSUPPLIERs.Size = new System.Drawing.Size(210, 29);
            this.cbbSUPPLIERs.TabIndex = 98;
            // 
            // cbbTYPE_OF_PRODUCT
            // 
            this.cbbTYPE_OF_PRODUCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPE_OF_PRODUCT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPE_OF_PRODUCT.FormattingEnabled = true;
            this.cbbTYPE_OF_PRODUCT.Location = new System.Drawing.Point(133, 68);
            this.cbbTYPE_OF_PRODUCT.Name = "cbbTYPE_OF_PRODUCT";
            this.cbbTYPE_OF_PRODUCT.Size = new System.Drawing.Size(210, 29);
            this.cbbTYPE_OF_PRODUCT.TabIndex = 97;
            this.cbbTYPE_OF_PRODUCT.SelectedIndexChanged += new System.EventHandler(this.cbbTYPE_OF_ITEMS_SelectedIndexChanged);
            // 
            // txtQUANTITY
            // 
            this.txtQUANTITY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUANTITY.ForeColor = System.Drawing.Color.Black;
            this.txtQUANTITY.Location = new System.Drawing.Point(133, 147);
            this.txtQUANTITY.Name = "txtQUANTITY";
            this.txtQUANTITY.Size = new System.Drawing.Size(210, 28);
            this.txtQUANTITY.TabIndex = 96;
            this.txtQUANTITY.Enter += new System.EventHandler(this.txtAMOUNT_Enter);
            this.txtQUANTITY.Leave += new System.EventHandler(this.txtAMOUNT_Leave);
            // 
            // txtNAME_PRODUCT
            // 
            this.txtNAME_PRODUCT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_PRODUCT.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_PRODUCT.Location = new System.Drawing.Point(133, 108);
            this.txtNAME_PRODUCT.Name = "txtNAME_PRODUCT";
            this.txtNAME_PRODUCT.Size = new System.Drawing.Size(210, 28);
            this.txtNAME_PRODUCT.TabIndex = 95;
            this.txtNAME_PRODUCT.Enter += new System.EventHandler(this.txtNAME_ITEM_Enter);
            this.txtNAME_PRODUCT.Leave += new System.EventHandler(this.txtNAME_ITEM_Leave);
            // 
            // txtID_PRODUCT
            // 
            this.txtID_PRODUCT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_PRODUCT.Location = new System.Drawing.Point(133, 29);
            this.txtID_PRODUCT.Name = "txtID_PRODUCT";
            this.txtID_PRODUCT.Size = new System.Drawing.Size(210, 28);
            this.txtID_PRODUCT.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 93;
            this.label5.Text = "Nhà CC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tên HH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 90;
            this.label6.Text = "Loại HH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 89;
            this.label7.Text = "Mã HH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(349, 321);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 21);
            this.label14.TabIndex = 107;
            this.label14.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 21);
            this.label13.TabIndex = 106;
            this.label13.Text = "VNĐ";
            // 
            // txtSALE
            // 
            this.txtSALE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALE.ForeColor = System.Drawing.Color.Black;
            this.txtSALE.Location = new System.Drawing.Point(133, 316);
            this.txtSALE.Name = "txtSALE";
            this.txtSALE.Size = new System.Drawing.Size(210, 28);
            this.txtSALE.TabIndex = 105;
            this.txtSALE.Enter += new System.EventHandler(this.txtSALE_Enter);
            this.txtSALE.Leave += new System.EventHandler(this.txtSALE_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 104;
            this.label10.Text = "Giá bán";
            // 
            // txtBUY
            // 
            this.txtBUY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUY.ForeColor = System.Drawing.Color.Black;
            this.txtBUY.Location = new System.Drawing.Point(133, 277);
            this.txtBUY.Name = "txtBUY";
            this.txtBUY.Size = new System.Drawing.Size(210, 28);
            this.txtBUY.TabIndex = 103;
            this.txtBUY.Enter += new System.EventHandler(this.txtBUY_Enter);
            this.txtBUY.Leave += new System.EventHandler(this.txtBUY_Leave);
            // 
            // cbbPRODUCERs
            // 
            this.cbbPRODUCERs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPRODUCERs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPRODUCERs.FormattingEnabled = true;
            this.cbbPRODUCERs.Location = new System.Drawing.Point(133, 236);
            this.cbbPRODUCERs.Name = "cbbPRODUCERs";
            this.cbbPRODUCERs.Size = new System.Drawing.Size(210, 29);
            this.cbbPRODUCERs.TabIndex = 102;
            // 
            // gbMota
            // 
            this.gbMota.Controls.Add(this.txtDESCRIBE);
            this.gbMota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMota.Location = new System.Drawing.Point(12, 350);
            this.gbMota.Name = "gbMota";
            this.gbMota.Size = new System.Drawing.Size(196, 218);
            this.gbMota.TabIndex = 101;
            this.gbMota.TabStop = false;
            this.gbMota.Text = "Mô tả";
            // 
            // txtDESCRIBE
            // 
            this.txtDESCRIBE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDESCRIBE.ForeColor = System.Drawing.Color.Black;
            this.txtDESCRIBE.Location = new System.Drawing.Point(6, 25);
            this.txtDESCRIBE.Multiline = true;
            this.txtDESCRIBE.Name = "txtDESCRIBE";
            this.txtDESCRIBE.Size = new System.Drawing.Size(184, 187);
            this.txtDESCRIBE.TabIndex = 28;
            this.txtDESCRIBE.Text = "Nhập mô tả ...";
            this.txtDESCRIBE.Enter += new System.EventHandler(this.txtDESCRIBE_Enter);
            this.txtDESCRIBE.Leave += new System.EventHandler(this.txtDESCRIBE_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 100;
            this.label9.Text = "Giá mua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 99;
            this.label11.Text = "Nhà SX";
            // 
            // rbNAME_ITEM
            // 
            this.rbNAME_ITEM.AutoSize = true;
            this.rbNAME_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNAME_ITEM.Location = new System.Drawing.Point(708, 630);
            this.rbNAME_ITEM.Name = "rbNAME_ITEM";
            this.rbNAME_ITEM.Size = new System.Drawing.Size(98, 25);
            this.rbNAME_ITEM.TabIndex = 115;
            this.rbNAME_ITEM.TabStop = true;
            this.rbNAME_ITEM.Text = "Tên HH";
            this.rbNAME_ITEM.UseVisualStyleBackColor = true;
            // 
            // rbID_ITEM
            // 
            this.rbID_ITEM.AutoSize = true;
            this.rbID_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID_ITEM.Location = new System.Drawing.Point(609, 630);
            this.rbID_ITEM.Name = "rbID_ITEM";
            this.rbID_ITEM.Size = new System.Drawing.Size(91, 25);
            this.rbID_ITEM.TabIndex = 114;
            this.rbID_ITEM.TabStop = true;
            this.rbID_ITEM.Text = "Mã HH";
            this.rbID_ITEM.UseVisualStyleBackColor = true;
            // 
            // cbbTYPE_OF__PRODUCT_DETAIL
            // 
            this.cbbTYPE_OF__PRODUCT_DETAIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPE_OF__PRODUCT_DETAIL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPE_OF__PRODUCT_DETAIL.FormattingEnabled = true;
            this.cbbTYPE_OF__PRODUCT_DETAIL.Location = new System.Drawing.Point(477, 61);
            this.cbbTYPE_OF__PRODUCT_DETAIL.Name = "cbbTYPE_OF__PRODUCT_DETAIL";
            this.cbbTYPE_OF__PRODUCT_DETAIL.Size = new System.Drawing.Size(214, 29);
            this.cbbTYPE_OF__PRODUCT_DETAIL.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 21);
            this.label8.TabIndex = 116;
            this.label8.Text = "Loại HH";
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::SaleManagement.Properties.Resources.plus_5_24;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(5, 574);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(122, 52);
            this.btnADD.TabIndex = 83;
            this.btnADD.Text = "Thêm";
            this.btnADD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
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
            this.btnEDIT.Location = new System.Drawing.Point(133, 574);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(121, 52);
            this.btnEDIT.TabIndex = 84;
            this.btnEDIT.Text = "Sửa";
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
            this.btnBACK.Location = new System.Drawing.Point(260, 630);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(133, 49);
            this.btnBACK.TabIndex = 88;
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
            this.btnSAVE.Location = new System.Drawing.Point(260, 574);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(133, 52);
            this.btnSAVE.TabIndex = 86;
            this.btnSAVE.Text = "Lưu";
            this.btnSAVE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.Color.IndianRed;
            this.btnCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.ForeColor = System.Drawing.Color.White;
            this.btnCANCEL.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnCANCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCANCEL.Location = new System.Drawing.Point(133, 630);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(121, 49);
            this.btnCANCEL.TabIndex = 87;
            this.btnCANCEL.Text = "Hủy bỏ";
            this.btnCANCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
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
            this.btnDELETE.Location = new System.Drawing.Point(5, 630);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(122, 49);
            this.btnDELETE.TabIndex = 85;
            this.btnDELETE.Text = "Xóa";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSEARCH.FlatAppearance.BorderSize = 0;
            this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEARCH.ForeColor = System.Drawing.Color.White;
            this.btnSEARCH.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.btnSEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEARCH.Location = new System.Drawing.Point(1098, 616);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(140, 47);
            this.btnSEARCH.TabIndex = 66;
            this.btnSEARCH.Text = "Tìm kiếm";
            this.btnSEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEARCH.UseVisualStyleBackColor = false;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
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
            this.btnSHOW.Location = new System.Drawing.Point(697, 51);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(119, 46);
            this.btnSHOW.TabIndex = 63;
            this.btnSHOW.Text = "Liệt kê";
            this.btnSHOW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.btnSHOW_Click);
            // 
            // btnADDTYPE
            // 
            this.btnADDTYPE.BackColor = System.Drawing.SystemColors.Control;
            this.btnADDTYPE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADDTYPE.FlatAppearance.BorderSize = 0;
            this.btnADDTYPE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDTYPE.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDTYPE.ForeColor = System.Drawing.Color.White;
            this.btnADDTYPE.Image = global::SaleManagement.Properties.Resources.plus_5_24__1_;
            this.btnADDTYPE.Location = new System.Drawing.Point(349, 60);
            this.btnADDTYPE.Name = "btnADDTYPE";
            this.btnADDTYPE.Size = new System.Drawing.Size(44, 46);
            this.btnADDTYPE.TabIndex = 118;
            this.btnADDTYPE.UseVisualStyleBackColor = false;
            this.btnADDTYPE.Click += new System.EventHandler(this.btnADDTYPE_Click);
            // 
            // btnADDSUPPLIER
            // 
            this.btnADDSUPPLIER.BackColor = System.Drawing.SystemColors.Control;
            this.btnADDSUPPLIER.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADDSUPPLIER.FlatAppearance.BorderSize = 0;
            this.btnADDSUPPLIER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDSUPPLIER.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDSUPPLIER.ForeColor = System.Drawing.Color.White;
            this.btnADDSUPPLIER.Image = global::SaleManagement.Properties.Resources.plus_5_24__1_;
            this.btnADDSUPPLIER.Location = new System.Drawing.Point(349, 183);
            this.btnADDSUPPLIER.Name = "btnADDSUPPLIER";
            this.btnADDSUPPLIER.Size = new System.Drawing.Size(44, 44);
            this.btnADDSUPPLIER.TabIndex = 119;
            this.btnADDSUPPLIER.UseVisualStyleBackColor = false;
            this.btnADDSUPPLIER.Click += new System.EventHandler(this.btnADDSUPPLIER_Click);
            // 
            // btnADDPRODUCER
            // 
            this.btnADDPRODUCER.BackColor = System.Drawing.SystemColors.Control;
            this.btnADDPRODUCER.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADDPRODUCER.FlatAppearance.BorderSize = 0;
            this.btnADDPRODUCER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDPRODUCER.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDPRODUCER.ForeColor = System.Drawing.Color.White;
            this.btnADDPRODUCER.Image = global::SaleManagement.Properties.Resources.plus_5_24__1_;
            this.btnADDPRODUCER.Location = new System.Drawing.Point(349, 227);
            this.btnADDPRODUCER.Name = "btnADDPRODUCER";
            this.btnADDPRODUCER.Size = new System.Drawing.Size(44, 44);
            this.btnADDPRODUCER.TabIndex = 120;
            this.btnADDPRODUCER.UseVisualStyleBackColor = false;
            this.btnADDPRODUCER.Click += new System.EventHandler(this.btnADDPRODUCER_Click);
            // 
            // btnEXCEL
            // 
            this.btnEXCEL.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEXCEL.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEXCEL.FlatAppearance.BorderSize = 0;
            this.btnEXCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXCEL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXCEL.ForeColor = System.Drawing.Color.White;
            this.btnEXCEL.Image = global::SaleManagement.Properties.Resources.excel_3_24;
            this.btnEXCEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEXCEL.Location = new System.Drawing.Point(822, 51);
            this.btnEXCEL.Name = "btnEXCEL";
            this.btnEXCEL.Size = new System.Drawing.Size(154, 46);
            this.btnEXCEL.TabIndex = 121;
            this.btnEXCEL.Text = "Xuất Excel";
            this.btnEXCEL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEXCEL.UseVisualStyleBackColor = false;
            this.btnEXCEL.Click += new System.EventHandler(this.btnEXCEL_Click);
            // 
            // btnHOME
            // 
            this.btnHOME.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(1041, 3);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 65);
            this.btnHOME.TabIndex = 122;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // pbIMAGE
            // 
            this.pbIMAGE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbIMAGE.Location = new System.Drawing.Point(214, 388);
            this.pbIMAGE.Name = "pbIMAGE";
            this.pbIMAGE.Size = new System.Drawing.Size(179, 180);
            this.pbIMAGE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIMAGE.TabIndex = 124;
            this.pbIMAGE.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(531, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 31);
            this.label1.TabIndex = 123;
            this.label1.Text = "Quản lý hàng hóa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnADDPIC
            // 
            this.btnADDPIC.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADDPIC.FlatAppearance.BorderSize = 0;
            this.btnADDPIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDPIC.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDPIC.ForeColor = System.Drawing.Color.White;
            this.btnADDPIC.Location = new System.Drawing.Point(250, 350);
            this.btnADDPIC.Name = "btnADDPIC";
            this.btnADDPIC.Size = new System.Drawing.Size(114, 32);
            this.btnADDPIC.TabIndex = 125;
            this.btnADDPIC.Text = "Thêm ảnh";
            this.btnADDPIC.UseVisualStyleBackColor = false;
            this.btnADDPIC.Click += new System.EventHandler(this.btnADDPIC_Click);
            // 
            // FrmManage_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1247, 691);
            this.Controls.Add(this.btnADDPIC);
            this.Controls.Add(this.pbIMAGE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHOME);
            this.Controls.Add(this.btnEXCEL);
            this.Controls.Add(this.btnADDPRODUCER);
            this.Controls.Add(this.btnADDSUPPLIER);
            this.Controls.Add(this.btnADDTYPE);
            this.Controls.Add(this.cbbTYPE_OF__PRODUCT_DETAIL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbNAME_ITEM);
            this.Controls.Add(this.rbID_ITEM);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSALE);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBUY);
            this.Controls.Add(this.cbbPRODUCERs);
            this.Controls.Add(this.gbMota);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbbSUPPLIERs);
            this.Controls.Add(this.cbbTYPE_OF_PRODUCT);
            this.Controls.Add(this.txtQUANTITY);
            this.Controls.Add(this.txtNAME_PRODUCT);
            this.Controls.Add(this.txtID_PRODUCT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.btnSEARCH);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLISTITEMS);
            this.Name = "FrmManage_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Items";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTITEMS)).EndInit();
            this.gbMota.ResumeLayout(false);
            this.gbMota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIMAGE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLISTITEMS;
        private System.Windows.Forms.ComboBox cbbSUPPLIERs;
        private System.Windows.Forms.ComboBox cbbTYPE_OF_PRODUCT;
        private System.Windows.Forms.TextBox txtQUANTITY;
        private System.Windows.Forms.TextBox txtNAME_PRODUCT;
        private System.Windows.Forms.TextBox txtID_PRODUCT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSALE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBUY;
        private System.Windows.Forms.ComboBox cbbPRODUCERs;
        private System.Windows.Forms.GroupBox gbMota;
        private System.Windows.Forms.TextBox txtDESCRIBE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbNAME_ITEM;
        private System.Windows.Forms.RadioButton rbID_ITEM;
        private System.Windows.Forms.ComboBox cbbTYPE_OF__PRODUCT_DETAIL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnADDTYPE;
        private System.Windows.Forms.Button btnADDSUPPLIER;
        private System.Windows.Forms.Button btnADDPRODUCER;
        private System.Windows.Forms.Button btnEXCEL;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.PictureBox pbIMAGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnADDPIC;
    }
}