using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        private static TaiKhoan instance;
        string tenTK, matKhau, maBaoMat, maNV;
        public static TaiKhoan Instance
        {
            get { if (instance == null) instance = new TaiKhoan(); return instance; }
            set => instance = value;
        }

        public string TenTK { get => tenTK; set => tenTK = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string MaBaoMat { get => maBaoMat; set => maBaoMat = value; }
        public string MaNV { get => maNV; set => maNV = value; }

        public TaiKhoan() { }

        public TaiKhoan(string tenTK, string matKhau, string maBaoMat = "", string maNV = "")
        {
            this.TenTK = tenTK;
            this.MatKhau = matKhau;
            this.MaBaoMat = maBaoMat;
            this.MaNV = maNV;
        }

        public TaiKhoan(DataRow row)
        {
            this.TenTK = row["TaiKhoan"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.MaBaoMat = row["MaBaoMat"].ToString();
            this.MaNV = row["MaNV"].ToString();
        }
    }
}
