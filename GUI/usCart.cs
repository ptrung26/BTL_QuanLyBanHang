
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
    public partial class usCart : UserControl
    {
        public usCart()
        {
            InitializeComponent();
            LoadCartList();
        }

        public void LoadCartList()
        {
            DataTable dtCart = CartDao.Instance.LoadCart();
            List<Cart> danhSachHang = new List<Cart>();

            foreach (DataRow item in dtCart.Rows)
            {
                Cart hang = new Cart(item);
                danhSachHang.Add(hang);
            }

            foreach(Cart hang in danhSachHang)
            {
                usCTGH item = new usCTGH(hang.TenHang,hang.DonGia,hang.SoLuong,null);
                flCart.Controls.Add(item);
            }
        }

        private void usCart_Load(object sender, EventArgs e)
        {

        }
    }
}
