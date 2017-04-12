using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace QuanLyNhaKho.DAO
{
    class Dao
    {
        public static DataTable GetListNhanVien()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_NHANVIEN);
        }
        public static DataTable GetNhanVienById(string maNV)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                 new SqlParameter("@MaNV",maNV)
            };
            return DataProvider.Query(Config.PROC_GET_NHANVIEN_BY_ID,para);
        }
   
    }
}
