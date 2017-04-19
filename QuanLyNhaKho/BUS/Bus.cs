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

        public static DataTable getListPhieuXuat()
        {
            return Dao.getListPhieuXuat();
        }
        public static DataTable SearchCuaHang(string maCH)
        {
            return Dao.SearchCuaHang(maCH);
        }
        public static string getTenCuaHang(string maCH)
        {
            DataTable dt = SearchCuaHang(maCH);
            if (dt.Rows.Count == 0) return "";
            string name = dt.Rows[0]["TenCH"].ToString();
            return name;
        }
        public static string getDiaChiCuaHang(string maCH)
        {
            DataTable dt = SearchCuaHang(maCH);
            if (dt.Rows.Count == 0) return "";
            string name = dt.Rows[0]["DiaChi"].ToString();
            return name;
        }
        public static string getTenNhanVien(string maNV)
        {
            DataTable dt = Dao.SearchNhanVien(maNV);
            if (dt.Rows.Count == 0) return "";
            string name = dt.Rows[0]["HoTen"].ToString();
            return name;
        }
        public static string getMaPXNext()
        {
            DataTable dt = Dao.getMaPXNext();
            string maPX = dt.Rows[0][0].ToString();
            return maPX;
        }
        public static DataTable getChiTietPhieuXuat(string maPX)
        {
            return Dao.getChiTietPhieuXuat(maPX);
        }
        public static DataTable SearchHangHoa(string maHH)
        {
            return Dao.SearchHangHoa(maHH);
        }
        public static  int AddChiTietPhieuXuat(ChiTietPhieuXuat chiTiet)
        {
            return Dao.AddChitietPhieuXuat(chiTiet);
        }
        public static int AddPhieuXuat(PhieuXuat phieuXuat)
        {
            return Dao.AddPhieuXuat(phieuXuat);
        }
    }
}
