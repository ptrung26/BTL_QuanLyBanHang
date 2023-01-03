
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class SanPhamDao
    {
        private static SanPhamDao instance;
        public static SanPhamDao Instance {
            get { if(instance == null) instance = new SanPhamDao(); return instance; }
            set => instance = value;
        }

        public SanPhamDao() { }

        public DataTable LoadTableList()
        {
            DataTable dtHang = ConnectData.Instance.ReadData("Select * from Hang");
            return dtHang;           
        }

        public DataTable TimKiemSP_Type(string columnName, string value)
        {
            DataTable dtHang = ConnectData.Instance.ReadData("Select * from Hang where " + columnName + " Like N'%" + value + "%'");
            if(columnName == "DonGiaBan")
            {
                dtHang = ConnectData.Instance.ReadData("Select * from Hang where " + columnName + " >= " + int.Parse(value));
            }
            if(columnName == "SLTon")
            {
                dtHang = ConnectData.Instance.ReadData("Select * from Hang where " + columnName + " <= " + int.Parse(value));
            }
            return dtHang;
        }

        public void InsertData(SanPham sp)
        {
            ConnectData.Instance.UpdateData("insert into Hang values('" + sp.MaHang + "',N'" + sp.TenHang + "'," + sp.DonGiaNhap +
            "," + sp.DonGia + ",N'" + sp.HangSanXuat + "',N'" + sp.Ram +
            "',N'" + sp.OCung + "',N'" + sp.CardDoHoa + "',N'" + sp.CPU + "',N'" + sp.ManHinh
            + "'," + sp.SlTon + "," + sp.ThoiGianBaoHanh + ",'" + sp.Anh + "')");
            
        }
        public void UpdateSP(SanPham sp)
        {
            ConnectData.Instance.UpdateData("Update Hang set TenHang=N'" + sp.TenHang + "',DonGiaNhap=" + sp.DonGiaNhap + ",DonGiaBan=" + sp.DonGia +
                ",HangSanXuat=N'" + sp.HangSanXuat + "',Ram='" + sp.Ram + "',OCung='" + sp.OCung + "',CardDoHoa='" + sp.CardDoHoa + "',CPU='" + sp.CPU +
                "',ManHinh='" + sp.ManHinh + "',SLTon=" + sp.SlTon + ",ThoiGianBaoHanh=" + sp.ThoiGianBaoHanh + ",Anh='" + sp.Anh + "' where MaHang='" + sp.MaHang + "'");
        }

        public void DeleteSP(string maHang)
        {
            try
            {
                ConnectData.Instance.UpdateData("Delete from Hang where MaHang='" + maHang + "'");
                MessageBox.Show("Xóa mặt hàng thành công !!");
            }
            catch
            {
                MessageBox.Show("Xóa mặt hàng thật bại, ràng buộc dữ liệu !!");
            }
        }

    }
}
