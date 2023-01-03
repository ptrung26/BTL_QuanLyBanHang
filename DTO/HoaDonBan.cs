using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class HoaDonBan
    {
        string maHDB, maNV, tenNV, maKH, tenKH, ngayLap;
        int tongTien;

        public static HoaDonBan instance = null;

        public static HoaDonBan Instance
        {
            get { if (instance == null) instance = new HoaDonBan(); return instance; }
            set => instance = value;
        }

        public string MaHDB { get => maHDB; set => maHDB = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }

        public HoaDonBan() { }

        public HoaDonBan(string maHDB, string maNV, string tenNV, string maKH, string tenKH, string ngayLap, int tongTien)
        {
            MaHDB = maHDB;
            MaNV = maNV;
            TenNV = tenNV;
            MaKH = maKH;
            TenKH = tenKH;
            NgayLap = ngayLap;
            TongTien = tongTien;
        }

        public HoaDonBan(DataRow row )
        {
            this.MaHDB = row["MaHDB"].ToString();
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.MaKH = row["MaKH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.NgayLap = row["NgayLap"].ToString();
            this.TongTien = int.Parse(row["TongTien"].ToString());
        }
    }
}
