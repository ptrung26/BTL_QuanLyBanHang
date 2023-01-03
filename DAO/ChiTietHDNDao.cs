using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class ChiTietHDNDao
    {
        private static ChiTietHDNDao instance;
        public static ChiTietHDNDao Instance
        {
            get { if (instance == null) instance = new ChiTietHDNDao(); return instance; }
            set => instance = value;
        }

        public ChiTietHDNDao() { }

        public DataTable LoadCTSP(string maHdn)
        {
            DataTable dtCTHDN = ConnectData.Instance.ReadData("Select ChiTietHDN.MaHang, TenHang, DonGia, SoLuong, ThanhTien from ChiTietHDN inner join Hang on ChiTietHDN.MaHang = Hang.MaHang" +
                " where MaHDN='" + maHdn + "'");
            return dtCTHDN;
        }
        public DataTable TimKiemCTHD_0(string maHdn)
        {
            DataTable dtCTHDN = ConnectData.Instance.ReadData("Select * from ChiTietHDN where MaHDN='" + maHdn + "'");
            return dtCTHDN;
        }
        public DataTable TimKiemCTHD_1(ChiTietHDN cthd)
        {
            DataTable dtCTHDN = ConnectData.Instance.ReadData("Select * from ChiTietHDN where MaHDN='" + cthd.MaHDN + "' and MaHang='" + cthd.MaHang + "'");
            return dtCTHDN;

        }

        public void UpdateCTHD(ChiTietHDN cthd)
        {
            ConnectData.Instance.UpdateData("Update ChiTietHDN set SoLuong='" + cthd.SoLuong.ToString() + "' where MaHDN='" + cthd.MaHDN + "' and MaHang='" + cthd.MaHang + "'");

        }

        public void InsertCTHD(ChiTietHDN cthd)
        {
            ConnectData.Instance.UpdateData("Insert into ChiTietHDN Values('" + cthd.MaHDN + "','" + cthd.MaHang + "'," + cthd.SoLuong.ToString() + "," + cthd.DonGia.ToString() + ", NULL)");
        }

        public void DeleteCTHD(string maHDN, string maHang)
        {
            ConnectData.Instance.UpdateData("Delete from ChiTietHDN where MaHDN='" + maHDN + "' and MaHang='" + maHang + "'");
        }
    }
}
