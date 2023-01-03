using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usHoaDon : UserControl
    {
        public static string maNV = "";
        public usHoaDon()
        {
            InitializeComponent();
            
        }

        private void usHoaDon_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = ConnectData.Instance.AutoIncrease("HDBan", "MaHDB", "HDB");
            DataTable dtKH = KhachHangDAO.Instance.LoadKH();
            ConnectData.Instance.FillCombobox(cboKH, dtKH, "MaKH", "MaKH");
            LoadSP();
            ResetData();
            btnXoa.Enabled = false;
        }

        public void ResetData()
        {
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            dgvCTDH.DataSource = null;
        }

        public void ResetSP()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtThanhTien.Text = "";
            numericUpDownSL.Value = 0;
            btnXoa.Enabled = false;
        }

        public void LoadSP()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = SanPhamDao.Instance.LoadTableList();
            dgvSanPham.Columns[0].DataPropertyName = "MaHang";
            dgvSanPham.Columns[1].DataPropertyName = "TenHang";
            dgvSanPham.Columns[2].DataPropertyName = "DonGiaBan";

        }

        public void LoadCTHD()
        {
            dgvCTDH.DataSource = ChiTietHoaDonDao.Instance.LoadCTSP(txtMaHD.Text);
            dgvCTDH.Columns[0].HeaderText = "Mã hàng";
            dgvCTDH.Columns[1].HeaderText = "Tên hàng";
            dgvCTDH.Columns[2].HeaderText = "Đơn giá";
            dgvCTDH.Columns[3].HeaderText = "Số lượng";
            dgvCTDH.Columns[4].HeaderText = "Thành tiền";
            dgvCTDH.Columns[0].Visible = false;
        }

        private void cboKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = KhachHangDAO.Instance.LoadKH_Ma(cboKH.Text);
                txtTenKH.Text = dt.Rows[0]["TenKH"].ToString();
                txtDiaChi.Text = dt.Rows[0]["DiaChi"].ToString();
                txtSDT.Text = dt.Rows[0]["SDT"].ToString();
                txtEmail.Text = dt.Rows[0]["Email"].ToString();
            } catch
            {

            }
            
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
                txtDonGia.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                txtThanhTien.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
                numericUpDownSL.Value = 1;
            }
            catch
            {

            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if(txtDonGia.Text == "")
            {
                txtMaHD.Focus();
                MessageBox.Show("Bạn chưa nhập đơn giá !!");
                return;
            }
            if(numericUpDownSL.Value == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0 !!");
                return; 
            }
            DataTable dtCheck = SanPhamDao.Instance.TimKiemSP_Type("MaHang", txtMaSP.Text);
            int slTon = int.Parse(dtCheck.Rows[0]["SLTon"].ToString());
            if (slTon < int.Parse(numericUpDownSL.Text))
            {
                MessageBox.Show("Hàng không đủ số lượng tồn !!");
                numericUpDownSL.Text = "1";
                return;
            }

            DataTable dtHang = ConnectData.Instance.ReadData("Select * from HDBan where MaHDB='" + txtMaHD.Text + "'");
            if(dtHang.Rows.Count == 0)
            {
                ConnectData.Instance.UpdateData("Insert into HDBan Values('" + txtMaHD.Text + "',GetDate(),NULL,'" + maNV + "','" + cboKH.Text + "')");
            }
            DataTable dtCTHDB = ChiTietHoaDonDao.Instance.TimKiemCTHD_1(new DTO.ChiTietHoaDon(txtMaHD.Text,txtMaSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(numericUpDownSL.Value)));
            if(dtCTHDB.Rows.Count > 0)
            {
                ChiTietHoaDonDao.Instance.UpdateCTHD(new DTO.ChiTietHoaDon(txtMaHD.Text, txtMaSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(numericUpDownSL.Value)));
                
            } else
            {
                ChiTietHoaDonDao.Instance.InsertCTHD(new DTO.ChiTietHoaDon(txtMaHD.Text, txtMaSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(numericUpDownSL.Value)));
            }

            LoadCTHD();
        }

        private void numericUpDownSL_ValueChanged(object sender, EventArgs e)
        {
            if(txtTenSP.Text == "")
            {
                return; 
            }

            txtThanhTien.Text = (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(numericUpDownSL.Value)).ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtHang = SanPhamDao.Instance.TimKiemSP_Type("TenHang",txtTimKiem.Text);
            dgvSanPham.DataSource = dtHang;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
             if(MessageBox.Show("Bạn có chắn chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChiTietHoaDonDao.Instance.DeleteCTHD(txtMaHD.Text, txtMaSP.Text);
                    MessageBox.Show("Xóa thành công !!");
                    ResetSP();
                    LoadCTHD();
                } catch
                {
                    MessageBox.Show("Xóa thất bại !!");

                }
            }
        }

        private void dgvCTDH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                btnXoa.Enabled = true;
                txtMaSP.Text = dgvCTDH.CurrentRow.Cells["MaHang"].Value.ToString();
                txtTenSP.Text = dgvCTDH.CurrentRow.Cells["TenHang"].Value.ToString();
                numericUpDownSL.Text = dgvCTDH.CurrentRow.Cells["SoLuong"].Value.ToString();
                txtThanhTien.Text = dgvCTDH.CurrentRow.Cells["ThanhTien"].Value.ToString();
            } catch
            {

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = ConnectData.Instance.AutoIncrease("HDBan", "MaHDB", "HDB");
            ResetData();
            ResetSP();
            
        }
    }
}
