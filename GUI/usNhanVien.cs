using DAO;
using Project_BTL;
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
    public partial class usNhanVien : UserControl
    {
        public usNhanVien()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "Số điện thoại")
            {
                dgvNhanVien.DataSource = NhanVienDao.Instance.TimKiemNV_TYPE("SDT", txtTimKiem.Text);
            }
            if (cboType.Text == "Tên nhân viên")
            {
                dgvNhanVien.DataSource = NhanVienDao.Instance.TimKiemNV_TYPE("TenNV", txtTimKiem.Text);
            }
            if (cboType.Text == "Mã nhân viên")
            {
                dgvNhanVien.DataSource = NhanVienDao.Instance.TimKiemNV_TYPE("MaNV", txtTimKiem.Text);
            }
            if (cboType.Text == "Địa chỉ")
            {
                dgvNhanVien.DataSource = NhanVienDao.Instance.TimKiemNV_TYPE("DiaChi", txtTimKiem.Text);
            }
            if (cboType.Text == "Giới tính")
            {
                dgvNhanVien.DataSource = NhanVienDao.Instance.TimKiemNV_TYPE("Gioitinh", txtTimKiem.Text);
            }
        }
        public void LoadDSNV()
        {
            dgvNhanVien.DataSource = null;
            dgvNhanVien.AutoGenerateColumns = false;
            dgvNhanVien.DataSource = NhanVienDao.Instance.LoadNV();
            dgvNhanVien.Columns[0].DataPropertyName = "MaNV";
            dgvNhanVien.Columns[1].DataPropertyName = "TenNV";
            dgvNhanVien.Columns[2].DataPropertyName = "SDT";
            dgvNhanVien.Columns[3].DataPropertyName = "GioiTinh";
            dgvNhanVien.Columns[4].DataPropertyName = "NgaySinh";
            dgvNhanVien.Columns[5].DataPropertyName = "NgayBD";
            dgvNhanVien.Columns[6].DataPropertyName = "DiaChi";
            dgvNhanVien.Columns[7].DataPropertyName = "MaChucVu";
            dgvNhanVien.Columns[8].DataPropertyName = "GhiChu";

        }
        private void usNhanVien_Load(object sender, EventArgs e)
        {
            LoadDSNV();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();

            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "ChinhSua")
            {
                frmThongTinNV.status = 0;
                frmThongTinNV.maNV = maNV;
                frmThongTinNV frm = new frmThongTinNV();
                frm.ShowDialog();
                LoadDSNV();
            }

            if (dgvNhanVien.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    NhanVienDao.Instance.DeleteNV(maNV);
                    LoadDSNV();
                }
            }
        }

        private void dgvNhanVien_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNV = dgvNhanVien.CurrentRow.Cells[0].Value.ToString();
            frmThongTinNV.maNV = maNV;
            frmThongTinNV.status = 3;
            frmThongTinNV frm = new frmThongTinNV();
            frm.ShowDialog();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThongTinNV.status = 1;
            frmThongTinNV.maNV = "";
            frmThongTinNV frm = new frmThongTinNV();
            frm.ShowDialog();
            LoadDSNV();
        }

    }
}
