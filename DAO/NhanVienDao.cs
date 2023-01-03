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
    public class NhanVienDao
    {
        private static NhanVienDao instance;
        public NhanVienDao() { }
        public static NhanVienDao Instance
        {
            get { if (instance == null) instance = new NhanVienDao(); return instance; }
            set => instance = value;
        }
        public DataTable LoadNV()
        {
            DataTable dtNhanvien = ConnectData.Instance.ReadData("Select * from NhanVien");

            return dtNhanvien;
        }
        public DataTable TimKiemNV_MaNV(string maNV)
        {
            DataTable dtNV = new DataTable();
            dtNV = ConnectData.Instance.ReadData("Select * from NhanVien where MaNV='" + maNV + "'");

            return dtNV;
        }
        public DataTable TimKiemNV_TYPE(string columnName, string type)
        {
            DataTable dtNhanvien = ConnectData.Instance.ReadData("Select * from NhanVien where " + columnName + " Like N'%" + type + "%'");

            return dtNhanvien;
        }
        public void DeleteNV(string maNV)
        {
            try
            {
                ConnectData.Instance.UpdateData("Delete from NhanVien where  MaNV='" + maNV + "'");
                MessageBox.Show("Xóa nhân viên thành công !!");
            }
            catch
            {
                MessageBox.Show("Xóa Nhân viên thất bại, ràng buộc dữ liệu");
            }
        }

        public void InsertNV(NhanVien NhanVienDTO)
        {
            try
            {
                ConnectData.Instance.UpdateData("Insert into NhanVien Values('" + NhanVienDTO.MaNV + "','" +
                    NhanVienDTO.TenNV + "','" + NhanVienDTO.SDT + "','" + NhanVienDTO.GioiTinh + "','" + NhanVienDTO.NgaySinh + "','" +
                     NhanVienDTO.NgayBD + "','" + NhanVienDTO.DiaChi + "','" + NhanVienDTO.MaChucVu + "','" + NhanVienDTO.GhiChu + "')");
                MessageBox.Show("Thêm Nhân viên thành công !!");

            }
            catch
            {
                MessageBox.Show("Thêm Nhân viên không thành công !!");
            }
        }

        public void UpdateNV(NhanVien NhanVienDTO)
        {
            try
            {
                ConnectData.Instance.UpdateData("Update NhanVien set TenNV=N'" + NhanVienDTO.TenNV + "',SDT='" + NhanVienDTO.SDT +
                    "',GioiTinh = N'" + NhanVienDTO.GioiTinh + "',NgaySinh = N'" + NhanVienDTO.NgaySinh + "',NgayBD = N'" + NhanVienDTO.NgayBD + "',DiaChi=N'"
                    + NhanVienDTO.DiaChi + "',MaChucVu=N'" + NhanVienDTO.MaChucVu + "',GhiChu = N'" + NhanVienDTO.GhiChu + "' where MaNV='" + NhanVienDTO.MaNV + "'");
                MessageBox.Show("Sửa thông tin nhân viên thành công !!");
            }
            catch
            {
                MessageBox.Show("Sửa thông tin Nhân viên không thành công !!");
            }
        }
    }
}
