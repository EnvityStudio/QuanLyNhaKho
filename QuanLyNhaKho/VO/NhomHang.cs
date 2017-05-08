using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
  public class NhomHang
    {
        public string MaNhom { get; set; }
        public string TenNhom { get; set; }
        public int SoLuong { get; set; }
        public string GhiChu { get; set; }
        public NhomHang() { }
        public NhomHang(string MaNhom,string TenNhom,int SoLuong,string GhiChu)
        {
            this.MaNhom = MaNhom;
            this.TenNhom = TenNhom;
            this.SoLuong = SoLuong;
            this.GhiChu = GhiChu;
        }
    }
}
