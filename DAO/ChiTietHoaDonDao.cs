using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class ChiTietHoaDonDao
    {
        private static ChiTietHoaDonDao instance;
        public static ChiTietHoaDonDao Instance
        {
            get { if (instance == null) instance = new ChiTietHoaDonDao(); return instance; }
            set => instance = value;
        }

        public ChiTietHoaDonDao() { }

        public DataTable LoadCTSP(string maHdb)
        {
            DataTable dtCTHDB = ConnectData.Instance.ReadData("Select ChiTietHDB.MaHang, TenHang, DonGia, SoLuong, ThanhTien from ChiTietHDB inner join Hang on ChiTietHDB.MaHang = Hang.MaHang" +
                " where MaHDB='" + maHdb + "'");
            return dtCTHDB;
        }
        public DataTable TimKiemCTHD_0(string maHdb)
        {
            DataTable dtCTHDB = ConnectData.Instance.ReadData("Select * from ChiTietHDB where MaHDB='" + maHdb + "'");
            return dtCTHDB;
        }
        public DataTable TimKiemCTHD_1(ChiTietHoaDon cthd )
        {
            DataTable dtCTHDB = ConnectData.Instance.ReadData("Select * from ChiTietHDB where MaHDB='" + cthd.MaHDB + "' and MaHang='" + cthd.MaHang + "'");
            return dtCTHDB;

        }

        public void UpdateCTHD(ChiTietHoaDon cthd)
        {
            ConnectData.Instance.UpdateData("Update ChiTietHDB set SoLuong='" + cthd.SoLuong.ToString() + "' where MaHDB='" + cthd.MaHDB + "' and MaHang='" + cthd.MaHang + "'");

        }

        public void InsertCTHD(ChiTietHoaDon cthd)
        {
            ConnectData.Instance.UpdateData("Insert into ChiTietHDB Values('" + cthd.MaHDB + "','" + cthd.MaHang + "'," + cthd.DonGia.ToString() + "," + cthd.SoLuong.ToString() + ", NULL)");
        }

        public void DeleteCTHD(string maHDB, string maHang)
        {
            ConnectData.Instance.UpdateData("Delete from ChiTietHDB where MaHDB='" + maHDB + "' and MaHang='" + maHang + "'");
        }
    }
}
