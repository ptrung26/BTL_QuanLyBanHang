using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHDN
    {
        public static ChiTietHDN instance = null;

        string maHDN, maHang;
        int donGia, soLuong;
        int thanhTien;

        public static ChiTietHDN Instance
        {
            get { if (instance == null) instance = new ChiTietHDN(); return instance; }
            set => instance = value;
        }

        public string MaHDN { get => maHDN; set => maHDN = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        public ChiTietHDN() { }

        public ChiTietHDN(string maHDN, string maHang, int donGia, int soLuong, int thanhTien = 0)
        {
            this.maHDN = maHDN;
            this.MaHang = maHang;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }

        public ChiTietHDN(DataRow row)
        {
            this.MaHDN = row["MaHDN"].ToString();
            this.MaHang = row["MaHang"].ToString();
            this.DonGia = int.Parse(row["DonGia"].ToString());
            this.soLuong = int.Parse(row["SoLuong"].ToString());
            this.ThanhTien = int.Parse(row["ThanhTien"].ToString());
        }
    }
}
