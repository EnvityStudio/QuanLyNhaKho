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
    public partial class UCNhomHang : UserControl
    {
        DataTable dt = Bus.GetListNhomHang();
        public UCNhomHang()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            dgv_NhomHang.DataSource = Bus.GetListNhomHang();
            panel_InforNhomHang.Enabled = false;
        }

        private void dgv_NhomHang_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgv_NhomHang.SelectedRows[0];
            txt_MaNhomHang.Text = dt.Cells["MaNhom"].Value.ToString();
            txt_TenNhom.Text = dt.Cells["TenNhom"].Value.ToString();
            txtSoLuong.Text = dt.Cells["SoLuong"].Value.ToString();
            rtxt_GhiChu.Text = dt.Cells["GhiChu"].Value.ToString();
        }

        public bool CheckEmpty(TextBox txt)
        {
            if (txt.Text.Trim() == "")
            {
                errorProviderHangHoa.SetError(txt, "Không được để trống");
                return false;
            }
            errorProviderHangHoa.SetError(txt, "");
            return true;

        }
        public bool CheckTextBox()
        {
            if (!CheckEmpty(txt_TenNhom))
            {
                MessageBox.Show("Có lỗi không thể thực hiện");
                return false;
            }
            return true;
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String str = string.Format("MaNhom like '%{0}' or TenNhom like '%{0}'", txtTimKiem.Text);
            (dgv_NhomHang.DataSource as DataTable).DefaultView.RowFilter = str;

        }
        public void ClearData()
        {
            rtxt_GhiChu.Text = "";
            txt_TenNhom.Text = "";
            txtSoLuong.Text = "0";
        }

        public void GetMaNext()
        {
            txt_MaNhomHang.Text = Bus.GetMaNhomHangNext();
            ClearData();
            panel_InforNhomHang.Enabled = true;

        }
        public NhomHang GetDataNhomHang()
        {
            string MaNhom, TenNhom, GhiChu;
            int SoLuong;
            MaNhom =txt_MaNhomHang.Text;
            TenNhom = txt_TenNhom.Text;
            GhiChu = rtxt_GhiChu.Text;
            SoLuong = int.Parse(txtSoLuong.Text);
            return new NhomHang(MaNhom, TenNhom, SoLuong, GhiChu);
        }
        public void AddNhomHang()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.AddNhomHang(GetDataNhomHang());
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

        public void UpdateNhomHang()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.UpdateNhomHang(GetDataNhomHang());
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
        public void DeleteNhomHang()
        {
            if (txt_MaNhomHang.Text.Equals("") || txt_MaNhomHang.Text == null)
            {
                return;
            }
            int result = Bus.DeleteNhomHang(GetDataNhomHang());
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
       public void EnablePanel()
        {
            panel_InforNhomHang.Enabled = true;
           
        }
    }
}
