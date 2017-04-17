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
        }

        private void dtgPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPX.Text =  dtgPhieuXuat.Rows[e.RowIndex].Cells["MaPX"].Value.ToString();
            txtMaCH.Text = dtgPhieuXuat.Rows[e.RowIndex].Cells["MaCH"].Value.ToString();
            rtxtGhiChu.Text = dtgPhieuXuat.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
            txtMaNV.Text = dtgPhieuXuat.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
            dtpNgayXuat.Text = dtgPhieuXuat.Rows[e.RowIndex].Cells["NgayXuat"].Value.ToString();
            txtTenCH.Text = Bus.getTenCuaHang(txtMaCH.Text);
            txtTenNV.Text = Bus.getTenNhanVien(txtMaNV.Text);
            txtDiaChiCH.Text = Bus.getDiaChiCuaHang(txtMaCH.Text);
        }
        public void ClearToolBox()
        {
            txtMaCH.Text = "";
            txtMaNV.Text = "";
            txtMaPX.Text = "";
            txtTenCH.Text = "";
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
            txtMaCH.Enabled = bol;
            rtxtGhiChu.Enabled = bol;
            dtpNgayXuat.Enabled = bol;
            txtMaPX.Enabled = false;
            txtMaNV.Enabled = bol;
        } 

        private void btnViewMore_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuXuat frmChiTiet = new FrmChiTietPhieuXuat(txtMaPX.Text,1);
            frmChiTiet.Show();
        }

        public void addPhieuXuat()
        {
            FrmChiTietPhieuXuat frmChiTiet = new FrmChiTietPhieuXuat(Bus.getMaPXNext(),0);
            frmChiTiet.Show();
        }


        
    }
}
