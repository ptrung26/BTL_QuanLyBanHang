using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap
    {
        string maNCC, tenNCC, diaChi, sDT;

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }


        public NhaCungCap() { }
        public NhaCungCap(string maNCC, string tenNCC, string diaChi, string sDT)
        {
            this.MaNCC = maNCC;
            this.DiaChi = diaChi;
            this.TenNCC = tenNCC;
            this.SDT = sDT;
        }

        public NhaCungCap(DataRow row)
        {
            this.MaNCC = row["MaNCC"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.TenNCC = row["TenNCC"].ToString();
            this.sDT = row["SDT"].ToString();
        }
    }
}
