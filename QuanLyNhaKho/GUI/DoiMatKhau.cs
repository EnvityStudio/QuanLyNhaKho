using QuanLyNhaKho.BUS;
using QuanLyNhaKho.DAO;
using QuanLyNhaKho.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhaKho.GUI
{
    public partial class DoiMatKhau : Form
    {
        private String MaNV;
        public DoiMatKhau(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            LoadData();
        }

       
        private void LoadData()
        {
            txtMaNV.Text = MaNV;
        }

        private NhanVien GetData(string MaNV)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien = Bus.GetDataNhanVien( MaNV);
            nhanVien.Password = txtValid.Text;
            return nhanVien;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if(txtMK.Text.Trim().Equals(txtValid.Text.Trim())==true)
            {
                int result = Bus.UpdatePassword(GetData(txtMaNV.Text));
                if (result > 0)
                {
                    MessageBox.Show("Thay đổi thành công");
                }
                else
                    MessageBox.Show("fail");
                this.Close();
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng nhau");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
