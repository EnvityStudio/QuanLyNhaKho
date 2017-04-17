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
        private Bitmap img = Properties.Resources.delete;

        public toolstrip_Them()
        {
            InitializeComponent();
            ucPhieuXuat = new UCPhieuXuat();
        
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
            if (tabControlHome.SelectedTab.Name == "UCPhieuXuat")
            {
                Config.TAB_CURRENT = Config.TAB_PHIEU_XUAT;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetTabCurrent();
            Config.ACTION = Config.ADD;
            if(Config.TAB_CURRENT == Config.TAB_PHIEU_XUAT)
            {
                ucPhieuXuat.addPhieuXuat();
            }
        }
    }
}
