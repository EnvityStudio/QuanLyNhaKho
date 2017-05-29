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
        public FrmChiTietPhieuXuat(string maPX)
        {
            InitializeComponent();
            this.maPX = maPX;
            dataTableChiTiet = new DataTable();
            txtMaPX.Text = maPX;
            LoadDataExportDetailByID();
            dataTableChiTiet = new DataTable();
            initDataTableChiTiet(dataTableChiTiet);
        }
        public FrmChiTietPhieuXuat()
        {
            InitializeComponent();
            dataTableChiTiet = new DataTable();
            LoadCombobox();
            initDataTableChiTiet(dataTableChiTiet);
            txtMaPX.Text = Bus.GetMaPNNext();
            txtTenNV.Text = Bus.getTenNhanVien(Config.CURRENT_NHANVIEN);

        }
        private void LoadDataExportDetailByID()
        {
            dgv_ChiTietPhieuXuat.DataSource = Bus.getChiTietPhieuXuat(maPX);
            dataTableChiTiet = (DataTable)dgv_ChiTietPhieuXuat.DataSource;
            dgv_ChiTietPhieuXuat.DataSource = dataTableChiTiet;
            //dgvChiTietPhieuNhap.Columns["MaPN"].HeaderText = "Ma Phieu Nhap";
            txtTongTien.Text = Bus.GetTongTienPhieuXuat(maPX).ToString();
        }
        public void LoadCombobox()
        {
            cbb_TenCH.DataSource = Bus.GetListTenCH();
            cbb_TenCH.ValueMember = "MaCH";
            cbb_TenCH.DisplayMember = "TenCH";
            //
            cbb_TenHH.DataSource = Bus.GetListTenHH();
            cbb_TenHH.ValueMember = "MaHH";
            cbb_TenHH.DisplayMember = "TenHang";
        }
        public string MaHH()
        {
            string maHH = cbb_TenHH.SelectedValue.ToString();
            return maHH;
        }
        public void EnableToolBox(bool bol)
        {
            txtTenNV.Enabled = false;
      //      txtMaCH.Enabled = bol;
            rtxtGhiChu.Enabled = bol;
            dtpNgayXuat.Enabled = bol;
            txtMaPX.Enabled = false;
     //       txtMaNV.Enabled = bol;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!checkChiTietPXInvalid(MaHH()))
                return;
            if(txtSoLuong.Text == null || txtSoLuong.Text == "0")
            {
                
                MessageBox.Show("Nhập số lượng","Thông báo!",MessageBoxButtons.OK);
                return ;
            }
            
            tongTien += int.Parse(txtThanhTien.Text);
            txtTongTien.Text = tongTien.ToString();
            DataRow newChiTiet = dataTableChiTiet.NewRow();
            ChiTietPhieuXuat chiTiet = getChiTietFormFRM();
            newChiTiet["MaPX"] = chiTiet.MaPX;
            newChiTiet["MaHH"] = chiTiet.MaHH;
            newChiTiet["TenHang"] = cbb_TenHH.Text;
            newChiTiet["SoLuong"] = chiTiet.SoLuong;
            newChiTiet["DonGia"] = txtDonGia.Text;
            newChiTiet["ThanhTien"] = txtThanhTien.Text;
            newChiTiet["GhiChu"] = rtxtGhiChu.Text;
            foreach(DataRow dr in dataTableChiTiet.Rows)
            {
                if(dr["MaHH"].ToString() == chiTiet.MaHH.ToString())
                {
                //    MessageBox.Show("Hàng đã tồn tại",);
                }
            }
            dataTableChiTiet.Rows.Add(newChiTiet);
            dgv_ChiTietPhieuXuat.DataSource = dataTableChiTiet;
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
            if (cbb_TenHH.SelectedValue== null)
                return false;
            return true;
        }
      

        private void initDataTableChiTiet(DataTable dt)
        {
            DataColumn dc = new DataColumn("MaPX", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("MaHH", typeof(String));
            dt.Columns.Add(dc);

            dc = new DataColumn("TenHang", typeof(String));

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
                MaHH = MaHH(),
                SoLuong = int.Parse(txtSoLuong.Text),
                ThanhTien = float.Parse(txtThanhTien.Text),
                GhiChu = rtxtGhiChu.Text
            };
            return chiTiet;
        }

        //private void txtMaHH_TextChanged(object sender, EventArgs e)
        //{
        //    if (MaHH() != null)
        //    {
        //        DataTable dt = Bus.SearchHangHoa(MaHH().ToUpper());
        //        if (dt.Rows.Count > 0) {
        //            txtTenHH.Text = dt.Rows[0]["TenHang"].ToString();
        //            txtDonGia.Text = dt.Rows[0]["GiaXuat"].ToString();
        //        }
        //        else
        //        {
        //            txtTenHH.Text = "";
        //            txtDonGia.Text = "";
        //        }
        //    }
        //}
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
            string maHH = MaHH();
            
            for(int i = 0; i < dataTableChiTiet.Rows.Count; i++)
            {
                if(dataTableChiTiet.Rows[i]["MaHH"].ToString().Contains(maHH))
                {
                    dataTableChiTiet.Rows.RemoveAt(i);
                    return;
                }
            }
            dgv_ChiTietPhieuXuat.DataSource = dataTableChiTiet;
        }

        private void dtgChiTietPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtMaHH.Text =  dgv_ChiTietPhieuXuat.Rows[e.RowIndex].Cells["MaHH"].Value.ToString();
            txtSoLuong.Text = dgv_ChiTietPhieuXuat.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            txtThanhTien.Text = dgv_ChiTietPhieuXuat.Rows[e.RowIndex].Cells["ThanhTien"].Value.ToString();
            txtDonGia.Text = dgv_ChiTietPhieuXuat.Rows[e.RowIndex].Cells["DonGia"].Value.ToString();
            rtxtGhiChu.Text = dgv_ChiTietPhieuXuat.Rows[e.RowIndex].Cells["GhiChu"].Value.ToString();
        }
        private void dgv_ChiTietPhieuXuat_Click(object sender, EventArgs e)
        {
            DataGridViewRow dt = dgv_ChiTietPhieuXuat.SelectedRows[0];
            txtMaPX.Text = dt.Cells["MaPX"].Value.ToString();
       //     txtMaNV.Text = dt.Cells["MaNV"].Value.ToString();
          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ChiTietPhieuXuat chiTiet;
            PhieuXuat phieuXuat = new PhieuXuat()
            {
                MaPX = txtMaPX.Text.ToUpper(),
                MaNV = Config.CURRENT_NHANVIEN,
                //      MaCH = txtMaCH.Text.ToUpper(),
                MaCH = cbb_TenCH.SelectedValue.ToString(),
                NgayXuat = dtpNgayXuat.Value,
                ChietKhau = 0,
                ThanhTien = 0,
                TongTien = 0,
                GhiChu = rtxtGhiChu.Text
            };

            int res = Bus.AddPhieuXuat(phieuXuat);
            if(res <= 0)
            {
         
                MessageBox.Show("Không thêm phiếu xuất!", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            foreach (DataRow dr in dataTableChiTiet.Rows)
            {
                chiTiet = new ChiTietPhieuXuat()
                {
                    MaHH = dr["MaHH"].ToString(),
                    MaPX = dr["MaPX"].ToString(),
                    SoLuong = int.Parse(dr["SoLuong"].ToString()),
                    DonGia = int.Parse(dr["DonGia"].ToString()),
                    ThanhTien=int.Parse(dr["ThanhTien"].ToString()),
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
            this.Close();
        }

     
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            //    txtTenNV.Text = Bus.getTenNhanVien(txtMaNV.Text.ToUpper());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataTableChiTiet.Reset();
            dgv_ChiTietPhieuXuat.DataSource = null;
            this.Close();
        }

        private void cbb_TenHH_SelectedValueChanged(object sender, EventArgs e)
        {

            if (MaHH() != null)
            {
                DataTable dt = Bus.SearchHangHoa(MaHH().ToUpper());
                if (dt.Rows.Count > 0)
                {
                  
   //                 txtDonGia.Text = dt.Rows[0]["GiaXuat"].ToString();
                }
                else
                {
              
                    txtDonGia.Text = "";
                }
            }
        }

        private void cbb_TenCH_SelectedValueChanged(object sender, EventArgs e)
        {
            string maCH = cbb_TenCH.SelectedValue.ToString();
            txtDiaChiCH.Text = Bus.getDiaChiCuaHang(maCH);
            //    string mach = cbb_tench.selectedvalue.tostring();
            //    //    txttench.text = bus.gettencuahang(txtmach.text.toupper());
            //  //  txttench.text = bus.gettencuahang(mach.toupper());

            //    txtdiachich.text = bus.getdiachicuahang(mach.toupper());
        }
    }
}
