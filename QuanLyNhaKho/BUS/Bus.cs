using QuanLyNhaKho.DAO;
using QuanLyNhaKho.VO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.BUS
{
    public class Bus
    {
        public Bus() {}
       
        public static DataTable GetListNhanVien()
        {
            return Dao.GetListNhanVien();
        }

        public static bool CheckAccount(NhanVien nhanVien)
        {
            DataTable dtNhanVien = GetListNhanVien();
            var userName = nhanVien.UserName;
            var matKhau = nhanVien.MatKhau;
            foreach(DataRow row in dtNhanVien.Rows)
            {
                if (userName == row["UserName"].ToString() && matKhau == row["Password"].ToString())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
