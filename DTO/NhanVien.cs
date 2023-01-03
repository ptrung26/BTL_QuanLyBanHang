using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        public static NhanVien instance = null;
        string maNV, tenNV, sDT, gioiTinh, ngaySinh, ngayBD, diaChi, maChucVu, ghiChu;
        public static NhanVien Instance
        {
            get { if (instance == null) instance = new NhanVien(); return instance; }
            set => instance = value;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string NgayBD { get => ngayBD; set => ngayBD = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaChucVu { get => maChucVu; set => maChucVu = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }

        public NhanVien() { }

        public NhanVien(string maNV, string tenNV, string sDT, string gioiTinh, string ngaySinh, string ngayBD, string diaChi, string maChucVu, string ghiChu)
        {
            this.MaNV = maNV;
            this.TenNV = tenNV;
            this.SDT = sDT;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.NgayBD = ngayBD;
            this.DiaChi = diaChi;
            this.MaChucVu = maChucVu;
            this.GhiChu = ghiChu;
        }
        public NhanVien(DataRow row)
        {
            this.MaNV = row["MaNV"].ToString();
            this.TenNV = row["TenNV"].ToString();
            this.SDT = row["SDT"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.NgaySinh = row["NgaySinh"].ToString();
            this.NgayBD = row["NgayBD"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.MaChucVu = row["MaChucVu"].ToString();
        }
    }
}
