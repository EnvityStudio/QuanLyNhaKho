using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
    public class NhanVien
    {
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public string Password{ get; set; }
        public string UserName { get; set; }
        public NhanVien()
        {

        }
        public NhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi,string SDT, string UserName,string Password)
        {
            this.MaNV = MaNV;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.GioiTinh = GioiTinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.Password = Password;
            this.UserName = UserName;
        }
    }
}
