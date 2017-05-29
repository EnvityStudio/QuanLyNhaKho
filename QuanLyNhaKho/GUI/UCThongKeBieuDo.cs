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
        public void LoadData()
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            //List<ThongKe> listStatistic = StatisticBus.GetListStatisticByDay();
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {

        }

        private void btnYear_Click(object sender, EventArgs e)
        {

        }
    }
}
