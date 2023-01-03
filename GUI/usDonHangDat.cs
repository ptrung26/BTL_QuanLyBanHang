using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace GUI
{
    public partial class usDonHangDat : UserControl
    {
        public usDonHangDat()
        {
            InitializeComponent();
            LoadHDB();
            cboType.SelectedIndex = 0;
        }
 
        public void LoadHDB()
        {
            dgvHoaDon.AutoGenerateColumns = false;
            dgvHoaDon.DataSource = HoaDonBanDao.Instance.LoadHDB();
            dgvHoaDon.Columns[0].DataPropertyName = "MaHDB";
            dgvHoaDon.Columns[1].DataPropertyName = "NgayLap";
            dgvHoaDon.Columns[2].DataPropertyName = "TenNV";
            dgvHoaDon.Columns[3].DataPropertyName = "TenKH";
            dgvHoaDon.Columns[4].DataPropertyName = "TongTien";
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHoaDon.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa hóa đơn này không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string maHDB = dgvHoaDon.CurrentRow.Cells["MaHDB"].Value.ToString();
                        HoaDonBanDao.Instance.DeleteHDB(maHDB);
                        MessageBox.Show("Xóa đơn hàng thành công");
                        LoadHDB();
                    } catch
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại");

                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboType.Text == "Mã hóa đơn bán")
            {
                dgvHoaDon.DataSource = HoaDonBanDao.Instance.TimKiemHDB_TYPE("MaHDB", txtTimKiem.Text);
            }
            if(cboType.Text == "Ngày lập")
            {
                dgvHoaDon.DataSource = HoaDonBanDao.Instance.TimKiemHDB_TYPE("NgayLap", txtTimKiem.Text);
            }
            if (cboType.Text == "Tên khách hàng")
            {
                dgvHoaDon.DataSource = HoaDonBanDao.Instance.TimKiemHDB_TYPE("TenKH", txtTimKiem.Text);
            }
            if(cboType.Text == "Số điện thoại")
            {
                dgvHoaDon.DataSource = HoaDonBanDao.Instance.TimKiemHDB_TYPE("KhachHang.SDT", txtTimKiem.Text);
            }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmChiTietHDB.maHDB = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
            frmChiTietHDB frm = new frmChiTietHDB();
            frm.ShowDialog();

        }

    }
}
