using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChiTietHoaDon
    {
        public static ChiTietHoaDon instance = null;

        string maHDB, maHang;
        int donGia, soLuong;
        int thanhTien;

        public static ChiTietHoaDon Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDon(); return instance; }
            set => instance = value;
        }

        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public int DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(string maHDB, string maHang, int donGia, int soLuong, int thanhTien = 0)
        {
            this.maHDB = maHDB;
            this.MaHang = maHang;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }

        public ChiTietHoaDon(DataRow row)
        {
            this.MaHDB = row["MaHDB"].ToString();
            this.DonGia = int.Parse(row["DonGia"].ToString());
            this.soLuong = int.Parse(row["SoLuong"].ToString());
            this.ThanhTien = int.Parse(row["ThanhTien"].ToString());
        }
    }
}
