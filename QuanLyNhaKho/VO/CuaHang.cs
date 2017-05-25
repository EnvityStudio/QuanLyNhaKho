using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
    public class CuaHang
    {
        public string MaCH { get; set; }
        public string TenCH { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string GhiChu { get; set; }
        public CuaHang() { }
        public CuaHang(string MaCH, string TenCH, string DiaChi, string SDT, string GhiChu)
        {
            this.MaCH = MaCH;
            this.TenCH = TenCH;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.GhiChu = GhiChu;
        }
    }
}
