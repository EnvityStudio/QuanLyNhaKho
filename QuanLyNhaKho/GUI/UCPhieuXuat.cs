using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaKho.BUS;
using QuanLyNhaKho.VO;
using QuanLyNhaKho.DAO;

namespace QuanLyNhaKho.GUI
{
    public partial class UCPhieuXuat : UserControl
    {
        public UCPhieuXuat()
        {
            InitializeComponent();
            LoadData();
            EnableToolBox(false);
        }
        public void LoadData()
        {
            dtgPhieuXuat.DataSource = Bus.getListPhieuXuat();
            cbb_TenCH.DataSource = Bus.GetListTenCH();
            cbb_TenCH.ValueMember = "MaCH";
            cbb_TenCH.DisplayMember = "TenCH";
        }
        
        public void ClearToolBox()
        {
       //     txtMaCH.Text = "";
            //txtMaNV.Text = "";
            txtMaPX.Text = "";
       //     txtTenCH.Text = "";
            txtTenNV.Text = "";
            rtxtGhiChu.Text = "";
        }
        
        public void setMaPXToToolBox()
        {
            txtMaPX.Text = Bus.getMaPXNext();
        }

        public void EnableToolBox(bool bol)
        {
            txtTenNV.Enabled = false;
            rtxtGhiChu.Enabled = bol;
            dtpNgayXuat.Enabled = bol;
            txtMaPX.Enabled = false;
        } 

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuXuat frmChiTiet = new FrmChiTietPhieuXuat(txtMaPX.Text);
            frmChiTiet.Show();
        }

        public void addPhieuXuat()
        {
            FrmChiTietPhieuXuat frmChiTiet = new FrmChiTietPhieuXuat();
            frmChiTiet.ShowDialog();
            LoadData();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String str = string.Format("MaPX like '%{0}' or MaCH like '%{0}' or MaNV like '%{0}' ", txtTimKiem.Text);
            (dtgPhieuXuat.DataSource as DataTable).DefaultView.RowFilter = str;

        }
        public void DeletePhieuXuat()
        {
            int result = Dao.DeletePX(txtMaPX.Text);
            if (result < 0)
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

        private void dtgPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dt = dtgPhieuXuat.SelectedRows[0];
                txtMaPX.Text = dt.Cells["MaPX"].Value.ToString();
               
                lb_TongTien.Text = dt.Cells["TongTien"].Value.ToString();
               
                dtpNgayXuat.Text = dt.Cells["NgayNhap"].Value.ToString();
                rtxtGhiChu.Text = dt.Cells["GhiChu"].Value.ToString();
                cbb_TenCH.Text = dt.Cells["TenNCC"].Value.ToString();
                cbb_TenCH.SelectedValue = dt.Cells["MaNCC"].Value.ToString();
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
    }
}
