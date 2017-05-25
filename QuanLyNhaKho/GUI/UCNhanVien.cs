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
    public partial class UCNhanVien : UserControl
    {
        private bool action =true;
        public UCNhanVien()
        {
            InitializeComponent();
            LoadData();
            pn_Info.Enabled = false;
            ClearData();
        }
        private void UCNhanVien_Load(object sender, EventArgs e)
        {
        }
        public void LoadData()
        {
           
            dgv_NhanVien.DataSource =  Bus.GetListNhanVien();
            dgv_NhanVien.Columns["MaNV"].HeaderText = "Mã NV";
            dgv_NhanVien.Columns["HoTen"].HeaderText = "Họ Tên";
            dgv_NhanVien.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dgv_NhanVien.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dgv_NhanVien.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dgv_NhanVien.Columns["SDT"].HeaderText = "Số ĐT";
        }
        public void EnablePanel()
        {
            
            pn_Info.Enabled = true;
        }
        public void ClearData()
        {
           
            txtHoTen.Text = "";
            txtMK.Text = "";
            txtQueQuan.Text = "";
            txtSoDT.Text = "";
            txtTaiKhoan.Text = "";
            
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DataTable dataTableEmployee = Bus.GetListNhanVien();
            String str = string.Format("HoTen like '%{0}%' or MaNV like '%{0}%' or DiaChi like '%{0}%' or GioiTinh like '%{0}%'", txtTimKiem.Text);
            (dgv_NhanVien.DataSource as DataTable).DefaultView.RowFilter = str;
        }
 

        private void dgv_NhanVien_Click(object sender, EventArgs e)
        {
            if (action == false)
            {
                return;
            }
            else
            {
                try
                {
                    DataGridViewRow dtRow = dgv_NhanVien.SelectedRows[0];
                    txtMaNV.Text = dtRow.Cells["MaNV"].Value.ToString();
                    txtHoTen.Text = dtRow.Cells["HoTen"].Value.ToString();
                    txtQueQuan.Text = dtRow.Cells["DiaChi"].Value.ToString();
                    txtSoDT.Text = dtRow.Cells["SDT"].Value.ToString();
                    txtTaiKhoan.Text = dtRow.Cells["UserName"].Value.ToString();
                    txtMK.Text = dtRow.Cells["Password"].Value.ToString();
                    dtp_NgaySinh.Text = dtRow.Cells["NgaySinh"].Value.ToString();
                    if (dtRow.Cells["GioiTinh"].Value.ToString().Contains("Nam"))
                    {
                        rdGTNam.Checked = true;
                        rdGTNu.Checked = false;
                    }
                    else
                    {
                        rdGTNu.Checked = true;
                        rdGTNam.Checked = false;
                    }
                }
                catch(Exception err)
                {
                    Console.Write(err.Message);
                }
            }
        }
        public void SetMaNVNext()
        {
            ClearData();
            txtMaNV.Text = Bus.GetMaNVNext();
            txtMaNV.Enabled = false;
            pn_Info.Enabled = true;
            action = false;
        }
        public bool CheckTextBox()
        {
            if (!CheckEmpty(txtHoTen) || !CheckEmpty(txtQueQuan) || !CheckEmpty(txtSoDT) || !CheckEmpty(txtTaiKhoan) || !CheckEmpty(txtMK))
            {
                MessageBox.Show("Có lỗi không thể thực hiện");
                return false;
            }
            return true;
        }
        public bool CheckEmpty(TextBox txt)
        {
            if(txt.Text.Trim()=="")
            {
                errorProvider.SetError(txt, "Không được để trống");
                return false;
            }
            errorProvider.SetError(txt, "");
            return true;
        }

        public void UpdateNhanVien()
        {
            if (!CheckTextBox())
            {
                return;
            }
            int result = Bus.UpdateNhanVien(GetDataNhanVien());
            if (result > 0)
            {
                MessageBox.Show("Sửa Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
                pn_Info.Enabled = false;
            }
            else
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void DeleteNhanVien()
        {
            if (txtMaNV.Text.Equals("") || txtMaNV.Text == null)
            {
                return;
            }
            int result = Bus.DeleteNhanVien(GetDataNhanVien());
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
                pn_Info.Enabled = false;
                
            }
            else
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public void AddNhanVien()
        {
            if(!CheckTextBox())
            {
                return;
            }
            int result = Bus.AddNhanVien(GetDataNhanVien());
            if (result > 0)
            {
                MessageBox.Show("Thêm Thành Công", "Thông báo", MessageBoxButtons.OK);
                ClearData();
                LoadData();
                pn_Info.Enabled = false;
            }
            else {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
        public NhanVien GetDataNhanVien()
        {
            string MaNV, HoTen, GioiTinh, DiaChi, SDT, UserName, Password;
            DateTime NgaySinh;
            MaNV = txtMaNV.Text;
            HoTen = txtHoTen.Text;
            if (rdGTNam.Checked)
            {
                GioiTinh = "Nam";
            }
            else GioiTinh = "Nu";
            DiaChi = txtQueQuan.Text;
            SDT = txtSoDT.Text;
            UserName = txtTaiKhoan.Text;
            Password = txtMK.Text;
            NgaySinh = (DateTime)dtp_NgaySinh.Value;
            return new NhanVien(MaNV, HoTen,NgaySinh, GioiTinh, DiaChi, SDT, UserName, Password);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ClearData();
        }

    
    }
}
