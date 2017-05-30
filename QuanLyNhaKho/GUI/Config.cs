using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho
{
    class Config
    {
        public Config()
        {

        }
        //
        public static string ACTION;
        public static string ADD = "ADD";
        public static string EDIT = "EDIT";
        public static string DELETE = "DELETE";

        public static string CURRENT_NHANVIEN = "";


        public static string PROC_EDIT_PASSWORD = "EditPassword";
        //
        public static string TAB_PHIEUNHAP = "PHIEUNHAP";
        public static string TAB_PHIEU_XUAT = "PHIEUXUAT";
        public static string TAB_CURRENT = "";
        public static string TAB_NHANVIEN = "NHANVIEN";
        public static string TAB_NHOMHANG = "NHOMHANG";
        public static string TAB_CUAHANG = "CUAHANG";
        public static string TAB_NHACUNGCAP = "NHACUNGCAP";
        public static string TAB_HANGHOA = "HANGHOA";

        //
        public static string PROC_GET_LIST_NHANVIEN = "[GetListNhanVien]";
        public static string PROC_GET_NHANVIEN_BY_ID = "[GetNhanVienByID]";
        public static string PROC_GET_LIST_PHIEUXUAT = "[GetListPhieuXuat]";
        public static string PROC_SEARCH_CUAHANG = "[SearchCuaHang]";
        public static string PROC_SEARCH_NHANVIEN = "[SearchNhanVien]";
        public static string PROC_SEARCH_NCC = "SearchNCC";
        public static string PROC_GET_MA_PHIEUXUAT_NEXT = "[GetMaPXNext]";
        public static string PROC_GET_CHITIET_PHIEUXUAT = "[GetListCTPXByMaPX]";
        public static string PROC_INSERT_CHITIET_PHIEUXUAT = "[InsertCTPX]";
        public static string PROC_INSERT_CHITIET_PHIEUNHAP = "InsertCTPN";
        public static string PROC_SEARCH_HANGHOA = "[SearchHangHoa]";
        public static string PROC_INSERT_PHIEUXUAT = "[InsertPX]";
        public static string PROC_GET_LIST_PHIEUNHAP = "GetListPhieuNhap";
        public static string PROC_GET_MA_PHIEUNHAP_NEXT = "GetMaPNNext";
        public static string PROC_GET_CHITIET_PHIEUNHAP = "GetListCTPNByMaPN";
        public static string PROC_INSERT_PHIEUNHAP = "InsertPhieuNhap";

        /// Table NhanVien
        public static string PROC_GET_MA_NHANVIEN_NEXT = "GetMaNVNext";
        public static string PROC_INSERT_NHANVIEN = "InsertNhanVien";
        public static string PROC_UPDATE_NHANVIEN = "UpdateNhanVien";
        public static string PROC_DELETE_NHANVIEN = "DeleteNhanVien";
        
        //// Table NhomHang
        public static string PROC_GET_MA_NHOMHANG_NEXT = "GetMaNhomHangNext";
        public static string PROC_INSERT_NHOMHANG = "InsertNhomHang";
        public static string PROC_UPDATE_NHOMHANG = "UpdateNhomHang";
        public static string PROC_DELETE_NHOMHANG = "DeleteNhomHang";
        public static string PROC_GET_LIST_NHOMHANG = "GetListNhomHang";
        public static string PROC_GET_LIST_TENNHOM = "GetTenNhom";
        ////// Table NhaCungCap
        public static string PROC_GET_MA_NCC_NEXT = "GetMaNCCNext";
        public static string PROC_INSERT_NCC = "InsertNCC";
        public static string PROC_UPDATE_NCC = "UpdateNCC";
        public static string PROC_DELETE_NCC = "DeleteNCC";
        public static string PROC_GET_LIST_NCC = "GetListNCC";
        public static string PROC_GET_LIST_TENNCC = "GetListTenNCC";
        ///// Table CuaHang
        public static string PROC_GET_MA_CH_NEXT = "GetMaCHNext";
        public static string PROC_INSERT_CH = "InsertCH";
        public static string PROC_UPDATE_CH = "UpdateCH";
        public static string PROC_DELETE_CH = "DeleteCH";
        public static string PROC_GET_LIST_CH = "GetListCH";
        public static string PROC_GET_LIST_TENCH = "GetListTenCH";
        /// Hang Hoa
        ///
        public static string PROC_GET_MA_HH_NEXT = "GetMaHHNext";
        public static string PROC_GET_LIST_HH= "GetListHangHoa";
        public static string PROC_UPDATE_HH = "UpdateHangHoa";
        public static string PROC_INSERT_HH = "InsertHangHoa";
        public static string PROC_DELETE_HH = "DeleteHangHoa";
        public static string PROC_GET_LIST_HH_BYNHOMHANG = "GetListHHByNhomHang";
        public static string PROC_GET_LIST_TENHH = "GetListTenHH";
        /// Phieu Nhap
        /// 

        public static string PROC_GET_MAPN_NEXT = "GetMaPNNext";
        public static string PROC_GET_LIST_PN = "GetListPhieuNhap";
        public static string PROC_INSERT_PN = "InsertPhieuNhap";
        public static string PROC_UPDATE_PN = "UpdatePhieuNhap";
        public static string PROC_DELETE_PN = "DeletePhieuNhap";
        public static string PROC_DELETE_PX = "DeletePhieuXuat";

        public static string PROC_GET_PX_BYID = "GetExportByID";
        public static string PROC_GET_PN_BYID = "GetImportByID";
        /// statistic 
        /// 
        public static string PROC_Statistic_Import_ByTime = "GetListStatisticByTimeImport";
        public static string PROC_Statistic_Export_ByTime = "GetListStatisticByTimeExport";
        public static string PROC_GetTotalMoneyImport = "GetTotalMoneyImport";
        public static string PROC_GetTotalMoneyExport = "GetTotalMoneyExport";
    }
}
