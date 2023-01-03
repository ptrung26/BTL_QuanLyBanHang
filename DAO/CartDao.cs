using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CartDao
    {
        private static CartDao instance;

        public static CartDao Instance
        {
            get { if (instance == null) instance = new CartDao(); return instance; }
            set => instance = value;
        }

        public CartDao() { }

        public DataTable LoadCart()
        {
            DataTable dtCart = ConnectData.Instance.ReadData("Select h.TenHang,h.DonGiaBan,ctgh.SoLuong from " +
                "ChiTietGH ctgh inner join Hang h on ctgh.MaHang = h.MaHang");

            return dtCart;
        }

    }
}
