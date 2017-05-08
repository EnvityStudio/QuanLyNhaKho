using QuanLyNhaKho.BUS;
using QuanLyNhaKho.DAO;
using QuanLyNhaKho.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaKho
{
    public partial class toolstrip_Them : Form
    {
        private UCPhieuXuat ucPhieuXuat;
        private UCNhanVien ucNhanVien;
        private UCNhomHang ucNhomHang;
        private UCCuaHang ucCuaHang;
        private UCHangHoa ucHangHoa;
        private UCNhaCungCap ucNhaCungCap;


        private Bitmap img = Properties.Resources.delete;

        public toolstrip_Them()
        {
            InitializeComponent();
            ucPhieuXuat = new UCPhieuXuat();
            ucNhanVien = new UCNhanVien();
            ucHangHoa = new UCHangHoa();
            ucNhomHang = new UCNhomHang();
            ucCuaHang = new UCCuaHang();
            ucNhaCungCap = new UCNhaCungCap();


        }

        public void AddNewTab(UserControl userControl)
        {


            foreach (TabPage tab in tabControlHome.TabPages)
            {
                if (tab.Name == userControl.Name)
                {
                    tabControlHome.SelectedTab = tab;
                    return;
                }
            }

            userControl.Dock = DockStyle.Fill;
            TabPage newTab = new TabPage(userControl.AccessibleDescription + "         ");//Create new tabpage , set name tab
            newTab.Controls.Add(userControl);
            newTab.Name = userControl.Name;
            tabControlHome.TabPages.Add(newTab);
            tabControlHome.SelectedTab = newTab;
        }

        private void SetTabCurrent()
        {
            if (tabControlHome.TabPages.Count == 0)
            {
                return;
            }
            if (tabControlHome.SelectedTab.Name == "UCPhieuXuat")
            {
                Config.TAB_CURRENT = Config.TAB_PHIEU_XUAT;
            }
            else if (tabControlHome.SelectedTab.Name == "UCNhanVien")
            {
                Config.TAB_CURRENT = Config.TAB_NHANVIEN;
            }
            else if (tabControlHome.SelectedTab.Name == "UCNhomHang")
            {
                Config.TAB_CURRENT = Config.TAB_NHOMHANG;
            }
            else if (tabControlHome.SelectedTab.Name == "UCNhaCungCap")
            {
                Config.TAB_CURRENT = Config.TAB_NHACUNGCAP;
            }
            else if (tabControlHome.SelectedTab.Name == "UCCuaHang")
            {
                Config.TAB_CURRENT = Config.TAB_CUAHANG;
            }
            else if (tabControlHome.SelectedTab.Name == "UCHangHoa")
            {
                Config.TAB_CURRENT = Config.TAB_HANGHOA;
            }
        }
        private void btn_PhieuXuat_Click(object sender, EventArgs e)
        {
            AddNewTab(ucPhieuXuat);
        }

        private void tabControlHome_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != 0)
            {
                e.Graphics.DrawImage(img, new Point(e.Bounds.Right - 18, e.Bounds.Top + 1));
                e.Graphics.DrawString(this.tabControlHome.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 4);
                e.DrawFocusRectangle();
            }
        }

        private void tabControlHome_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle r = tabControlHome.GetTabRect(this.tabControlHome.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location))
            {

                this.tabControlHome.TabPages.Remove(this.tabControlHome.SelectedTab);
            }
        }



        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            AddNewTab(ucNhanVien);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Config.ACTION = Config.ADD;
            if (Config.TAB_CURRENT == Config.TAB_PHIEU_XUAT)
            {
                ucPhieuXuat.addPhieuXuat();
            }
            else if (Config.TAB_CURRENT == Config.TAB_NHANVIEN)
            {
                ucNhanVien.SetMaNVNext();

            }
            else if (Config.TAB_CURRENT == Config.TAB_NHOMHANG)
            {
                ucNhomHang.GetMaNext();
            }
            else if (Config.TAB_CURRENT == Config.TAB_NHACUNGCAP)
            {
                ucNhaCungCap.GetMaNCCNext();
            }
            else if (Config.TAB_CURRENT == Config.TAB_CUAHANG)
            {
                ucCuaHang.GetMaCHNext();
            }
            else if (Config.TAB_CURRENT == Config.TAB_HANGHOA)
            {
                ucHangHoa.GetMaHHNext();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Config.ACTION = Config.DELETE;
            if (Config.TAB_CURRENT == Config.TAB_NHANVIEN)
            {
                ucNhanVien.DeleteNhanVien();
            }
            else if (Config.TAB_CURRENT == Config.TAB_NHOMHANG)
            {
                ucNhomHang.DeleteNhomHang();
            }
            else if (Config.TAB_CURRENT == Config.TAB_NHACUNGCAP)
            {
                ucNhaCungCap.DeleteNCC();
            }
            else if (Config.TAB_CURRENT == Config.TAB_CUAHANG)
            {
                ucCuaHang.DeleteCH();
            }
            else if (Config.TAB_CURRENT == Config.TAB_HANGHOA)
            {
                ucHangHoa.DeleteHH();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Config.ACTION = Config.EDIT;
            if (Config.TAB_CURRENT == Config.TAB_NHANVIEN)
            {
                ucNhanVien.EnablePanel();
            }
            else if (Config.TAB_CURRENT == Config.TAB_NHOMHANG)
            {
                ucNhomHang.EnablePanel();
            }
            else if (Config.TAB_CURRENT == Config.TAB_NHACUNGCAP)
            {
                ucNhaCungCap.EnablePanel();
            }
            else if (Config.TAB_CURRENT == Config.TAB_CUAHANG)
            {
                ucCuaHang.EnablePanel();
            }
            else if (Config.TAB_CURRENT == Config.TAB_HANGHOA)
            {
                ucHangHoa.EnablePanel();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            if (Config.ACTION == Config.ADD)
            {
                if (Config.TAB_CURRENT == Config.TAB_NHANVIEN)
                {
                    ucNhanVien.AddNhanVien();

                }
                else if (Config.TAB_CURRENT == Config.TAB_NHOMHANG)
                {
                    ucNhomHang.AddNhomHang();
                }
                else if (Config.TAB_CURRENT == Config.TAB_NHACUNGCAP)
                {
                    ucNhaCungCap.AddNCC();
                }
                else if (Config.TAB_CURRENT == Config.TAB_CUAHANG)
                {
                    ucCuaHang.AddCH();
                }
                else if (Config.TAB_CURRENT == Config.TAB_HANGHOA)
                {
                    ucHangHoa.AddHH();
                }
            }
            if (Config.ACTION == Config.EDIT)
            {
                if (Config.TAB_CURRENT == Config.TAB_NHANVIEN)
                {
                    ucNhanVien.UpdateNhanVien();

                }
                else if (Config.TAB_CURRENT == Config.TAB_NHOMHANG)
                {
                    ucNhomHang.UpdateNhomHang();
                }
                else if (Config.TAB_CURRENT == Config.TAB_NHACUNGCAP)
                {
                    ucNhaCungCap.UpdateNCC();
                }
                else if (Config.TAB_CURRENT == Config.TAB_CUAHANG)
                {
                    ucCuaHang.UpdateCH();
                }
                else if (Config.TAB_CURRENT == Config.TAB_HANGHOA)
                {
                    ucHangHoa.UpdateHH();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hủy thao tác", "Thông báo", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                if (Config.TAB_CURRENT == Config.TAB_NHANVIEN)
                {
                    ucNhanVien.ClearData();
                }

            }
        }

        private void EnableButton()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btn_NhomHang_Click(object sender, EventArgs e)
        {
            AddNewTab(ucNhomHang);
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            AddNewTab(ucNhaCungCap);
        }

        private void btn_CuaHang_Click(object sender, EventArgs e)
        {
            AddNewTab(ucCuaHang);
        }

        private void btn_HangHoa_Click(object sender, EventArgs e)
        {
            AddNewTab(ucHangHoa);
        }
     

        private void btn_XuatHang_Click(object sender, EventArgs e)
        {
            FrmChiTietPhieuXuat frmChiTietPhieuXuat = new FrmChiTietPhieuXuat(Bus.getMaPXNext(),0);
            frmChiTietPhieuXuat.Show();
        }
    }
}
