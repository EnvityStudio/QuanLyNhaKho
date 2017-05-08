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
        public Bus() { }

        public static DataTable GetListNhanVien()
        {
            return Dao.GetListNhanVien();
        }

        public static bool CheckAccount(NhanVien nhanVien)
        {
            DataTable dtNhanVien = GetListNhanVien();
            var userName = nhanVien.UserName;
            var matKhau = nhanVien.Password;
            foreach (DataRow row in dtNhanVien.Rows)
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

        public static DataTable getChiTietPhieuXuat(string maPX)
        {
            return Dao.getChiTietPhieuXuat(maPX);
        }
        public static DataTable SearchHangHoa(string maHH)
        {
            return Dao.SearchHangHoa(maHH);
        }
        public static int AddChiTietPhieuXuat(ChiTietPhieuXuat chiTiet)
        {
            return Dao.AddChitietPhieuXuat(chiTiet);
        }
        public static int AddPhieuXuat(PhieuXuat phieuXuat)
        {
            return Dao.AddPhieuXuat(phieuXuat);
        }


        public static string getMaPXNext()
        {
            DataTable dt = Dao.getMaPXNext();
            string maPX = dt.Rows[0][0].ToString();
            return maPX;
        }
        // Nhan Vien
        public static string GetMaNVNext()
        {
            DataTable dt = Dao.GetMaNVNext();
            string MaNV = dt.Rows[0][0].ToString();
            return MaNV;
        }
        public static int AddNhanVien(NhanVien nhanVien)
        {
            return Dao.AddNhanVien(nhanVien);
        }
        public static int UpdateNhanVien(NhanVien nhanVien)
        {
            return Dao.UpdateNhanVien(nhanVien);
        }
        public static int DeleteNhanVien(NhanVien nhanVien)
        {
            return Dao.DeleteNhanVien(nhanVien);
        }

        /// Nhom Hang
        /// 
        public static DataTable GetListTenNhom()
        {
            return Dao.GetTenNhom();
        }
        public static DataTable GetListNhomHang()
        {
            return Dao.GetListNhomHang();
        }
        public static string GetMaNhomHangNext()
        {
            DataTable dt = Dao.GetMaNhomHangNext();
            string MaNhomHang = dt.Rows[0][0].ToString();
            return MaNhomHang;
        }
        public static int AddNhomHang(NhomHang nhomHang)
        {
            return Dao.AddNhomHang(nhomHang);
        }
        public static int UpdateNhomHang(NhomHang nhomHang)
        {
            return Dao.UpdateNhomHang(nhomHang);
        }
        public static int DeleteNhomHang(NhomHang nhomHang)
        {
            return Dao.DeleteNhomHang(nhomHang);
        }
        /// NhaCungCap
        /// 
        public static string GetMaNCCNext()
        {
            DataTable dt = Dao.GetMaNCCNext();
            string MaNCC = dt.Rows[0][0].ToString();
            return MaNCC;
        }
        public static DataTable GetListNCC()
        {
            return Dao.GetListNCC();
        }
        public static int AddNCC(NhaCungCap nhaCungCap)
        {
            return Dao.AddNCC(nhaCungCap);
        }
        public static int UpdateNCC(NhaCungCap nhaCungCap)
        {
            return Dao.UpdateNCC(nhaCungCap);
        }
        public static int DeleteNCC(NhaCungCap nhaCungCap)
        {
            return Dao.DeleteNCC(nhaCungCap);
        }
        //// Cua Hang
        public static string GetMaCHNext()
        {
            DataTable dt = Dao.GetMaCHNext();
            string MaCH = dt.Rows[0][0].ToString();
            return MaCH;
        }
        public static DataTable GetListCH()
        {
            return Dao.GetListCH();
        }
        public static int AddCH(CuaHang cuaHang)
        {
            return Dao.AddCH(cuaHang);
        }
        public static int UpdateCH(CuaHang cuaHang)
        {
            return Dao.UpdateCH(cuaHang);
        }
        public static int DeleteCH(CuaHang cuaHang)
        {
            return Dao.DeleteCH(cuaHang);
        }
        /// Hang Hoa
        /// 
        public static string GetMaHHNext()
        {
            DataTable dt = Dao.GetMaHHNext();
            string MaHH = dt.Rows[0][0].ToString();
            return MaHH;
        }
        public static int AddHH(HangHoa hangHoa)
        {
            return Dao.AddHH(hangHoa);
        }
        public static int UpdateHH(HangHoa hangHoa)
        {
            return Dao.UpdateHH(hangHoa);
        }
        public static int DeleteHH(HangHoa hangHoa)
        {
            return Dao.DeleteHH(hangHoa);
        }
        public static DataTable GetListHH()
        {
            return Dao.GetListHH();
        }
        
    }
}
