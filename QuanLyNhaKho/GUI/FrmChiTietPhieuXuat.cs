using QuanLyNhaKho.BUS;
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
    public partial class FrmChiTietPhieuXuat : Form
    {
        private string maPX;
        private DataTable dataTableChiTiet;
        private int tongTien = 0;
        private int type;  
        // type = 0 : add  new
        // type = 1 : view more
        public FrmChiTietPhieuXuat(string maPX,int type)
        {
            InitializeComponent();
            this.maPX = maPX;
            this.type = type;
            LoadData();
            dataTableChiTiet = new DataTable();
            initDataTableChiTiet(dataTableChiTiet);
        }
        private void LoadData()
        {
            if (maPX != null)
            {
                if (type == 0)
                {
                  
                }
                else if(type == 1)
                {
                    dtgChiTietPhieuXuat.DataSource = Bus.getChiTietPhieuXuat(maPX);
                }

            }
                txtMaPX.Text = maPX;
        }

        public void EnableToolBox(bool bol)
        {
            txtTenNV.Enabled = false;
            txtMaCH.Enabled = bol;
            rtxtGhiChu.Enabled = bol;
            dtpNgayXuat.Enabled = bol;
            txtMaPX.Enabled = false;
            txtMaNV.Enabled = bol;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkChiTietPXInvalid(txtMaHH.Text))
                return;
            tongTien += int.Parse(txtThanhTien.Text);
            txtTongTien.Text = tongTien.ToString();
            DataRow newChiTiet = dataTableChiTiet.NewRow();
            ChiTietPhieuXuat chiTiet = getChiTietFormFRM();
            newChiTiet["MaPX"] = chiTiet.MaPX;
            newChiTiet["MaHH"] = chiTiet.MaHH;
            newChiTiet["SoLuong"] = chiTiet.SoLuong;
            newChiTiet["DonGia"] = txtDonGia.Text;
            newChiTiet["ThanhTien"] = txtThanhTien.Text;
            newChiTiet["GhiChu"] = rtxtGhiChu.Text;
            dataTableChiTiet.Rows.Add(newChiTiet);
            dtgChiTietPhieuXuat.DataSource = dataTableChiTiet;
        }

        private bool checkChiTietPXInvalid(string maHH)
        {
            foreach(DataRow dr in dataTableChiTiet.Rows)
            {
                if (dr["MaHH"].ToString().Contains(maHH))
                {
                    return false ;
                }
            }
            if (txtTenHH == null || txtTenHH.Text == "")
                return false;
            return true;
        }
      

        private void initDataTableChiTiet(DataTable dt)
        {
            DataColumn dc = new DataColumn("MaPX", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("MaHH", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("SoLuong", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("DonGia", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("ThanhTien", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("GhiChu", typeof(String));
            dt.Columns.Add(dc);
        }

        private ChiTietPhieuXuat getChiTietFormFRM()
        {
            if(txtSoLuong.Text == "")
            {
                txtSoLuong.Text = "0";
            }
            ChiTietPhieuXuat chiTiet = new ChiTietPhieuXuat()
            {
                MaPX = maPX,
                MaHH = txtMaHH.Text,
                SoLuong = int.Parse(txtSoLuong.Text),
                ThanhTien = float.Parse(txtThanhTien.Text),
                GhiChu = rtxtGhiChu.Text
            };
            return chiTiet;
        }

        private void txtMaHH_TextChanged(object sender, EventArgs e)
        {
            if (txtMaHH.Text != null)
            {
                DataTable dt = Bus.SearchHangHoa(txtMaHH.Text.ToUpper());
                if (dt.Rows.Count > 0) {
                    txtTenHH.Text = dt.Rows[0]["TenHang"].ToString();
                    txtDonGia.Text = dt.Rows[0]["GiaXuat"].ToString();
                }
                else
                {
                    txtTenHH.Text = "";
                    txtDonGia.Text = "";
                }
            }
        }
        private void setThanhTien()
        {
            if (txtSoLuong.Text == "" || txtSoLuong.Text == null || txtDonGia.Text == null || txtDonGia.Text == "")
            {
                return;
            }
            int soLuong = int.Parse(txtSoLuong.Text);
            float donGia = float.Parse(txtDonGia.Text);
            txtThanhTien.Text = (soLuong * donGia).ToString();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            setThanhTien();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maHH = txtMaHH.Text;
            
            for(int i = 0; i < dataTableChiTiet.Rows.Count; i++)
            {
                if(dataTableChiTiet.Rows[i]["MaHH"].ToString().Contains(maHH))
                {
                    dataTableChiTiet.Rows.RemoveAt(i);
                    return;
                }
            }
            dtgChiTietPhieuXuat.DataSource = dataTableChiTiet;
        }

        private void dtgChiTietPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHH.Text =  dtgChiTietPhieuXuat.Rows[e.RowIndex].Cells["MaHH"].Value.ToString();
            txtSoLuong.Text = dtgChiTietPhieuXuat.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtThanhTien.Text = dtgChiTietPhieuXuat.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            txtDonGia.Text = dtgChiTietPhieuXuat.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            rtxtGhiChu.Text = dtgChiTietPhieuXuat.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuat chiTiet;
            PhieuXuat phieuXuat = new PhieuXuat()
            {
                MaPX = txtMaPX.Text,
                MaNV = txtMaNV.Text,
                MaCH = txtMaCH.Text,
                ChietKhau = 0,
                ThanhTien = 0,
                TongTien = 0,
                GhiChu = rtxtGhiChu.Text
            };

            int res = Bus.AddPhieuXuat(phieuXuat);
            if(res <= 0)
            {
                return;
            }
            foreach (DataRow dr in dataTableChiTiet.Rows)
            {
                chiTiet = new ChiTietPhieuXuat()
                {
                    MaHH = dr["MaHH"].ToString(),
                    MaPX = dr["MaPX"].ToString(),
                    SoLuong = int.Parse(dr["SoLuong"].ToString()),
                    GhiChu = dr["GhiChu"].ToString()
                };
               int result =  Bus.AddChiTietPhieuXuat(chiTiet);
               if(result <= 0)
               {
                    MessageBox.Show("Không thành công!" ,"Thông báo",MessageBoxButtons.OK);
                    return ;
               }
            }
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
        }
    }
}
