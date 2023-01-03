using DAO;
using DTO;
using Project_BTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usKhachHang : UserControl
    {
        public usKhachHang()
        {
            InitializeComponent();
        }

        public void LoadDSKH()
        {
            dgvKhachHang.DataSource = null;
            dgvKhachHang.AutoGenerateColumns = false;
            dgvKhachHang.DataSource = KhachHangDAO.Instance.LoadKH();
            dgvKhachHang.Columns[0].DataPropertyName = "MaKH";
            dgvKhachHang.Columns[1].DataPropertyName = "TenKH";
            dgvKhachHang.Columns[2].DataPropertyName = "SDT";
            dgvKhachHang.Columns[3].DataPropertyName = "DiaChi";
            dgvKhachHang.Columns[4].DataPropertyName = "Email";

            cboType.SelectedIndex = 0;

        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKH = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();

            if (dgvKhachHang.Columns[e.ColumnIndex].Name == "ChinhSua")
            {
                frmThongTinKH.status = 0;
                frmThongTinKH.maKH = maKH;
                frmThongTinKH frm = new frmThongTinKH();
                frm.ShowDialog();
                LoadDSKH();
            }

            if (dgvKhachHang.Columns[e.ColumnIndex].Name == "Xoa")
            {
                if(MessageBox.Show("Bạn chắc chắn muốn xóa khách hàng này không ?", "Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    KhachHangDAO.Instance.DeleteKH(maKH);
                    LoadDSKH();
                }      
            }
        }

        private void dgvKhachHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maKH = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            frmThongTinKH.maKH = maKH;
            frmThongTinKH.status = 3;
            frmThongTinKH frm = new frmThongTinKH();
            frm.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {


            frmThongTinKH.status = 1;
            frmThongTinKH.maKH = "";
            frmThongTinKH frm = new frmThongTinKH();
            frm.ShowDialog();
            LoadDSKH();
        }

        private void usKhachHang_Load(object sender, EventArgs e)
        {
            LoadDSKH();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboType.Text == "Số điện thoại")
            {
                dgvKhachHang.DataSource = KhachHangDAO.Instance.TimKiemKH_TYPE("SDT",txtTimKiem.Text);
            }
            if(cboType.Text == "Tên khách hàng")
            {
                dgvKhachHang.DataSource = KhachHangDAO.Instance.TimKiemKH_TYPE("TenKH", txtTimKiem.Text);
            }
            if(cboType.Text == "Mã khách hàng")
            {
                dgvKhachHang.DataSource = KhachHangDAO.Instance.TimKiemKH_TYPE("MaKH", txtTimKiem.Text);
            }
            if (cboType.Text == "Địa chỉ")
            {
                dgvKhachHang.DataSource = KhachHangDAO.Instance.TimKiemKH_TYPE("DiaChi", txtTimKiem.Text);
            }


        }

    }
}
