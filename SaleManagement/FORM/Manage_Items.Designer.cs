﻿
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
            this.label1 = new System.Windows.Forms.Label();
            this.panelMANAGE_STAFF = new System.Windows.Forms.Panel();
            this.btnHOME = new System.Windows.Forms.Button();
            this.cbbSUPPLIERs = new System.Windows.Forms.ComboBox();
            this.cbbTYPE_OF_ITEMs = new System.Windows.Forms.ComboBox();
            this.txtAMOUNT = new System.Windows.Forms.TextBox();
            this.txtNAME_ITEM = new System.Windows.Forms.TextBox();
            this.txtID_ITEM = new System.Windows.Forms.TextBox();
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
            this.cbbTYPE_OF_ITEMS_DETAIL = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTITEMS)).BeginInit();
            this.panelMANAGE_STAFF.SuspendLayout();
            this.gbMota.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(807, 650);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(274, 28);
            this.txtSEARCH.TabIndex = 67;
            this.txtSEARCH.Text = "Nhập thông tin cần tìm kiếm";
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(888, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 34);
            this.label2.TabIndex = 62;
            this.label2.Text = "DANH SÁCH HÀNG HÓA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLISTITEMS
            // 
            this.dgvLISTITEMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLISTITEMS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTITEMS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLISTITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTITEMS.Location = new System.Drawing.Point(399, 153);
            this.dgvLISTITEMS.Name = "dgvLISTITEMS";
            this.dgvLISTITEMS.RowHeadersWidth = 62;
            this.dgvLISTITEMS.RowTemplate.Height = 28;
            this.dgvLISTITEMS.Size = new System.Drawing.Size(824, 458);
            this.dgvLISTITEMS.TabIndex = 61;
            this.dgvLISTITEMS.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLISTITEMS_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ HÀNG HÓA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMANAGE_STAFF
            // 
            this.panelMANAGE_STAFF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMANAGE_STAFF.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMANAGE_STAFF.Controls.Add(this.btnHOME);
            this.panelMANAGE_STAFF.Controls.Add(this.label1);
            this.panelMANAGE_STAFF.Location = new System.Drawing.Point(0, 0);
            this.panelMANAGE_STAFF.Name = "panelMANAGE_STAFF";
            this.panelMANAGE_STAFF.Size = new System.Drawing.Size(1234, 76);
            this.panelMANAGE_STAFF.TabIndex = 60;
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
            this.btnHOME.Location = new System.Drawing.Point(1034, 3);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(197, 68);
            this.btnHOME.TabIndex = 37;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // cbbSUPPLIERs
            // 
            this.cbbSUPPLIERs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSUPPLIERs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSUPPLIERs.FormattingEnabled = true;
            this.cbbSUPPLIERs.Location = new System.Drawing.Point(133, 285);
            this.cbbSUPPLIERs.Name = "cbbSUPPLIERs";
            this.cbbSUPPLIERs.Size = new System.Drawing.Size(210, 29);
            this.cbbSUPPLIERs.TabIndex = 98;
            // 
            // cbbTYPE_OF_ITEMs
            // 
            this.cbbTYPE_OF_ITEMs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPE_OF_ITEMs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPE_OF_ITEMs.FormattingEnabled = true;
            this.cbbTYPE_OF_ITEMs.Location = new System.Drawing.Point(133, 161);
            this.cbbTYPE_OF_ITEMs.Name = "cbbTYPE_OF_ITEMs";
            this.cbbTYPE_OF_ITEMs.Size = new System.Drawing.Size(210, 29);
            this.cbbTYPE_OF_ITEMs.TabIndex = 97;
            this.cbbTYPE_OF_ITEMs.SelectedIndexChanged += new System.EventHandler(this.cbbTYPE_OF_ITEMS_SelectedIndexChanged);
            // 
            // txtAMOUNT
            // 
            this.txtAMOUNT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAMOUNT.ForeColor = System.Drawing.Color.Black;
            this.txtAMOUNT.Location = new System.Drawing.Point(133, 240);
            this.txtAMOUNT.Name = "txtAMOUNT";
            this.txtAMOUNT.Size = new System.Drawing.Size(210, 28);
            this.txtAMOUNT.TabIndex = 96;
            this.txtAMOUNT.Text = "Nhập số lượng hàng hóa";
            this.txtAMOUNT.Enter += new System.EventHandler(this.txtAMOUNT_Enter);
            this.txtAMOUNT.Leave += new System.EventHandler(this.txtAMOUNT_Leave);
            // 
            // txtNAME_ITEM
            // 
            this.txtNAME_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_ITEM.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_ITEM.Location = new System.Drawing.Point(133, 201);
            this.txtNAME_ITEM.Name = "txtNAME_ITEM";
            this.txtNAME_ITEM.Size = new System.Drawing.Size(210, 28);
            this.txtNAME_ITEM.TabIndex = 95;
            this.txtNAME_ITEM.Text = "Nhập tên hàng hóa";
            this.txtNAME_ITEM.Enter += new System.EventHandler(this.txtNAME_ITEM_Enter);
            this.txtNAME_ITEM.Leave += new System.EventHandler(this.txtNAME_ITEM_Leave);
            // 
            // txtID_ITEM
            // 
            this.txtID_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_ITEM.Location = new System.Drawing.Point(133, 122);
            this.txtID_ITEM.Name = "txtID_ITEM";
            this.txtID_ITEM.Size = new System.Drawing.Size(210, 28);
            this.txtID_ITEM.TabIndex = 94;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 93;
            this.label5.Text = "Nhà CC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 92;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = "Tên HH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 21);
            this.label6.TabIndex = 90;
            this.label6.Text = "Loại HH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 21);
            this.label7.TabIndex = 89;
            this.label7.Text = "Mã HH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(349, 414);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 21);
            this.label14.TabIndex = 107;
            this.label14.Text = "VNĐ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 375);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 21);
            this.label13.TabIndex = 106;
            this.label13.Text = "VNĐ";
            // 
            // txtSALE
            // 
            this.txtSALE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSALE.ForeColor = System.Drawing.Color.Black;
            this.txtSALE.Location = new System.Drawing.Point(133, 409);
            this.txtSALE.Name = "txtSALE";
            this.txtSALE.Size = new System.Drawing.Size(210, 28);
            this.txtSALE.TabIndex = 105;
            this.txtSALE.Text = "Nhập giá bán";
            this.txtSALE.Enter += new System.EventHandler(this.txtSALE_Enter);
            this.txtSALE.Leave += new System.EventHandler(this.txtSALE_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(27, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 21);
            this.label10.TabIndex = 104;
            this.label10.Text = "Giá bán";
            // 
            // txtBUY
            // 
            this.txtBUY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBUY.ForeColor = System.Drawing.Color.Black;
            this.txtBUY.Location = new System.Drawing.Point(133, 370);
            this.txtBUY.Name = "txtBUY";
            this.txtBUY.Size = new System.Drawing.Size(210, 28);
            this.txtBUY.TabIndex = 103;
            this.txtBUY.Text = "Nhập giá mua";
            this.txtBUY.Enter += new System.EventHandler(this.txtBUY_Enter);
            this.txtBUY.Leave += new System.EventHandler(this.txtBUY_Leave);
            // 
            // cbbPRODUCERs
            // 
            this.cbbPRODUCERs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPRODUCERs.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPRODUCERs.FormattingEnabled = true;
            this.cbbPRODUCERs.Location = new System.Drawing.Point(133, 329);
            this.cbbPRODUCERs.Name = "cbbPRODUCERs";
            this.cbbPRODUCERs.Size = new System.Drawing.Size(210, 29);
            this.cbbPRODUCERs.TabIndex = 102;
            // 
            // gbMota
            // 
            this.gbMota.Controls.Add(this.txtDESCRIBE);
            this.gbMota.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMota.Location = new System.Drawing.Point(28, 442);
            this.gbMota.Name = "gbMota";
            this.gbMota.Size = new System.Drawing.Size(341, 98);
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
            this.txtDESCRIBE.Size = new System.Drawing.Size(329, 66);
            this.txtDESCRIBE.TabIndex = 28;
            this.txtDESCRIBE.Text = "Nhập mô tả ...";
            this.txtDESCRIBE.Enter += new System.EventHandler(this.txtDESCRIBE_Enter);
            this.txtDESCRIBE.Leave += new System.EventHandler(this.txtDESCRIBE_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(27, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 21);
            this.label9.TabIndex = 100;
            this.label9.Text = "Giá mua";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 99;
            this.label11.Text = "Nhà SX";
            // 
            // rbNAME_ITEM
            // 
            this.rbNAME_ITEM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbNAME_ITEM.AutoSize = true;
            this.rbNAME_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNAME_ITEM.Location = new System.Drawing.Point(682, 653);
            this.rbNAME_ITEM.Name = "rbNAME_ITEM";
            this.rbNAME_ITEM.Size = new System.Drawing.Size(98, 25);
            this.rbNAME_ITEM.TabIndex = 115;
            this.rbNAME_ITEM.TabStop = true;
            this.rbNAME_ITEM.Text = "Tên HH";
            this.rbNAME_ITEM.UseVisualStyleBackColor = true;
            // 
            // rbID_ITEM
            // 
            this.rbID_ITEM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rbID_ITEM.AutoSize = true;
            this.rbID_ITEM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID_ITEM.Location = new System.Drawing.Point(583, 653);
            this.rbID_ITEM.Name = "rbID_ITEM";
            this.rbID_ITEM.Size = new System.Drawing.Size(91, 25);
            this.rbID_ITEM.TabIndex = 114;
            this.rbID_ITEM.TabStop = true;
            this.rbID_ITEM.Text = "Mã HH";
            this.rbID_ITEM.UseVisualStyleBackColor = true;
            // 
            // cbbTYPE_OF_ITEMS_DETAIL
            // 
            this.cbbTYPE_OF_ITEMS_DETAIL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTYPE_OF_ITEMS_DETAIL.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTYPE_OF_ITEMS_DETAIL.FormattingEnabled = true;
            this.cbbTYPE_OF_ITEMS_DETAIL.Location = new System.Drawing.Point(477, 109);
            this.cbbTYPE_OF_ITEMS_DETAIL.Name = "cbbTYPE_OF_ITEMS_DETAIL";
            this.cbbTYPE_OF_ITEMS_DETAIL.Size = new System.Drawing.Size(197, 29);
            this.cbbTYPE_OF_ITEMS_DETAIL.TabIndex = 117;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 112);
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
            this.btnADD.Location = new System.Drawing.Point(5, 560);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(122, 60);
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
            this.btnEDIT.Location = new System.Drawing.Point(133, 560);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(121, 60);
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
            this.btnBACK.Location = new System.Drawing.Point(260, 626);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(121, 53);
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
            this.btnSAVE.Location = new System.Drawing.Point(260, 560);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(121, 60);
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
            this.btnCANCEL.Location = new System.Drawing.Point(133, 626);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(121, 53);
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
            this.btnDELETE.Location = new System.Drawing.Point(5, 626);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(122, 53);
            this.btnDELETE.TabIndex = 85;
            this.btnDELETE.Text = "Xóa";
            this.btnDELETE.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDELETE.UseVisualStyleBackColor = false;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSEARCH.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSEARCH.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSEARCH.FlatAppearance.BorderSize = 0;
            this.btnSEARCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEARCH.ForeColor = System.Drawing.Color.White;
            this.btnSEARCH.Image = global::SaleManagement.Properties.Resources.search_12_24;
            this.btnSEARCH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSEARCH.Location = new System.Drawing.Point(1087, 638);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(135, 49);
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
            this.btnSHOW.Location = new System.Drawing.Point(682, 98);
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
            this.btnADDTYPE.Location = new System.Drawing.Point(349, 153);
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
            this.btnADDSUPPLIER.Location = new System.Drawing.Point(349, 276);
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
            this.btnADDPRODUCER.Location = new System.Drawing.Point(349, 320);
            this.btnADDPRODUCER.Name = "btnADDPRODUCER";
            this.btnADDPRODUCER.Size = new System.Drawing.Size(44, 44);
            this.btnADDPRODUCER.TabIndex = 120;
            this.btnADDPRODUCER.UseVisualStyleBackColor = false;
            this.btnADDPRODUCER.Click += new System.EventHandler(this.btnADDPRODUCER_Click);
            // 
            // FrmManage_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1234, 691);
            this.Controls.Add(this.btnADDPRODUCER);
            this.Controls.Add(this.btnADDSUPPLIER);
            this.Controls.Add(this.btnADDTYPE);
            this.Controls.Add(this.cbbTYPE_OF_ITEMS_DETAIL);
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
            this.Controls.Add(this.cbbTYPE_OF_ITEMs);
            this.Controls.Add(this.txtAMOUNT);
            this.Controls.Add(this.txtNAME_ITEM);
            this.Controls.Add(this.txtID_ITEM);
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
            this.Controls.Add(this.panelMANAGE_STAFF);
            this.Name = "FrmManage_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Items";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTITEMS)).EndInit();
            this.panelMANAGE_STAFF.ResumeLayout(false);
            this.panelMANAGE_STAFF.PerformLayout();
            this.gbMota.ResumeLayout(false);
            this.gbMota.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMANAGE_STAFF;
        private System.Windows.Forms.ComboBox cbbSUPPLIERs;
        private System.Windows.Forms.ComboBox cbbTYPE_OF_ITEMs;
        private System.Windows.Forms.TextBox txtAMOUNT;
        private System.Windows.Forms.TextBox txtNAME_ITEM;
        private System.Windows.Forms.TextBox txtID_ITEM;
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
        private System.Windows.Forms.ComboBox cbbTYPE_OF_ITEMS_DETAIL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHOME;
        private System.Windows.Forms.Button btnADDTYPE;
        private System.Windows.Forms.Button btnADDSUPPLIER;
        private System.Windows.Forms.Button btnADDPRODUCER;
    }
}