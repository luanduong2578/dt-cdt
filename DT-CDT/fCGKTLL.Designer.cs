namespace DT_CDT
{
    partial class fCGKTLL
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
            this.cbbSearchTuNam = new System.Windows.Forms.ComboBox();
            this.cbbSearchDenNam = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txbSearchND = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dtgvCGKT = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mktxbHCKKetThuc = new System.Windows.Forms.DateTimePicker();
            this.mktxbHCKBatDau = new System.Windows.Forms.DateTimePicker();
            this.txbHCKNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbHCKPhai = new System.Windows.Forms.TextBox();
            this.txbCGKTTENGOI = new System.Windows.Forms.TextBox();
            this.txbChucDanh = new System.Windows.Forms.TextBox();
            this.txbKhoaPhong = new System.Windows.Forms.TextBox();
            this.txbHCKDVCT = new System.Windows.Forms.TextBox();
            this.ccbCGKTNAM = new System.Windows.Forms.ComboBox();
            this.txbHCKGhichu = new System.Windows.Forms.TextBox();
            this.cbbIDDONVICT = new System.Windows.Forms.ComboBox();
            this.cbbIDKHOAPHONGCGKT = new System.Windows.Forms.ComboBox();
            this.cbbIDCBDMCGKT = new System.Windows.Forms.ComboBox();
            this.btnBVKetthuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBVXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBVBoQua = new System.Windows.Forms.Button();
            this.txbCGKTMASO = new System.Windows.Forms.TextBox();
            this.txbCGKTID = new System.Windows.Forms.TextBox();
            this.btnBVSua = new System.Windows.Forms.Button();
            this.btnBVLuu = new System.Windows.Forms.Button();
            this.btnBVMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCGKT)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbSearchTuNam
            // 
            this.cbbSearchTuNam.FormattingEnabled = true;
            this.cbbSearchTuNam.Location = new System.Drawing.Point(452, 15);
            this.cbbSearchTuNam.Name = "cbbSearchTuNam";
            this.cbbSearchTuNam.Size = new System.Drawing.Size(91, 21);
            this.cbbSearchTuNam.TabIndex = 36;
            this.cbbSearchTuNam.TabStop = false;
            // 
            // cbbSearchDenNam
            // 
            this.cbbSearchDenNam.FormattingEnabled = true;
            this.cbbSearchDenNam.Location = new System.Drawing.Point(597, 16);
            this.cbbSearchDenNam.Name = "cbbSearchDenNam";
            this.cbbSearchDenNam.Size = new System.Drawing.Size(91, 21);
            this.cbbSearchDenNam.TabIndex = 37;
            this.cbbSearchDenNam.TabStop = false;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(28, 16);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(317, 24);
            this.label23.TabIndex = 35;
            this.label23.Text = "GÓI CHUYỂN GIAO KỸ THUẬT";
            // 
            // txbSearchND
            // 
            this.txbSearchND.ForeColor = System.Drawing.Color.Red;
            this.txbSearchND.Location = new System.Drawing.Point(694, 16);
            this.txbSearchND.Name = "txbSearchND";
            this.txbSearchND.Size = new System.Drawing.Size(541, 20);
            this.txbSearchND.TabIndex = 34;
            this.txbSearchND.TabStop = false;
            this.txbSearchND.Text = "Tìm kiếm";
            this.txbSearchND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSearchND.TextChanged += new System.EventHandler(this.txbSearchND_TextChanged);
            this.txbSearchND.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txbSearchND_MouseUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(396, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 13);
            this.label22.TabIndex = 31;
            this.label22.Text = "Từ năm:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(549, 20);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "Đến năm:";
            // 
            // dtgvCGKT
            // 
            this.dtgvCGKT.AllowUserToAddRows = false;
            this.dtgvCGKT.AllowUserToDeleteRows = false;
            this.dtgvCGKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCGKT.Location = new System.Drawing.Point(10, 43);
            this.dtgvCGKT.Name = "dtgvCGKT";
            this.dtgvCGKT.ReadOnly = true;
            this.dtgvCGKT.Size = new System.Drawing.Size(1225, 474);
            this.dtgvCGKT.TabIndex = 40;
            this.dtgvCGKT.TabStop = false;
            this.dtgvCGKT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCGKT_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mktxbHCKKetThuc);
            this.panel1.Controls.Add(this.mktxbHCKBatDau);
            this.panel1.Controls.Add(this.txbHCKNgaySinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbHCKPhai);
            this.panel1.Controls.Add(this.txbCGKTTENGOI);
            this.panel1.Controls.Add(this.txbChucDanh);
            this.panel1.Controls.Add(this.txbKhoaPhong);
            this.panel1.Controls.Add(this.txbHCKDVCT);
            this.panel1.Controls.Add(this.ccbCGKTNAM);
            this.panel1.Controls.Add(this.txbHCKGhichu);
            this.panel1.Controls.Add(this.cbbIDDONVICT);
            this.panel1.Controls.Add(this.cbbIDKHOAPHONGCGKT);
            this.panel1.Controls.Add(this.cbbIDCBDMCGKT);
            this.panel1.Controls.Add(this.btnBVKetthuc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnBVXoa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBVBoQua);
            this.panel1.Controls.Add(this.txbCGKTMASO);
            this.panel1.Controls.Add(this.txbCGKTID);
            this.panel1.Controls.Add(this.btnBVSua);
            this.panel1.Controls.Add(this.btnBVLuu);
            this.panel1.Controls.Add(this.btnBVMoi);
            this.panel1.Location = new System.Drawing.Point(8, 523);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 133);
            this.panel1.TabIndex = 41;
            // 
            // mktxbHCKKetThuc
            // 
            this.mktxbHCKKetThuc.CustomFormat = "dd/MM/yyyy";
            this.mktxbHCKKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mktxbHCKKetThuc.Location = new System.Drawing.Point(1129, 19);
            this.mktxbHCKKetThuc.Name = "mktxbHCKKetThuc";
            this.mktxbHCKKetThuc.Size = new System.Drawing.Size(88, 20);
            this.mktxbHCKKetThuc.TabIndex = 4;
            // 
            // mktxbHCKBatDau
            // 
            this.mktxbHCKBatDau.CustomFormat = "dd/MM/yyyy";
            this.mktxbHCKBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mktxbHCKBatDau.Location = new System.Drawing.Point(1021, 19);
            this.mktxbHCKBatDau.Name = "mktxbHCKBatDau";
            this.mktxbHCKBatDau.Size = new System.Drawing.Size(100, 20);
            this.mktxbHCKBatDau.TabIndex = 3;
            // 
            // txbHCKNgaySinh
            // 
            this.txbHCKNgaySinh.Location = new System.Drawing.Point(545, 57);
            this.txbHCKNgaySinh.Mask = "00/00/0000";
            this.txbHCKNgaySinh.Name = "txbHCKNgaySinh";
            this.txbHCKNgaySinh.Size = new System.Drawing.Size(71, 20);
            this.txbHCKNgaySinh.TabIndex = 25;
            this.txbHCKNgaySinh.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Năm sinh:";
            // 
            // txbHCKPhai
            // 
            this.txbHCKPhai.Location = new System.Drawing.Point(499, 58);
            this.txbHCKPhai.Name = "txbHCKPhai";
            this.txbHCKPhai.Size = new System.Drawing.Size(40, 20);
            this.txbHCKPhai.TabIndex = 6;
            this.txbHCKPhai.TabStop = false;
            // 
            // txbCGKTTENGOI
            // 
            this.txbCGKTTENGOI.Location = new System.Drawing.Point(62, 18);
            this.txbCGKTTENGOI.Name = "txbCGKTTENGOI";
            this.txbCGKTTENGOI.Size = new System.Drawing.Size(580, 20);
            this.txbCGKTTENGOI.TabIndex = 1;
            // 
            // txbChucDanh
            // 
            this.txbChucDanh.Location = new System.Drawing.Point(622, 57);
            this.txbChucDanh.Name = "txbChucDanh";
            this.txbChucDanh.Size = new System.Drawing.Size(126, 20);
            this.txbChucDanh.TabIndex = 18;
            this.txbChucDanh.TabStop = false;
            // 
            // txbKhoaPhong
            // 
            this.txbKhoaPhong.Location = new System.Drawing.Point(1005, 57);
            this.txbKhoaPhong.Name = "txbKhoaPhong";
            this.txbKhoaPhong.Size = new System.Drawing.Size(212, 20);
            this.txbKhoaPhong.TabIndex = 18;
            this.txbKhoaPhong.TabStop = false;
            // 
            // txbHCKDVCT
            // 
            this.txbHCKDVCT.Location = new System.Drawing.Point(753, 57);
            this.txbHCKDVCT.Name = "txbHCKDVCT";
            this.txbHCKDVCT.Size = new System.Drawing.Size(247, 20);
            this.txbHCKDVCT.TabIndex = 18;
            this.txbHCKDVCT.TabStop = false;
            // 
            // ccbCGKTNAM
            // 
            this.ccbCGKTNAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ccbCGKTNAM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ccbCGKTNAM.FormattingEnabled = true;
            this.ccbCGKTNAM.Location = new System.Drawing.Point(6, 16);
            this.ccbCGKTNAM.Name = "ccbCGKTNAM";
            this.ccbCGKTNAM.Size = new System.Drawing.Size(52, 21);
            this.ccbCGKTNAM.TabIndex = 0;
            // 
            // txbHCKGhichu
            // 
            this.txbHCKGhichu.Location = new System.Drawing.Point(53, 82);
            this.txbHCKGhichu.Name = "txbHCKGhichu";
            this.txbHCKGhichu.Size = new System.Drawing.Size(1163, 20);
            this.txbHCKGhichu.TabIndex = 6;
            // 
            // cbbIDDONVICT
            // 
            this.cbbIDDONVICT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbIDDONVICT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbIDDONVICT.FormattingEnabled = true;
            this.cbbIDDONVICT.Location = new System.Drawing.Point(648, 18);
            this.cbbIDDONVICT.Name = "cbbIDDONVICT";
            this.cbbIDDONVICT.Size = new System.Drawing.Size(369, 21);
            this.cbbIDDONVICT.TabIndex = 2;
            // 
            // cbbIDKHOAPHONGCGKT
            // 
            this.cbbIDKHOAPHONGCGKT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbIDKHOAPHONGCGKT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbIDKHOAPHONGCGKT.FormattingEnabled = true;
            this.cbbIDKHOAPHONGCGKT.Location = new System.Drawing.Point(10, 57);
            this.cbbIDKHOAPHONGCGKT.Name = "cbbIDKHOAPHONGCGKT";
            this.cbbIDKHOAPHONGCGKT.Size = new System.Drawing.Size(243, 21);
            this.cbbIDKHOAPHONGCGKT.TabIndex = 5;
            this.cbbIDKHOAPHONGCGKT.SelectedIndexChanged += new System.EventHandler(this.cbbIDCBDMCGKT_SelectedIndexChanged);
            // 
            // cbbIDCBDMCGKT
            // 
            this.cbbIDCBDMCGKT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbIDCBDMCGKT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbIDCBDMCGKT.FormattingEnabled = true;
            this.cbbIDCBDMCGKT.Location = new System.Drawing.Point(255, 57);
            this.cbbIDCBDMCGKT.Name = "cbbIDCBDMCGKT";
            this.cbbIDCBDMCGKT.Size = new System.Drawing.Size(239, 21);
            this.cbbIDCBDMCGKT.TabIndex = 5;
            this.cbbIDCBDMCGKT.SelectedIndexChanged += new System.EventHandler(this.cbbIDCBDMCGKT_SelectedIndexChanged);
            // 
            // btnBVKetthuc
            // 
            this.btnBVKetthuc.Location = new System.Drawing.Point(712, 106);
            this.btnBVKetthuc.Name = "btnBVKetthuc";
            this.btnBVKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnBVKetthuc.TabIndex = 12;
            this.btnBVKetthuc.Text = "Kết thúc";
            this.btnBVKetthuc.UseVisualStyleBackColor = true;
            this.btnBVKetthuc.Click += new System.EventHandler(this.btnBVKetthuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phái:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1124, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Thời gian kết thúc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1017, 4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Thời gian bắt đầu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Cán bộ đầu mối";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 85);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Ghi chú:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khoa phòng CGKT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Năm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(647, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Đơn vị nhận chuyển giao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Chức danh:";
            // 
            // btnBVXoa
            // 
            this.btnBVXoa.Location = new System.Drawing.Point(631, 106);
            this.btnBVXoa.Name = "btnBVXoa";
            this.btnBVXoa.Size = new System.Drawing.Size(75, 23);
            this.btnBVXoa.TabIndex = 11;
            this.btnBVXoa.TabStop = false;
            this.btnBVXoa.Text = "Xóa";
            this.btnBVXoa.UseVisualStyleBackColor = true;
            this.btnBVXoa.Click += new System.EventHandler(this.btnBVXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gói kỹ thuật";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1002, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Khoa phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(749, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Đơn vị công tác:";
            // 
            // btnBVBoQua
            // 
            this.btnBVBoQua.Location = new System.Drawing.Point(566, 106);
            this.btnBVBoQua.Name = "btnBVBoQua";
            this.btnBVBoQua.Size = new System.Drawing.Size(59, 23);
            this.btnBVBoQua.TabIndex = 10;
            this.btnBVBoQua.Text = "Bỏ qua";
            this.btnBVBoQua.UseVisualStyleBackColor = true;
            this.btnBVBoQua.Click += new System.EventHandler(this.btnBVBoQua_Click);
            // 
            // txbCGKTMASO
            // 
            this.txbCGKTMASO.Location = new System.Drawing.Point(84, 110);
            this.txbCGKTMASO.Name = "txbCGKTMASO";
            this.txbCGKTMASO.Size = new System.Drawing.Size(112, 20);
            this.txbCGKTMASO.TabIndex = 10;
            this.txbCGKTMASO.TabStop = false;
            // 
            // txbCGKTID
            // 
            this.txbCGKTID.Location = new System.Drawing.Point(24, 110);
            this.txbCGKTID.Name = "txbCGKTID";
            this.txbCGKTID.Size = new System.Drawing.Size(50, 20);
            this.txbCGKTID.TabIndex = 10;
            this.txbCGKTID.TabStop = false;
            this.txbCGKTID.Visible = false;
            // 
            // btnBVSua
            // 
            this.btnBVSua.Location = new System.Drawing.Point(510, 106);
            this.btnBVSua.Name = "btnBVSua";
            this.btnBVSua.Size = new System.Drawing.Size(50, 23);
            this.btnBVSua.TabIndex = 9;
            this.btnBVSua.Text = "Sửa";
            this.btnBVSua.UseVisualStyleBackColor = true;
            this.btnBVSua.Click += new System.EventHandler(this.btnBVSua_Click);
            // 
            // btnBVLuu
            // 
            this.btnBVLuu.Location = new System.Drawing.Point(451, 106);
            this.btnBVLuu.Name = "btnBVLuu";
            this.btnBVLuu.Size = new System.Drawing.Size(53, 23);
            this.btnBVLuu.TabIndex = 8;
            this.btnBVLuu.Text = "Lưu";
            this.btnBVLuu.UseVisualStyleBackColor = true;
            this.btnBVLuu.Click += new System.EventHandler(this.btnBVLuu_Click);
            // 
            // btnBVMoi
            // 
            this.btnBVMoi.Location = new System.Drawing.Point(396, 106);
            this.btnBVMoi.Name = "btnBVMoi";
            this.btnBVMoi.Size = new System.Drawing.Size(49, 23);
            this.btnBVMoi.TabIndex = 7;
            this.btnBVMoi.Text = "Mới";
            this.btnBVMoi.UseVisualStyleBackColor = true;
            this.btnBVMoi.Click += new System.EventHandler(this.btnBVMoi_Click);
            // 
            // fCGKTLL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgvCGKT);
            this.Controls.Add(this.cbbSearchTuNam);
            this.Controls.Add(this.cbbSearchDenNam);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txbSearchND);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Name = "fCGKTLL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gói Chuyển Giao Kỹ Thuật";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCGKT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbSearchTuNam;
        private System.Windows.Forms.ComboBox cbbSearchDenNam;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txbSearchND;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dtgvCGKT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker mktxbHCKKetThuc;
        private System.Windows.Forms.DateTimePicker mktxbHCKBatDau;
        private System.Windows.Forms.MaskedTextBox txbHCKNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbHCKPhai;
        private System.Windows.Forms.TextBox txbCGKTTENGOI;
        private System.Windows.Forms.TextBox txbChucDanh;
        private System.Windows.Forms.TextBox txbHCKDVCT;
        private System.Windows.Forms.ComboBox ccbCGKTNAM;
        private System.Windows.Forms.TextBox txbHCKGhichu;
        private System.Windows.Forms.ComboBox cbbIDDONVICT;
        private System.Windows.Forms.ComboBox cbbIDCBDMCGKT;
        private System.Windows.Forms.Button btnBVKetthuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBVXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBVBoQua;
        private System.Windows.Forms.TextBox txbCGKTMASO;
        private System.Windows.Forms.TextBox txbCGKTID;
        private System.Windows.Forms.Button btnBVSua;
        private System.Windows.Forms.Button btnBVLuu;
        private System.Windows.Forms.Button btnBVMoi;
        private System.Windows.Forms.TextBox txbKhoaPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbIDKHOAPHONGCGKT;
        private System.Windows.Forms.Label label9;
    }
}