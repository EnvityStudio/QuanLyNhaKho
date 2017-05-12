namespace QuanLyNhaKho.GUI
{
    partial class UCThongKeHangTonKho
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
            // UCThongKeHangTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_PhieuNhapKho);
            this.Name = "UCThongKeHangTonKho";
            this.Size = new System.Drawing.Size(909, 584);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PhieuNhapKho;
    }
}
