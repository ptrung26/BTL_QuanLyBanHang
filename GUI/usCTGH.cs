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
    public partial class usCTGH : UserControl
    {
        string tenHang = "";
        int donGia = 0;
        int soLuong = 0;
        PictureBox pic = null;
        public usCTGH(string tenHang, int donGia, int soLuong, PictureBox pic)
        {
            InitializeComponent();
            this.tenHang = tenHang;
            this.donGia = donGia;
            this.soLuong = soLuong;
            this.pic = pic;
        }

        public void LoadData()
        {
            lbl.Text = tenHang;
            priceLbl.Text = donGia.ToString();
            txtSoLuong.Text = soLuong.ToString();
            picSp = pic;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            btnMinus.Enabled = true;
            int n = int.Parse(txtSoLuong.Text);
            n++;
            txtSoLuong.Text = n.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
           
            int n = int.Parse(txtSoLuong.Text);
            n--;
            if(n == 1)
            {
                btnMinus.Enabled = false;
            }
            txtSoLuong.Text = n.ToString();
        }
    }
}
