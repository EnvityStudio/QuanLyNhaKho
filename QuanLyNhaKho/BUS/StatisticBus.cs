using QuanLyNhaKho.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNhaKho.DAO;
namespace QuanLyNhaKho.BUS
    
{
    public class StatisticBus
    {
        public StatisticBus() { }
        //public List<ThongKe> GetListStatisticByDay()
        //{
        //    DateTime date = DateTime.Now;
            
        //}
        public static DataTable StatisticImportByTime(DateTime fromTime,DateTime toTime)
        {
            return Dao.StatisticImportByTime(fromTime,toTime);
        }
        public static DataTable StatisticExportByTime(DateTime fromTime, DateTime toTime)
        {
            return Dao.StatisticExportByTime(fromTime, toTime);
        }
        public static string GetTotalMoneyImport(DateTime fromTime,DateTime toTime)
        {
            DataTable dt = Dao.GetTotalMoneyImport(fromTime, toTime);
            if (dt.Rows.Count == 0) return "0";
            string totalMoney =dt.Rows[0]["ThanhTien"].ToString();
            return totalMoney;
        }
        public static string GetTotalMoneyExport(DateTime fromTime, DateTime toTime)
        {
            DataTable dt = Dao.GetTotalMoneyExport(fromTime, toTime);
            if (dt.Rows.Count == 0) return "0";
            string totalMoney = dt.Rows[0]["ThanhTien"].ToString();
            return totalMoney;
        }
    }
}
