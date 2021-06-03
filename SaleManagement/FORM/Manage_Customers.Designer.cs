
namespace SaleManagement.VIEW
{
    partial class FrmManage_Customers
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
            this.dpDAY = new System.Windows.Forms.DateTimePicker();
            this.gbGENDER = new System.Windows.Forms.GroupBox();
            this.rbFEMALE = new System.Windows.Forms.RadioButton();
            this.rbMALE = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.txtADDRESS = new System.Windows.Forms.TextBox();
            this.txtPHONE = new System.Windows.Forms.TextBox();
            this.txtNAME_CUSTOMER = new System.Windows.Forms.TextBox();
            this.txtID_CUSTOMER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLISTCUSTOMER = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMANAGE_CUSTOMER = new System.Windows.Forms.Panel();
            this.btnHOME = new System.Windows.Forms.Button();
            this.rbNAME_CUSTOMER = new System.Windows.Forms.RadioButton();
            this.rbID_CUSTOMER = new System.Windows.Forms.RadioButton();
            this.btnADD = new System.Windows.Forms.Button();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.btnSHOW = new System.Windows.Forms.Button();
            this.gbGENDER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTCUSTOMER)).BeginInit();
            this.panelMANAGE_CUSTOMER.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpDAY
            // 
            this.dpDAY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpDAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDAY.Location = new System.Drawing.Point(118, 254);
            this.dpDAY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dpDAY.Name = "dpDAY";
            this.dpDAY.Size = new System.Drawing.Size(210, 25);
            this.dpDAY.TabIndex = 82;
            // 
            // gbGENDER
            // 
            this.gbGENDER.Controls.Add(this.rbFEMALE);
            this.gbGENDER.Controls.Add(this.rbMALE);
            this.gbGENDER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGENDER.Location = new System.Drawing.Point(26, 287);
            this.gbGENDER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGENDER.Name = "gbGENDER";
            this.gbGENDER.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbGENDER.Size = new System.Drawing.Size(289, 91);
            this.gbGENDER.TabIndex = 80;
            this.gbGENDER.TabStop = false;
            this.gbGENDER.Text = "Giới tính";
            // 
            // rbFEMALE
            // 
            this.rbFEMALE.AutoSize = true;
            this.rbFEMALE.Location = new System.Drawing.Point(58, 52);
            this.rbFEMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbFEMALE.Name = "rbFEMALE";
            this.rbFEMALE.Size = new System.Drawing.Size(51, 22);
            this.rbFEMALE.TabIndex = 1;
            this.rbFEMALE.TabStop = true;
            this.rbFEMALE.Text = "Nữ";
            this.rbFEMALE.UseVisualStyleBackColor = true;
            // 
            // rbMALE
            // 
            this.rbMALE.AutoSize = true;
            this.rbMALE.Location = new System.Drawing.Point(58, 20);
            this.rbMALE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbMALE.Name = "rbMALE";
            this.rbMALE.Size = new System.Drawing.Size(60, 22);
            this.rbMALE.TabIndex = 0;
            this.rbMALE.TabStop = true;
            this.rbMALE.Text = "Nam";
            this.rbMALE.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 79;
            this.label9.Text = "Ngày sinh";
            // 
            // txtADDRESS
            // 
            this.txtADDRESS.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtADDRESS.ForeColor = System.Drawing.Color.Black;
            this.txtADDRESS.Location = new System.Drawing.Point(118, 222);
            this.txtADDRESS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtADDRESS.Name = "txtADDRESS";
            this.txtADDRESS.Size = new System.Drawing.Size(211, 25);
            this.txtADDRESS.TabIndex = 76;
            this.txtADDRESS.Text = "Nhập địa chỉ";
            this.txtADDRESS.Enter += new System.EventHandler(this.txtADDRESS_Enter);
            this.txtADDRESS.Leave += new System.EventHandler(this.txtADDRESS_Leave);
            // 
            // txtPHONE
            // 
            this.txtPHONE.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPHONE.ForeColor = System.Drawing.Color.Black;
            this.txtPHONE.Location = new System.Drawing.Point(118, 190);
            this.txtPHONE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPHONE.Name = "txtPHONE";
            this.txtPHONE.Size = new System.Drawing.Size(211, 25);
            this.txtPHONE.TabIndex = 75;
            this.txtPHONE.Text = "Nhập SĐT";
            this.txtPHONE.Enter += new System.EventHandler(this.txtPHONE_Enter);
            this.txtPHONE.Leave += new System.EventHandler(this.txtPHONE_Leave);
            // 
            // txtNAME_CUSTOMER
            // 
            this.txtNAME_CUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAME_CUSTOMER.ForeColor = System.Drawing.Color.Black;
            this.txtNAME_CUSTOMER.Location = new System.Drawing.Point(118, 158);
            this.txtNAME_CUSTOMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNAME_CUSTOMER.Name = "txtNAME_CUSTOMER";
            this.txtNAME_CUSTOMER.Size = new System.Drawing.Size(211, 25);
            this.txtNAME_CUSTOMER.TabIndex = 74;
            this.txtNAME_CUSTOMER.Text = "Nhập tên khách hàng";
            this.txtNAME_CUSTOMER.Enter += new System.EventHandler(this.txtNAME_CUSTOMER_Enter);
            this.txtNAME_CUSTOMER.Leave += new System.EventHandler(this.txtNAME_CUSTOMER_Leave);
            // 
            // txtID_CUSTOMER
            // 
            this.txtID_CUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_CUSTOMER.Location = new System.Drawing.Point(118, 127);
            this.txtID_CUSTOMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID_CUSTOMER.Name = "txtID_CUSTOMER";
            this.txtID_CUSTOMER.Size = new System.Drawing.Size(211, 25);
            this.txtID_CUSTOMER.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 71;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 18);
            this.label3.TabIndex = 70;
            this.label3.Text = "Số ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tên KH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "Mã KH";
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.ForeColor = System.Drawing.Color.Silver;
            this.txtSEARCH.Location = new System.Drawing.Point(722, 522);
            this.txtSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(244, 25);
            this.txtSEARCH.TabIndex = 67;
            this.txtSEARCH.Text = "Nhập thông tin cần tìm kiếm";
            this.txtSEARCH.Enter += new System.EventHandler(this.txtSEARCH_Enter);
            this.txtSEARCH.Leave += new System.EventHandler(this.txtSEARCH_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(759, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 28);
            this.label2.TabIndex = 62;
            this.label2.Text = "DANH SÁCH KHÁCH HÀNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvLISTCUSTOMER
            // 
            this.dgvLISTCUSTOMER.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLISTCUSTOMER.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLISTCUSTOMER.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLISTCUSTOMER.Location = new System.Drawing.Point(354, 126);
            this.dgvLISTCUSTOMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLISTCUSTOMER.Name = "dgvLISTCUSTOMER";
            this.dgvLISTCUSTOMER.RowHeadersWidth = 62;
            this.dgvLISTCUSTOMER.RowTemplate.Height = 28;
            this.dgvLISTCUSTOMER.Size = new System.Drawing.Size(732, 371);
            this.dgvLISTCUSTOMER.TabIndex = 61;
            this.dgvLISTCUSTOMER.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLISTCUSTOMER_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMANAGE_CUSTOMER
            // 
            this.panelMANAGE_CUSTOMER.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMANAGE_CUSTOMER.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMANAGE_CUSTOMER.Controls.Add(this.btnHOME);
            this.panelMANAGE_CUSTOMER.Controls.Add(this.label1);
            this.panelMANAGE_CUSTOMER.Location = new System.Drawing.Point(0, 0);
            this.panelMANAGE_CUSTOMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMANAGE_CUSTOMER.Name = "panelMANAGE_CUSTOMER";
            this.panelMANAGE_CUSTOMER.Size = new System.Drawing.Size(1097, 62);
            this.panelMANAGE_CUSTOMER.TabIndex = 60;
            // 
            // btnHOME
            // 
            this.btnHOME.BackColor = System.Drawing.Color.SteelBlue;
            this.btnHOME.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHOME.FlatAppearance.BorderSize = 0;
            this.btnHOME.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHOME.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHOME.ForeColor = System.Drawing.Color.White;
            this.btnHOME.Image = global::SaleManagement.Properties.Resources.house_48;
            this.btnHOME.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHOME.Location = new System.Drawing.Point(919, 2);
            this.btnHOME.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHOME.Name = "btnHOME";
            this.btnHOME.Size = new System.Drawing.Size(175, 54);
            this.btnHOME.TabIndex = 37;
            this.btnHOME.Text = "Trang chủ";
            this.btnHOME.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHOME.UseVisualStyleBackColor = false;
            this.btnHOME.Click += new System.EventHandler(this.btnHOME_Click);
            // 
            // rbNAME_CUSTOMER
            // 
            this.rbNAME_CUSTOMER.AutoSize = true;
            this.rbNAME_CUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNAME_CUSTOMER.Location = new System.Drawing.Point(596, 524);
            this.rbNAME_CUSTOMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbNAME_CUSTOMER.Name = "rbNAME_CUSTOMER";
            this.rbNAME_CUSTOMER.Size = new System.Drawing.Size(83, 22);
            this.rbNAME_CUSTOMER.TabIndex = 90;
            this.rbNAME_CUSTOMER.TabStop = true;
            this.rbNAME_CUSTOMER.Text = "Tên KH";
            this.rbNAME_CUSTOMER.UseVisualStyleBackColor = true;
            // 
            // rbID_CUSTOMER
            // 
            this.rbID_CUSTOMER.AutoSize = true;
            this.rbID_CUSTOMER.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbID_CUSTOMER.Location = new System.Drawing.Point(495, 524);
            this.rbID_CUSTOMER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbID_CUSTOMER.Name = "rbID_CUSTOMER";
            this.rbID_CUSTOMER.Size = new System.Drawing.Size(76, 22);
            this.rbID_CUSTOMER.TabIndex = 89;
            this.rbID_CUSTOMER.TabStop = true;
            this.rbID_CUSTOMER.Text = "Mã KH";
            this.rbID_CUSTOMER.UseVisualStyleBackColor = true;
            // 
            // btnADD
            // 
            this.btnADD.BackColor = System.Drawing.Color.SteelBlue;
            this.btnADD.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.White;
            this.btnADD.Image = global::SaleManagement.Properties.Resources.add_user_24;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(4, 394);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(108, 49);
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
            this.btnEDIT.Location = new System.Drawing.Point(118, 394);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(108, 49);
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
            this.btnBACK.Location = new System.Drawing.Point(231, 450);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(108, 47);
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
            this.btnSAVE.Location = new System.Drawing.Point(231, 394);
            this.btnSAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(108, 49);
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
            this.btnCANCEL.Location = new System.Drawing.Point(118, 450);
            this.btnCANCEL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(108, 47);
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
            this.btnDELETE.Location = new System.Drawing.Point(4, 450);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(108, 47);
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
            this.btnSEARCH.Location = new System.Drawing.Point(971, 510);
            this.btnSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.Size = new System.Drawing.Size(116, 38);
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
            this.btnSHOW.Location = new System.Drawing.Point(354, 82);
            this.btnSHOW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSHOW.Name = "btnSHOW";
            this.btnSHOW.Size = new System.Drawing.Size(106, 38);
            this.btnSHOW.TabIndex = 63;
            this.btnSHOW.Text = "Liệt kê";
            this.btnSHOW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSHOW.UseVisualStyleBackColor = false;
            this.btnSHOW.Click += new System.EventHandler(this.btnSHOW_Click);
            // 
            // FrmManage_Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 553);
            this.Controls.Add(this.rbNAME_CUSTOMER);
            this.Controls.Add(this.rbID_CUSTOMER);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.btnCANCEL);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.dpDAY);
            this.Controls.Add(this.gbGENDER);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtADDRESS);
            this.Controls.Add(this.txtPHONE);
            this.Controls.Add(this.txtNAME_CUSTOMER);
            this.Controls.Add(this.txtID_CUSTOMER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSEARCH);
            this.Controls.Add(this.btnSEARCH);
            this.Controls.Add(this.btnSHOW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLISTCUSTOMER);
            this.Controls.Add(this.panelMANAGE_CUSTOMER);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmManage_Customers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage_Customers";
            this.gbGENDER.ResumeLayout(false);
            this.gbGENDER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLISTCUSTOMER)).EndInit();
            this.panelMANAGE_CUSTOMER.ResumeLayout(false);
            this.panelMANAGE_CUSTOMER.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker dpDAY;
        private System.Windows.Forms.GroupBox gbGENDER;
        private System.Windows.Forms.RadioButton rbFEMALE;
        private System.Windows.Forms.RadioButton rbMALE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtADDRESS;
        private System.Windows.Forms.TextBox txtPHONE;
        private System.Windows.Forms.TextBox txtNAME_CUSTOMER;
        private System.Windows.Forms.TextBox txtID_CUSTOMER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSEARCH;
        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.Button btnSHOW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLISTCUSTOMER;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMANAGE_CUSTOMER;
        private System.Windows.Forms.RadioButton rbNAME_CUSTOMER;
        private System.Windows.Forms.RadioButton rbID_CUSTOMER;
        private System.Windows.Forms.Button btnHOME;
    }
}