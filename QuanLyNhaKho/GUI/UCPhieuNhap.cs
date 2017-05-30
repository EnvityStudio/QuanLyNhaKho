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
using QuanLyNhaKho.BUS;

namespace QuanLyNhaKho.GUI
{
    public partial class UCPhieuNhap : UserControl
    {
        public UCPhieuNhap()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgvPhieuNhap.DataSource = Dao.GetListPN();

            dgvPhieuNhap.Columns["MaPN"].HeaderText = "Mã Phiếu Nhập";
            dgvPhieuNhap.Columns["TenNCC"].HeaderText = "Tên NCC";
            dgvPhieuNhap.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvPhieuNhap.Columns["NgayNhap"].HeaderText = "Ngày Nhập";
            dgvPhieuNhap.Columns["TongTien"].HeaderText = "Tổng Tiền";
            dgvPhieuNhap.Columns["ChietKhau"].HeaderText = "Chiết Khấu";
            dgvPhieuNhap.Columns["ThanhTien"].HeaderText = "Thành Tiền";
            dgvPhieuNhap.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dgvPhieuNhap.Columns["MaNCC"].Visible = false;
            panel_PN.Enabled = true;
            cbbTenNCC.DataSource = Bus.GetListTenNCC();
            cbbTenNCC.DisplayMember = "TenNCC";
            cbbTenNCC.ValueMember = "MaNCC";
            
        }

        private void dgvPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dt = dgvPhieuNhap.SelectedRows[0];
                txtMaPN.Text = dt.Cells["MaPN"].Value.ToString();
                txtThanhTien.Text = dt.Cells["ThanhTien"].Value.ToString();
                lb_TongTien.Text = dt.Cells["TongTien"].Value.ToString();
                txtChietKhau.Text = dt.Cells["ChietKhau"].Value.ToString();
                dtpNgayNhap.Text = dt.Cells["NgayNhap"].Value.ToString();
                rtxtGhiChu.Text = dt.Cells["GhiChu"].Value.ToString();
                cbbTenNCC.Text = dt.Cells["TenNCC"].Value.ToString();
                cbbTenNCC.SelectedValue = dt.Cells["MaNCC"].Value.ToString();
            }
            catch(Exception err)
            {
                Console.Write(err.Message);
            }


        }

        private void cbbTenNCC_TextChanged(object sender, EventArgs e)
        {
            
            
        }
      
         public void DeletePhieuNhap()
           {
            int result = Dao.DeletePN(txtMaPN.Text);
            if(result<0)
            {
                MessageBox.Show("Xoa khong thanh cong", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                MessageBox.Show("Xoa thanh cong!", "Thông báo", MessageBoxButtons.OK);
                LoadData();
                return;
            }
           
        }

        private void cbbTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            string MaNCC = cbbTenNCC.SelectedValue.ToString();
            DataTable dt = Bus.SearchNCC(MaNCC);
            if (dt.Rows.Count>0)
            {
                
                txtDiaChiNCC.Text = dt.Rows[0]["DiaChi"].ToString();
            }
            else
                txtDiaChiNCC.Text = "";
        }
        public void AddPhieuNhap()
        {
            FrmChiTietPhieuNhap frm = new FrmChiTietPhieuNhap();
            frm.ShowDialog();
        }

        private void btnXCT_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuNhap frm = new FrmChiTietPhieuNhap(txtMaPN.Text);
            frm.ShowDialog();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String str = string.Format("MaPN like '%{0}' or TenNCC like '%{0}' or MaNV like '%{0}' ", txtTimKiem.Text);
            (dgvPhieuNhap.DataSource as DataTable).DefaultView.RowFilter = str;

        }
    }
}
