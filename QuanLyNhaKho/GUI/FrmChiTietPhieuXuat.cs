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
        private int status;
        private int action;
        private int deleteMoney;
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
            txtMaPX.Text = Bus.getMaPXNext();
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

            txtThanhTien.Text = (int.Parse(txtDonGia.Text) * int.Parse(txtSoLuong.Text)).ToString();
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
                        if (dr["MaHH"].ToString() == cbb_TenHH.SelectedValue.ToString())
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
                        if (dr["MaHH"].ToString() == cbb_TenHH.SelectedValue.ToString())
                        {
                            a = 1;
                            int quantity = int.Parse(txtSoLuong.Text);
                            dr["SoLuong"] = int.Parse(dr["SoLuong"].ToString()) + quantity;
                            dr["ThanhTien"] = int.Parse(dr["SoLuong"].ToString()) * int.Parse(txtDonGia.Text);
                            dr["DonGia"] = txtDonGia.Text;
                        }
                    }
                    if (a != 1)
                    {
                        DataRow newChiTiet = dataTableChiTiet.NewRow();
                        ChiTietPhieuXuat chiTiet = getChiTietFormFRM();
                        newChiTiet["MaPX"] = chiTiet.MaPX;
                        newChiTiet["MaHH"] = chiTiet.MaHH;
                        newChiTiet["TenHang"] = cbb_TenHH.Text;
                        newChiTiet["SoLuong"] = chiTiet.SoLuong;
                        newChiTiet["DonGia"] = txtDonGia.Text;
                        newChiTiet["ThanhTien"] = chiTiet.SoLuong * int.Parse(txtDonGia.Text);
                        newChiTiet["GhiChu"] = rtxtGhiChu.Text;
                        dataTableChiTiet.Rows.Add(newChiTiet);
                        dgv_ChiTietPhieuXuat.DataSource = dataTableChiTiet;
                    }
                }
                dgv_ChiTietPhieuXuat.DataSource = dataTableChiTiet;
                tongTien = tongTien + int.Parse(txtThanhTien.Text);
            }
            txtTongTien.Text = tongTien.ToString();
            btnAddNew.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = false;
            txtSoLuong.Enabled = false;
            cbb_TenHH.Enabled = false;
            txtDonGia.Text = "0";
            txtDonGia.Enabled = false;
            status = 0;
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
                MaPX = txtMaPX.Text,
                MaHH = MaHH(),
                SoLuong = int.Parse(txtSoLuong.Text),
                ThanhTien = float.Parse(txtThanhTien.Text),
                GhiChu = rtxtGhiChu.Text
            };
            return chiTiet;
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
            DialogResult rs = MessageBox.Show("Bạn có muốn xóa bản ghi?", "Xóa chi tiết", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
               dgv_ChiTietPhieuXuat.Rows.RemoveAt(dgv_ChiTietPhieuXuat.CurrentRow.Index);
                tongTien = tongTien - deleteMoney;
                txtTongTien.Text = tongTien.ToString();
                btnSave.Enabled = true;
            }
        }

        private void dgv_ChiTietPhieuXuat_Click(object sender, EventArgs e)
        {
            try
            {
                if (status == 1)
                {
                    return;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    DataGridViewRow dt = dgv_ChiTietPhieuXuat.SelectedRows[0];
                    cbb_TenHH.SelectedValue = dt.Cells["MaHH"].Value.ToString();
                    txtSoLuong.Text = dt.Cells["SoLuong"].Value.ToString();
                    txtThanhTien.Text = dt.Cells["ThanhTien"].Value.ToString();
                    txtDonGia.Text = dt.Cells["DonGia"].Value.ToString();
                    deleteMoney = int.Parse(txtThanhTien.Text);
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }

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
                ThanhTien = int.Parse(txtTongTien.Text),
                TongTien = int.Parse(txtTongTien.Text),
                GhiChu = rtxtGhiChu.Text

            };

            int res = Bus.AddPhieuXuat(phieuXuat);
            if (res <= 0)
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
                    GhiChu = dr["GhiChu"].ToString(),
                    ThanhTien = int.Parse(dr["ThanhTien"].ToString()),
                    DonGia = int.Parse(dr["DonGia"].ToString())
                };
                int result = Bus.AddChiTietPhieuXuat(chiTiet);
                if (result <= 0)
                {
                    MessageBox.Show("Không them CT thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            MessageBox.Show("Thêm Hóa Đơn thành công!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

     
        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            //    txtTenNV.Text = Bus.getTenNhanVien(txtMaNV.Text.ToUpper());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtDonGia.Text = "";
            txtThanhTien.Text = "0";

            status = 1;
            txtSoLuong.Enabled = true;
            cbb_TenHH.Enabled = true;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            btnSave.Enabled = false;
            btnAddNew.Enabled = false;
            if (dataTableChiTiet.Rows.Count > 0) btnSave.Enabled = true;
            else btnSave.Enabled = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtSoLuong.Enabled = true;
            txtDonGia.Enabled = true;
            btnAdd.Text = "OK";
            btnEdit.Enabled = false;
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnAdd.Enabled = true;
            btnCancel.Enabled = true;
            action = 1;
        }

        private void cbb_TenCH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
