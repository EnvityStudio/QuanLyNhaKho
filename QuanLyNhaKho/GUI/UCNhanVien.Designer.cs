namespace QuanLyNhaKho.GUI
{
    partial class UCNhanVien
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
            this.components = new System.ComponentModel.Container();
            this.pn_Info = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.btnResetPass = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.dtp_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdGTNu = new System.Windows.Forms.RadioButton();
            this.rdGTNam = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.txtQueQuan = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.panel_Search = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pn_Info.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.panel_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Info
            // 
            this.pn_Info.Controls.Add(this.label5);
            this.pn_Info.Controls.Add(this.label2);
            this.pn_Info.Controls.Add(this.txtTaiKhoan);
            this.pn_Info.Controls.Add(this.label3);
            this.pn_Info.Controls.Add(this.label26);
            this.pn_Info.Controls.Add(this.txtMaNV);
            this.pn_Info.Controls.Add(this.btnResetPass);
            this.pn_Info.Controls.Add(this.label23);
            this.pn_Info.Controls.Add(this.dtp_NgaySinh);
            this.pn_Info.Controls.Add(this.panel4);
            this.pn_Info.Controls.Add(this.label11);
            this.pn_Info.Controls.Add(this.label8);
            this.pn_Info.Controls.Add(this.label4);
            this.pn_Info.Controls.Add(this.txtMK);
            this.pn_Info.Controls.Add(this.txtSoDT);
            this.pn_Info.Controls.Add(this.txtQueQuan);
            this.pn_Info.Controls.Add(this.txtHoTen);
            this.pn_Info.Controls.Add(this.label1);
            this.pn_Info.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Info.Location = new System.Drawing.Point(0, 0);
            this.pn_Info.Name = "pn_Info";
            this.pn_Info.Size = new System.Drawing.Size(922, 255);
            this.pn_Info.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Tài Khoản:";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(538, 84);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(162, 20);
            this.txtTaiKhoan.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Giới Tính:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(94, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(43, 13);
            this.label26.TabIndex = 68;
            this.label26.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Location = new System.Drawing.Point(182, 33);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(167, 20);
            this.txtMaNV.TabIndex = 1;
            this.txtMaNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResetPass
            // 
            this.btnResetPass.Location = new System.Drawing.Point(763, 215);
            this.btnResetPass.Name = "btnResetPass";
            this.btnResetPass.Size = new System.Drawing.Size(80, 23);
            this.btnResetPass.TabIndex = 95;
            this.btnResetPass.Text = "Reset";
            this.btnResetPass.UseVisualStyleBackColor = true;
            this.btnResetPass.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(436, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 13);
            this.label23.TabIndex = 94;
            this.label23.Text = "Mật Khẩu:";
            // 
            // dtp_NgaySinh
            // 
            this.dtp_NgaySinh.CustomFormat = "";
            this.dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgaySinh.Location = new System.Drawing.Point(182, 172);
            this.dtp_NgaySinh.Name = "dtp_NgaySinh";
            this.dtp_NgaySinh.Size = new System.Drawing.Size(167, 20);
            this.dtp_NgaySinh.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.rdGTNu);
            this.panel4.Controls.Add(this.rdGTNam);
            this.panel4.Location = new System.Drawing.Point(182, 119);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 30);
            this.panel4.TabIndex = 3;
            // 
            // rdGTNu
            // 
            this.rdGTNu.AutoSize = true;
            this.rdGTNu.Location = new System.Drawing.Point(110, 6);
            this.rdGTNu.Name = "rdGTNu";
            this.rdGTNu.Size = new System.Drawing.Size(39, 17);
            this.rdGTNu.TabIndex = 1;
            this.rdGTNu.Text = "Nữ";
            this.rdGTNu.UseVisualStyleBackColor = true;
            // 
            // rdGTNam
            // 
            this.rdGTNam.AutoSize = true;
            this.rdGTNam.Checked = true;
            this.rdGTNam.Location = new System.Drawing.Point(17, 6);
            this.rdGTNam.Name = "rdGTNam";
            this.rdGTNam.Size = new System.Drawing.Size(47, 17);
            this.rdGTNam.TabIndex = 0;
            this.rdGTNam.TabStop = true;
            this.rdGTNam.Text = "Nam";
            this.rdGTNam.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(436, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 80;
            this.label11.Text = "Số ĐT:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 77;
            this.label8.Text = "Quê quán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Ngày Sinh:";
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(538, 128);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(162, 20);
            this.txtMK.TabIndex = 8;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(538, 36);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(162, 20);
            this.txtSoDT.TabIndex = 6;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Location = new System.Drawing.Point(182, 219);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.Size = new System.Drawing.Size(518, 20);
            this.txtQueQuan.TabIndex = 5;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(182, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(167, 20);
            this.txtHoTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Họ tên :";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhanVien.Location = new System.Drawing.Point(0, 285);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.ReadOnly = true;
            this.dgv_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhanVien.Size = new System.Drawing.Size(922, 285);
            this.dgv_NhanVien.TabIndex = 1;
            this.dgv_NhanVien.Click += new System.EventHandler(this.dgv_NhanVien_Click);
            // 
            // panel_Search
            // 
            this.panel_Search.Controls.Add(this.btn_TimKiem);
            this.panel_Search.Controls.Add(this.txtTimKiem);
            this.panel_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Search.Location = new System.Drawing.Point(0, 255);
            this.panel_Search.Name = "panel_Search";
            this.panel_Search.Size = new System.Drawing.Size(922, 30);
            this.panel_Search.TabIndex = 2;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(210, 4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Firebrick;
            this.label5.Location = new System.Drawing.Point(422, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 99;
            this.label5.Text = "Nhân Viên";
            // 
            // UCNhanVien
            // 
            this.AccessibleDescription = "Nhân Viên";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_NhanVien);
            this.Controls.Add(this.panel_Search);
            this.Controls.Add(this.pn_Info);
            this.Name = "UCNhanVien";
            this.Size = new System.Drawing.Size(922, 570);
            this.Load += new System.EventHandler(this.UCNhanVien_Load);
            this.pn_Info.ResumeLayout(false);
            this.pn_Info.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.panel_Search.ResumeLayout(false);
            this.panel_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Button btnResetPass;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtp_NgaySinh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdGTNu;
        private System.Windows.Forms.RadioButton rdGTNam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox txtQueQuan;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.Panel panel_Search;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label5;
    }
}
