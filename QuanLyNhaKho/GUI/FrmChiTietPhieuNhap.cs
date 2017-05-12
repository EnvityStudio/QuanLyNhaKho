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
    public partial class FrmChiTietPhieuNhap : Form
    {
        private string MaPN;
        private int tongTien = 0;
        private DataTable dataTableChiTiet;
        private int type;
        public FrmChiTietPhieuNhap(string MaPN, int type)
        {
            InitializeComponent();
            this.MaPN = MaPN;
            this.type = type;
            LoadData();
            dataTableChiTiet = new DataTable();
            initDataTableChiTiet(dataTableChiTiet);
        }
        public void LoadData()
        {

            if (MaPN != null)
            {
                if (type == 0)
                {
                    LoadCombobox();
                }
                else if (type == 1)
                {

                    // dgvChiTietPhieuNhap.DataSource = Bus.GetChiTietPhieuNhap(MaPN);
                    LoadData1();
                    LoadCombobox();

                }

            }
            txtMaPN.Text = MaPN;
        }
        private void LoadData1()
        {
            dgvChiTietPhieuNhap.DataSource = Bus.GetChiTietPhieuNhap(MaPN);
            dgvChiTietPhieuNhap.Columns["MaPN"].HeaderText = "Ma Phieu Nhap";
        }
        private void initDataTableChiTiet(DataTable dt)
        {



            DataColumn dc = new DataColumn("MaPN", typeof(String));
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
        public void LoadCombobox()
        {
            cbbTenNCC.DataSource = Bus.GetListTenNCC();
            cbbTenNCC.DisplayMember = "TenNCC";
            cbbTenNCC.ValueMember = "MaNCC";
            // 
            cbbTenHH.DataSource = Bus.GetListTenHH();
            cbbTenHH.DisplayMember = "TenHang";
            cbbTenHH.ValueMember = "MaHH";

        }

        private void cbbTenNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            string MaNCC = cbbTenNCC.SelectedValue.ToString();
            DataTable dt = Bus.SearchNCC(MaNCC);
            if (dt.Rows.Count > 0)
            {

                txtDiaChiNCC.Text = dt.Rows[0]["DiaChi"].ToString();
            }
            else
                txtDiaChiNCC.Text = "";
        }
        private void SetThanhTien()
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
            SetThanhTien();
        }
        private string MaHH()
        {
            string MaHH = cbbTenHH.SelectedValue.ToString();
            return MaHH;
        }

        private void cbbTenHH_SelectedValueChanged(object sender, EventArgs e)
        {

            if (MaHH() != null)
            {
                DataTable dt = Bus.SearchHangHoa(MaHH().ToUpper());
                if (dt.Rows.Count > 0)
                {
                    
                    txtDonGia.Text = dt.Rows[0]["GiaXuat"].ToString();
                }
                else
                {
                    
                    txtDonGia.Text = "";
                }
            }
        }
        private void ClearData()
        {
            txtSoLuong.Text = "0";
        }
        private bool CheckInvalid(string MaHH)
        {
            foreach (DataRow dr in dataTableChiTiet.Rows)
            {
                if (dr["MaHH"].ToString().Contains(MaHH))
                {
                    return false;
                }
            }
            if (cbbTenHH.SelectedValue == null)
                return false;
            return true;
        }
        private ChiTietPhieuNhap GetDataChiTietPN()
        {
            if (txtSoLuong.Text == "")
            {
                txtSoLuong.Text = "0";
            }
            ChiTietPhieuNhap chiTiet = new ChiTietPhieuNhap()
            {
                MaPN = MaPN,
                MaHH = MaHH(),
                SoLuong = int.Parse(txtSoLuong.Text),
                ThanhTien = float.Parse(txtThanhTien.Text),
                GhiChu = rtxtGhiChu.Text
            };
            return chiTiet;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInvalid(MaHH()))
                return;
            if (txtSoLuong.Text == null || txtSoLuong.Text == "0")
            {

                MessageBox.Show("Nhập số lượng", "Thông báo!", MessageBoxButtons.OK);
                return;
            }
            tongTien += int.Parse(txtThanhTien.Text);
            txtTongTien.Text = tongTien.ToString();
            DataRow newChiTiet = dataTableChiTiet.NewRow();
            ChiTietPhieuNhap chiTiet = GetDataChiTietPN();
            newChiTiet["MaPN"] = chiTiet.MaPN;
            newChiTiet["MaHH"] = chiTiet.MaHH;
            newChiTiet["SoLuong"] = chiTiet.SoLuong;
            newChiTiet["DonGia"] = txtDonGia.Text;
            newChiTiet["ThanhTien"] = txtThanhTien.Text;
            newChiTiet["GhiChu"] = rtxtGhiChu.Text;
            dataTableChiTiet.Rows.Add(newChiTiet);
            dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap chiTiet;
            PhieuNhap phieuNhap = new PhieuNhap()
            {
                MaPN = txtMaPN.Text.ToUpper(),
                MaNV = Config.CURRENT_NHANVIEN,
                //      MaCH = txtMaCH.Text.ToUpper(),
                MaNCC = cbbTenNCC.SelectedValue.ToString(),
                NgayNhap = dtpNgayNhap.Value,
                ChietKhau = 0,
                ThanhTien = 0,
                TongTien = 0,
                GhiChu = rtxtGhiChu.Text
            };

            int res = Bus.AddPhieuNhap(phieuNhap);
            if (res <= 0)
            {

                MessageBox.Show("Không thêm phiếu xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            foreach (DataRow dr in dataTableChiTiet.Rows)
            {
                chiTiet = new ChiTietPhieuNhap()
                {
                    MaHH = dr["MaHH"].ToString(),
                    MaPN = dr["MaPN"].ToString(),
                    SoLuong = int.Parse(dr["SoLuong"].ToString()),
                    GhiChu = dr["GhiChu"].ToString(),
                    ThanhTien=int.Parse(dr["ThanhTien"].ToString()),
                    DonGia = int.Parse(dr["DonGia"].ToString())
                };
                int result = Bus.AddChiTietPhieuNhap(chiTiet);
                if (result <= 0)
                {
                    MessageBox.Show("Không them CT thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            MessageBox.Show("Thêm CT thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void dgvChiTietPhieuNhap_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgvChiTietPhieuNhap.SelectedRows[0];
            //cbbTenHH.Text=dt.Cells[""]
        }
    }
}
