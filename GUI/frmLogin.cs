using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAO;
using Project_BTL;
using Guna.UI2.WinForms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public bool statusForm { set; get; }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public frmLogin()
        {
            InitializeComponent();
            //statusForm mặc định là false
            statusForm = false;
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnQuenMK.Visible = false;
            pnDangNhap.Visible = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "")
            {
                txtUser.FocusedState.BorderColor = Color.Red;
                txtUser.Focus();
                return;
            }
            if(txtMK.Text == "")
            {
                txtMK.FocusedState.BorderColor = Color.Red;
                txtMK.Focus();
                return; 
            }

            DataTable dtTK = TaiKhoanDao.Instance.TimKiemTK(new TaiKhoan(txtUser.Text, txtMK.Text));
            if(dtTK.Rows.Count > 0)
            {
                statusForm = true;
                frmAdmin.maNV = dtTK.Rows[0]["MaNV"].ToString();
                messDialog.Text = "Đăng nhập thành công !!";
                messDialog.Show();
                this.Close();
            } else
            {
                messDialog.Text = "Tài khoản hoặc mật khẩu không chính xác !!";
                messDialog.Show();
            }

        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            pnDangNhap.Visible = false;
            pnQuenMK.Visible = true;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            pnQuenMK.Visible = false;
            pnDangNhap.Visible = true;
        }

        private void txtMK_Moi_IconRightClick(object sender, EventArgs e)
        {
            if(txtMK_Moi.UseSystemPasswordChar)
            {
                txtMK_Moi.UseSystemPasswordChar = false;
                txtMK_Moi.PasswordChar = default;

                txtMK_Moi.IconRight = Properties.Resources.eye_s;
            } else
            {
                txtMK_Moi.UseSystemPasswordChar = true;
                txtMK_Moi.IconRight = Properties.Resources.eye_c;
            }
        }

        private void txtMK_IconRightClick(object sender, EventArgs e)
        {
            if (txtMK.UseSystemPasswordChar)
            {
                txtMK.UseSystemPasswordChar = false;
                txtMK.PasswordChar = default;
                txtMK.IconRight = Properties.Resources.eye_s;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
                txtMK.IconRight = Properties.Resources.eye_c;
            }
        }

        public void SetFocus(Guna2TextBox txt)
        {
            txt.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
        }
        private void txt_Click(object sender, EventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;
            SetFocus(txt);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTK_Quen.Text == "")
            {
                txtTK_Quen.FocusedState.BorderColor = Color.Red;
                txtUser.Focus();
                return;
            }
            if (txtMK_Moi.Text == "")
            {
                txtMK_Moi.FocusedState.BorderColor = Color.Red;
                txtMK_Moi.Focus();
                return;
            }
            if (txtNhapLaiMK.Text == "")
            {
                txtNhapLaiMK.FocusedState.BorderColor = Color.Red;
                txtNhapLaiMK.Focus();
                return;
             }
            if (txtMaBaoMat.Text == "")
            {
                txtNhapLaiMK.FocusedState.BorderColor = Color.Red;
                txtNhapLaiMK.Focus();
                return; 
            }
            DataTable dt = TaiKhoanDao.Instance.TimKiemTK_TK(txtTK_Quen.Text);
            if (dt.Rows.Count == 0)
            {
                messDialog.Text = "Tài khoản không tồn tại";
                messDialog.Show();
                return;
            }
            if (txtMK_Moi.Text != txtNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không giống !!");
                return;
            }

            DataTable dtTK = TaiKhoanDao.Instance.TimKiemTK_TK(txtTK_Quen.Text);
            string maBaoMat = dtTK.Rows[0]["MaBaoMat"].ToString();
            if(maBaoMat != txtMaBaoMat.Text)
            {
                MessageBox.Show("Mã bảo mật không đúng !!");
            }

            try
            {
                TaiKhoanDao.Instance.UpdateTK(new TaiKhoan(txtTK_Quen.Text, txtMK_Moi.Text));
                messDialog.Text = "Đổi mật khẩu thành công";
                pnQuenMK.Visible = false;
                pnDangNhap.Visible = true;
                messDialog.Show();
            } catch
            {
                MessageBox.Show("Lỗi truy vấn !!");
            }
            
        }
    }
}
