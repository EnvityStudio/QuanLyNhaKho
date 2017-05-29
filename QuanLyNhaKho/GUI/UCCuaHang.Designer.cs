namespace QuanLyNhaKho.GUI
{
    partial class UCCuaHang
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
            this.panel_InforCuaHang = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt_GhiChu = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.txt_TenCH = new System.Windows.Forms.TextBox();
            this.lb_TenCH = new System.Windows.Forms.Label();
            this.txt_MaCH = new System.Windows.Forms.TextBox();
            this.lb_MaCH = new System.Windows.Forms.Label();
            this.panel_SearchCuaHang = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgv_CuaHang = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_InforCuaHang.SuspendLayout();
            this.panel_SearchCuaHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuaHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_InforCuaHang
            // 
            this.panel_InforCuaHang.AccessibleDescription = "Cửa Hàng";
            this.panel_InforCuaHang.Controls.Add(this.label2);
            this.panel_InforCuaHang.Controls.Add(this.rtxt_GhiChu);
            this.panel_InforCuaHang.Controls.Add(this.label5);
            this.panel_InforCuaHang.Controls.Add(this.txtSDT);
            this.panel_InforCuaHang.Controls.Add(this.lb_SDT);
            this.panel_InforCuaHang.Controls.Add(this.txt_DiaChi);
            this.panel_InforCuaHang.Controls.Add(this.lb_DiaChi);
            this.panel_InforCuaHang.Controls.Add(this.txt_TenCH);
            this.panel_InforCuaHang.Controls.Add(this.lb_TenCH);
            this.panel_InforCuaHang.Controls.Add(this.txt_MaCH);
            this.panel_InforCuaHang.Controls.Add(this.lb_MaCH);
            this.panel_InforCuaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_InforCuaHang.Enabled = false;
            this.panel_InforCuaHang.Location = new System.Drawing.Point(0, 0);
            this.panel_InforCuaHang.Name = "panel_InforCuaHang";
            this.panel_InforCuaHang.Size = new System.Drawing.Size(926, 245);
            this.panel_InforCuaHang.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(366, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cửa Hàng";
            // 
            // rtxt_GhiChu
            // 
            this.rtxt_GhiChu.Location = new System.Drawing.Point(535, 90);
            this.rtxt_GhiChu.Name = "rtxt_GhiChu";
            this.rtxt_GhiChu.Size = new System.Drawing.Size(311, 96);
            this.rtxt_GhiChu.TabIndex = 5;
            this.rtxt_GhiChu.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(409, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Ghi Chú: ";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(219, 199);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(100, 20);
            this.txtSDT.TabIndex = 4;
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(89, 202);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(81, 13);
            this.lb_SDT.TabIndex = 16;
            this.lb_SDT.Text = "Số Điện Thoại: ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(219, 148);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(100, 20);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(89, 155);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(44, 13);
            this.lb_DiaChi.TabIndex = 14;
            this.lb_DiaChi.Text = "Địa Chỉ:";
            // 
            // txt_TenCH
            // 
            this.txt_TenCH.Location = new System.Drawing.Point(219, 101);
            this.txt_TenCH.Name = "txt_TenCH";
            this.txt_TenCH.Size = new System.Drawing.Size(100, 20);
            this.txt_TenCH.TabIndex = 2;
            // 
            // lb_TenCH
            // 
            this.lb_TenCH.AutoSize = true;
            this.lb_TenCH.Location = new System.Drawing.Point(89, 104);
            this.lb_TenCH.Name = "lb_TenCH";
            this.lb_TenCH.Size = new System.Drawing.Size(47, 13);
            this.lb_TenCH.TabIndex = 12;
            this.lb_TenCH.Text = "Tên CH:";
            // 
            // txt_MaCH
            // 
            this.txt_MaCH.Enabled = false;
            this.txt_MaCH.Location = new System.Drawing.Point(219, 51);
            this.txt_MaCH.Name = "txt_MaCH";
            this.txt_MaCH.Size = new System.Drawing.Size(100, 20);
            this.txt_MaCH.TabIndex = 1;
            // 
            // lb_MaCH
            // 
            this.lb_MaCH.AutoSize = true;
            this.lb_MaCH.Location = new System.Drawing.Point(89, 58);
            this.lb_MaCH.Name = "lb_MaCH";
            this.lb_MaCH.Size = new System.Drawing.Size(43, 13);
            this.lb_MaCH.TabIndex = 10;
            this.lb_MaCH.Text = "Mã CH:";
            // 
            // panel_SearchCuaHang
            // 
            this.panel_SearchCuaHang.Controls.Add(this.btn_TimKiem);
            this.panel_SearchCuaHang.Controls.Add(this.txtTimKiem);
            this.panel_SearchCuaHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_SearchCuaHang.Location = new System.Drawing.Point(0, 245);
            this.panel_SearchCuaHang.Name = "panel_SearchCuaHang";
            this.panel_SearchCuaHang.Size = new System.Drawing.Size(926, 31);
            this.panel_SearchCuaHang.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(212, 3);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 7;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(200, 20);
            this.txtTimKiem.TabIndex = 6;
            // 
            // dgv_CuaHang
            // 
            this.dgv_CuaHang.AccessibleDescription = "Cửa Hàng ";
            this.dgv_CuaHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CuaHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CuaHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CuaHang.Location = new System.Drawing.Point(0, 276);
            this.dgv_CuaHang.Name = "dgv_CuaHang";
            this.dgv_CuaHang.ReadOnly = true;
            this.dgv_CuaHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CuaHang.Size = new System.Drawing.Size(926, 294);
            this.dgv_CuaHang.TabIndex = 2;
            this.dgv_CuaHang.Click += new System.EventHandler(this.dgv_CuaHang_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UCCuaHang
            // 
            this.AccessibleDescription = "Cửa Hàng";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_CuaHang);
            this.Controls.Add(this.panel_SearchCuaHang);
            this.Controls.Add(this.panel_InforCuaHang);
            this.Name = "UCCuaHang";
            this.Size = new System.Drawing.Size(926, 570);
            this.panel_InforCuaHang.ResumeLayout(false);
            this.panel_InforCuaHang.PerformLayout();
            this.panel_SearchCuaHang.ResumeLayout(false);
            this.panel_SearchCuaHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CuaHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_InforCuaHang;
        private System.Windows.Forms.Panel panel_SearchCuaHang;
        private System.Windows.Forms.DataGridView dgv_CuaHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RichTextBox rtxt_GhiChu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox txt_TenCH;
        private System.Windows.Forms.Label lb_TenCH;
        private System.Windows.Forms.TextBox txt_MaCH;
        private System.Windows.Forms.Label lb_MaCH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
    }
}
