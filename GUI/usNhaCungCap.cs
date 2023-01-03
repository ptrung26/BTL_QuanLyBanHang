using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usNhaCungCap : UserControl
    {
        public usNhaCungCap()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
            txtMaNCC.Enabled = false;
        }
        public void LoadDSNCC()
        {
            dgvNhaCungCap.DataSource = null;
            dgvNhaCungCap.ClearSelection();
            dgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.LoadNCC();
            
           
        }
        
        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNCC.Text = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dgvNhaCungCap.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNhaCungCap.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvNhaCungCap.CurrentRow.Cells[3].Value.ToString();
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            txtMaNCC.Text = ConnectData.Instance.AutoIncrease("NhaCungCap", "MaNCC", "NCC");
        }

        private void usNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadDSNCC();
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            NhaCungCapDAO.Instance.UpdateNCC(new NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text));
            LoadDSNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = dgvNhaCungCap.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn chắc chắn muốn xóa nhà cung cấp này không ?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                NhaCungCapDAO.Instance.DeleteNCC(maNCC);
                LoadDSNCC();
                resetValue();
            }
        }

        public void resetValue()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            resetValue();
            LoadDSNCC();
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (cboType.Text == "Số điện thoại")
            {
                dgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.TimKiemNCC_TYPE("SDT", txtTimKiem.Text);
            }
            if (cboType.Text == "Tên nhà cung cấp")
            {
                dgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.TimKiemNCC_TYPE("TenNCC", txtTimKiem.Text);
            }
            if (cboType.Text == "Mã nhà cung cấp")
            {
                dgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.TimKiemNCC_TYPE("MaNCC", txtTimKiem.Text);
            }
            if (cboType.Text == "Địa chỉ")
            {
                dgvNhaCungCap.DataSource = NhaCungCapDAO.Instance.TimKiemNCC_TYPE("DiaChi", txtTimKiem.Text);
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnThem.Enabled == true)
            {
                if (txtTenNCC.Text == "")
                {
                    txtTenNCC.Focus();
                    return;
                }
                if (txtSDT.Text == "")
                {
                    txtSDT.Focus();
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    txtDiaChi.Focus();
                    return;
                }
                NhaCungCapDAO.Instance.InsertNCC(new NhaCungCap(txtMaNCC.Text, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text));
                LoadDSNCC();

            }
        }
    }
}
