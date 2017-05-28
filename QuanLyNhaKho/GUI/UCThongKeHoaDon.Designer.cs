namespace QuanLyNhaKho.GUI
{
    partial class UCThongKeHoaDon
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
            this.lb_PhieuNhapKho = new System.Windows.Forms.Label();
            this.grb_PhieuNhap = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lb_PhieuNhapKho
            // 
            this.lb_PhieuNhapKho.AutoSize = true;
            this.lb_PhieuNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PhieuNhapKho.ForeColor = System.Drawing.Color.Firebrick;
            this.lb_PhieuNhapKho.Location = new System.Drawing.Point(350, 15);
            this.lb_PhieuNhapKho.Name = "lb_PhieuNhapKho";
            this.lb_PhieuNhapKho.Size = new System.Drawing.Size(291, 25);
            this.lb_PhieuNhapKho.TabIndex = 47;
            this.lb_PhieuNhapKho.Text = "Thống Kê Hàng Trong Kho";
            // 
            // grb_PhieuNhap
            // 
            this.grb_PhieuNhap.Location = new System.Drawing.Point(53, 98);
            this.grb_PhieuNhap.Name = "grb_PhieuNhap";
            this.grb_PhieuNhap.Size = new System.Drawing.Size(498, 228);
            this.grb_PhieuNhap.TabIndex = 48;
            this.grb_PhieuNhap.TabStop = false;
            this.grb_PhieuNhap.Text = "Phiếu Nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(53, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 228);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // UCThongKeHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_PhieuNhap);
            this.Controls.Add(this.lb_PhieuNhapKho);
            this.Name = "UCThongKeHoaDon";
            this.Size = new System.Drawing.Size(909, 584);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PhieuNhapKho;
        private System.Windows.Forms.GroupBox grb_PhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
