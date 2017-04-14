﻿using QuanLyNhaKho.BUS;
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

namespace QuanLyNhaKho
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
            var userName = txtUserName.Text;
            var matKhau = txtPassword.Text;
            NhanVien nhanVien = new NhanVien()
            {
                UserName = userName,
                MatKhau = matKhau
            };
            var isExist = Bus.CheckAccount(nhanVien);
            if (isExist)
            {
                this.Hide();
                var main = new toolstrip_Them();
                main.Closed += (s, args) => this.Close();
                main.Show();
            } else
            {
                MessageBox.Show("Fail");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
