using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.DAO;
using QuanLyNhaKho.VO;
using QuanLyNhaKho.BUS;

namespace QuanLyNhaKho.GUI
{
    public partial class UCHangHoa : UserControl
    {
        public UCHangHoa()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgv_HangHoa.DataSource = Dao.GetListHH();
            dgv_HangHoa.Columns["MaHH"].HeaderText = "Mã Hàng Hóa";
            dgv_HangHoa.Columns["TenNhom"].HeaderText = "Tên Nhóm";
            dgv_HangHoa.Columns["MaNhom"].Visible = false;
            dgv_HangHoa.Columns["TenHang"].HeaderText = "Tên Hàng Hóa";
            dgv_HangHoa.Columns["SoLuong"].HeaderText = "Số Lượng";
            dgv_HangHoa.Columns["DonViTinh"].HeaderText = "Đơn Vị Tính";
            dgv_HangHoa.Columns["NSX"].HeaderText = "NSX";
            dgv_HangHoa.Columns["HSD"].HeaderText = "HSD";
            dgv_HangHoa.Columns["ThongTin"].HeaderText = "Thông Tin";
            dgv_HangHoa.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            panel_InforHangHoa.Enabled = false;
            cbb_TenNhom.DataSource = Bus.GetListTenNhom();
            cbb_TenNhom.DisplayMember = "TenNhom";
            cbb_TenNhom.ValueMember = "MaNhom";
            ClearData();
        }
        public void GetMaHHNext()
        {
            ClearData();
            txtMaHH.Text = Bus.GetMaHHNext();
            panel_InforHangHoa.Enabled = true;
        }
        public void EnablePanel()
        {

        }
        public void ClearData()
        {
        }
        private void dgv_HangHoa_Click(object sender, EventArgs e)
        {
        }
        public bool CheckTextBox()
        {
        }
        public bool CheckEmpty(TextBox txt)
        {
        }
        public HangHoa GetDataHH()
        {
            
        }
        public void InputKeyPress(object sender, KeyPressEventArgs e)
        {
        }
        public void AddHH()
        {
            
        }
        public void UpdateHH()
        {
        }
        public void DeleteHH()
        {
      
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
        }

        private void txtGiaXuat_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
