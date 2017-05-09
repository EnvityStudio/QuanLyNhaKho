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
            panel_InforHangHoa.Enabled = true;
        }
        public void ClearData()
        {
            txtDonViTinh.Text = "";
            txtTenHH.Text = "";
            txtGiaNhap.Text = "";
            txtGiaXuat.Text = "";
            rtxtGhiChu.Text = "";
            txtSoLuong.Text = "";
            dtpNgayNhap.Value = DateTime.Now;

        }
        private void dgv_HangHoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgv_HangHoa.SelectedRows[0];
            txtMaHH.Text = dt.Cells["MaHH"].Value.ToString();
            txtTenHH.Text = dt.Cells["TenHang"].Value.ToString();
            txtSoLuong.Text = dt.Cells["SoLuong"].Value.ToString();
            txtDonViTinh.Text = dt.Cells["DonViTinh"].Value.ToString();
            dtpNSX.Text = dt.Cells["NSX"].Value.ToString();
            dtpHSD.Text = dt.Cells["HSD"].Value.ToString();
            rtxtGhiChu.Text = dt.Cells["ThongTin"].Value.ToString();
            dtpNgayNhap.Text = dt.Cells["NgayNhap"].Value.ToString();
            cbb_TenNhom.Text = dt.Cells["TenNhom"].Value.ToString();
            cbb_TenNhom.SelectedValue = dt.Cells["MaNhom"].Value.ToString();
        }
        public bool CheckTextBox()
        {
            if (!CheckEmpty(txtTenHH) || !CheckEmpty(txtDonViTinh) || !CheckEmpty(txtSoLuong) || !CheckEmpty(txtGiaNhap) || !CheckEmpty(txtGiaXuat))
            {
                MessageBox.Show("Có lỗi không thể thực hiện");
                return false;
            }
            return true;
        }
        public bool CheckEmpty(TextBox txt)
        {
            if (txt.Text.Trim() == "")
            {
                errorProvider.SetError(txt, "Không được để trống");
                return false;
            }
            errorProvider.SetError(txt, "");
            return true;

        }
        public HangHoa GetDataHH()
        {
            string MaHH, MaNhom, ThongTin, TenHang, DonViTinh;
            int SoLuong;

            DateTime NSX, HSD, NgayNhap;
            MaNhom = cbb_TenNhom.SelectedValue.ToString();
            MaHH = txtMaHH.Text;
            TenHang = txtTenHH.Text;
            SoLuong = int.Parse(txtSoLuong.Text);
            DonViTinh = txtDonViTinh.Text;
            ThongTin = rtxtGhiChu.Text;
            NSX = (DateTime)dtpNSX.Value;
            HSD = (DateTime)dtpHSD.Value;
            NgayNhap = (DateTime)dtpNgayNhap.Value;
            return new HangHoa(MaHH, MaNhom, TenHang, SoLuong, DonViTinh, NSX, HSD, ThongTin, NgayNhap);
        }
        public void InputKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void AddHH()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.AddHH(GetDataHH());
            if (result > 0)
            {
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
                panel_InforHangHoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void UpdateHH()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.UpdateHH(GetDataHH());
            if (result > 0)
            {
                MessageBox.Show("Sua Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
                panel_InforHangHoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Sua không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void DeleteHH()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.DeleteHH(GetDataHH());
            if (result > 0)
            {
                MessageBox.Show("Xoa Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
                panel_InforHangHoa.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xoa không thành công", "Thông báo", MessageBoxButtons.OK);
            }

        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
        }

        private void txtGiaXuat_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
