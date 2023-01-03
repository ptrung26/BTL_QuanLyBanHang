using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace Project_BTL
{
    public partial class frmThongTinKH : Form
    {
        public static int status = 0;
        public static string maKH = "";
        public frmThongTinKH()
        {
            InitializeComponent();
            txtMaKH.Enabled = false;
            if(status == 0 || status == 3)
            {
                LoadData();
            }
            if(status == 1)
            {
                txtMaKH.Text = ConnectData.Instance.AutoIncrease("KhachHang", "MaKH", "KH");
            }
            if(status == 3)
            {
                OnLyReadData();
            }
        }

        public void OnLyReadData()
        {
            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            txtEmail.Enabled = false;
            btnLuu.Visible = false;
        }
        public void LoadData()
        {
            DataTable dtKH = KhachHangDAO.Instance.LoadKH_Ma(maKH);
            txtMaKH.Text = dtKH.Rows[0]["MaKH"].ToString();
            txtTenKH.Text = dtKH.Rows[0]["TenKH"].ToString();
            txtSDT.Text = dtKH.Rows[0]["SDT"].ToString();
            txtDiaChi.Text = dtKH.Rows[0]["DiaChi"].ToString();
            txtEmail.Text = dtKH.Rows[0]["Email"].ToString();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaKH.Text == "")
            {
                txtMaKH.Focus();
                return;
            }
            if(txtTenKH.Text == "")
            {
                txtTenKH.Focus();
                return;
            }
            if(txtSDT.Text == "")
            {
                txtSDT.Focus();
                return;
            }
            if(txtDiaChi.Text == "")
            {
                txtDiaChi.Focus();
                return;
            }

            if(status == 1)
            {
                KhachHangDAO.Instance.InsertKH(new KhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text));
                this.Close();
            }
            else
            {
                KhachHangDAO.Instance.UpdateKH(new KhachHang(txtMaKH.Text, txtTenKH.Text, txtSDT.Text, txtDiaChi.Text, txtEmail.Text));
                this.Close();
            }
        }
    }
}
