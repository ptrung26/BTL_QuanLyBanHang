using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        public static SanPham instance = null;
        string maHang, tenHang, donGia, donGiaNhap, hangSanXuat, ram, oCung,
            cardDoHoa, cPU, manHinh, slTon, thoiGianBaoHanh, anh;

        public static SanPham Instance
        {
            get { if (instance == null) instance = new SanPham(); return instance; }
            set => instance = value;
        }

        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DonGia { get => donGia; set => donGia = value; }
        public string DonGiaNhap { get => donGiaNhap; set => donGiaNhap = value; }
        public string HangSanXuat { get => hangSanXuat; set => hangSanXuat = value; }
        public string Ram { get => ram; set => ram = value; }
        public string OCung { get => oCung; set => oCung = value; }
        public string CardDoHoa { get => cardDoHoa; set => cardDoHoa = value; }
        public string CPU { get => cPU; set => cPU = value; }
        public string ManHinh { get => manHinh; set => manHinh = value; }
        public string SlTon { get => slTon; set => slTon = value; }
        public string ThoiGianBaoHanh { get => thoiGianBaoHanh; set => thoiGianBaoHanh = value; }
        public string MaHang { get => maHang; set => maHang = value; }
        public string Anh { get => anh; set => anh = value; }

        public SanPham()
        {

        }

        public SanPham(string maHang,string tenHang, string donGia, string donGiaNhap, string hangSanXuat, string ram, string oCung, string cardDoHoa, string cPU, string manHinh, string slTon, string thoiGianBaoHanh, string anh)
        {
            MaHang = maHang;
            TenHang = tenHang;
            DonGia = donGia;
            DonGiaNhap = donGiaNhap;
            HangSanXuat = hangSanXuat;
            Ram = ram;
            OCung = oCung;
            CardDoHoa = cardDoHoa;
            CPU = cPU;
            ManHinh = manHinh;
            SlTon = slTon;
            ThoiGianBaoHanh = thoiGianBaoHanh;
            Anh = anh;
        }

        public SanPham(DataRow row)
        {
            this.MaHang = row["MaHang"].ToString();
            this.TenHang = row["TenHang"].ToString();
            this.DonGia = row["DonGiaBan"].ToString();
            this.Ram = row["Ram"].ToString();
            this.DonGiaNhap = row["DonGiaNhap"].ToString();
            this.HangSanXuat = row["HangSanXuat"].ToString();
            this.OCung = row["OCung"].ToString();
            this.CardDoHoa = row["CardDoHoa"].ToString();
            this.CPU = row["CPU"].ToString();
            this.ManHinh = row["ManHinh"].ToString();
            this.SlTon = row["SLTon"].ToString();
            this.ThoiGianBaoHanh = row["ThoiGianBaoHanh"].ToString();
        }
    }
}
