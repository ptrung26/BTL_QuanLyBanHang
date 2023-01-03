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
    public partial class usHoaDonNhap : UserControl
    {
        public static string maNV = "";
        public usHoaDonNhap()
        {
            InitializeComponent();
        }
        public void LoadSP()
        {
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.DataSource = SanPhamDao.Instance.LoadTableList();
            dgvSanPham.Columns[0].DataPropertyName = "MaHang";
            dgvSanPham.Columns[1].DataPropertyName = "TenHang";
            dgvSanPham.Columns[2].DataPropertyName = "DonGiaBan";

        }

        public void ResetData()
        {
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            dgvCTDH.DataSource = null;
        }

        public void ResetSP()
        {
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtDonGia.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtThanhTien.Text = "";
            numericUpDownSL.Value = 0;
            btnXoa.Enabled = false;
        }
        public void LoadCTHD()
        {
            dgvCTDH.DataSource = ChiTietHDNDao.Instance.LoadCTSP(txtMaHD.Text);
            dgvCTDH.Columns[0].HeaderText = "Mã hàng";
            dgvCTDH.Columns[1].HeaderText = "Tên hàng";
            dgvCTDH.Columns[2].HeaderText = "Đơn giá";
            dgvCTDH.Columns[3].HeaderText = "Số lượng";
            dgvCTDH.Columns[4].HeaderText = "Thành tiền";
            dgvCTDH.Columns[0].Visible = false;
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
            if (txtDonGia.Text == "")
            {
                txtMaHD.Focus();
                MessageBox.Show("Bạn chưa nhập đơn giá !!");
                return;
            }
            if (numericUpDownSL.Value == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0 !!");
                return;
            }

            DataTable dtHang = ConnectData.Instance.ReadData("Select * from HDNhap where MaHDN='" + txtMaHD.Text + "'");
            if (dtHang.Rows.Count == 0)
            {
                ConnectData.Instance.UpdateData("Insert into HDNhap Values('" + txtMaHD.Text + "',GetDate(),NULL,'" + cboNCC.Text + "','" + maNV + "')");
            }
            DataTable dtCTHDN = ChiTietHDNDao.Instance.TimKiemCTHD_1(new DTO.ChiTietHDN(txtMaHD.Text, txtMaSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(numericUpDownSL.Value)));
            if (dtCTHDN.Rows.Count > 0)
            {
                ChiTietHDNDao.Instance.UpdateCTHD(new DTO.ChiTietHDN(txtMaHD.Text, txtMaSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(numericUpDownSL.Value)));

            }
            else
            {
                ChiTietHDNDao.Instance.InsertCTHD(new DTO.ChiTietHDN(txtMaHD.Text, txtMaSP.Text, Convert.ToInt32(txtDonGia.Text), Convert.ToInt32(numericUpDownSL.Value)));
            }

            LoadCTHD();
        }

        private void numericUpDownSL_ValueChanged(object sender, EventArgs e)
        {
            if (txtTenSP.Text == "")
            {
                return;
            }

            txtThanhTien.Text = (Convert.ToInt32(txtDonGia.Text) * Convert.ToInt32(numericUpDownSL.Value)).ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable dtHang = SanPhamDao.Instance.TimKiemSP_Type("TenHang", txtTimKiem.Text);
            dgvSanPham.DataSource = dtHang;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắn chắn muốn xóa không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    ChiTietHDNDao.Instance.DeleteCTHD(txtMaHD.Text, txtMaSP.Text);
                    MessageBox.Show("Xóa thành công !!");
                    ResetSP();
                    LoadCTHD();
                }
                catch
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
            }
            catch
            {

            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = ConnectData.Instance.AutoIncrease("HDNhap", "MaHDN", "HDN");
            ResetData();
            ResetSP();

        }

        private void cboNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtNCC = NhaCungCapDAO.Instance.LoadNCC_MaNCC(cboNCC.Text);
                txtTenNCC.Text = dtNCC.Rows[0][1].ToString();
                txtDiaChi.Text = dtNCC.Rows[0][2].ToString();
                txtSDT.Text = dtNCC.Rows[0][3].ToString();
            } catch
            {

            }

           
        }

        private void usHoaDonNhap_Load(object sender, EventArgs e)
        {
            txtMaHD.Text = ConnectData.Instance.AutoIncrease("HDNhap", "MaHDN", "HDN");
            DataTable dtNCC = NhaCungCapDAO.Instance.LoadNCC();
            ConnectData.Instance.FillCombobox(cboNCC, dtNCC, "MaNCC", "MaNCC");
            LoadSP();
            ResetData();
            btnXoa.Enabled = false;
        }
    }
}
