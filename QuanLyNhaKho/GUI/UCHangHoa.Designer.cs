namespace QuanLyNhaKho.GUI
{
    partial class UCHangHoa
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
            this.panel_SearchHangHoa = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgv_HangHoa = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lb__MaHH = new System.Windows.Forms.Label();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.lb_TenHH = new System.Windows.Forms.Label();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.lb_DonViTinh = new System.Windows.Forms.Label();
            this.txtDonViTinh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_HSD = new System.Windows.Forms.Label();
            this.lb_NgayNhap = new System.Windows.Forms.Label();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.lb_GhiChu = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.dtpNSX = new System.Windows.Forms.DateTimePicker();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.cbb_TenNhom = new System.Windows.Forms.ComboBox();
            this.lb_TenNhom = new System.Windows.Forms.Label();
            this.panel_InforHangHoa = new System.Windows.Forms.Panel();
            this.panel_SearchHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel_InforHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_SearchHangHoa
            // 
            this.panel_SearchHangHoa.Controls.Add(this.btn_TimKiem);
            this.panel_SearchHangHoa.Controls.Add(this.txtTimKiem);
            this.panel_SearchHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SearchHangHoa.Location = new System.Drawing.Point(0, 236);
            this.panel_SearchHangHoa.Name = "panel_SearchHangHoa";
            this.panel_SearchHangHoa.Size = new System.Drawing.Size(904, 31);
            this.panel_SearchHangHoa.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(234, 5);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(28, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // dgv_HangHoa
            // 
            this.dgv_HangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_HangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_HangHoa.Location = new System.Drawing.Point(0, 267);
            this.dgv_HangHoa.Name = "dgv_HangHoa";
            this.dgv_HangHoa.ReadOnly = true;
            this.dgv_HangHoa.RowHeadersWidth = 50;
            this.dgv_HangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HangHoa.Size = new System.Drawing.Size(904, 306);
            this.dgv_HangHoa.TabIndex = 2;
            this.dgv_HangHoa.Click += new System.EventHandler(this.dgv_HangHoa_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(351, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hàng Hóa";
            // 
            // lb__MaHH
            // 
            this.lb__MaHH.AutoSize = true;
            this.lb__MaHH.Location = new System.Drawing.Point(42, 58);
            this.lb__MaHH.Name = "lb__MaHH";
            this.lb__MaHH.Size = new System.Drawing.Size(80, 13);
            this.lb__MaHH.TabIndex = 33;
            this.lb__MaHH.Text = "Mã Hàng Hóa: ";
            // 
            // txtMaHH
            // 
            this.txtMaHH.Enabled = false;
            this.txtMaHH.Location = new System.Drawing.Point(137, 55);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(100, 20);
            this.txtMaHH.TabIndex = 1;
            // 
            // lb_TenHH
            // 
            this.lb_TenHH.AutoSize = true;
            this.lb_TenHH.Location = new System.Drawing.Point(34, 136);
            this.lb_TenHH.Name = "lb_TenHH";
            this.lb_TenHH.Size = new System.Drawing.Size(84, 13);
            this.lb_TenHH.TabIndex = 35;
            this.lb_TenHH.Text = "Tên Hàng Hóa: ";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(137, 133);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTenHH.Size = new System.Drawing.Size(201, 20);
            this.txtTenHH.TabIndex = 3;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(48, 171);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(59, 13);
            this.lb_SoLuong.TabIndex = 37;
            this.lb_SoLuong.Text = "Số Lượng: ";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(137, 171);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 4;
            // 
            // lb_DonViTinh
            // 
            this.lb_DonViTinh.AutoSize = true;
            this.lb_DonViTinh.Location = new System.Drawing.Point(42, 197);
            this.lb_DonViTinh.Name = "lb_DonViTinh";
            this.lb_DonViTinh.Size = new System.Drawing.Size(65, 13);
            this.lb_DonViTinh.TabIndex = 39;
            this.lb_DonViTinh.Text = "Đơn Vị Tính";
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.Location = new System.Drawing.Point(137, 197);
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Size = new System.Drawing.Size(100, 20);
            this.txtDonViTinh.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "NSX";
            // 
            // lb_HSD
            // 
            this.lb_HSD.AutoSize = true;
            this.lb_HSD.Location = new System.Drawing.Point(512, 156);
            this.lb_HSD.Name = "lb_HSD";
            this.lb_HSD.Size = new System.Drawing.Size(30, 13);
            this.lb_HSD.TabIndex = 47;
            this.lb_HSD.Text = "HSD";
            // 
            // lb_NgayNhap
            // 
            this.lb_NgayNhap.AutoSize = true;
            this.lb_NgayNhap.Location = new System.Drawing.Point(512, 61);
            this.lb_NgayNhap.Name = "lb_NgayNhap";
            this.lb_NgayNhap.Size = new System.Drawing.Size(64, 13);
            this.lb_NgayNhap.TabIndex = 49;
            this.lb_NgayNhap.Text = "Ngày Nhập:";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Enabled = false;
            this.dtpNgayNhap.Location = new System.Drawing.Point(618, 57);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(200, 20);
            this.dtpNgayNhap.TabIndex = 8;
            // 
            // lb_GhiChu
            // 
            this.lb_GhiChu.AutoSize = true;
            this.lb_GhiChu.Location = new System.Drawing.Point(304, 181);
            this.lb_GhiChu.Name = "lb_GhiChu";
            this.lb_GhiChu.Size = new System.Drawing.Size(48, 13);
            this.lb_GhiChu.TabIndex = 51;
            this.lb_GhiChu.Text = "Ghi Chú:";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(383, 178);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(435, 39);
            this.rtxtGhiChu.TabIndex = 11;
            this.rtxtGhiChu.Text = "";
            // 
            // dtpNSX
            // 
            this.dtpNSX.Location = new System.Drawing.Point(618, 112);
            this.dtpNSX.Name = "dtpNSX";
            this.dtpNSX.Size = new System.Drawing.Size(200, 20);
            this.dtpNSX.TabIndex = 9;
            // 
            // dtpHSD
            // 
            this.dtpHSD.Location = new System.Drawing.Point(618, 150);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(200, 20);
            this.dtpHSD.TabIndex = 10;
            // 
            // cbb_TenNhom
            // 
            this.cbb_TenNhom.FormattingEnabled = true;
            this.cbb_TenNhom.Location = new System.Drawing.Point(137, 96);
            this.cbb_TenNhom.Name = "cbb_TenNhom";
            this.cbb_TenNhom.Size = new System.Drawing.Size(144, 21);
            this.cbb_TenNhom.TabIndex = 2;
            // 
            // lb_TenNhom
            // 
            this.lb_TenNhom.AutoSize = true;
            this.lb_TenNhom.Location = new System.Drawing.Point(38, 96);
            this.lb_TenNhom.Name = "lb_TenNhom";
            this.lb_TenNhom.Size = new System.Drawing.Size(57, 13);
            this.lb_TenNhom.TabIndex = 56;
            this.lb_TenNhom.Text = "Tên Nhóm";
            // 
            // panel_InforHangHoa
            // 
            this.panel_InforHangHoa.AccessibleDescription = "";
            this.panel_InforHangHoa.Controls.Add(this.lb_TenNhom);
            this.panel_InforHangHoa.Controls.Add(this.cbb_TenNhom);
            this.panel_InforHangHoa.Controls.Add(this.dtpHSD);
            this.panel_InforHangHoa.Controls.Add(this.dtpNSX);
            this.panel_InforHangHoa.Controls.Add(this.rtxtGhiChu);
            this.panel_InforHangHoa.Controls.Add(this.lb_GhiChu);
            this.panel_InforHangHoa.Controls.Add(this.dtpNgayNhap);
            this.panel_InforHangHoa.Controls.Add(this.lb_NgayNhap);
            this.panel_InforHangHoa.Controls.Add(this.lb_HSD);
            this.panel_InforHangHoa.Controls.Add(this.label7);
            this.panel_InforHangHoa.Controls.Add(this.txtDonViTinh);
            this.panel_InforHangHoa.Controls.Add(this.lb_DonViTinh);
            this.panel_InforHangHoa.Controls.Add(this.txtSoLuong);
            this.panel_InforHangHoa.Controls.Add(this.lb_SoLuong);
            this.panel_InforHangHoa.Controls.Add(this.txtTenHH);
            this.panel_InforHangHoa.Controls.Add(this.lb_TenHH);
            this.panel_InforHangHoa.Controls.Add(this.txtMaHH);
            this.panel_InforHangHoa.Controls.Add(this.lb__MaHH);
            this.panel_InforHangHoa.Controls.Add(this.label2);
            this.panel_InforHangHoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InforHangHoa.Enabled = false;
            this.panel_InforHangHoa.Location = new System.Drawing.Point(0, 0);
            this.panel_InforHangHoa.Name = "panel_InforHangHoa";
            this.panel_InforHangHoa.Size = new System.Drawing.Size(904, 236);
            this.panel_InforHangHoa.TabIndex = 0;
            // 
            // UCHangHoa
            // 
            this.AccessibleDescription = "Hàng Hóa";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_HangHoa);
            this.Controls.Add(this.panel_SearchHangHoa);
            this.Controls.Add(this.panel_InforHangHoa);
            this.Name = "UCHangHoa";
            this.Size = new System.Drawing.Size(904, 573);
            this.panel_SearchHangHoa.ResumeLayout(false);
            this.panel_SearchHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel_InforHangHoa.ResumeLayout(false);
            this.panel_InforHangHoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_SearchHangHoa;
        private System.Windows.Forms.DataGridView dgv_HangHoa;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel_InforHangHoa;
        private System.Windows.Forms.Label lb_TenNhom;
        private System.Windows.Forms.ComboBox cbb_TenNhom;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.DateTimePicker dtpNSX;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label lb_GhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private System.Windows.Forms.Label lb_NgayNhap;
        private System.Windows.Forms.Label lb_HSD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDonViTinh;
        private System.Windows.Forms.Label lb_DonViTinh;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label lb_TenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label lb__MaHH;
        private System.Windows.Forms.Label label2;
    }
}
