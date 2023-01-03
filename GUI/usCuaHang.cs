
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
    public partial class usCuaHang : UserControl
    {
        public usCuaHang()
        {
            InitializeComponent();
            LoadTable();
        }

        public void LoadTable()
        {
            DataTable dtHang = SanPhamDao.Instance.LoadTableList();
            List<SanPham> danhSachHang = new List<SanPham>();

            foreach (DataRow item in dtHang.Rows)
            {
                SanPham hang = new SanPham(item);
                danhSachHang.Add(hang);
            }

            foreach (SanPham hang in danhSachHang)
            {
                usSanPhamItem item = new usSanPhamItem(null, hang.TenHang, hang.DonGia);
                flHangHoa.Controls.Add(item);
            }
        }
    }
}
