using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
    public class ChiTietPhieuNhap
    {
        public string MaPN { get; set; }
        public string MaHH { get; set; }
        public int SoLuong { get; set; }
        public float DonGia { get; set; }
        public float ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public ChiTietPhieuNhap() { }
        public ChiTietPhieuNhap(string MaPN,string MaHH,int SoLuong,float DonGia, float ThanhTien,string GhiChu)
        {
            this.MaPN = MaPN;
            this.MaHH = MaHH;
            this.SoLuong = SoLuong;
            this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
            this.GhiChu = GhiChu;
        }

    }
}
