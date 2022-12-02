namespace DT_CDT
{
    partial class fDMChamCong
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
            this.dtgvDMChamCong = new System.Windows.Forms.DataGridView();
            this.btnKetthuc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.txbKyHieu = new System.Windows.Forms.TextBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tên = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSoNgayCong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbSoTietHoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGhiChu = new System.Windows.Forms.TextBox();
            this.txbid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDMChamCong
            // 
            this.dtgvDMChamCong.AllowUserToAddRows = false;
            this.dtgvDMChamCong.AllowUserToDeleteRows = false;
            this.dtgvDMChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDMChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDMChamCong.Location = new System.Drawing.Point(3, 31);
            this.dtgvDMChamCong.Name = "dtgvDMChamCong";
            this.dtgvDMChamCong.ReadOnly = true;
            this.dtgvDMChamCong.Size = new System.Drawing.Size(806, 279);
            this.dtgvDMChamCong.TabIndex = 1;
            this.dtgvDMChamCong.TabStop = false;
            this.dtgvDMChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChucDanh_CellClick);
            // 
            // btnKetthuc
            // 
            this.btnKetthuc.Location = new System.Drawing.Point(496, 364);
            this.btnKetthuc.Name = "btnKetthuc";
            this.btnKetthuc.Size = new System.Drawing.Size(75, 23);
            this.btnKetthuc.TabIndex = 11;
            this.btnKetthuc.Text = "Kết thúc";
            this.btnKetthuc.UseVisualStyleBackColor = true;
            this.btnKetthuc.Click += new System.EventHandler(this.btnKetthuc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(415, 364);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(350, 364);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(59, 23);
            this.btnBoQua.TabIndex = 9;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(294, 364);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(50, 23);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(235, 364);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(53, 23);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(180, 364);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(49, 23);
            this.btnMoi.TabIndex = 6;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // txbKyHieu
            // 
            this.txbKyHieu.Location = new System.Drawing.Point(343, 337);
            this.txbKyHieu.MaxLength = 10;
            this.txbKyHieu.Name = "txbKyHieu";
            this.txbKyHieu.Size = new System.Drawing.Size(86, 20);
            this.txbKyHieu.TabIndex = 2;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(3, 338);
            this.txbTen.MaxLength = 100;
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(334, 20);
            this.txbTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ký hiệu";
            // 
            // Tên
            // 
            this.Tên.AutoSize = true;
            this.Tên.Location = new System.Drawing.Point(0, 321);
            this.Tên.Name = "Tên";
            this.Tên.Size = new System.Drawing.Size(26, 13);
            this.Tên.TabIndex = 11;
            this.Tên.Text = "Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số ngày công";
            // 
            // txbSoNgayCong
            // 
            this.txbSoNgayCong.Location = new System.Drawing.Point(438, 337);
            this.txbSoNgayCong.MaxLength = 2;
            this.txbSoNgayCong.Name = "txbSoNgayCong";
            this.txbSoNgayCong.Size = new System.Drawing.Size(86, 20);
            this.txbSoNgayCong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(531, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Số tiết";
            // 
            // txbSoTietHoc
            // 
            this.txbSoTietHoc.Location = new System.Drawing.Point(534, 337);
            this.txbSoTietHoc.MaxLength = 2;
            this.txbSoTietHoc.Name = "txbSoTietHoc";
            this.txbSoTietHoc.Size = new System.Drawing.Size(86, 20);
            this.txbSoTietHoc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ghi chú";
            // 
            // txbGhiChu
            // 
            this.txbGhiChu.Location = new System.Drawing.Point(626, 337);
            this.txbGhiChu.MaxLength = 200;
            this.txbGhiChu.Name = "txbGhiChu";
            this.txbGhiChu.Size = new System.Drawing.Size(183, 20);
            this.txbGhiChu.TabIndex = 5;
            // 
            // txbid
            // 
            this.txbid.Location = new System.Drawing.Point(3, 367);
            this.txbid.MaxLength = 10;
            this.txbid.Name = "txbid";
            this.txbid.Size = new System.Drawing.Size(86, 20);
            this.txbid.TabIndex = 13;
            this.txbid.Visible = false;
            // 
            // fDMChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 389);
            this.Controls.Add(this.btnKetthuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.txbGhiChu);
            this.Controls.Add(this.txbSoTietHoc);
            this.Controls.Add(this.txbSoNgayCong);
            this.Controls.Add(this.txbid);
            this.Controls.Add(this.txbKyHieu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tên);
            this.Controls.Add(this.dtgvDMChamCong);
            this.Name = "fDMChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khai báo chấm công";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDMChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDMChamCong;
        private System.Windows.Forms.Button btnKetthuc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.TextBox txbKyHieu;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Tên;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSoNgayCong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbSoTietHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbGhiChu;
        private System.Windows.Forms.TextBox txbid;
    }
}