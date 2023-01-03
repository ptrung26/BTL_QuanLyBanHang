using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonNhapDAO
    {
        private static HoaDonNhapDAO instance;
        public static HoaDonNhapDAO Instance
        {
            get { if (instance == null) instance = new HoaDonNhapDAO(); return instance; }
            set => instance = value;
        }

        public DataTable LoadHDN()
        {
            DataTable dtHDB = ConnectData.Instance.ReadData("Select MaHDN, HDNhap.MaNV, TenNV, NhaCungCap.MaNCC, TenNCC, NgayNhap, TongTien from HDNhap inner join NhaCungCap on " +
                "HDNhap.MaNCC = NhaCungCap.MaNCC inner join NhanVien on HDNhap.MaNV = NhanVien.MaNV");
            return dtHDB;
        }

        public void DeleteHDN(string maHDN)
        {
            ConnectData.Instance.UpdateData("Delete from HDNhap where MaHDN='" + maHDN + "'");
        }

        public DataTable TimKiemHDN_TYPE(string columnName, string type)
        {
            DataTable dtHDN = ConnectData.Instance.ReadData("Select MaHDN, HDNhap.MaNV, TenNV, NhaCungCap.MaNCC, TenNCC, NgayNhap, TongTien from HDNhap inner join NhaCungCap on " +
                "HDNhap.MaNCC = NhaCungCap.MaNCC inner join NhanVien on HDNhap.MaNV = NhanVien.MaNV where " + columnName + " like '" + type + "%'");
            if (columnName == "NgayNhap")
            {
                dtHDN = ConnectData.Instance.ReadData("Select MaHDN, HDNhap.MaNV, TenNV, NhaCungCap.MaNCC, TenNCC, NgayNhap, TongTien from HDNhap inner join NhaCungCap on " +
                    "HDNhap.MaNCC = NhaCungCap.MaNCC inner join NhanVien on HDNhap.MaNV = NhanVien.MaNV where NgayNhap = '" + type + "'");
            }
            if (columnName == "TenNCC")
            {
                dtHDN = ConnectData.Instance.ReadData("Select MaHDN, HDNhap.MaNV, TenNV, NhaCungCap.MaNCC, TenNCC, NgayNhap, TongTien from HDNhap inner join NhaCungCap on " +
                    "HDNhap.MaNCC = NhaCungCap.MaNCC inner join NhanVien on HDNhap.MaNV = NhanVien.MaNV where TenNCC like '%" + type + "%'");
            }
            return dtHDN;
        }
    }
}
