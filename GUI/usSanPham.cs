
using DAO;
using Project_BTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class usSanPham : UserControl
    {

        public usSanPham()
        {
            InitializeComponent();
            LoadData();
            cboType.SelectedIndex = 1;
        }

        #region Method

        public void LoadData()
        {
            dgvHangHoa.AutoGenerateColumns = false;
            DataTable dt = SanPhamDao.Instance.LoadTableList();
            dgvHangHoa.DataSource = dt;
            dgvHangHoa.Columns[0].DataPropertyName = "MaHang";
            dgvHangHoa.Columns[1].DataPropertyName = "TenHang";
            dgvHangHoa.Columns[2].DataPropertyName = "DonGiaNhap";
            dgvHangHoa.Columns[3].DataPropertyName = "DonGiaBan";
            dgvHangHoa.Columns[4].DataPropertyName = "SLTon";
            dgvHangHoa.Columns[5].DataPropertyName = "ThoiGianBaoHanh";

        }

        #endregion

        #region Events
        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string maHang = dgvHangHoa.CurrentRow.Cells[0].Value.ToString();
            try
            {
                if (dgvHangHoa.Columns[e.ColumnIndex].Name == "ChinhSua")
                {

                    frmThongTinSP.maHang = maHang;
                    frmThongTinSP.status = 0;
                    frmThongTinSP frm = new frmThongTinSP();
                    frm.ShowDialog();
                    LoadData();
                }

                if (dgvHangHoa.Columns[e.ColumnIndex].Name == "Xoa")
                {
                    if(MessageBox.Show("Bạn chắc chắn muốn xóa sản phẩm này không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        SanPhamDao.Instance.DeleteSP(maHang);
                        LoadData();
                    }
                    
                }          
            } catch
            {

            }
            
        }

        private void dgvHangHoa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string maHang = dgvHangHoa.CurrentRow.Cells[0].Value.ToString();
            try
            {
                frmThongTinSP.maHang = maHang;
                frmThongTinSP.status = 3;
                frmThongTinSP frm = new frmThongTinSP();
                frm.ShowDialog();
                LoadData();
            }
            catch
            {

            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThongTinSP.status = 1;
            frmThongTinSP frm = new frmThongTinSP();
            frm.ShowDialog();
        }

        #endregion

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

            if (cboType.Text == "Mã hàng")
            {
                dgvHangHoa.DataSource = SanPhamDao.Instance.TimKiemSP_Type("MaHang", txtTimKiem.Text);
            }
            if(cboType.Text == "Tên hàng")
            {
                dgvHangHoa.DataSource = SanPhamDao.Instance.TimKiemSP_Type("TenHang", txtTimKiem.Text);
            }
            if (cboType.Text == "Hãng sản xuất")
            {
                dgvHangHoa.DataSource = SanPhamDao.Instance.TimKiemSP_Type("HangSanXuat", txtTimKiem.Text);
            }
            if (cboType.Text == "Đơn giá bán")
            {
                dgvHangHoa.DataSource = SanPhamDao.Instance.TimKiemSP_Type("DonGiaBan", txtTimKiem.Text);
            }
            if (cboType.Text == "Số lượng tồn")
            {
                dgvHangHoa.DataSource = SanPhamDao.Instance.TimKiemSP_Type("SLTon", txtTimKiem.Text);
            }
        }

    }
}
