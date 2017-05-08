namespace QuanLyNhaKho.GUI
{
    partial class UCNhomHang
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
            this.errorProviderHangHoa = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_InforNhomHang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.lb_TenNhom = new System.Windows.Forms.Label();
            this.txt_TenNhom = new System.Windows.Forms.TextBox();
            this.lb_SoLuong = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txt_MaNhomHang = new System.Windows.Forms.TextBox();
            this.panel_SearchNhomHang = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgv_NhomHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHangHoa)).BeginInit();
            this.panel_InforNhomHang.SuspendLayout();
            this.panel_SearchNhomHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomHang)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProviderHangHoa
            // 
            this.errorProviderHangHoa.ContainerControl = this;
            // 
            // panel_InforNhomHang
            // 
            this.panel_InforNhomHang.Controls.Add(this.label1);
            this.panel_InforNhomHang.Controls.Add(this.rtxt_GhiChu);
            this.panel_InforNhomHang.Controls.Add(this.lb_TenNhom);
            this.panel_InforNhomHang.Controls.Add(this.txt_TenNhom);
            this.panel_InforNhomHang.Controls.Add(this.lb_SoLuong);
            this.panel_InforNhomHang.Controls.Add(this.label11);
            this.panel_InforNhomHang.Controls.Add(this.txtSoLuong);
            this.panel_InforNhomHang.Controls.Add(this.txt_MaNhomHang);
            this.panel_InforNhomHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InforNhomHang.Location = new System.Drawing.Point(0, 0);
            this.panel_InforNhomHang.Name = "panel_InforNhomHang";
            this.panel_InforNhomHang.Size = new System.Drawing.Size(965, 211);
            this.panel_InforNhomHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Ghi Chú:";
            // 
            // rtxt_GhiChu
            // 
            this.rtxt_GhiChu.Location = new System.Drawing.Point(475, 36);
            this.rtxt_GhiChu.Name = "rtxt_GhiChu";
            this.rtxt_GhiChu.Size = new System.Drawing.Size(412, 69);
            this.rtxt_GhiChu.TabIndex = 105;
            this.rtxt_GhiChu.Text = "";
            // 
            // lb_TenNhom
            // 
            this.lb_TenNhom.AutoSize = true;
            this.lb_TenNhom.Location = new System.Drawing.Point(73, 79);
            this.lb_TenNhom.Name = "lb_TenNhom";
            this.lb_TenNhom.Size = new System.Drawing.Size(63, 13);
            this.lb_TenNhom.TabIndex = 104;
            this.lb_TenNhom.Text = "Tên Nhóm: ";
            // 
            // txt_TenNhom
            // 
            this.txt_TenNhom.Location = new System.Drawing.Point(182, 72);
            this.txt_TenNhom.Name = "txt_TenNhom";
            this.txt_TenNhom.Size = new System.Drawing.Size(129, 20);
            this.txt_TenNhom.TabIndex = 103;
            // 
            // lb_SoLuong
            // 
            this.lb_SoLuong.AutoSize = true;
            this.lb_SoLuong.Location = new System.Drawing.Point(73, 119);
            this.lb_SoLuong.Name = "lb_SoLuong";
            this.lb_SoLuong.Size = new System.Drawing.Size(56, 13);
            this.lb_SoLuong.TabIndex = 102;
            this.lb_SoLuong.Text = "Số Lượng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 99;
            this.label11.Text = "Mã Nhóm Hàng:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(182, 112);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(129, 20);
            this.txtSoLuong.TabIndex = 101;
            // 
            // txt_MaNhomHang
            // 
            this.txt_MaNhomHang.Enabled = false;
            this.txt_MaNhomHang.Location = new System.Drawing.Point(182, 36);
            this.txt_MaNhomHang.Name = "txt_MaNhomHang";
            this.txt_MaNhomHang.Size = new System.Drawing.Size(129, 20);
            this.txt_MaNhomHang.TabIndex = 100;
            // 
            // panel_SearchNhomHang
            // 
            this.panel_SearchNhomHang.Controls.Add(this.btn_TimKiem);
            this.panel_SearchNhomHang.Controls.Add(this.txtTimKiem);
            this.panel_SearchNhomHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SearchNhomHang.Location = new System.Drawing.Point(0, 211);
            this.panel_SearchNhomHang.Name = "panel_SearchNhomHang";
            this.panel_SearchNhomHang.Size = new System.Drawing.Size(965, 30);
            this.panel_SearchNhomHang.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(224, 5);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(18, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // dgv_NhomHang
            // 
            this.dgv_NhomHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhomHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhomHang.Location = new System.Drawing.Point(0, 241);
            this.dgv_NhomHang.Name = "dgv_NhomHang";
            this.dgv_NhomHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhomHang.Size = new System.Drawing.Size(965, 323);
            this.dgv_NhomHang.TabIndex = 2;
            this.dgv_NhomHang.Click += new System.EventHandler(this.dgv_NhomHang_Click);
            // 
            // UCNhomHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_NhomHang);
            this.Controls.Add(this.panel_SearchNhomHang);
            this.Controls.Add(this.panel_InforNhomHang);
            this.Name = "UCNhomHang";
            this.Size = new System.Drawing.Size(965, 564);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHangHoa)).EndInit();
            this.panel_InforNhomHang.ResumeLayout(false);
            this.panel_InforNhomHang.PerformLayout();
            this.panel_SearchNhomHang.ResumeLayout(false);
            this.panel_SearchNhomHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhomHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProviderHangHoa;
        private System.Windows.Forms.DataGridView dgv_NhomHang;
        private System.Windows.Forms.Panel panel_SearchNhomHang;
        private System.Windows.Forms.Panel panel_InforNhomHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lb_TenNhom;
        private System.Windows.Forms.TextBox txt_TenNhom;
        private System.Windows.Forms.Label lb_SoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txt_MaNhomHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxt_GhiChu;
    }
}
