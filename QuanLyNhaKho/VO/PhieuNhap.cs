using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
    public class PhieuNhap
    {
        public string MaPN { get; set; }
        public string MaNCC { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayNhap{ get; set; }
        public float TongTien { get; set;}
        public int ChietKhau { get; set; }
        public float ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public PhieuNhap(string MaPN,string MaNCC,string MaNV,DateTime NgayNhap,float TongTien,int ChietKhau,float ThanhTien,string GhiChu)
        {
            this.MaPN = MaPN;
            this.MaNCC = MaNCC;
            this.NgayNhap = NgayNhap;
            this.TongTien = TongTien;
            this.ChietKhau = ChietKhau;
            this.ThanhTien = ThanhTien;
            this.GhiChu = GhiChu;
        }

        public PhieuNhap() { }


    }
}
