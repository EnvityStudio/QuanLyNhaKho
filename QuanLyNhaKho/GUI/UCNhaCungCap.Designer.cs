namespace QuanLyNhaKho.GUI
{
    partial class UCNhaCungCap
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
            this.panel_InforNCC = new System.Windows.Forms.Panel();
            this.panel_SearchNCC = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgv_NhaCungCap = new System.Windows.Forms.DataGridView();
            this.lb_MaNCC = new System.Windows.Forms.Label();
            this.txt_MaNCC = new System.Windows.Forms.TextBox();
            this.txt_TenNCC = new System.Windows.Forms.TextBox();
            this.lb_TenNCC = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rtxt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_InforNCC.SuspendLayout();
            this.panel_SearchNCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_InforNCC
            // 
            this.panel_InforNCC.Controls.Add(this.rtxt_GhiChu);
            this.panel_InforNCC.Controls.Add(this.label5);
            this.panel_InforNCC.Controls.Add(this.txtSDT);
            this.panel_InforNCC.Controls.Add(this.lb_SDT);
            this.panel_InforNCC.Controls.Add(this.txt_DiaChi);
            this.panel_InforNCC.Controls.Add(this.lb_DiaChi);
            this.panel_InforNCC.Controls.Add(this.txt_TenNCC);
            this.panel_InforNCC.Controls.Add(this.lb_TenNCC);
            this.panel_InforNCC.Controls.Add(this.txt_MaNCC);
            this.panel_InforNCC.Controls.Add(this.lb_MaNCC);
            this.panel_InforNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InforNCC.Enabled = false;
            this.panel_InforNCC.Location = new System.Drawing.Point(0, 0);
            this.panel_InforNCC.Name = "panel_InforNCC";
            this.panel_InforNCC.Size = new System.Drawing.Size(929, 211);
            this.panel_InforNCC.TabIndex = 0;
            // 
            // panel_SearchNCC
            // 
            this.panel_SearchNCC.Controls.Add(this.btn_TimKiem);
            this.panel_SearchNCC.Controls.Add(this.txtTimKiem);
            this.panel_SearchNCC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SearchNCC.Location = new System.Drawing.Point(0, 211);
            this.panel_SearchNCC.Name = "panel_SearchNCC";
            this.panel_SearchNCC.Size = new System.Drawing.Size(929, 26);
            this.panel_SearchNCC.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(222, 3);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 5;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(16, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 4;
            // 
            // dgv_NhaCungCap
            // 
            this.dgv_NhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhaCungCap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_NhaCungCap.Location = new System.Drawing.Point(0, 237);
            this.dgv_NhaCungCap.Name = "dgv_NhaCungCap";
            this.dgv_NhaCungCap.ReadOnly = true;
            this.dgv_NhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_NhaCungCap.Size = new System.Drawing.Size(929, 334);
            this.dgv_NhaCungCap.TabIndex = 2;
            this.dgv_NhaCungCap.Click += new System.EventHandler(this.dgv_NhaCungCap_Click);
            // 
            // lb_MaNCC
            // 
            this.lb_MaNCC.AutoSize = true;
            this.lb_MaNCC.Location = new System.Drawing.Point(88, 31);
            this.lb_MaNCC.Name = "lb_MaNCC";
            this.lb_MaNCC.Size = new System.Drawing.Size(53, 13);
            this.lb_MaNCC.TabIndex = 0;
            this.lb_MaNCC.Text = "Mã NCC: ";
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Enabled = false;
            this.txt_MaNCC.Location = new System.Drawing.Point(222, 31);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.Size = new System.Drawing.Size(100, 20);
            this.txt_MaNCC.TabIndex = 1;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(222, 67);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Size = new System.Drawing.Size(100, 20);
            this.txt_TenNCC.TabIndex = 3;
            // 
            // lb_TenNCC
            // 
            this.lb_TenNCC.AutoSize = true;
            this.lb_TenNCC.Location = new System.Drawing.Point(84, 70);
            this.lb_TenNCC.Name = "lb_TenNCC";
            this.lb_TenNCC.Size = new System.Drawing.Size(57, 13);
            this.lb_TenNCC.TabIndex = 2;
            this.lb_TenNCC.Text = "Tên NCC: ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(222, 123);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(100, 20);
            this.txt_DiaChi.TabIndex = 5;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(88, 123);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(44, 13);
            this.lb_DiaChi.TabIndex = 4;
            this.lb_DiaChi.Text = "Địa Chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(222, 174);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 7;
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(84, 174);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(81, 13);
            this.lb_SDT.TabIndex = 6;
            this.lb_SDT.Text = "Số Điện Thoại: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ghi Chú: ";
            // 
            // rtxt_GhiChu
            // 
            this.rtxt_GhiChu.Location = new System.Drawing.Point(538, 80);
            this.rtxt_GhiChu.Name = "rtxt_GhiChu";
            this.rtxt_GhiChu.Size = new System.Drawing.Size(311, 96);
            this.rtxt_GhiChu.TabIndex = 9;
            this.rtxt_GhiChu.Text = "";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_NhaCungCap);
            this.Controls.Add(this.panel_SearchNCC);
            this.Controls.Add(this.panel_InforNCC);
            this.Name = "UCNhaCungCap";
            this.Size = new System.Drawing.Size(929, 571);
            this.panel_InforNCC.ResumeLayout(false);
            this.panel_InforNCC.PerformLayout();
            this.panel_SearchNCC.ResumeLayout(false);
            this.panel_SearchNCC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_InforNCC;
        private System.Windows.Forms.Panel panel_SearchNCC;
        private System.Windows.Forms.DataGridView dgv_NhaCungCap;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RichTextBox rtxt_GhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox txt_TenNCC;
        private System.Windows.Forms.Label lb_TenNCC;
        private System.Windows.Forms.TextBox txt_MaNCC;
        private System.Windows.Forms.Label lb_MaNCC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
