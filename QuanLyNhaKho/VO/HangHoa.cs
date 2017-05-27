using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
    public class HangHoa
    {
        public string MaHH { get; set; }
        public string MaNhom { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public DateTime NSX { get; set; }
        public DateTime HSD { get; set; }
        public string ThongTin { get; set; }
        public DateTime NgayNhap { get; set; }
        public HangHoa() { }
        public HangHoa(string MaHH,string MaNhom ,string TenHang, int SoLuong, string DonViTinh, DateTime NSX, DateTime HSD, string ThongTin,DateTime NgayNhap)
        {

            this.MaHH = MaHH;
            this.MaNhom = MaNhom;
            this.TenHang = TenHang;
            this.SoLuong = SoLuong;
            this.DonViTinh = DonViTinh;
     
            this.NSX = NSX;
            this.HSD = HSD;
            this.ThongTin = ThongTin;
            this.NgayNhap = NgayNhap;
        }
    }
}
