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
        private bool importNew = true;
   
        public FrmChiTietPhieuNhap(string MaPN)
        {
            InitializeComponent();
            this.MaPN = MaPN;
            dataTableChiTiet = new DataTable();
            txtMaPN.Text = MaPN;
            LoadDataImportDetailByID();
            tongTien= Bus.GetTongTienPhieuNhap(MaPN);
            listBoxHangHoa.Visible = false;
            LoadCombobox();
            listBoxHangHoa.Visible = false;
        }
        public FrmChiTietPhieuNhap()
        {
            InitializeComponent();
            dataTableChiTiet = new DataTable();
            LoadCombobox();
            initDataTableChiTiet(dataTableChiTiet);
            txtMaPN.Text = Bus.GetMaPNNext();
            txtTenNV.Text = Bus.getTenNhanVien(Config.CURRENT_NHANVIEN);
            listBoxHangHoa.Visible = false;
        }

      
        private void LoadDataImportDetailByID()
        {
            dgvChiTietPhieuNhap.DataSource = Bus.GetChiTietPhieuNhap(MaPN);
            dataTableChiTiet = (DataTable)dgvChiTietPhieuNhap.DataSource;
            dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
            //dgvChiTietPhieuNhap.Columns["MaPN"].HeaderText = "Ma Phieu Nhap";
            txtTongTien.Text = Bus.GetTongTienPhieuNhap(MaPN).ToString();
            importNew = false;
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
            tongTien = 0;
            if (txtDonGia.Text == "" || txtDonGia.Text == null)
            {
                MessageBox.Show("Nhap don gia");
            }
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
                        if (dr["MaHH"].ToString() == cbbTenHH.SelectedValue.ToString())
                        {

                            int quantity = int.Parse(txtSoLuong.Text);
                            int b = int.Parse((int.Parse(txtDonGia.Text) * (quantity - int.Parse(dr["SoLuong"].ToString()))).ToString());
                            //if ((quantity - int.Parse(dr["SoLuong"].ToString())) > 0)
                            //{
                            //    tongTien = tongTien + b;
                            //}
                            //else
                            //{
                            //    tongTien = tongTien - (int.Parse(txtDonGia.Text) * (int.Parse(dr["SoLuong"].ToString()) - quantity));
                            //}
                           
                            dr["SoLuong"] = quantity;
                            dr["ThanhTien"] = quantity * int.Parse(txtDonGia.Text);
                            dr["DonGia"] = txtDonGia.Text;
                            btnAdd.Text = "Thêm";
                          //  tongTien = 0;
                          }
                        tongTien += int.Parse(dr["ThanhTien"].ToString());
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
                            dr["DonGia"] = txtDonGia.Text;
                            //tongTien = 0;
                            tongTien += int.Parse(dr["ThanhTien"].ToString());
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
                        newChiTiet["ThanhTien"] = chiTiet.SoLuong * int.Parse(txtDonGia.Text);
                        newChiTiet["GhiChu"] = rtxtGhiChu.Text;
                        dataTableChiTiet.Rows.Add(newChiTiet);
                        dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
                        foreach (DataRow dr in dataTableChiTiet.Rows)
                        {
                           // tongTien = 0;
                            tongTien += int.Parse(dr["ThanhTien"].ToString());
                        }
                    }
                    dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
                    //    tongTien = tongTien + int.Parse(txtThanhTien.Text);
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
                txtDonGia.Text = "0";
                txtDonGia.Enabled = false;
                status = 0;
                action = 0;
                
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            ChiTietPhieuNhap chiTiet;
            if (importNew==true)
            {
                PhieuNhap phieuNhap = new PhieuNhap()
                {
                    MaPN = txtMaPN.Text.ToUpper(),
                    MaNV = Config.CURRENT_NHANVIEN,
                    MaNCC = cbbTenNCC.SelectedValue.ToString(),
                    NgayNhap = dtpNgayNhap.Value,
                    ChietKhau = 0,
                    ThanhTien = int.Parse(txtTongTien.Text),
                    TongTien = int.Parse(txtTongTien.Text),
                    GhiChu = rtxtGhiChu.Text
                };
                int res = Bus.AddPhieuNhap(phieuNhap);
                int result;
                chiTiet = new ChiTietPhieuNhap();
                foreach (DataRow dr in dataTableChiTiet.Rows)
                {
                    chiTiet = new ChiTietPhieuNhap()
                    {

                        MaHH = dr["MaHH"].ToString(),
                        MaPN = dr["MaPN"].ToString(),
                        SoLuong = int.Parse(dr["SoLuong"].ToString()),
                        GhiChu = dr["GhiChu"].ToString(),
                        ThanhTien = int.Parse(dr["ThanhTien"].ToString()),
                        DonGia = int.Parse(dr["DonGia"].ToString())
                    };
                    result = Bus.AddChiTietPhieuNhap(chiTiet);
                }
             //   int res = Bus.AddPhieuNhap(phieuNhap);
              //  int result = Bus.AddChiTietPhieuNhap(chiTiet);
            
                if (res >0)
                {
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                        .Information);

                }
                else
                {
                    MessageBox.Show("Thêm hóa đơn thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                         .Information);
                }
            }

          else {
                PhieuNhap phieuNhap = new PhieuNhap()
                {
                    MaPN = txtMaPN.Text.ToUpper(),
                    MaNV = Config.CURRENT_NHANVIEN,
                    MaNCC = cbbTenNCC.SelectedValue.ToString(),
                    NgayNhap = dtpNgayNhap.Value,
                    ChietKhau = 0,
                    ThanhTien = int.Parse(txtTongTien.Text),
                    TongTien = int.Parse(txtTongTien.Text),
                    GhiChu = rtxtGhiChu.Text
                };
                int a = Bus.DeleteCTPN(MaPN);

                chiTiet = new ChiTietPhieuNhap();
                foreach (DataRow dr in dataTableChiTiet.Rows)
                {
                    chiTiet = new ChiTietPhieuNhap();
                    chiTiet.MaHH = dr["MaHH"].ToString();
                    chiTiet.MaPN = dr["MaPN"].ToString();
                    chiTiet.SoLuong = int.Parse(dr["SoLuong"].ToString());
                    chiTiet.GhiChu = dr["GhiChu"].ToString();
                    chiTiet.ThanhTien = int.Parse(dr["ThanhTien"].ToString());
                    chiTiet.DonGia = int.Parse(dr["DonGia"].ToString());

                    int result = Bus.UpdateChiTietPhieuNhap(chiTiet);
                }
                int res = Bus.UpdatePhieuNhap(phieuNhap);
      //          int a = Bus.DeleteCTPN(MaPN);
             //   int result = Bus.UpdateChiTietPhieuNhap(chiTiet);
                if(res>0)
                {
                    MessageBox.Show("Update thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                        .Information);
                }
                else
                {
                    MessageBox.Show("Update that bai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon
                       .Information);
                }
            }
       //     MessageBox.Show("Thêm Hóa Đơn thành công!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }

        private void dgvChiTietPhieuNhap_Click(object sender, EventArgs e)
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
                    DataGridViewRow dt = dgvChiTietPhieuNhap.SelectedRows[0];
                    cbbTenHH.SelectedValue = dt.Cells["MaHH"].Value.ToString();
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
            txtDonGia.Enabled = true;
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
            txtSoLuong.Text = "1";
            txtDonGia.Text = "";
            txtThanhTien.Text = "0";
            
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

                //dgvChiTietPhieuNhap.Rows.RemoveAt(dgvChiTietPhieuNhap.CurrentRow.Index);
                //dataTableChiTiet = (DataTable)dgvChiTietPhieuNhap.DataSource;
                foreach (DataRow dr in dataTableChiTiet.Rows)
                {
                    string mahh = dr["MaHH"].ToString();
                    string ma = cbbTenHH.SelectedValue.ToString();
                    if (dr["MaHH"].ToString() == cbbTenHH.SelectedValue.ToString())
                    {
                        dr.Delete();
                      //  dr.AcceptChanges();
                        dgvChiTietPhieuNhap.DataSource = dataTableChiTiet;
                        if (dataTableChiTiet.Rows.Count == 0)
                        {
                            return;
                        }
                        tongTien = tongTien - deleteMoney;
                        txtTongTien.Text = tongTien.ToString();
                        btnSave.Enabled = true;
                        dataTableChiTiet.AcceptChanges();
                        return;
                    }
                }
                ////dr.AcceptChanges();
                //tongTien = tongTien - deleteMoney;
                //txtTongTien.Text = tongTien.ToString();
                //btnSave.Enabled = true;
            }
        }

        private void listBoxHangHoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbTenHH.SelectedItem = listBoxHangHoa.SelectedItem;
            listBoxHangHoa.Visible = false;
        }

        private void cbbTenHH_TextChanged(object sender, EventArgs e)
        {
            string textToSearch = cbbTenHH.Text.ToLower();
            if (textToSearch.Length == 0)
            {
                //.Text = "";
            }
            else
            {
            }
          
            listBoxHangHoa.Visible = false; // hide the listbox, see below for why doing that
            if (String.IsNullOrEmpty(textToSearch))
                return; // return with listbox's Visible set to false if the keyword is empty
                        //search
            string[] result = Bus.getNameHangHoa().ToArray();
            if (result.Length == 0)
                return; // return with listbox's Visible set to false if nothing found

            listBoxHangHoa.Items.Clear(); // remember to Clear before Add
            listBoxHangHoa.Items.AddRange(result);
            listBoxHangHoa.Visible = false; // show the listbox again
        }
    }
}
