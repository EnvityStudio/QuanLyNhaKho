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
        private bool action = true;
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
       public void ClearData()
        {
            txt_TenNCC.Text = "";
            txt_DiaChi.Text = "";
            txtSDT.Text = "";
            rtxt_GhiChu.Text = "";
        }

        private void dgv_NhaCungCap_Click(object sender, EventArgs e)
        {
            try
            {
                if(action ==false)
                { return;
                }
                DataGridViewRow dt = dgv_NhaCungCap.SelectedRows[0];
                txt_MaNCC.Text = dt.Cells["MaNCC"].Value.ToString();
                txt_TenNCC.Text = dt.Cells["TenNCC"].Value.ToString();
                txt_DiaChi.Text = dt.Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dt.Cells["SDT"].Value.ToString();
                rtxt_GhiChu.Text = dt.Cells["GhiChu"].Value.ToString();
            }
            catch(Exception err)
            {
                Console.Write(err.Message);
            }
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
            action = false;
            panel_InforNCC.Enabled = true;
        }
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String str = string.Format("MaNCC like '%{0}' or TenNCC like '%{0}' or DiaChi like '%{0}' ", txtTimKiem.Text);
            (dgv_NhaCungCap.DataSource as DataTable).DefaultView.RowFilter = str;
        }
        public void AddNCC()
        {
            action = false;
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.AddNCC(GetDataNCC());
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
        public void UpdateNCC()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.UpdateNCC(GetDataNCC());
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
        public void DeleteNCC()
        {
            if (txt_MaNCC.Text.Equals("") || txt_MaNCC.Text == null)
            {
                return;
            }
            int result = Bus.DeleteNCC(GetDataNCC());
            if (result > 0)
            {
                MessageBox.Show("Xoa Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
            }
            else
            {
                MessageBox.Show("Xoa không thành công", "Thông báo", MessageBoxButtons.OK);

            }
        }
    }
}
