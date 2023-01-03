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
using GUI;

namespace Project_BTL
{
    public partial class frmAdmin : Form
    {
        public static string maNV = "";
        
        public bool statusForm { set; get; }

        public string usName = "";
        public frmAdmin()
        {
            InitializeComponent();
            //statusform Admin mặc định là true
            statusForm = true;
            usHoaDon.maNV = maNV;
            usHoaDonNhap.maNV = maNV;
            usBaoCaoTK.maNV = maNV;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // FULL màn hình 
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            DataTable dtNhanVien = NhanVienDao.Instance.TimKiemNV_MaNV(maNV);
            lblUserName.Text = dtNhanVien.Rows[0]["TenNV"].ToString();
            DataTable dtChucVu = ConnectData.Instance.ReadData("Select * from ChucVu where MaChucVu='" + dtNhanVien.Rows[0]["MaChucVu"].ToString() + "'");
            string chucVu = dtChucVu.Rows[0]["TenChucVu"].ToString();
            lblChucVu.Text = "Chức vụ : " + chucVu;
            if(chucVu == "Nhân Viên")
            {
                btnThongKe.Visible = false;
                btnNhanVien.Visible = false;
            }

            customizeDesing();

            usSanPham usSanPham1 = new usSanPham();
            addUserControl(usSanPham1);


            
        }

        public bool CheckStateForm(UserControl frm)
        {
            if (frm.Visible == true)
            {
                return true;
            }

            return false;
        }
        public void addUserControl(UserControl user)
        {

            user.Dock = DockStyle.Fill;
            pnlParent.Controls.Clear();
            pnlParent.Controls.Add(user);
            user.BringToFront();

        }
        private void btnQLKH_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if(usName != "KH")
            {
                usKhachHang usKhachHang1 = new usKhachHang();
                addUserControl(usKhachHang1);
                usName = "KH";
            }         
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (usName != "HDB")
            {
                usHoaDon usHoaDon1 = new usHoaDon();
                addUserControl(usHoaDon1);
                usName = "HDB";
            }

            
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (usName != "SP")
            {
                usSanPham usSanPham1 = new usSanPham();
                addUserControl(usSanPham1);
                usName = "SP";
            }
            
        }

        private void btnDonDatHang_Click(object sender, EventArgs e)
        {
            if (usName != "DonDH")
            {
                usDonHangDat usDonHangDat1 = new usDonHangDat();
                addUserControl(usDonHangDat1);
                usName = "DonDH";
            }
          
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            statusForm = false;
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (usName != "ThongKe")
            {
                usBaoCao usBaoCao1 = new usBaoCao();
                addUserControl(usBaoCao1);
                usName = "ThongKe";
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            if (usName != "NV")
            {
                usNhanVien usNhanVien1 = new usNhanVien();
                addUserControl(usNhanVien1);
                usName = "NV";
            }
            
        }

        private void customizeDesing()
        {
            panelChucNang.Visible = false;
        }

        private void hideSubMenu()
        {
            if(panelChucNang.Visible == true)
            {
                panelChucNang.Visible = false ;
            }
        }

        private bool MouseIsOverControl(Panel subMenu)
        {
            return subMenu.ClientRectangle.Contains(subMenu.PointToClient(Cursor.Position));
        }
   
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
                 
        }
        private void btnChucNang_Click(object sender, EventArgs e)
        {
            showSubMenu(panelChucNang);
        }

        private void btnHDN_Click(object sender, EventArgs e)
        {
            if (usName != "HDN")
            {
                usHoaDonNhap usHDN1 = new usHoaDonNhap();
                addUserControl(usHDN1);
                usName = "HDN";
            }
            
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            usNhaCungCap usNhaCungCap1 = new usNhaCungCap();
            addUserControl(usNhaCungCap1);
        }

        private void btnDonNhapHang_Click(object sender, EventArgs e)
        {
            if (usName != "DonNH")
            {
                usDonNhapHang usDonNhapHang1 = new usDonNhapHang();
                addUserControl(usDonNhapHang1);
                usName = "DonNH";
            }
            
        }

        private void btnBaoCaoDT_Click(object sender, EventArgs e)
        {
            if (usName != "BaoCaoDT")
            {
                usBaoCaoTK usBaoCaoTK1 = new usBaoCaoTK();
                addUserControl(usBaoCaoTK1);
                usName = "BaoCaoDT";
            }
        }
    }
}
