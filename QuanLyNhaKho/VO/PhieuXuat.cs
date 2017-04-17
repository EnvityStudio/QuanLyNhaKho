using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.VO
{
    public class PhieuXuat
    {
        public string MaPX { get; set; }
        public string MaCH { get; set; }
        public string MaNV { get; set; }
        public DateTime NgayXuat { get; set; }
        public float TongTien { get; set; }
        public float ChietKhau { get; set; }
        public float ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public PhieuXuat()
        {

        }
    }
}
