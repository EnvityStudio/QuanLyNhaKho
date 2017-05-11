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
    public partial class UCNhaCungCap : UserControl
    {
        public UCNhaCungCap()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dgv_NhaCungCap.DataSource = Bus.GetListNCC();
            panel_InforNCC.Enabled = false;
        }
        public NhaCungCap GetDataNCC()
        {
            string MaNCC, TenNCC, DiaChi, SDT, GhiChu;
            MaNCC = txt_MaNCC.Text;
            TenNCC = txt_TenNCC.Text;
            DiaChi = txt_DiaChi.Text;
            SDT = txtSDT.Text;
            GhiChu = rtxt_GhiChu.Text;
            return new NhaCungCap(MaNCC, TenNCC, DiaChi, SDT, GhiChu);
        }
        private void ClearData()
        {
            txt_TenNCC.Text = "";
            txt_DiaChi.Text = "";
            txtSDT.Text = "";
            rtxt_GhiChu.Text = "";
        }

        private void dgv_NhaCungCap_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgv_NhaCungCap.SelectedRows[0];
            txt_MaNCC.Text = dt.Cells["MaNCC"].Value.ToString();
            txt_TenNCC.Text = dt.Cells["TenNCC"].Value.ToString();
            txt_DiaChi.Text = dt.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dt.Cells["SDT"].Value.ToString();
            rtxt_GhiChu.Text = dt.Cells["GhiChu"].Value.ToString();
        }
        public bool CheckEmpty(TextBox txt)
        {
            if (txt.Text.Trim() == "")
            {
                errorProvider1.SetError(txt, "Không được để trống");
                return false;
            }
            errorProvider1.SetError(txt, "");
            return true;
        }
        public bool CheckTextBox()
        {
            if (!CheckEmpty(txt_TenNCC) || !CheckEmpty(txt_DiaChi) || !CheckEmpty(txtSDT))
            {
                MessageBox.Show("Có lỗi không thể thực hiện");
                return false;
            }
            return true;
        }
        public void GetMaNCCNext()
        {
            txt_MaNCC.Text = Bus.GetMaNCCNext();
            ClearData();
            panel_InforNCC.Enabled = true;

        }
        public void EnablePanel()
        {
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
         
        }
        public void AddNCC()
        {
         }
        public void UpdateNCC()
        {

        }
        public void DeleteNCC()
        {
        }
    }
}
