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
    public partial class usDonNhapHang : UserControl
    {
        public usDonNhapHang()
        {
            InitializeComponent();
            LoadHDN();
            cboType.SelectedIndex = 0;
        }
        public void LoadHDN()
        {
            dgvHoaDonNhap.DataSource = null;
            dgvHoaDonNhap.AutoGenerateColumns = false;
            dgvHoaDonNhap.DataSource = HoaDonNhapDAO.Instance.LoadHDN();
            dgvHoaDonNhap.Columns[0].DataPropertyName = "MaHDN";
            dgvHoaDonNhap.Columns[1].DataPropertyName = "MaNV";
            dgvHoaDonNhap.Columns[2].DataPropertyName = "TenNV";
            dgvHoaDonNhap.Columns[3].DataPropertyName = "MaNCC";
            dgvHoaDonNhap.Columns[4].DataPropertyName = "TenNCC";
            dgvHoaDonNhap.Columns[5].DataPropertyName = "NgayNhap";
            dgvHoaDonNhap.Columns[6].DataPropertyName = "TongTien";

        }

        private void dgvHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDonNhap.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string maHDN = dgvHoaDonNhap.CurrentRow.Cells["MaHDN"].Value.ToString();
                        HoaDonNhapDAO.Instance.DeleteHDN(maHDN);
                        MessageBox.Show("Xóa đơn hàng thành công");
                        LoadHDN();
                    }
                    catch
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại");

                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "Mã hóa đơn nhập")
            {
                dgvHoaDonNhap.DataSource = HoaDonNhapDAO.Instance.TimKiemHDN_TYPE("MaHDN", txtTimKiem.Text);
            }
            if (cboType.Text == "Ngày nhập")
            {
                dgvHoaDonNhap.DataSource = HoaDonNhapDAO.Instance.TimKiemHDN_TYPE("NgayNhap", txtTimKiem.Text);
            }
            if (cboType.Text == "Tên nhà cung cấp")
            {
                dgvHoaDonNhap.DataSource = HoaDonNhapDAO.Instance.TimKiemHDN_TYPE("TenNCC", txtTimKiem.Text);
            }
            if (cboType.Text == "Mã nhân viên")
            {
                dgvHoaDonNhap.DataSource = HoaDonNhapDAO.Instance.TimKiemHDN_TYPE("MaNV", txtTimKiem.Text);
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }


        private void dgvHoaDonNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietHDN.maHDN = dgvHoaDonNhap.CurrentRow.Cells[0].Value.ToString();
            frmChiTietHDN frm = new frmChiTietHDN();
            frm.ShowDialog();
        }
    }
}
