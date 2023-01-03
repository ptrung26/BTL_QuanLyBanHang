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
    public partial class usSanPhamItem : UserControl
    {

        string tenHang = "";
        string donGia = "";
        PictureBox pic = null;
        public usSanPhamItem(PictureBox pic, string tenHang, string donGia)
        {
            InitializeComponent();
            this.tenHang = tenHang;
            this.donGia = donGia;
            this.pic = pic;
            LoadData();
        }

        public void LoadData()
        {
            lbl.Text = tenHang;
            priceLbl.Text = donGia + " VNĐ";
            picSp = pic;
            
        }

        private void picCart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm vào giỏ hàng thành công");

        }
    }
}
