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
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvExport = new System.Windows.Forms.DataGridView();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_TotalImport = new System.Windows.Forms.Label();
            this.lb_totalExport = new System.Windows.Forms.Label();
            this.lb_profit = new System.Windows.Forms.Label();
            this.grb_PhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).BeginInit();
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
            this.grb_PhieuNhap.Controls.Add(this.dgvImport);
            this.grb_PhieuNhap.Location = new System.Drawing.Point(53, 43);
            this.grb_PhieuNhap.Name = "grb_PhieuNhap";
            this.grb_PhieuNhap.Size = new System.Drawing.Size(613, 246);
            this.grb_PhieuNhap.TabIndex = 48;
            this.grb_PhieuNhap.TabStop = false;
            this.grb_PhieuNhap.Text = "Phiếu Nhập";
            // 
            // dgvImport
            // 
            this.dgvImport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport.Location = new System.Drawing.Point(3, 16);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.Size = new System.Drawing.Size(607, 227);
            this.dgvImport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvExport);
            this.groupBox1.Location = new System.Drawing.Point(53, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 261);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // dgvExport
            // 
            this.dgvExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExport.Location = new System.Drawing.Point(3, 16);
            this.dgvExport.Name = "dgvExport";
            this.dgvExport.Size = new System.Drawing.Size(607, 242);
            this.dgvExport.TabIndex = 2;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(705, 84);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 20);
            this.dtFrom.TabIndex = 50;
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(705, 165);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 20);
            this.dtTo.TabIndex = 51;
            // 
            // btnStatistic
            // 
            this.btnStatistic.Location = new System.Drawing.Point(692, 218);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(130, 68);
            this.btnStatistic.TabIndex = 52;
            this.btnStatistic.Text = "Thống Kê";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "From ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(688, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(702, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tổng Tiền Phiếu Nhập ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(702, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tổng Tiền Phiếu Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(702, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Thu Nhập ";
            // 
            // lb_TotalImport
            // 
            this.lb_TotalImport.AutoSize = true;
            this.lb_TotalImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TotalImport.Location = new System.Drawing.Point(868, 313);
            this.lb_TotalImport.Name = "lb_TotalImport";
            this.lb_TotalImport.Size = new System.Drawing.Size(32, 24);
            this.lb_TotalImport.TabIndex = 58;
            this.lb_TotalImport.Text = "00";
            // 
            // lb_totalExport
            // 
            this.lb_totalExport.AutoSize = true;
            this.lb_totalExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalExport.Location = new System.Drawing.Point(868, 363);
            this.lb_totalExport.Name = "lb_totalExport";
            this.lb_totalExport.Size = new System.Drawing.Size(32, 24);
            this.lb_totalExport.TabIndex = 59;
            this.lb_totalExport.Text = "00";
            // 
            // lb_profit
            // 
            this.lb_profit.AutoSize = true;
            this.lb_profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_profit.Location = new System.Drawing.Point(868, 410);
            this.lb_profit.Name = "lb_profit";
            this.lb_profit.Size = new System.Drawing.Size(32, 24);
            this.lb_profit.TabIndex = 60;
            this.lb_profit.Text = "00";
            // 
            // UCThongKeHoaDon
            // 
            this.AccessibleName = "Thống Kê";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_profit);
            this.Controls.Add(this.lb_totalExport);
            this.Controls.Add(this.lb_TotalImport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grb_PhieuNhap);
            this.Controls.Add(this.lb_PhieuNhapKho);
            this.Name = "UCThongKeHoaDon";
            this.Size = new System.Drawing.Size(1271, 584);
            this.grb_PhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_PhieuNhapKho;
        private System.Windows.Forms.GroupBox grb_PhieuNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.DataGridView dgvExport;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_TotalImport;
        private System.Windows.Forms.Label lb_totalExport;
        private System.Windows.Forms.Label lb_profit;
    }
}
