using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
    public class NhaCungCap
    {
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string GhiChu { get; set; }
        public NhaCungCap() { }
        public NhaCungCap(string MaNCC,string TenNCC,string DiaChi,string SDT, string GhiChu)
        {
            this.MaNCC = MaNCC;
            this.TenNCC = TenNCC;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.GhiChu = GhiChu;
        }
    }
}
