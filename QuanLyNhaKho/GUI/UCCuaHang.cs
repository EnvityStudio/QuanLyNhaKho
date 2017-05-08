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
    public partial class UCCuaHang : UserControl
    {
        public UCCuaHang()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            dgv_CuaHang.DataSource = Bus.GetListCH();
            panel_InforCuaHang.Enabled = false;
        }
        public void GetMaCHNext()
        {
            txt_MaCH.Text = Bus.GetMaCHNext();
            ClearData();
            panel_InforCuaHang.Enabled = true;
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
            if (!CheckEmpty(txt_TenCH) || !CheckEmpty(txt_DiaChi) || !CheckEmpty(txtSDT))
            {
                MessageBox.Show("Có lỗi không thể thực hiện");
                return false;
            }
            return true;
        }
        public void AddCH()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.AddCH(GetDataCH());
            if (result > 0)
            {

                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void UpdateCH()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.UpdateCH(GetDataCH());
            if (result > 0)
            {

                MessageBox.Show("Sua Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Sua không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void EnablePanel()
        {
            panel_InforCuaHang.Enabled = true;
        }
        public void DeleteCH()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.DeleteCH(GetDataCH());
            if (result > 0)
            {

                MessageBox.Show("Delete Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Delete không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void ClearData()
        {
            txt_TenCH.Text = "";
            txt_DiaChi.Text = "";
            txtSDT.Text = "";
            rtxt_GhiChu.Text = "";
        }
        public CuaHang GetDataCH()
        {
            string MaCH, TenCH, DiaChi, SDT, GhiChu;
            MaCH = txt_MaCH.Text;
            TenCH = txt_TenCH.Text;
            DiaChi = txt_DiaChi.Text;
            SDT = txtSDT.Text;
            GhiChu = rtxt_GhiChu.Text;
            return new CuaHang(MaCH, TenCH, DiaChi, SDT, GhiChu);
        }
        private void dgv_CuaHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgv_CuaHang.SelectedRows[0];
            txt_MaCH.Text = dt.Cells["MaCH"].Value.ToString();
            txt_TenCH.Text = dt.Cells["TenCH"].Value.ToString();
            txt_DiaChi.Text = dt.Cells["DiaChi"].Value.ToString();
            txtSDT.Text = dt.Cells["SDT"].Value.ToString();
            rtxt_GhiChu.Text = dt.Cells["GhiChu"].Value.ToString();
        }
    }
}
