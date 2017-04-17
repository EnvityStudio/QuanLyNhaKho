using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuanLyNhaKho.VO;


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
        public static DataTable getListPhieuXuat()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_PHIEUXUAT);
        }

        public static DataTable SearchCuaHang(string maCH)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@maCH",maCH)
            };
            return DataProvider.Query(Config.PROC_SEARCH_CUAHANG,para);
        }

        public static DataTable SearchNhanVien(string maNV)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                new SqlParameter("@maNV",maNV)
           };
            return DataProvider.Query(Config.PROC_SEARCH_NHANVIEN, para);
        }
        public static DataTable getMaPXNext()
        {
            return DataProvider.Query(Config.PROC_GET_MA_PHIEUXUAT_NEXT);
        }
        public static DataTable getChiTietPhieuXuat(string maPX)
        {
            SqlParameter[] para = new SqlParameter[]
          {
                new SqlParameter("@MaPX",maPX)
          };
            return DataProvider.Query(Config.PROC_GET_CHITIET_PHIEUXUAT,para);
        }
        public static DataTable SearchHangHoa(string maHH)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@MaHH",maHH)
            };
            return DataProvider.Query(Config.PROC_SEARCH_HANGHOA, para);
        }
        public static int AddChitietPhieuXuat(ChiTietPhieuXuat chiTiet)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@MaPX",chiTiet.MaPX),
                new SqlParameter("@MaHH",chiTiet.MaHH),
                new SqlParameter("@SoLuong",chiTiet.SoLuong),
                new SqlParameter("@GhiChu",chiTiet.GhiChu)
             };
            return DataProvider.NonQuery(Config.PROC_INSERT_CHITIET_PHIEUXUAT,para);
        }

        public static int AddPhieuXuat(PhieuXuat phieuXuat)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@MaPX",phieuXuat.MaPX),
                new SqlParameter("@MaCH",phieuXuat.MaCH),
                new SqlParameter("@MaNV",phieuXuat.MaNV),
                new SqlParameter("@TongTien",phieuXuat.TongTien),
                new SqlParameter("@NgayXuat",phieuXuat.NgayXuat),
                new SqlParameter("@ChietKhau",phieuXuat.ChietKhau),
                new SqlParameter("@ThanhTien",phieuXuat.ThanhTien),
                new SqlParameter("@GhiChu",phieuXuat.NgayXuat)
             };
            return DataProvider.NonQuery(Config.PROC_INSERT_PHIEUXUAT, para);
        }
    }
}
