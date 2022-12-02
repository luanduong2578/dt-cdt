namespace DT_CDT
{
    partial class fChamCong
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
            this.dtgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.txbSearch_HV = new System.Windows.Forms.TextBox();
            this.txbMALOP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbHOCVIEN = new System.Windows.Forms.TextBox();
            this.dtpkNGAYDIEMDANH = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cbbDIEMDANH = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGHICHU = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbIDLOP = new System.Windows.Forms.TextBox();
            this.txbMMYY = new System.Windows.Forms.TextBox();
            this.tabDTTL = new System.Windows.Forms.TabControl();
            this.tabHCK = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbMMYYDTTL = new System.Windows.Forms.TextBox();
            this.txbIDHOCVIEN = new System.Windows.Forms.TextBox();
            this.btnKetThucDTTL = new System.Windows.Forms.Button();
            this.btnInDTTL = new System.Windows.Forms.Button();
            this.btnLuuDTTL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbChonDiemDanhDTTL = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpkNgayChamCong_DTTL = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbHVDTTL = new System.Windows.Forms.TextBox();
            this.txbIDLOPDTTL = new System.Windows.Forms.TextBox();
            this.txbMaLopDTTL = new System.Windows.Forms.TextBox();
            this.txbGhiChuDTTL = new System.Windows.Forms.TextBox();
            this.dtgvDTTL = new System.Windows.Forms.DataGridView();
            this.txbTimLop = new System.Windows.Forms.TextBox();
            this.txbTimHV = new System.Windows.Forms.TextBox();
            this.cbbNamDTTL = new System.Windows.Forms.ComboBox();
            this.cbbThangDTTL = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemDanh)).BeginInit();
            this.tabDTTL.SuspendLayout();
            this.tabHCK.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTTL)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDiemDanh
            // 
            this.dtgvDiemDanh.AllowUserToAddRows = false;
            this.dtgvDiemDanh.AllowUserToDeleteRows = false;
            this.dtgvDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDiemDanh.Location = new System.Drawing.Point(6, 33);
            this.dtgvDiemDanh.Name = "dtgvDiemDanh";
            this.dtgvDiemDanh.ReadOnly = true;
            this.dtgvDiemDanh.Size = new System.Drawing.Size(1218, 427);
            this.dtgvDiemDanh.TabIndex = 34;
            this.dtgvDiemDanh.TabStop = false;
            this.dtgvDiemDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDiemDanh_CellClick);
            this.dtgvDiemDanh.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvDiemDanh_CellFormatting);
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbbNam.Location = new System.Drawing.Point(52, 6);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(73, 23);
            this.cbbNam.TabIndex = 35;
            this.cbbNam.TabStop = false;
            this.cbbNam.SelectedValueChanged += new System.EventHandler(this.cbbNam_SelectedValueChanged);
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbThang.Location = new System.Drawing.Point(6, 6);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(42, 23);
            this.cbbThang.TabIndex = 35;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // txbSearch_HV
            // 
            this.txbSearch_HV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbSearch_HV.Location = new System.Drawing.Point(792, 6);
            this.txbSearch_HV.Name = "txbSearch_HV";
            this.txbSearch_HV.Size = new System.Drawing.Size(432, 22);
            this.txbSearch_HV.TabIndex = 36;
            this.txbSearch_HV.Text = "------ Tìm kiếm Học viên ------";
            this.txbSearch_HV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbSearch_HV.TextChanged += new System.EventHandler(this.txbSearch_HV_TextChanged);
            this.txbSearch_HV.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txbSearch_HV_MouseUp);
            // 
            // txbMALOP
            // 
            this.txbMALOP.Enabled = false;
            this.txbMALOP.Location = new System.Drawing.Point(19, 485);
            this.txbMALOP.Name = "txbMALOP";
            this.txbMALOP.Size = new System.Drawing.Size(65, 22);
            this.txbMALOP.TabIndex = 41;
            this.txbMALOP.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mã lớp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 469);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Học viên";
            // 
            // txbHOCVIEN
            // 
            this.txbHOCVIEN.Enabled = false;
            this.txbHOCVIEN.Location = new System.Drawing.Point(90, 485);
            this.txbHOCVIEN.Name = "txbHOCVIEN";
            this.txbHOCVIEN.Size = new System.Drawing.Size(203, 22);
            this.txbHOCVIEN.TabIndex = 42;
            this.txbHOCVIEN.TabStop = false;
            // 
            // dtpkNGAYDIEMDANH
            // 
            this.dtpkNGAYDIEMDANH.CustomFormat = "dd/MM/yyyy";
            this.dtpkNGAYDIEMDANH.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNGAYDIEMDANH.Location = new System.Drawing.Point(299, 485);
            this.dtpkNGAYDIEMDANH.Name = "dtpkNGAYDIEMDANH";
            this.dtpkNGAYDIEMDANH.Size = new System.Drawing.Size(81, 22);
            this.dtpkNGAYDIEMDANH.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(295, 470);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Ngày";
            // 
            // cbbDIEMDANH
            // 
            this.cbbDIEMDANH.FormattingEnabled = true;
            this.cbbDIEMDANH.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbbDIEMDANH.Location = new System.Drawing.Point(386, 484);
            this.cbbDIEMDANH.Name = "cbbDIEMDANH";
            this.cbbDIEMDANH.Size = new System.Drawing.Size(169, 23);
            this.cbbDIEMDANH.TabIndex = 45;
            this.cbbDIEMDANH.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(383, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Điểm danh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 469);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Ghi chú";
            // 
            // txbGHICHU
            // 
            this.txbGHICHU.Location = new System.Drawing.Point(561, 485);
            this.txbGHICHU.Name = "txbGHICHU";
            this.txbGHICHU.Size = new System.Drawing.Size(440, 22);
            this.txbGHICHU.TabIndex = 42;
            this.txbGHICHU.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(1007, 482);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(40, 23);
            this.btnLuu.TabIndex = 46;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1053, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 46;
            this.button2.Text = "In";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1114, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Kết thúc";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbIDLOP
            // 
            this.txbIDLOP.Location = new System.Drawing.Point(622, 462);
            this.txbIDLOP.Name = "txbIDLOP";
            this.txbIDLOP.Size = new System.Drawing.Size(100, 22);
            this.txbIDLOP.TabIndex = 47;
            this.txbIDLOP.TabStop = false;
            this.txbIDLOP.Visible = false;
            // 
            // txbMMYY
            // 
            this.txbMMYY.Location = new System.Drawing.Point(728, 461);
            this.txbMMYY.Name = "txbMMYY";
            this.txbMMYY.Size = new System.Drawing.Size(100, 22);
            this.txbMMYY.TabIndex = 47;
            this.txbMMYY.TabStop = false;
            this.txbMMYY.Visible = false;
            // 
            // tabDTTL
            // 
            this.tabDTTL.Controls.Add(this.tabHCK);
            this.tabDTTL.Controls.Add(this.tabPage2);
            this.tabDTTL.Location = new System.Drawing.Point(3, 2);
            this.tabDTTL.Name = "tabDTTL";
            this.tabDTTL.SelectedIndex = 0;
            this.tabDTTL.Size = new System.Drawing.Size(1235, 561);
            this.tabDTTL.TabIndex = 48;
            // 
            // tabHCK
            // 
            this.tabHCK.Controls.Add(this.txbSearch_HV);
            this.tabHCK.Controls.Add(this.txbMMYY);
            this.tabHCK.Controls.Add(this.cbbNam);
            this.tabHCK.Controls.Add(this.txbIDLOP);
            this.tabHCK.Controls.Add(this.cbbThang);
            this.tabHCK.Controls.Add(this.button3);
            this.tabHCK.Controls.Add(this.button2);
            this.tabHCK.Controls.Add(this.dtgvDiemDanh);
            this.tabHCK.Controls.Add(this.btnLuu);
            this.tabHCK.Controls.Add(this.label14);
            this.tabHCK.Controls.Add(this.cbbDIEMDANH);
            this.tabHCK.Controls.Add(this.label1);
            this.tabHCK.Controls.Add(this.dtpkNGAYDIEMDANH);
            this.tabHCK.Controls.Add(this.label5);
            this.tabHCK.Controls.Add(this.label2);
            this.tabHCK.Controls.Add(this.label4);
            this.tabHCK.Controls.Add(this.txbHOCVIEN);
            this.tabHCK.Controls.Add(this.txbMALOP);
            this.tabHCK.Controls.Add(this.txbGHICHU);
            this.tabHCK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabHCK.Location = new System.Drawing.Point(4, 22);
            this.tabHCK.Name = "tabHCK";
            this.tabHCK.Padding = new System.Windows.Forms.Padding(3);
            this.tabHCK.Size = new System.Drawing.Size(1227, 535);
            this.tabHCK.TabIndex = 0;
            this.tabHCK.Text = "Học chuyên khoa";
            this.tabHCK.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txbMMYYDTTL);
            this.tabPage2.Controls.Add(this.txbIDHOCVIEN);
            this.tabPage2.Controls.Add(this.btnKetThucDTTL);
            this.tabPage2.Controls.Add(this.btnInDTTL);
            this.tabPage2.Controls.Add(this.btnLuuDTTL);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cbbChonDiemDanhDTTL);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dtpkNgayChamCong_DTTL);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txbHVDTTL);
            this.tabPage2.Controls.Add(this.txbIDLOPDTTL);
            this.tabPage2.Controls.Add(this.txbMaLopDTTL);
            this.tabPage2.Controls.Add(this.txbGhiChuDTTL);
            this.tabPage2.Controls.Add(this.dtgvDTTL);
            this.tabPage2.Controls.Add(this.txbTimLop);
            this.tabPage2.Controls.Add(this.txbTimHV);
            this.tabPage2.Controls.Add(this.cbbNamDTTL);
            this.tabPage2.Controls.Add(this.cbbThangDTTL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1227, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đào tạo theo lớp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txbMMYYDTTL
            // 
            this.txbMMYYDTTL.Location = new System.Drawing.Point(654, 463);
            this.txbMMYYDTTL.Name = "txbMMYYDTTL";
            this.txbMMYYDTTL.Size = new System.Drawing.Size(100, 20);
            this.txbMMYYDTTL.TabIndex = 61;
            this.txbMMYYDTTL.TabStop = false;
            // 
            // txbIDHOCVIEN
            // 
            this.txbIDHOCVIEN.Location = new System.Drawing.Point(831, 462);
            this.txbIDHOCVIEN.Name = "txbIDHOCVIEN";
            this.txbIDHOCVIEN.Size = new System.Drawing.Size(100, 20);
            this.txbIDHOCVIEN.TabIndex = 62;
            this.txbIDHOCVIEN.TabStop = false;
            // 
            // btnKetThucDTTL
            // 
            this.btnKetThucDTTL.Location = new System.Drawing.Point(1114, 482);
            this.btnKetThucDTTL.Name = "btnKetThucDTTL";
            this.btnKetThucDTTL.Size = new System.Drawing.Size(92, 23);
            this.btnKetThucDTTL.TabIndex = 58;
            this.btnKetThucDTTL.Text = "Kết thúc";
            this.btnKetThucDTTL.UseVisualStyleBackColor = true;
            this.btnKetThucDTTL.Click += new System.EventHandler(this.btnKetThucDTTL_Click);
            // 
            // btnInDTTL
            // 
            this.btnInDTTL.Location = new System.Drawing.Point(1053, 482);
            this.btnInDTTL.Name = "btnInDTTL";
            this.btnInDTTL.Size = new System.Drawing.Size(55, 23);
            this.btnInDTTL.TabIndex = 59;
            this.btnInDTTL.Text = "In";
            this.btnInDTTL.UseVisualStyleBackColor = true;
            // 
            // btnLuuDTTL
            // 
            this.btnLuuDTTL.Location = new System.Drawing.Point(1007, 482);
            this.btnLuuDTTL.Name = "btnLuuDTTL";
            this.btnLuuDTTL.Size = new System.Drawing.Size(40, 23);
            this.btnLuuDTTL.TabIndex = 60;
            this.btnLuuDTTL.Text = "Lưu";
            this.btnLuuDTTL.UseVisualStyleBackColor = true;
            this.btnLuuDTTL.Click += new System.EventHandler(this.btnLuuDTTL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Ngày";
            // 
            // cbbChonDiemDanhDTTL
            // 
            this.cbbChonDiemDanhDTTL.FormattingEnabled = true;
            this.cbbChonDiemDanhDTTL.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbbChonDiemDanhDTTL.Location = new System.Drawing.Point(386, 484);
            this.cbbChonDiemDanhDTTL.Name = "cbbChonDiemDanhDTTL";
            this.cbbChonDiemDanhDTTL.Size = new System.Drawing.Size(169, 21);
            this.cbbChonDiemDanhDTTL.TabIndex = 57;
            this.cbbChonDiemDanhDTTL.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 469);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Học viên";
            // 
            // dtpkNgayChamCong_DTTL
            // 
            this.dtpkNgayChamCong_DTTL.CustomFormat = "dd/MM/yyyy";
            this.dtpkNgayChamCong_DTTL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpkNgayChamCong_DTTL.Location = new System.Drawing.Point(299, 485);
            this.dtpkNgayChamCong_DTTL.Name = "dtpkNgayChamCong_DTTL";
            this.dtpkNgayChamCong_DTTL.Size = new System.Drawing.Size(81, 20);
            this.dtpkNgayChamCong_DTTL.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 469);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Mã lớp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "Điểm danh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(559, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Ghi chú";
            // 
            // txbHVDTTL
            // 
            this.txbHVDTTL.Enabled = false;
            this.txbHVDTTL.Location = new System.Drawing.Point(90, 485);
            this.txbHVDTTL.Name = "txbHVDTTL";
            this.txbHVDTTL.Size = new System.Drawing.Size(203, 20);
            this.txbHVDTTL.TabIndex = 52;
            this.txbHVDTTL.TabStop = false;
            // 
            // txbIDLOPDTTL
            // 
            this.txbIDLOPDTTL.Enabled = false;
            this.txbIDLOPDTTL.Location = new System.Drawing.Point(760, 463);
            this.txbIDLOPDTTL.Name = "txbIDLOPDTTL";
            this.txbIDLOPDTTL.Size = new System.Drawing.Size(65, 20);
            this.txbIDLOPDTTL.TabIndex = 51;
            this.txbIDLOPDTTL.TabStop = false;
            // 
            // txbMaLopDTTL
            // 
            this.txbMaLopDTTL.Enabled = false;
            this.txbMaLopDTTL.Location = new System.Drawing.Point(19, 485);
            this.txbMaLopDTTL.Name = "txbMaLopDTTL";
            this.txbMaLopDTTL.Size = new System.Drawing.Size(65, 20);
            this.txbMaLopDTTL.TabIndex = 51;
            this.txbMaLopDTTL.TabStop = false;
            // 
            // txbGhiChuDTTL
            // 
            this.txbGhiChuDTTL.Location = new System.Drawing.Point(561, 485);
            this.txbGhiChuDTTL.Name = "txbGhiChuDTTL";
            this.txbGhiChuDTTL.Size = new System.Drawing.Size(440, 20);
            this.txbGhiChuDTTL.TabIndex = 53;
            this.txbGhiChuDTTL.TabStop = false;
            // 
            // dtgvDTTL
            // 
            this.dtgvDTTL.AllowUserToAddRows = false;
            this.dtgvDTTL.AllowUserToDeleteRows = false;
            this.dtgvDTTL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDTTL.Location = new System.Drawing.Point(6, 33);
            this.dtgvDTTL.Name = "dtgvDTTL";
            this.dtgvDTTL.ReadOnly = true;
            this.dtgvDTTL.Size = new System.Drawing.Size(1218, 427);
            this.dtgvDTTL.TabIndex = 40;
            this.dtgvDTTL.TabStop = false;
            this.dtgvDTTL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDTTL_CellClick);
            // 
            // txbTimLop
            // 
            this.txbTimLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimLop.ForeColor = System.Drawing.Color.Blue;
            this.txbTimLop.Location = new System.Drawing.Point(206, 6);
            this.txbTimLop.Name = "txbTimLop";
            this.txbTimLop.Size = new System.Drawing.Size(580, 21);
            this.txbTimLop.TabIndex = 39;
            this.txbTimLop.Text = "------ Tìm Lớp------";
            this.txbTimLop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbTimLop.TextChanged += new System.EventHandler(this.txbTimLop_TextChanged);
            this.txbTimLop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.txbTimLop_MouseUp);
            // 
            // txbTimHV
            // 
            this.txbTimHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimHV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbTimHV.Location = new System.Drawing.Point(792, 6);
            this.txbTimHV.Name = "txbTimHV";
            this.txbTimHV.Size = new System.Drawing.Size(432, 21);
            this.txbTimHV.TabIndex = 39;
            this.txbTimHV.Text = "------ Tìm kiếm Học viên ------";
            this.txbTimHV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbNamDTTL
            // 
            this.cbbNamDTTL.FormattingEnabled = true;
            this.cbbNamDTTL.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029"});
            this.cbbNamDTTL.Location = new System.Drawing.Point(52, 6);
            this.cbbNamDTTL.Name = "cbbNamDTTL";
            this.cbbNamDTTL.Size = new System.Drawing.Size(73, 21);
            this.cbbNamDTTL.TabIndex = 37;
            this.cbbNamDTTL.TabStop = false;
            this.cbbNamDTTL.SelectedIndexChanged += new System.EventHandler(this.cbbNamDTTL_SelectedIndexChanged);
            // 
            // cbbThangDTTL
            // 
            this.cbbThangDTTL.FormattingEnabled = true;
            this.cbbThangDTTL.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbbThangDTTL.Location = new System.Drawing.Point(6, 6);
            this.cbbThangDTTL.Name = "cbbThangDTTL";
            this.cbbThangDTTL.Size = new System.Drawing.Size(42, 21);
            this.cbbThangDTTL.TabIndex = 38;
            this.cbbThangDTTL.SelectedIndexChanged += new System.EventHandler(this.cbbThangDTTL_SelectedIndexChanged);
            // 
            // fChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 534);
            this.Controls.Add(this.tabDTTL);
            this.Name = "fChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm danh HCK";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDiemDanh)).EndInit();
            this.tabDTTL.ResumeLayout(false);
            this.tabHCK.ResumeLayout(false);
            this.tabHCK.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDTTL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDiemDanh;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.TextBox txbSearch_HV;
        private System.Windows.Forms.TextBox txbMALOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHOCVIEN;
        private System.Windows.Forms.DateTimePicker dtpkNGAYDIEMDANH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbbDIEMDANH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGHICHU;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbIDLOP;
        private System.Windows.Forms.TextBox txbMMYY;
        private System.Windows.Forms.TabControl tabDTTL;
        private System.Windows.Forms.TabPage tabHCK;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtgvDTTL;
        private System.Windows.Forms.TextBox txbTimHV;
        private System.Windows.Forms.ComboBox cbbNamDTTL;
        private System.Windows.Forms.ComboBox cbbThangDTTL;
        private System.Windows.Forms.TextBox txbMMYYDTTL;
        private System.Windows.Forms.TextBox txbIDHOCVIEN;
        private System.Windows.Forms.Button btnKetThucDTTL;
        private System.Windows.Forms.Button btnInDTTL;
        private System.Windows.Forms.Button btnLuuDTTL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbChonDiemDanhDTTL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpkNgayChamCong_DTTL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbHVDTTL;
        private System.Windows.Forms.TextBox txbMaLopDTTL;
        private System.Windows.Forms.TextBox txbGhiChuDTTL;
        private System.Windows.Forms.TextBox txbIDLOPDTTL;
        private System.Windows.Forms.TextBox txbTimLop;
    }
}