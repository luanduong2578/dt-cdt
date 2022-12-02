namespace DT_CDT
{
    partial class fDMKhoaPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ccbBenhVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKPKetthuc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKPXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnKPBoQua = new System.Windows.Forms.Button();
            this.txbKPid = new System.Windows.Forms.TextBox();
            this.btnKPSua = new System.Windows.Forms.Button();
            this.txbKPTen = new System.Windows.Forms.TextBox();
            this.btnKPLuu = new System.Windows.Forms.Button();
            this.txbKPTenVietTat = new System.Windows.Forms.TextBox();
            this.btnKPMoi = new System.Windows.Forms.Button();
            this.dtgvKhoaPhong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoaPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ccbBenhVien);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnKPKetthuc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnKPXoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnKPBoQua);
            this.panel1.Controls.Add(this.txbKPid);
            this.panel1.Controls.Add(this.btnKPSua);
            this.panel1.Controls.Add(this.txbKPTen);
            this.panel1.Controls.Add(this.btnKPLuu);
            this.panel1.Controls.Add(this.txbKPTenVietTat);
            this.panel1.Controls.Add(this.btnKPMoi);
            this.panel1.Location = new System.Drawing.Point(205, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 120);
            this.panel1.TabIndex = 18;
            // 
            // ccbBenhVien
            // 
            this.ccbBenhVien.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ccbBenhVien.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ccbBenhVien.FormattingEnabled = true;
            this.ccbBenhVien.Location = new System.Drawing.Point(74, 6);
            this.ccbBenhVien.Name = "ccbBenhVien";
            this.ccbBenhVien.Size = new System.Drawing.Size(348, 21);
            this.ccbBenhVien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bệnh viện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã KP";
            // 
            // btnKPKetthuc
            // 
            this.btnKPKetthuc.Location = new System.Drawing.Point(325, 84);
            this.btnKPKetthuc.Name = "btnKPKetthuc";
            this.btnKPKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnKPKetthuc.TabIndex = 8;
            this.btnKPKetthuc.Text = "Kết thúc";
            this.btnKPKetthuc.UseVisualStyleBackColor = true;
            this.btnKPKetthuc.Click += new System.EventHandler(this.btnKPKetthuc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Khoa phòng";
            // 
            // btnKPXoa
            // 
            this.btnKPXoa.Location = new System.Drawing.Point(244, 84);
            this.btnKPXoa.Name = "btnKPXoa";
            this.btnKPXoa.Size = new System.Drawing.Size(75, 23);
            this.btnKPXoa.TabIndex = 7;
            this.btnKPXoa.Text = "Xóa";
            this.btnKPXoa.UseVisualStyleBackColor = true;
            this.btnKPXoa.Click += new System.EventHandler(this.btnKPXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên Viết tắt";
            // 
            // btnKPBoQua
            // 
            this.btnKPBoQua.Location = new System.Drawing.Point(179, 84);
            this.btnKPBoQua.Name = "btnKPBoQua";
            this.btnKPBoQua.Size = new System.Drawing.Size(59, 23);
            this.btnKPBoQua.TabIndex = 6;
            this.btnKPBoQua.Text = "Bỏ qua";
            this.btnKPBoQua.UseVisualStyleBackColor = true;
            this.btnKPBoQua.Click += new System.EventHandler(this.btnKPBoQua_Click);
            // 
            // txbKPid
            // 
            this.txbKPid.Location = new System.Drawing.Point(9, 55);
            this.txbKPid.Name = "txbKPid";
            this.txbKPid.Size = new System.Drawing.Size(40, 20);
            this.txbKPid.TabIndex = 10;
            this.txbKPid.TabStop = false;
            // 
            // btnKPSua
            // 
            this.btnKPSua.Location = new System.Drawing.Point(123, 84);
            this.btnKPSua.Name = "btnKPSua";
            this.btnKPSua.Size = new System.Drawing.Size(50, 23);
            this.btnKPSua.TabIndex = 5;
            this.btnKPSua.Text = "Sửa";
            this.btnKPSua.UseVisualStyleBackColor = true;
            this.btnKPSua.Click += new System.EventHandler(this.btnKPSua_Click);
            // 
            // txbKPTen
            // 
            this.txbKPTen.Location = new System.Drawing.Point(63, 55);
            this.txbKPTen.Name = "txbKPTen";
            this.txbKPTen.Size = new System.Drawing.Size(242, 20);
            this.txbKPTen.TabIndex = 2;
            // 
            // btnKPLuu
            // 
            this.btnKPLuu.Location = new System.Drawing.Point(64, 84);
            this.btnKPLuu.Name = "btnKPLuu";
            this.btnKPLuu.Size = new System.Drawing.Size(53, 23);
            this.btnKPLuu.TabIndex = 4;
            this.btnKPLuu.Text = "Lưu";
            this.btnKPLuu.UseVisualStyleBackColor = true;
            this.btnKPLuu.Click += new System.EventHandler(this.btnKPLuu_Click);
            // 
            // txbKPTenVietTat
            // 
            this.txbKPTenVietTat.Location = new System.Drawing.Point(322, 55);
            this.txbKPTenVietTat.Name = "txbKPTenVietTat";
            this.txbKPTenVietTat.Size = new System.Drawing.Size(100, 20);
            this.txbKPTenVietTat.TabIndex = 3;
            // 
            // btnKPMoi
            // 
            this.btnKPMoi.Location = new System.Drawing.Point(9, 84);
            this.btnKPMoi.Name = "btnKPMoi";
            this.btnKPMoi.Size = new System.Drawing.Size(49, 23);
            this.btnKPMoi.TabIndex = 0;
            this.btnKPMoi.Text = "Mới";
            this.btnKPMoi.UseVisualStyleBackColor = true;
            this.btnKPMoi.Click += new System.EventHandler(this.btnKPMoi_Click);
            // 
            // dtgvKhoaPhong
            // 
            this.dtgvKhoaPhong.AllowUserToAddRows = false;
            this.dtgvKhoaPhong.AllowUserToDeleteRows = false;
            this.dtgvKhoaPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvKhoaPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvKhoaPhong.Location = new System.Drawing.Point(12, 2);
            this.dtgvKhoaPhong.Name = "dtgvKhoaPhong";
            this.dtgvKhoaPhong.ReadOnly = true;
            this.dtgvKhoaPhong.Size = new System.Drawing.Size(796, 293);
            this.dtgvKhoaPhong.TabIndex = 19;
            this.dtgvKhoaPhong.TabStop = false;
            this.dtgvKhoaPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvKhoaPhong_CellClick);
            // 
            // fKhoaPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 425);
            this.Controls.Add(this.dtgvKhoaPhong);
            this.Controls.Add(this.panel1);
            this.Name = "fKhoaPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Khoa phòng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvKhoaPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKPKetthuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKPXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnKPBoQua;
        private System.Windows.Forms.TextBox txbKPid;
        private System.Windows.Forms.Button btnKPSua;
        private System.Windows.Forms.TextBox txbKPTen;
        private System.Windows.Forms.Button btnKPLuu;
        private System.Windows.Forms.TextBox txbKPTenVietTat;
        private System.Windows.Forms.Button btnKPMoi;
        private System.Windows.Forms.DataGridView dtgvKhoaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ccbBenhVien;
    }
}