using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.BUS;

namespace QuanLyNhaKho.GUI
{
    public partial class UCThongKeHoaDon : UserControl
    {
        public UCThongKeHoaDon()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgvImport.DataSource = StatisticBus.StatisticImportByTime(dtFrom.Value, dtTo.Value);
            dgvExport.DataSource = StatisticBus.StatisticExportByTime(dtFrom.Value, dtTo.Value);
            lb_TotalImport.Text = StatisticBus.GetTotalMoneyImport(dtFrom.Value, dtTo.Value).ToString();
            lb_totalExport.Text = StatisticBus.GetTotalMoneyExport(dtFrom.Value, dtTo.Value).ToString();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            dgvImport.DataSource = StatisticBus.StatisticImportByTime(dtFrom.Value, dtTo.Value);
            dgvExport.DataSource = StatisticBus.StatisticExportByTime(dtFrom.Value, dtTo.Value);
            lb_TotalImport.Text = StatisticBus.GetTotalMoneyImport(dtFrom.Value, dtTo.Value).ToString();
            lb_totalExport.Text = StatisticBus.GetTotalMoneyExport(dtFrom.Value, dtTo.Value).ToString();
            int a = int.Parse(lb_TotalImport.Text);
            int b = int.Parse(lb_totalExport.Text);
            lb_profit.Text = (a-b).ToString();

        }
    }
}
