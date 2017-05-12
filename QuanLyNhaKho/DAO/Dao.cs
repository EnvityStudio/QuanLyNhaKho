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
            return DataProvider.Query(Config.PROC_GET_NHANVIEN_BY_ID, para);
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
            return DataProvider.Query(Config.PROC_SEARCH_CUAHANG, para);
        }
        public static DataTable SearchNCC(string MaNCC)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@MaNCC",MaNCC)
                };
            return DataProvider.Query(Config.PROC_SEARCH_NCC, para);
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
            return DataProvider.Query(Config.PROC_GET_CHITIET_PHIEUXUAT, para);
        }
        public static DataTable GetListChiTietPhieuNhap(string MaPN)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@MaPN",MaPN)
                };
            return DataProvider.Query(Config.PROC_GET_CHITIET_PHIEUNHAP, para);
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
            return DataProvider.NonQuery(Config.PROC_INSERT_CHITIET_PHIEUXUAT, para);
        }
        public static int AddChiTietPhieuNhap(ChiTietPhieuNhap chiTiet)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaPN",chiTiet.MaPN),
                    new SqlParameter(@"MaHH",chiTiet.MaHH),
                    new SqlParameter(@"SoLuong",chiTiet.SoLuong),
                    new SqlParameter(@"GhiChu",chiTiet.GhiChu)
                };
            return DataProvider.NonQuery(Config.PROC_INSERT_CHITIET_PHIEUNHAP,para);
        }

        public static int AddPhieuXuat(PhieuXuat phieuXuat)
        {
            SqlParameter[] para = new SqlParameter[]
             {
                new SqlParameter("@MaPX",phieuXuat.MaPX),
                new SqlParameter("@MaCH",phieuXuat.MaCH),
                new SqlParameter("@MaNV",phieuXuat.MaNV),
                new SqlParameter("@NgayXuat",phieuXuat.NgayXuat),
                new SqlParameter("@TongTien",phieuXuat.TongTien),
                new SqlParameter("@ChietKhau",phieuXuat.ChietKhau),
                new SqlParameter("@ThanhTien",phieuXuat.ThanhTien),
                new SqlParameter("@GhiChu",phieuXuat.GhiChu)
             };
            return DataProvider.NonQuery(Config.PROC_INSERT_PHIEUXUAT, para);
        }
        public static int AddPhieuNhap(PhieuNhap phieuNhap)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaPN",phieuNhap.MaPN),
                    new SqlParameter(@"MaNCC",phieuNhap.MaNCC),
                    new SqlParameter(@"MaNV",phieuNhap.MaNV),
                    new SqlParameter(@"NgayNhap",phieuNhap.NgayNhap),
                    new SqlParameter(@"TongTien",phieuNhap.TongTien),
                    new SqlParameter(@"ChietKhau",phieuNhap.ChietKhau),
                    new SqlParameter(@"ThanhTien",phieuNhap.ThanhTien),
                    new SqlParameter(@"GhiChu",phieuNhap.GhiChu)
                };
            return DataProvider.NonQuery(Config.PROC_INSERT_PHIEUNHAP, para);
        }
        // Table Nhan Vien
        public static DataTable GetMaNVNext()
        {
            return DataProvider.Query(Config.PROC_GET_MA_NHANVIEN_NEXT);

        }
        public static int AddNhanVien(NhanVien nhanVien)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@MaNV",nhanVien.MaNV),
                    new SqlParameter("@HoTen",nhanVien.HoTen),
                    new SqlParameter("@NgaySinh",nhanVien.NgaySinh),
                    new SqlParameter("@GioiTinh",nhanVien.GioiTinh),
                    new SqlParameter("@DiaChi",nhanVien.DiaChi),
                    new SqlParameter("@SDT",nhanVien.SDT),
                    new SqlParameter("@UserName",nhanVien.UserName),
                    new SqlParameter("@Password",nhanVien.Password)
                 };
            return DataProvider.NonQuery(Config.PROC_INSERT_NHANVIEN, para);
        }
        public static int UpdateNhanVien(NhanVien nhanVien)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@MaNV",nhanVien.MaNV),
                    new SqlParameter("@HoTen",nhanVien.HoTen),
                    new SqlParameter("@NgaySinh",nhanVien.NgaySinh),
                    new SqlParameter("@GioiTinh",nhanVien.GioiTinh),
                    new SqlParameter("@DiaChi",nhanVien.DiaChi),
                    new SqlParameter("@SDT",nhanVien.SDT),
                    new SqlParameter("@UserName",nhanVien.UserName),
                    new SqlParameter("@Password",nhanVien.Password)
                };
            return DataProvider.NonQuery(Config.PROC_UPDATE_NHANVIEN, para);
        }
        public static int DeleteNhanVien(NhanVien nhanVien)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter("@MaNV",nhanVien.MaNV)
                };
            return DataProvider.NonQuery(Config.PROC_DELETE_NHANVIEN, para);
        }


        /// Table NhomHang

        public static DataTable GetMaNhomHangNext()
        {
            return DataProvider.Query(Config.PROC_GET_MA_NHOMHANG_NEXT);
        }
        public static DataTable GetListNhomHang()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_NHOMHANG);
        }
        public static int AddNhomHang(NhomHang nhomHang)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaNhom",nhomHang.MaNhom),
                    new SqlParameter(@"TenNhom",nhomHang.TenNhom),
                    new SqlParameter(@"SoLuong",nhomHang.SoLuong),
                    new SqlParameter(@"GhiChu",nhomHang.GhiChu)
                };
            return DataProvider.NonQuery(Config.PROC_INSERT_NHOMHANG, para);
        }
        public static int UpdateNhomHang(NhomHang nhomHang)
        {
            SqlParameter[] para = new SqlParameter[]
              {
                    new SqlParameter(@"MaNhom",nhomHang.MaNhom),
                    new SqlParameter(@"TenNhom",nhomHang.TenNhom),
                    new SqlParameter(@"SoLuong",nhomHang.SoLuong),
                    new SqlParameter(@"GhiChu",nhomHang.GhiChu)
              };
            return DataProvider.NonQuery(Config.PROC_UPDATE_NHOMHANG, para);
        }
        public static int DeleteNhomHang(NhomHang nhomHang)
        {
            SqlParameter[] para = new SqlParameter[]
                   {
                         new SqlParameter(@"MaNhom",nhomHang.MaNhom)
                   };
            return DataProvider.NonQuery(Config.PROC_DELETE_NHOMHANG, para);
        }
        public static DataTable GetTenNhom()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_TENNHOM);
        }
        
        //// Table NhaCungCap
        public static DataTable GetListTenNCC()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_TENNCC);
        }
        public static DataTable GetMaNCCNext()
        {
            return DataProvider.Query(Config.PROC_GET_MA_NCC_NEXT);
        }
        public static DataTable GetListNCC()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_NCC);
        }
        public static int AddNCC(NhaCungCap nhaCungCap)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaNCC",nhaCungCap.MaNCC),
                    new SqlParameter(@"TenNCC",nhaCungCap.TenNCC),
                    new SqlParameter(@"DiaChi",nhaCungCap.DiaChi),
                    new SqlParameter(@"SDT",nhaCungCap.SDT),
                    new SqlParameter(@"GhiChu",nhaCungCap.GhiChu)
                };
            return DataProvider.NonQuery(Config.PROC_INSERT_NCC, para);
        }
        public static int UpdateNCC(NhaCungCap nhaCungCap)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaNCC",nhaCungCap.MaNCC),
                    new SqlParameter(@"TenNCC",nhaCungCap.TenNCC),
                    new SqlParameter(@"DiaChi",nhaCungCap.DiaChi),
                    new SqlParameter(@"SDT",nhaCungCap.SDT),
                    new SqlParameter(@"GhiChu",nhaCungCap.GhiChu)

                };
            return DataProvider.NonQuery(Config.PROC_UPDATE_NCC, para);
        }
        public static int DeleteNCC(NhaCungCap nhaCungCap)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaNCC",nhaCungCap.MaNCC)
                };
            return DataProvider.NonQuery(Config.PROC_DELETE_NCC, para);
        }
        ///// CuaHang
        public static DataTable GetListTenCH()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_TENCH);
        }
        public static DataTable GetListCH()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_CH);
        }
        public static DataTable GetMaCHNext()
        {
            return DataProvider.Query(Config.PROC_GET_MA_CH_NEXT);
        }
        public static int AddCH(CuaHang cuaHang)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaCH",cuaHang.MaCH),
                    new SqlParameter(@"TenCH",cuaHang.TenCH),
                    new SqlParameter(@"DiaChi",cuaHang.DiaChi),
                    new SqlParameter(@"SDT",cuaHang.SDT),
                    new SqlParameter(@"GhiChu",cuaHang.GhiChu)
                };
            return DataProvider.NonQuery(Config.PROC_INSERT_CH, para);
        }
        public static int UpdateCH(CuaHang cuaHang)
        {
            SqlParameter[] para = new SqlParameter[]
                  {
                    new SqlParameter(@"MaCH",cuaHang.MaCH),
                    new SqlParameter(@"TenCH",cuaHang.TenCH),
                    new SqlParameter(@"DiaChi",cuaHang.DiaChi),
                    new SqlParameter(@"SDT",cuaHang.SDT),
                    new SqlParameter(@"GhiChu",cuaHang.GhiChu)
                  };
            return DataProvider.NonQuery(Config.PROC_UPDATE_CH, para);
        }
        public static int DeleteCH(CuaHang cuaHang)
        {
            SqlParameter[] para = new SqlParameter[]
                     {
                    new SqlParameter(@"MaCH",cuaHang.MaCH)
                     };
            return DataProvider.NonQuery(Config.PROC_DELETE_CH, para);

        }

        /// Hang Hoa
        /// 
        public static DataTable GetListTenHH()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_TENHH);
        }
        public static DataTable GetListHH()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_HH_BYNHOMHANG);
        }
        public static DataTable GetMaHHNext()
        {
            return DataProvider.Query(Config.PROC_GET_MA_HH_NEXT);
        }
        public static int AddHH(HangHoa hangHoa)
        {
            SqlParameter[] para = new SqlParameter[]
                {
                    new SqlParameter(@"MaHH",hangHoa.MaHH),
                    new SqlParameter(@"MaNhom",hangHoa.MaNhom),
                    new SqlParameter(@"TenHang",hangHoa.TenHang),
                    new SqlParameter(@"SoLuong",hangHoa.SoLuong),
                    new SqlParameter(@"DonViTinh",hangHoa.DonViTinh),
                    new SqlParameter(@"GiaNhap",hangHoa.GiaNhap),
                    new SqlParameter(@"GiaXuat",hangHoa.GiaXuat),
                    new SqlParameter(@"NSX",hangHoa.NSX),
                    new SqlParameter(@"HSD",hangHoa.HSD),
                    new SqlParameter(@"ThongTin",hangHoa.ThongTin),
                    new SqlParameter(@"NgayNhap",hangHoa.NgayNhap)
                };
            return DataProvider.NonQuery(Config.PROC_INSERT_HH, para);
        }
        public static int UpdateHH(HangHoa hangHoa)
        {
            SqlParameter[] para = new SqlParameter[]
              {
                    new SqlParameter(@"MaHH",hangHoa.MaHH),
                    new SqlParameter(@"MaNhom",hangHoa.MaNhom),
                    new SqlParameter(@"TenHang",hangHoa.TenHang),
                    new SqlParameter(@"SoLuong",hangHoa.SoLuong),
                    new SqlParameter(@"DonViTinh",hangHoa.DonViTinh),
                    new SqlParameter(@"GiaNhap",hangHoa.GiaNhap),
                    new SqlParameter(@"GiaXuat",hangHoa.GiaXuat),
                    new SqlParameter(@"NSX",hangHoa.NSX),
                    new SqlParameter(@"HSD",hangHoa.HSD),
                    new SqlParameter(@"ThongTin",hangHoa.ThongTin),
                    new SqlParameter(@"NgayNhap",hangHoa.NgayNhap)
              };
            return DataProvider.NonQuery(Config.PROC_UPDATE_HH, para);
        }
        public static int DeleteHH(HangHoa hangHoa)
        {
            SqlParameter[] para = new SqlParameter[]
              {
                    new SqlParameter(@"MaHH",hangHoa.MaHH)
              };
              return DataProvider.NonQuery(Config.PROC_DELETE_HH, para);
        }
        ////// Phieu Nhap
        public static DataTable GetListPN()
        {
            return DataProvider.Query(Config.PROC_GET_LIST_PHIEUNHAP);
        }
        public static DataTable GetMaPNNext()
        {
            return DataProvider.Query(Config.PROC_GET_MAPN_NEXT);
        }
        public static int AddPN(PhieuNhap phieuNhap)
        {
            SqlParameter[] para = new SqlParameter[] 
            {
                new SqlParameter(@"MaPN",phieuNhap.MaPN),
                new SqlParameter(@"MaNCC",phieuNhap.MaNCC),
                new SqlParameter(@"MaNV",phieuNhap.MaNV),
                new SqlParameter(@"NgayNhap",phieuNhap.NgayNhap),
                new SqlParameter(@"TongTien",phieuNhap.TongTien),
                new SqlParameter(@"ChietKhau",phieuNhap.ThanhTien),
                new SqlParameter(@"GhiChu",phieuNhap.GhiChu)
            };
            return DataProvider.NonQuery(Config.PROC_INSERT_PN, para);
        }
        public static int UpdatePN(PhieuNhap phieuNhap)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter(@"MaPN",phieuNhap.MaPN),
                new SqlParameter(@"MaNCC",phieuNhap.MaNCC),
                new SqlParameter(@"MaNV",phieuNhap.MaNV),
                new SqlParameter(@"NgayNhap",phieuNhap.NgayNhap),
                new SqlParameter(@"TongTien",phieuNhap.TongTien),
                new SqlParameter(@"ChietKhau",phieuNhap.ThanhTien),
                new SqlParameter(@"GhiChu",phieuNhap.GhiChu)
            };
            return DataProvider.NonQuery(Config.PROC_UPDATE_PN, para);
        }
        public static int DeletePN(PhieuNhap phieuNhap)
        {
            SqlParameter[] para = new SqlParameter[]
           {
                new SqlParameter(@"MaPN",phieuNhap.MaPN),
           };
            return DataProvider.NonQuery(Config.PROC_DELETE_PN, para);
       }
    }


}
