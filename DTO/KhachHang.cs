using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang
    {
        public static KhachHang instance = null;

        string maKH, tenKH, sDT, diaChi, email;
        public static KhachHang Instance
        {
            get { if (instance == null) instance = new KhachHang(); return instance; }
            set => instance = value;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Email { get => email; set => email = value; }

        public KhachHang() { }

        public KhachHang(string maKH, string tenKH, string sDT,string diaChi, string email)
        {
            this.MaKH = maKH;
            this.TenKH = tenKH;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.Email = email;
        }

        public KhachHang(DataRow row)
        {
            this.MaKH = row["MaKH"].ToString();
            this.TenKH = row["TenKH"].ToString();
            this.SDT = row["SDT"].ToString();
        }
    }
}
