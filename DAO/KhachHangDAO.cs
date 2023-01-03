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
    public class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return instance; }
            set => instance = value;
        }

        public KhachHangDAO() { }

        public DataTable LoadKH()
        {
            DataTable dtKhachHang = ConnectData.Instance.ReadData("Select * from KhachHang");

            return dtKhachHang;
        }

        public DataTable TimKiemKH_TYPE(string columnName,string type)
        {
            DataTable dtKhachHang = ConnectData.Instance.ReadData("Select * from KhachHang Where " + columnName + " Like '%" + type + "%'");
            return dtKhachHang;
        }

        public DataTable LoadKH_Ma(string makh)
        {
            DataTable dtKhachHang = ConnectData.Instance.ReadData("Select * from KhachHang Where MaKH='" + makh + "'");
            return dtKhachHang;
        }
        public void DeleteKH(string maKH)
        {
            try
            {
                ConnectData.Instance.UpdateData("Delete from KhachHang where MaKH='" + maKH + "'");
                MessageBox.Show("Xóa khách hàng thành công !!");
            } catch
            {
                MessageBox.Show("Xóa khách hàng thất bại, ràng buộc dữ liệu");
            }
        }

        public void InsertKH(KhachHang khachHangDTO)
        {
            try
            {
                ConnectData.Instance.UpdateData("Insert into KhachHang Values('" + khachHangDTO.MaKH + "',N'" +
                    khachHangDTO.TenKH + "','" + khachHangDTO.SDT + "',N'" + khachHangDTO.DiaChi + "','" + khachHangDTO.Email + "')");
                MessageBox.Show("Thêm khách hàng thành công !!");
                
            } catch
            {
                MessageBox.Show("Thêm khách hàng không thành công !!");
            }
        }

        public void UpdateKH(KhachHang khachHangDTO)
        {
            try
            {
                ConnectData.Instance.UpdateData("Update KhachHang set TenKH=N'" + khachHangDTO.TenKH + "',SDT='" + khachHangDTO.SDT + "',DiaChi=N'" 
                    + khachHangDTO.DiaChi + "',Email='" + khachHangDTO.Email + "' where MaKH='" + khachHangDTO.MaKH + "'");
                MessageBox.Show("Sửa thông tin khách hàng thành công !!");
            }
            catch
            {
                MessageBox.Show("Sửa thông tin khách hàng không thành công !!");
            }
        }
    }
}
