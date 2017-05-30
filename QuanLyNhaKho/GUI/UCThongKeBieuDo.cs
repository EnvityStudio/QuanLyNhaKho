using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.VO;
using QuanLyNhaKho.BUS;

namespace QuanLyNhaKho.GUI
{
    public partial class UCThongKeBieuDo : UserControl
    {
        public UCThongKeBieuDo()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {

        }
        private void ResetValueChart()
        {
            foreach(var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
        
        private void btnDate_Click(object sender, EventArgs e)
        {
            //List<ThongKe> listStatistic = StatisticBus.GetListStatisticByDay();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            //ResetValueChart();
            //List<ThongKe> listStatistic = ;
            //foreach (ThongKe int listStatistic)
            //    {
            //    chart1
            //}
        }

        private void btnYear_Click(object sender, EventArgs e)
        {

        }
    }
}
