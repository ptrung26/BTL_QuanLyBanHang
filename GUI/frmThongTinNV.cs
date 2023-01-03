using DAO;
using DTO;
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
    public partial class frmThongTinNV : Form
    {
        public static int status = 0;
        public static string maNV = "";
        public frmThongTinNV()
        {
            InitializeComponent();
            if (status == 0 || status == 3)
            {
                LoadData();
            }
            if(status == 1)
            {
                txtMaNV.Text = ConnectData.Instance.AutoIncrease("NhanVien", "MaNV", "NV");
                txtMaNV.Enabled = false;
            }
            if (status == 3)
            {
                OnLyReadData();
            }


        }
        public void LoadData()
        {
            DataTable dtNV = NhanVienDao.Instance.TimKiemNV_MaNV(maNV);
            txtMaNV.Text = dtNV.Rows[0]["MaNV"].ToString();
            txtTenNV.Text = dtNV.Rows[0]["TenNV"].ToString();
            txtSDT.Text = dtNV.Rows[0]["SDT"].ToString();
            txtGioiTinh.Text = dtNV.Rows[0]["GioiTinh"].ToString();
            dtpNgaySinh.Text = dtNV.Rows[0]["NgaySinh"].ToString();
            dtpNgayBatDau.Text = dtNV.Rows[0]["NgayBD"].ToString();
            txtDiaChi.Text = dtNV.Rows[0]["DiaChi"].ToString();
            txtMaChucVu.Text = dtNV.Rows[0]["MaChucVu"].ToString();
            txtGhiChu.Text = dtNV.Rows[0]["GhiChu"].ToString();
        }

        public void OnLyReadData()
        {
            txtMaNV.Enabled = false;
            txtTenNV.Enabled = false;
            txtSDT.Enabled = false;
            txtGioiTinh.Enabled = false;
            dtpNgaySinh.Enabled = false;
            dtpNgayBatDau.Enabled = false;
            txtDiaChi.Enabled = false;
            txtMaChucVu.Enabled = false;
            txtGhiChu.Enabled = false;
            btnLuu.Visible = false;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text == "")
            {
                txtTenNV.Focus();
                return;
            }
            if (txtSDT.Text == "")
            {
                txtSDT.Focus();
                return;
            }
            if (txtGioiTinh.Text == "")
            {
                txtGioiTinh.Focus();
                return;
            }
            if (txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                return;
            }
            if (txtMaChucVu.Text == "")
            {
                txtMaChucVu.Focus();
                return;
            }

            if (status == 1)
            {
                NhanVienDao.Instance.InsertNV(new NhanVien(txtMaNV.Text, txtTenNV.Text, txtSDT.Text, txtGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy-MM-dd"), dtpNgayBatDau.Value.ToString("yyyy-MM-dd"), txtDiaChi.Text, txtMaChucVu.Text,txtGhiChu.Text));
                this.Close();
            }
            else
            {
                NhanVienDao.Instance.UpdateNV(new NhanVien(txtMaNV.Text, txtTenNV.Text, txtSDT.Text, txtGioiTinh.Text, dtpNgaySinh.Value.ToString("yyyy-MM-dd"), dtpNgayBatDau.Value.ToString("yyyy-MM-dd"), txtDiaChi.Text, txtMaChucVu.Text, txtGhiChu.Text));
                this.Close();
            }
        }

     
    }
}
