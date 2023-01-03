using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cart
    {
        string tenHang;
        int donGia;
        int soLuong;

        public string TenHang { get => tenHang; set => tenHang = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public Cart(string tenHang,int donGia, int soLuong)
        {
            this.TenHang = tenHang;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
        }

        public Cart(DataRow row)
        {
            this.TenHang = row["TenHang"].ToString();
            this.donGia = int.Parse(row["DonGiaBan"].ToString());
            this.soLuong = int.Parse(row["SoLuong"].ToString());
        }
    }
}
