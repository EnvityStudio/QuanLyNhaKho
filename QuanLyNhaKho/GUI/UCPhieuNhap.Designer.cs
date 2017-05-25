namespace QuanLyNhaKho.GUI
{
    partial class UCPhieuNhap
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_PN = new System.Windows.Forms.Panel();
            this.btnXCT = new System.Windows.Forms.Button();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTenNCC = new System.Windows.Forms.ComboBox();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.panel_PN.SuspendLayout();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_PN
            // 
            this.panel_PN.Controls.Add(this.btnXCT);
            this.panel_PN.Controls.Add(this.txtThanhTien);
            this.panel_PN.Controls.Add(this.label6);
            this.panel_PN.Controls.Add(this.txtChietKhau);
            this.panel_PN.Controls.Add(this.label5);
            this.panel_PN.Controls.Add(this.lb_TongTien);
            this.panel_PN.Controls.Add(this.label15);
            this.panel_PN.Controls.Add(this.txtTenNhanVien);
            this.panel_PN.Controls.Add(this.label2);
            this.panel_PN.Controls.Add(this.cbbTenNCC);
            this.panel_PN.Controls.Add(this.dtpNgayNhap);
            this.panel_PN.Controls.Add(this.rtxtGhiChu);
            this.panel_PN.Controls.Add(this.label4);
            this.panel_PN.Controls.Add(this.txtDiaChiNCC);
            this.panel_PN.Controls.Add(this.label8);
            this.panel_PN.Controls.Add(this.label7);
            this.panel_PN.Controls.Add(this.txtMaPN);
            this.panel_PN.Controls.Add(this.label9);
            this.panel_PN.Controls.Add(this.label3);
            this.panel_PN.Controls.Add(this.label1);
            this.panel_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PN.Enabled = false;
            this.panel_PN.Location = new System.Drawing.Point(0, 0);
            this.panel_PN.Name = "panel_PN";
            this.panel_PN.Size = new System.Drawing.Size(967, 275);
            this.panel_PN.TabIndex = 0;
            // 
            // btnXCT
            // 
            this.btnXCT.Location = new System.Drawing.Point(774, 240);
            this.btnXCT.Name = "btnXCT";
            this.btnXCT.Size = new System.Drawing.Size(113, 29);
            this.btnXCT.TabIndex = 49;
            this.btnXCT.Text = "Xem Chi Tiết";
            this.btnXCT.UseVisualStyleBackColor = true;
            this.btnXCT.Click += new System.EventHandler(this.btnXCT_Click);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(741, 134);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(146, 20);
            this.txtThanhTien.TabIndex = 48;
            this.txtThanhTien.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Thành Tiền: ";
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Enabled = false;
            this.txtChietKhau.Location = new System.Drawing.Point(741, 172);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(41, 20);
            this.txtChietKhau.TabIndex = 46;
            this.txtChietKhau.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(646, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Chiết Khấu: ";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_TongTien.Location = new System.Drawing.Point(737, 209);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(19, 20);
            this.lb_TongTien.TabIndex = 44;
            this.lb_TongTien.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(645, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "Tổng tiền :";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Location = new System.Drawing.Point(788, 71);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(116, 20);
            this.txtTenNhanVien.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(688, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Tên Nhân Viên: ";
            // 
            // cbbTenNCC
            // 
            this.cbbTenNCC.FormattingEnabled = true;
            this.cbbTenNCC.Location = new System.Drawing.Point(109, 104);
            this.cbbTenNCC.Name = "cbbTenNCC";
            this.cbbTenNCC.Size = new System.Drawing.Size(135, 21);
            this.cbbTenNCC.TabIndex = 2;
            this.cbbTenNCC.SelectedValueChanged += new System.EventHandler(this.cbbTenNCC_SelectedValueChanged);
            this.cbbTenNCC.TextChanged += new System.EventHandler(this.cbbTenNCC_TextChanged);
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.CustomFormat = "";
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayNhap.Location = new System.Drawing.Point(511, 68);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayNhap.TabIndex = 5;
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(109, 199);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(462, 48);
            this.rtxtGhiChu.TabIndex = 4;
            this.rtxtGhiChu.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ngày Nhâp: ";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Enabled = false;
            this.txtDiaChiNCC.Location = new System.Drawing.Point(109, 149);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.Size = new System.Drawing.Size(249, 20);
            this.txtDiaChiNCC.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ghi chú :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Địa chỉ NCC:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.Enabled = false;
            this.txtMaPN.Location = new System.Drawing.Point(109, 55);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(100, 20);
            this.txtMaPN.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Mã phiếu Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tên NCC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(473, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "Phiếu Nhập Kho";
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.btn_TimKiem);
            this.panel_Search.Controls.Add(this.txtTimKiem);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Search.Location = new System.Drawing.Point(0, 275);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(967, 29);
            this.panel_Search.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(215, 5);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(9, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 4;
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhieuNhap.Location = new System.Drawing.Point(0, 304);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(967, 263);
            this.dgvPhieuNhap.TabIndex = 2;
            this.dgvPhieuNhap.Click += new System.EventHandler(this.dgvPhieuNhap_Click);
            // 
            // UCPhieuNhap
            // 
            this.AccessibleDescription = "Phiếu Nhập";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.panel_PN);
            this.Name = "UCPhieuNhap";
            this.Size = new System.Drawing.Size(967, 567);
            this.panel_PN.ResumeLayout(false);
            this.panel_PN.PerformLayout();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_PN;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.ComboBox cbbTenNCC;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXCT;
    }
}
