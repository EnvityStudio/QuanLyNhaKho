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

        public static string ACTION;
        public static string ADD = "ADD";
        public static string EDIT = "EDIT";
        public static string DELETE = "DELETE";

        public static string TAB_PHIEU_XUAT = "PHIEUXUAT";
        public static string TAB_CURRENT = "";
        public static string PROC_GET_LIST_NHANVIEN = "[GetListNhanVien]";
        public static string PROC_GET_NHANVIEN_BY_ID = "[GetNhanVienByID]";
        public static string PROC_GET_LIST_PHIEUXUAT = "[GetListPhieuXuat]";
        public static string PROC_SEARCH_CUAHANG = "[SearchCuaHang]";
        public static string PROC_SEARCH_NHANVIEN = "[SearchNhanVien]";
        public static string PROC_GET_MA_PHIEUXUAT_NEXT = "[GetMaPXNext]";
        public static string PROC_GET_CHITIET_PHIEUXUAT = "[GetListCTPXByMaPX]";
        public static string PROC_INSERT_CHITIET_PHIEUXUAT = "[InsertCTPX]";
        public static string PROC_SEARCH_HANGHOA = "[SearchHangHoa]";
        public static string PROC_INSERT_PHIEUXUAT = "[InsertPhieuXuat]";            

        
    }
}
