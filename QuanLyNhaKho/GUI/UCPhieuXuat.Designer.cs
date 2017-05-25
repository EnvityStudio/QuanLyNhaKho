namespace QuanLyNhaKho.GUI
{
    partial class UCPhieuXuat
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
            this.btnViewMore = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgPhieuXuat = new System.Windows.Forms.DataGridView();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChiCH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.cbb_TenCH = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lb_TongTien = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnViewMore
            // 
            this.btnViewMore.Location = new System.Drawing.Point(943, 218);
            this.btnViewMore.Name = "btnViewMore";
            this.btnViewMore.Size = new System.Drawing.Size(120, 42);
            this.btnViewMore.TabIndex = 25;
            this.btnViewMore.Text = "Xem chi tiết";
            this.btnViewMore.UseVisualStyleBackColor = true;
            this.btnViewMore.Click += new System.EventHandler(this.btnViewMore_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.dtgPhieuXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 297);
            this.panel1.TabIndex = 24;
            // 
            // dtgPhieuXuat
            // 
            this.dtgPhieuXuat.AccessibleDescription = "Phiếu Xuất";
            this.dtgPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgPhieuXuat.Location = new System.Drawing.Point(0, 33);
            this.dtgPhieuXuat.Name = "dtgPhieuXuat";
            this.dtgPhieuXuat.ReadOnly = true;
            this.dtgPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPhieuXuat.Size = new System.Drawing.Size(1168, 264);
            this.dtgPhieuXuat.TabIndex = 0;
            this.dtgPhieuXuat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieuXuat_CellContentClick);
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(139, 218);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(765, 44);
            this.rtxtGhiChu.TabIndex = 4;
            this.rtxtGhiChu.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày xuất :";
            // 
            // txtDiaChiCH
            // 
            this.txtDiaChiCH.Enabled = false;
            this.txtDiaChiCH.Location = new System.Drawing.Point(139, 130);
            this.txtDiaChiCH.Name = "txtDiaChiCH";
            this.txtDiaChiCH.Size = new System.Drawing.Size(333, 20);
            this.txtDiaChiCH.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Ghi chú :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Địa chỉ cửa hàng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên cửa hàng :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(503, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phiếu Xuất Kho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã phiếu xuất :";
            // 
            // txtMaPX
            // 
            this.txtMaPX.Location = new System.Drawing.Point(139, 45);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(100, 20);
            this.txtMaPX.TabIndex = 1;
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.CustomFormat = "";
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayXuat.Location = new System.Drawing.Point(541, 61);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(123, 20);
            this.dtpNgayXuat.TabIndex = 5;
            // 
            // cbb_TenCH
            // 
            this.cbb_TenCH.FormattingEnabled = true;
            this.cbb_TenCH.Location = new System.Drawing.Point(139, 89);
            this.cbb_TenCH.Name = "cbb_TenCH";
            this.cbb_TenCH.Size = new System.Drawing.Size(165, 21);
            this.cbb_TenCH.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(758, 187);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 16);
            this.label15.TabIndex = 28;
            this.label15.Text = "Tổng tiền :";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.AutoSize = true;
            this.lb_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_TongTien.Location = new System.Drawing.Point(855, 183);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(49, 20);
            this.lb_TongTien.TabIndex = 29;
            this.lb_TongTien.Text = "1000";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(923, 23);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(146, 20);
            this.txtTenNV.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(835, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên nhân viên :";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(420, 6);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(214, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 6;
            // 
            // UCPhieuXuat
            // 
            this.AccessibleDescription = "Phiếu Xuất ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_TongTien);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbb_TenCH);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.btnViewMore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtGhiChu);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChiCH);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaPX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UCPhieuXuat";
            this.Size = new System.Drawing.Size(1168, 563);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewMore;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgPhieuXuat;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChiCH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.ComboBox cbb_TenCH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_TongTien;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}
