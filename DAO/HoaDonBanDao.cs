using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDonBanDao
    {
        private static HoaDonBanDao instance;
        public static HoaDonBanDao Instance
        {
            get { if (instance == null) instance = new HoaDonBanDao(); return instance; }
            set => instance = value;
        }

        public DataTable LoadHDB()
        {
            DataTable dtHDB = ConnectData.Instance.ReadData("Select MaHDB, HDBan.MaNV, TenNV, KhachHang.MaKH, TenKH, NgayLap, TongTien from HDBan inner join KhachHang on " +
                "HDBan.MaKH = KhachHang.MaKH inner join NhanVien on HDBan.MaNV = NhanVien.MaNV");
            return dtHDB;
        }

        public void DeleteHDB(string maHDB)
        {
            ConnectData.Instance.UpdateData("Delete from HDBan where MaHDB='" + maHDB + "'");
        }

        public DataTable TimKiemHDB_TYPE(string columnName, string type)
        {
            DataTable dtHDB = ConnectData.Instance.ReadData("Select MaHDB, HDBan.MaNV, TenNV, KhachHang.MaKH, TenKH, NgayLap, TongTien from HDBan inner join KhachHang on " +
                "HDBan.MaKH = KhachHang.MaKH inner join NhanVien on HDBan.MaNV = NhanVien.MaNV where " + columnName + " like '" + type + "%'");
            if(columnName == "NgayLap")
            {
                dtHDB = ConnectData.Instance.ReadData("Select MaHDB, HDBan.MaNV, TenNV, KhachHang.MaKH, TenKH, NgayLap, TongTien from HDBan inner join KhachHang on " +
                    "HDBan.MaKH = KhachHang.MaKH inner join NhanVien on HDBan.MaNV = NhanVien.MaNV where NgayLap = '" + type + "'");
            }
            return dtHDB;
        }
    }
}
