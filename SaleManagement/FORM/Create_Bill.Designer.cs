﻿
namespace SaleManagement.VIEW
{
    partial class FrmBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBill));
            this.label1 = new System.Windows.Forms.Label();
            this.panelMANAGE_DATA = new System.Windows.Forms.Panel();
            this.btnHOME = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbNAME_ITEM = new System.Windows.Forms.RadioButton();
            this.rbID_ITEM = new System.Windows.Forms.RadioButton();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDISCOUNT_ITEM = new System.Windows.Forms.TextBox();
            this.dgvSELECT = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.txtAMOUNT_ITEM = new System.Windows.Forms.TextBox();
            this.cbbTYPE_OF_ITEMS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnADDCUSTOMER = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.txtALL_AMOUNT_ITEMs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtITEMs = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvLIST = new System.Windows.Forms.DataGridView();
            this.cbbCUSTOMER = new System.Windows.Forms.ComboBox();
            this.dpDAY = new System.Windows.Forms.DateTimePicker();
            this.cbbSTAFF = new System.Windows.Forms.ComboBox();
            this.txtID_BILL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDISCOUNT_BILL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTOTAL_MONEY = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPRICE_BILL = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSEND_BY_STAFF = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSEND_BY_CUSTOMER = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtNOTE = new System.Windows.Forms.TextBox();
            this.btnPRINT = new System.Windows.Forms.Button();
            this.btnPAYMENT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnLOAD = new System.Windows.Forms.Button();
            this.btnDISCOUNT_MONEY = new System.Windows.Forms.Button();
            this.btnDISCOUNT_PERCENT = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panelMANAGE_DATA.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSELECT)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẬP HÓA ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMANAGE_DATA
            // 
            this.panelMANAGE_DATA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMANAGE_DATA.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMANAGE_DATA.Controls.Add(this.btnHOME);
            this.panelMANAGE_DATA.Controls.Add(this.label1);
            this.panelMANAGE_DATA.Location = new System.Drawing.Point(0, 0);
            this.panelMANAGE_DATA.Name = "panelMANAGE_DATA";
            this.panelMANAGE_DATA.Size = new System.Drawing.Size(1247, 74);
            this.panelMANAGE_DATA.TabIndex = 60;
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
            this.btnHOME.Location = new System.Drawing.Point(1047, 3);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 68);
            this.btnHOME.TabIndex = 36;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.rbNAME_ITEM);
            this.groupBox1.Controls.Add(this.rbID_ITEM);
            this.groupBox1.Controls.Add(this.txtSEARCH);
            this.groupBox1.Controls.Add(this.btnSEARCH);
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtDISCOUNT_ITEM);
            this.groupBox1.Controls.Add(this.dgvSELECT);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnSHOW);
            this.groupBox1.Controls.Add(this.txtAMOUNT_ITEM);
            this.groupBox1.Controls.Add(this.cbbTYPE_OF_ITEMS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 452);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn hàng hóa";
            // 
            // rbNAME_ITEM
            // 
            this.rbNAME_ITEM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbNAME_ITEM.AutoSize = true;
            this.rbNAME_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNAME_ITEM.Location = new System.Drawing.Point(105, 406);
            this.rbNAME_ITEM.Name = "rbNAME_ITEM";
            this.rbNAME_ITEM.Size = new System.Drawing.Size(98, 25);
            this.rbNAME_ITEM.TabIndex = 118;
            this.rbNAME_ITEM.TabStop = true;
            this.rbNAME_ITEM.Text = "Tên HH";
            this.rbNAME_ITEM.UseVisualStyleBackColor = true;
            // 
            // rbID_ITEM
            // 
            this.rbID_ITEM.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rbID_ITEM.AutoSize = true;
            this.rbID_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID_ITEM.Location = new System.Drawing.Point(8, 406);
            this.rbID_ITEM.Name = "rbID_ITEM";
            this.rbID_ITEM.Size = new System.Drawing.Size(91, 25);
            this.rbID_ITEM.TabIndex = 117;
            this.rbID_ITEM.TabStop = true;
            this.rbID_ITEM.Text = "Mã HH";
            this.rbID_ITEM.UseVisualStyleBackColor = true;
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(210, 405);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(201, 28);
            this.txtSEARCH.TabIndex = 116;
            this.txtSEARCH.Text = "Nhập thông tin cần tìm kiếm";
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSEARCH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSEARCH.FlatAppearance.BorderSize = 0;
            this.btnSEARCH.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEARCH.ForeColor = System.Drawing.Color.White;
            this.btnSEARCH.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.btnSEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEARCH.Location = new System.Drawing.Point(417, 395);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(137, 46);
            this.btnSEARCH.TabIndex = 82;
            this.btnSEARCH.Text = "Tìm kiếm";
            this.btnSEARCH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSEARCH.UseVisualStyleBackColor = false;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.SystemColors.Control;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::SaleManagement.Properties.Resources.plus_5_24__1_;
            this.btnADD.Location = new System.Drawing.Point(485, 262);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(44, 48);
            this.btnADD.TabIndex = 55;
            this.btnADD.UseVisualStyleBackColor = false;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(531, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 18);
            this.label13.TabIndex = 63;
            this.label13.Text = "%";
            // 
            // txtDISCOUNT_ITEM
            // 
            this.txtDISCOUNT_ITEM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDISCOUNT_ITEM.Location = new System.Drawing.Point(484, 219);
            this.txtDISCOUNT_ITEM.Name = "txtDISCOUNT_ITEM";
            this.txtDISCOUNT_ITEM.Size = new System.Drawing.Size(44, 26);
            this.txtDISCOUNT_ITEM.TabIndex = 26;
            this.txtDISCOUNT_ITEM.TextChanged += new System.EventHandler(this.txtDISCOUNT_ITEM_TextChanged);
            this.txtDISCOUNT_ITEM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDISCOUNT_ITEM_KeyPress);
            // 
            // dgvSELECT
            // 
            this.dgvSELECT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSELECT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSELECT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSELECT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvSELECT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSELECT.GridColor = System.Drawing.Color.Silver;
            this.dgvSELECT.Location = new System.Drawing.Point(6, 118);
            this.dgvSELECT.Name = "dgvSELECT";
            this.dgvSELECT.RowHeadersWidth = 62;
            this.dgvSELECT.RowTemplate.Height = 28;
            this.dgvSELECT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSELECT.Size = new System.Drawing.Size(466, 269);
            this.dgvSELECT.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(480, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "K.Mãi";
            // 
            // btnSHOW
            // 
            this.btnSHOW.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSHOW.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSHOW.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSHOW.FlatAppearance.BorderSize = 0;
            this.btnSHOW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSHOW.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSHOW.ForeColor = System.Drawing.Color.White;
            this.btnSHOW.Image = global::SaleManagement.Properties.Resources.activity_feed_24;
            this.btnSHOW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSHOW.Location = new System.Drawing.Point(353, 59);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(119, 46);
            this.btnSHOW.TabIndex = 35;
            this.btnSHOW.Text = "Liệt kê";
            this.btnSHOW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.btnSHOW_Click);
            // 
            // txtAMOUNT_ITEM
            // 
            this.txtAMOUNT_ITEM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAMOUNT_ITEM.Location = new System.Drawing.Point(484, 158);
            this.txtAMOUNT_ITEM.Name = "txtAMOUNT_ITEM";
            this.txtAMOUNT_ITEM.Size = new System.Drawing.Size(44, 26);
            this.txtAMOUNT_ITEM.TabIndex = 24;
            this.txtAMOUNT_ITEM.TextChanged += new System.EventHandler(this.txtAMOUNT_ITEM_TextChanged);
            this.txtAMOUNT_ITEM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAMOUNT_ITEM_KeyPress);
            // 
            // cbbTYPE_OF_ITEMS
            // 
            this.cbbTYPE_OF_ITEMS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbTYPE_OF_ITEMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPE_OF_ITEMS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPE_OF_ITEMS.FormattingEnabled = true;
            this.cbbTYPE_OF_ITEMS.Location = new System.Drawing.Point(150, 69);
            this.cbbTYPE_OF_ITEMS.Name = "cbbTYPE_OF_ITEMS";
            this.cbbTYPE_OF_ITEMS.Size = new System.Drawing.Size(190, 29);
            this.cbbTYPE_OF_ITEMS.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(480, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 14;
            this.label10.Text = "Loại hàng hóa";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnADDCUSTOMER);
            this.groupBox2.Controls.Add(this.btnDELETE);
            this.groupBox2.Controls.Add(this.btnEDIT);
            this.groupBox2.Controls.Add(this.txtALL_AMOUNT_ITEMs);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtITEMs);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dgvLIST);
            this.groupBox2.Controls.Add(this.cbbCUSTOMER);
            this.groupBox2.Controls.Add(this.dpDAY);
            this.groupBox2.Controls.Add(this.cbbSTAFF);
            this.groupBox2.Controls.Add(this.txtID_BILL);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(567, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 452);
            this.groupBox2.TabIndex = 62;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // btnADDCUSTOMER
            // 
            this.btnADDCUSTOMER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnADDCUSTOMER.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADDCUSTOMER.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADDCUSTOMER.FlatAppearance.BorderSize = 0;
            this.btnADDCUSTOMER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADDCUSTOMER.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADDCUSTOMER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnADDCUSTOMER.Image = global::SaleManagement.Properties.Resources.add_user_24;
            this.btnADDCUSTOMER.Location = new System.Drawing.Point(619, 65);
            this.btnADDCUSTOMER.Name = "btnADDCUSTOMER";
            this.btnADDCUSTOMER.Size = new System.Drawing.Size(52, 46);
            this.btnADDCUSTOMER.TabIndex = 81;
            this.btnADDCUSTOMER.UseVisualStyleBackColor = false;
            this.btnADDCUSTOMER.Click += new System.EventHandler(this.btnADDCUSTOMER_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDELETE.BackColor = System.Drawing.Color.IndianRed;
            this.btnDELETE.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDELETE.FlatAppearance.BorderSize = 0;
            this.btnDELETE.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDELETE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDELETE.ForeColor = System.Drawing.Color.White;
            this.btnDELETE.Image = global::SaleManagement.Properties.Resources.delete_2_24;
            this.btnDELETE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDELETE.Location = new System.Drawing.Point(560, 395);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(102, 46);
            this.btnDELETE.TabIndex = 64;
            this.btnDELETE.Text = "Xóa";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnEDIT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEDIT.FlatAppearance.BorderSize = 0;
            this.btnEDIT.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnEDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEDIT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.White;
            this.btnEDIT.Image = global::SaleManagement.Properties.Resources.edit_3_24;
            this.btnEDIT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEDIT.Location = new System.Drawing.Point(443, 394);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(111, 48);
            this.btnEDIT.TabIndex = 63;
            this.btnEDIT.Text = "Sửa";
            this.btnEDIT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEDIT.UseVisualStyleBackColor = false;
            // 
            // txtALL_AMOUNT_ITEMs
            // 
            this.txtALL_AMOUNT_ITEMs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtALL_AMOUNT_ITEMs.Enabled = false;
            this.txtALL_AMOUNT_ITEMs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtALL_AMOUNT_ITEMs.Location = new System.Drawing.Point(311, 411);
            this.txtALL_AMOUNT_ITEMs.Name = "txtALL_AMOUNT_ITEMs";
            this.txtALL_AMOUNT_ITEMs.Size = new System.Drawing.Size(45, 28);
            this.txtALL_AMOUNT_ITEMs.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 21);
            this.label9.TabIndex = 40;
            this.label9.Text = "Số lượng";
            // 
            // txtITEMs
            // 
            this.txtITEMs.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtITEMs.Enabled = false;
            this.txtITEMs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtITEMs.Location = new System.Drawing.Point(143, 411);
            this.txtITEMs.Name = "txtITEMs";
            this.txtITEMs.Size = new System.Drawing.Size(49, 28);
            this.txtITEMs.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 21);
            this.label8.TabIndex = 38;
            this.label8.Text = "Số hàng hóa";
            // 
            // dgvLIST
            // 
            this.dgvLIST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLIST.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLIST.GridColor = System.Drawing.Color.Silver;
            this.dgvLIST.Location = new System.Drawing.Point(15, 118);
            this.dgvLIST.Name = "dgvLIST";
            this.dgvLIST.RowHeadersWidth = 62;
            this.dgvLIST.RowTemplate.Height = 28;
            this.dgvLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLIST.Size = new System.Drawing.Size(656, 269);
            this.dgvLIST.TabIndex = 37;
            // 
            // cbbCUSTOMER
            // 
            this.cbbCUSTOMER.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbCUSTOMER.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCUSTOMER.FormattingEnabled = true;
            this.cbbCUSTOMER.Location = new System.Drawing.Point(431, 75);
            this.cbbCUSTOMER.Name = "cbbCUSTOMER";
            this.cbbCUSTOMER.Size = new System.Drawing.Size(177, 29);
            this.cbbCUSTOMER.TabIndex = 30;
            // 
            // dpDAY
            // 
            this.dpDAY.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dpDAY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDAY.Location = new System.Drawing.Point(431, 31);
            this.dpDAY.Name = "dpDAY";
            this.dpDAY.Size = new System.Drawing.Size(177, 28);
            this.dpDAY.TabIndex = 29;
            // 
            // cbbSTAFF
            // 
            this.cbbSTAFF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbbSTAFF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSTAFF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSTAFF.FormattingEnabled = true;
            this.cbbSTAFF.Location = new System.Drawing.Point(145, 75);
            this.cbbSTAFF.Name = "cbbSTAFF";
            this.cbbSTAFF.Size = new System.Drawing.Size(161, 29);
            this.cbbSTAFF.TabIndex = 28;
            // 
            // txtID_BILL
            // 
            this.txtID_BILL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID_BILL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_BILL.Location = new System.Drawing.Point(145, 34);
            this.txtID_BILL.Name = "txtID_BILL";
            this.txtID_BILL.Size = new System.Drawing.Size(161, 28);
            this.txtID_BILL.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày lập";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Khách hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nhân viên lập";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã hóa đơn";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(263, 604);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 18);
            this.label15.TabIndex = 68;
            this.label15.Text = "VNĐ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(263, 558);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 18);
            this.label14.TabIndex = 67;
            this.label14.Text = "VNĐ";
            // 
            // txtDISCOUNT_BILL
            // 
            this.txtDISCOUNT_BILL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtDISCOUNT_BILL.Enabled = false;
            this.txtDISCOUNT_BILL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDISCOUNT_BILL.Location = new System.Drawing.Point(118, 599);
            this.txtDISCOUNT_BILL.Name = "txtDISCOUNT_BILL";
            this.txtDISCOUNT_BILL.Size = new System.Drawing.Size(139, 28);
            this.txtDISCOUNT_BILL.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 602);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 65;
            this.label6.Text = "Giảm ";
            // 
            // txtTOTAL_MONEY
            // 
            this.txtTOTAL_MONEY.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtTOTAL_MONEY.Enabled = false;
            this.txtTOTAL_MONEY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTAL_MONEY.Location = new System.Drawing.Point(118, 553);
            this.txtTOTAL_MONEY.Name = "txtTOTAL_MONEY";
            this.txtTOTAL_MONEY.Size = new System.Drawing.Size(139, 28);
            this.txtTOTAL_MONEY.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 556);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 21);
            this.label7.TabIndex = 63;
            this.label7.Text = "Tổng cộng";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(550, 601);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 18);
            this.label16.TabIndex = 73;
            this.label16.Text = "VNĐ";
            // 
            // txtPRICE_BILL
            // 
            this.txtPRICE_BILL.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPRICE_BILL.Enabled = false;
            this.txtPRICE_BILL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPRICE_BILL.Location = new System.Drawing.Point(417, 597);
            this.txtPRICE_BILL.Name = "txtPRICE_BILL";
            this.txtPRICE_BILL.Size = new System.Drawing.Size(125, 28);
            this.txtPRICE_BILL.TabIndex = 72;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(312, 600);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 21);
            this.label17.TabIndex = 71;
            this.label17.Text = "Thành tiền";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(884, 601);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 18);
            this.label18.TabIndex = 79;
            this.label18.Text = "VNĐ";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(884, 555);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 18);
            this.label19.TabIndex = 78;
            this.label19.Text = "VNĐ";
            // 
            // txtSEND_BY_STAFF
            // 
            this.txtSEND_BY_STAFF.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSEND_BY_STAFF.Enabled = false;
            this.txtSEND_BY_STAFF.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEND_BY_STAFF.Location = new System.Drawing.Point(739, 597);
            this.txtSEND_BY_STAFF.Name = "txtSEND_BY_STAFF";
            this.txtSEND_BY_STAFF.Size = new System.Drawing.Size(139, 28);
            this.txtSEND_BY_STAFF.TabIndex = 77;
            this.txtSEND_BY_STAFF.TextChanged += new System.EventHandler(this.txtSEND_BY_STAFF_TextChanged);
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(600, 599);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(133, 21);
            this.label20.TabIndex = 76;
            this.label20.Text = "Tiền trả khách";
            // 
            // txtSEND_BY_CUSTOMER
            // 
            this.txtSEND_BY_CUSTOMER.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtSEND_BY_CUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEND_BY_CUSTOMER.Location = new System.Drawing.Point(739, 551);
            this.txtSEND_BY_CUSTOMER.Name = "txtSEND_BY_CUSTOMER";
            this.txtSEND_BY_CUSTOMER.Size = new System.Drawing.Size(139, 28);
            this.txtSEND_BY_CUSTOMER.TabIndex = 75;
            this.txtSEND_BY_CUSTOMER.TextChanged += new System.EventHandler(this.txtSEND_BY_CUSTOMER_TextChanged);
            this.txtSEND_BY_CUSTOMER.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSEND_BY_CUSTOMER_KeyPress);
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(600, 553);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(133, 21);
            this.label21.TabIndex = 74;
            this.label21.Text = "Tiền khách trả";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(954, 553);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 21);
            this.label22.TabIndex = 84;
            this.label22.Text = "Lưu ý";
            // 
            // txtNOTE
            // 
            this.txtNOTE.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtNOTE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOTE.ForeColor = System.Drawing.Color.Silver;
            this.txtNOTE.Location = new System.Drawing.Point(1012, 552);
            this.txtNOTE.Multiline = true;
            this.txtNOTE.Name = "txtNOTE";
            this.txtNOTE.Size = new System.Drawing.Size(179, 72);
            this.txtNOTE.TabIndex = 85;
            this.txtNOTE.Text = "Nhập thông tin ...";
            this.txtNOTE.Enter += new System.EventHandler(this.txtNOTE_Enter);
            this.txtNOTE.Leave += new System.EventHandler(this.txtNOTE_Leave);
            // 
            // btnPRINT
            // 
            this.btnPRINT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPRINT.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPRINT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPRINT.FlatAppearance.BorderSize = 0;
            this.btnPRINT.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPRINT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPRINT.ForeColor = System.Drawing.Color.White;
            this.btnPRINT.Image = global::SaleManagement.Properties.Resources.printer_3_24;
            this.btnPRINT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPRINT.Location = new System.Drawing.Point(800, 642);
            this.btnPRINT.Name = "btnPRINT";
            this.btnPRINT.Size = new System.Drawing.Size(156, 44);
            this.btnPRINT.TabIndex = 86;
            this.btnPRINT.Text = "In hóa đơn";
            this.btnPRINT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPRINT.UseVisualStyleBackColor = false;
            this.btnPRINT.Click += new System.EventHandler(this.btnPRINT_Click);
            // 
            // btnPAYMENT
            // 
            this.btnPAYMENT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPAYMENT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPAYMENT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPAYMENT.FlatAppearance.BorderSize = 0;
            this.btnPAYMENT.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnPAYMENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPAYMENT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAYMENT.ForeColor = System.Drawing.Color.White;
            this.btnPAYMENT.Image = global::SaleManagement.Properties.Resources.bank_cards_24;
            this.btnPAYMENT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPAYMENT.Location = new System.Drawing.Point(644, 642);
            this.btnPAYMENT.Name = "btnPAYMENT";
            this.btnPAYMENT.Size = new System.Drawing.Size(150, 44);
            this.btnPAYMENT.TabIndex = 83;
            this.btnPAYMENT.Text = "Thanh toán";
            this.btnPAYMENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPAYMENT.UseVisualStyleBackColor = false;
            this.btnPAYMENT.Click += new System.EventHandler(this.btnPAYMENT_Click);
            // 
            // btnBACK
            // 
            this.btnBACK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBACK.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBACK.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBACK.FlatAppearance.BorderSize = 0;
            this.btnBACK.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnBACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBACK.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBACK.ForeColor = System.Drawing.Color.White;
            this.btnBACK.Image = global::SaleManagement.Properties.Resources.arrow_121_24;
            this.btnBACK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBACK.Location = new System.Drawing.Point(1105, 642);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(133, 46);
            this.btnBACK.TabIndex = 82;
            this.btnBACK.Text = "Quay lại";
            this.btnBACK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBACK.UseVisualStyleBackColor = false;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // btnLOAD
            // 
            this.btnLOAD.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLOAD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLOAD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLOAD.FlatAppearance.BorderSize = 0;
            this.btnLOAD.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnLOAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLOAD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLOAD.ForeColor = System.Drawing.Color.White;
            this.btnLOAD.Image = global::SaleManagement.Properties.Resources.sinchronize_24;
            this.btnLOAD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLOAD.Location = new System.Drawing.Point(962, 641);
            this.btnLOAD.Name = "btnLOAD";
            this.btnLOAD.Size = new System.Drawing.Size(137, 46);
            this.btnLOAD.TabIndex = 81;
            this.btnLOAD.Text = "Làm mới";
            this.btnLOAD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLOAD.UseVisualStyleBackColor = false;
            this.btnLOAD.Click += new System.EventHandler(this.btnLOAD_Click);
            // 
            // btnDISCOUNT_MONEY
            // 
            this.btnDISCOUNT_MONEY.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDISCOUNT_MONEY.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDISCOUNT_MONEY.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDISCOUNT_MONEY.FlatAppearance.BorderSize = 0;
            this.btnDISCOUNT_MONEY.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnDISCOUNT_MONEY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDISCOUNT_MONEY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDISCOUNT_MONEY.ForeColor = System.Drawing.Color.White;
            this.btnDISCOUNT_MONEY.Image = global::SaleManagement.Properties.Resources.banknotes_24;
            this.btnDISCOUNT_MONEY.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDISCOUNT_MONEY.Location = new System.Drawing.Point(168, 639);
            this.btnDISCOUNT_MONEY.Name = "btnDISCOUNT_MONEY";
            this.btnDISCOUNT_MONEY.Size = new System.Drawing.Size(138, 43);
            this.btnDISCOUNT_MONEY.TabIndex = 70;
            this.btnDISCOUNT_MONEY.Text = "Giảm tiền";
            this.btnDISCOUNT_MONEY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDISCOUNT_MONEY.UseVisualStyleBackColor = false;
            this.btnDISCOUNT_MONEY.Click += new System.EventHandler(this.btnDISCOUNT_MONEY_Click);
            // 
            // btnDISCOUNT_PERCENT
            // 
            this.btnDISCOUNT_PERCENT.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDISCOUNT_PERCENT.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDISCOUNT_PERCENT.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDISCOUNT_PERCENT.FlatAppearance.BorderSize = 0;
            this.btnDISCOUNT_PERCENT.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue;
            this.btnDISCOUNT_PERCENT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDISCOUNT_PERCENT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDISCOUNT_PERCENT.ForeColor = System.Drawing.Color.White;
            this.btnDISCOUNT_PERCENT.Image = global::SaleManagement.Properties.Resources.percentage_3_24;
            this.btnDISCOUNT_PERCENT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDISCOUNT_PERCENT.Location = new System.Drawing.Point(14, 639);
            this.btnDISCOUNT_PERCENT.Name = "btnDISCOUNT_PERCENT";
            this.btnDISCOUNT_PERCENT.Size = new System.Drawing.Size(144, 43);
            this.btnDISCOUNT_PERCENT.TabIndex = 69;
            this.btnDISCOUNT_PERCENT.Text = "Giảm %";
            this.btnDISCOUNT_PERCENT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDISCOUNT_PERCENT.UseVisualStyleBackColor = false;
            this.btnDISCOUNT_PERCENT.Click += new System.EventHandler(this.btnDISCOUNT_PERCENT_Click);
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
            // FrmBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 691);
            this.Controls.Add(this.btnPRINT);
            this.Controls.Add(this.txtNOTE);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.btnPAYMENT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnLOAD);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSEND_BY_STAFF);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSEND_BY_CUSTOMER);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPRICE_BILL);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.btnDISCOUNT_MONEY);
            this.Controls.Add(this.btnDISCOUNT_PERCENT);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDISCOUNT_BILL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTOTAL_MONEY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMANAGE_DATA);
            this.Name = "FrmBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.panelMANAGE_DATA.ResumeLayout(false);
            this.panelMANAGE_DATA.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSELECT)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMANAGE_DATA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbTYPE_OF_ITEMS;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDISCOUNT_ITEM;
        private System.Windows.Forms.DataGridView dgvSELECT;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.TextBox txtAMOUNT_ITEM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtALL_AMOUNT_ITEMs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtITEMs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvLIST;
        private System.Windows.Forms.ComboBox cbbCUSTOMER;
        private System.Windows.Forms.DateTimePicker dpDAY;
        private System.Windows.Forms.ComboBox cbbSTAFF;
        private System.Windows.Forms.TextBox txtID_BILL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDISCOUNT_BILL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTOTAL_MONEY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDISCOUNT_MONEY;
        private System.Windows.Forms.Button btnDISCOUNT_PERCENT;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPRICE_BILL;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSEND_BY_STAFF;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSEND_BY_CUSTOMER;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnBACK;
        private System.Windows.Forms.Button btnLOAD;
        private System.Windows.Forms.Button btnPAYMENT;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtNOTE;
        private System.Windows.Forms.Button btnADDCUSTOMER;
        private System.Windows.Forms.Button btnPRINT;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.RadioButton rbNAME_ITEM;
        private System.Windows.Forms.RadioButton rbID_ITEM;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Button btnHOME;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}