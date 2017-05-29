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
        private int action;
        private int status;
        private int deleteMoney;
   
        public FrmChiTietPhieuNhap(string MaPN)
        {
            InitializeComponent();
            this.MaPN = MaPN;
            dataTableChiTiet = new DataTable();
            txtMaPN.Text = MaPN;
            LoadDataImportDetailByID();
        }
        public FrmChiTietPhieuNhap()
        {
            InitializeComponent();
            dataTableChiTiet = new DataTable();
            LoadCombobox();
            initDataTableChiTiet(dataTableChiTiet);
            txtMaPN.Text = Bus.GetMaPNNext();
            txtTenNV.Text = Bus.getTenNhanVien(Config.CURRENT_NHANVIEN);
        }

      
        private void LoadDataImportDetailByID()
        {
            dgvChiTietPhieuNhap.DataSource = Bus.GetChiTietPhieuNhap(MaPN);
            dataTableChiTiet = (DataTable)dgvChiTietPhieuNhap.DataSource;
            dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
            //dgvChiTietPhieuNhap.Columns["MaPN"].HeaderText = "Ma Phieu Nhap";
            txtTongTien.Text = Bus.GetTongTienPhieuNhap(MaPN).ToString();
        }
        private void initDataTableChiTiet(DataTable dt)
        {



            DataColumn dc = new DataColumn("MaPN", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("MaHH", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("TenHang", typeof(String));
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
            int donGia = int.Parse(txtDonGia.Text);
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
                    
                  //  txtDonGia.Text = dt.Rows[0]["GiaXuat"].ToString();
                }
                else
                {
                    
                    txtDonGia.Text = "";
                }
            }
        }
        private void ClearData()
        {
            txtSoLuong.Text = "1";
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
                MaPN = txtMaPN.Text,
                MaHH = MaHH(),
                SoLuong = int.Parse(txtSoLuong.Text),
                ThanhTien = float.Parse(txtThanhTien.Text),
                GhiChu = rtxtGhiChu.Text
            };
            return chiTiet;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

           
            if (tongTien > 1700000000)
            {
                MessageBox.Show("Số tiền của bạn quá cao");
             
            }
            else
            {
                if (action == 1)
                {
                    foreach (DataRow dr in dataTableChiTiet.Rows)
                    {
                        if (dr["MaHH"].ToString() == cbbTenHH.SelectedValue.ToString())
                        {

                            int quantity = int.Parse(txtSoLuong.Text);
                            int b = int.Parse((int.Parse(txtDonGia.Text) * (quantity - int.Parse(dr["SoLuong"].ToString()))).ToString());
                            if ((quantity - int.Parse(dr["SoLuong"].ToString())) > 0)
                            {
                                tongTien = tongTien + b;
                            }
                            else
                            {
                                tongTien = tongTien - (int.Parse(txtDonGia.Text) * (int.Parse(dr["SoLuong"].ToString()) - quantity));
                            }
                            dr["SoLuong"] = quantity;
                            dr["ThanhTien"] = quantity * int.Parse(txtDonGia.Text);
                            btnAdd.Text = "Thêm";
                        }
                    }
                }
                else
                {
                    int a = 0;
                    foreach (DataRow dr in dataTableChiTiet.Rows)
                    {
                        if (dr["MaHH"].ToString() == cbbTenHH.SelectedValue.ToString())
                        {
                            a = 1;
                            int quantity = int.Parse(txtSoLuong.Text);
                            dr["SoLuong"] = int.Parse(dr["SoLuong"].ToString()) + quantity;
                            dr["ThanhTien"] = int.Parse(dr["SoLuong"].ToString()) * int.Parse(txtDonGia.Text);
                        }
                    }
                    if (a != 1)
                    {
                        DataRow newChiTiet = dataTableChiTiet.NewRow();
                        ChiTietPhieuNhap chiTiet = GetDataChiTietPN();
                        newChiTiet["MaPN"] = chiTiet.MaPN;
                        newChiTiet["MaHH"] = chiTiet.MaHH;
                        newChiTiet["TenHang"] = cbbTenHH.Text;
                        newChiTiet["SoLuong"] = chiTiet.SoLuong;
                        newChiTiet["DonGia"] = txtDonGia.Text;
                        newChiTiet["ThanhTien"] = txtThanhTien.Text;
                        newChiTiet["GhiChu"] = rtxtGhiChu.Text;
                        dataTableChiTiet.Rows.Add(newChiTiet);
                        dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
                    }
                }
                dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
                tongTien = tongTien + int.Parse(txtThanhTien.Text);
            }
            txtTongTien.Text = tongTien.ToString();
            btnAddNewImport.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            txtSoLuong.Enabled = false;
            cbbTenHH.Enabled = false;
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
            try
            {
                if(status ==1)
                {
                    return;
                }
                DataGridViewRow dt = dgvChiTietPhieuNhap.SelectedRows[0];
                cbbTenHH.SelectedValue = dt.Cells["MaHH"].Value.ToString();
                txtSoLuong.Text = dt.Cells["SoLuong"].Value.ToString();
                txtThanhTien.Text = dt.Cells["ThanhTien"].Value.ToString();
                txtDonGia.Text = dt.Cells["DonGia"].Value.ToString();
                deleteMoney = int.Parse(txtThanhTien.Text);
                btnDelete.Enabled = true;
            }
            catch(Exception err)
            {
                Console.Write(err.Message);
            }
          
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
      (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtSoLuong.Enabled = true;
            btnAdd.Text = "OK";
            btnEdit.Enabled = false;
            btnAddNewImport.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            action = 1;
        }

        private void btnAddNewImport_Click(object sender, EventArgs e)
        {
            status = 1;
           txtSoLuong.Enabled = true;
           cbbTenHH.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            btnSave.Enabled = false;
            btnAddNewImport.Enabled = false;
            if (dataTableChiTiet.Rows.Count > 0) btnSave.Enabled = true;
            else btnSave.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Bạn có muốn xóa bản ghi?", "Xóa chi tiết", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                dgvChiTietPhieuNhap.Rows.RemoveAt(dgvChiTietPhieuNhap.CurrentRow.Index);
                tongTien = tongTien - deleteMoney;
                txtTongTien.Text = tongTien.ToString();
                btnSave.Enabled = true;
            }
        }
    }
}
