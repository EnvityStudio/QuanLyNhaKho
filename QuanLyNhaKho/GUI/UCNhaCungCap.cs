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
        }

        private void dgv_NhaCungCap_Click(object sender, EventArgs e)
        {
        }
        public bool CheckEmpty(TextBox txt)
        {
        
        }
        public bool CheckTextBox()
        {
        }
        public void GetMaNCCNext()
        {
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
