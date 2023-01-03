
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
    public class NhaCungCapDAO
    {
        private static NhaCungCapDAO instance;
        public NhaCungCapDAO() { }
        public static NhaCungCapDAO Instance
        {
            get { if (instance == null) instance = new NhaCungCapDAO(); return instance; }
            set => instance = value;
        }

        public DataTable LoadNCC_MaNCC(string mancc)
        {
            DataTable dtNCC = ConnectData.Instance.ReadData("Select * from NhaCungCap Where MaNCC='" + mancc + "'");
            return dtNCC;
        }

        public DataTable LoadNCC()
        {
            DataTable dtNhaCungCap = ConnectData.Instance.ReadData("Select * from NhaCungCap");
            return dtNhaCungCap;
        }
        public DataTable TimKiemNCC_MaNCC(string maNCC)
        {
            DataTable dtNCC = new DataTable();
            dtNCC = ConnectData.Instance.ReadData("Select * from NhaCungCap where MaNCC='" + maNCC + "'");
            return dtNCC;
        }
        public DataTable TimKiemNCC_TYPE(string columnName, string type)
        {
            DataTable dtNhacungcap = ConnectData.Instance.ReadData("Select * from NhaCungCap where " +
                                                                   columnName + " Like'%" + type + "%'");
            return dtNhacungcap;
        }
        public void DeleteNCC(string maNCC)
        {
            try
            {
                ConnectData.Instance.UpdateData("Delete from NhaCungCap where  MaNCC='" + maNCC + "'");
                MessageBox.Show("Xóa nhà cung cấp thành công !!");
            }
            catch
            {
                MessageBox.Show("Xóa nhà cung cấp thất bại, hãy kiểm tra lại.");
            }
        }

        public void InsertNCC(NhaCungCap NhaCungCapDTO)
        {
            try
            {
                ConnectData.Instance.UpdateData("Insert into NhaCungCap Values('" + NhaCungCapDTO.MaNCC + "',N'" +
                    NhaCungCapDTO.TenNCC + "',N'" + NhaCungCapDTO.DiaChi + "','" + NhaCungCapDTO.SDT + "')");
                MessageBox.Show("Thêm nhà cung cấp thành công !!");

            }
            catch
            {
                MessageBox.Show("Thêm nhà cung cấp không thành công !!");
            }
        }

        public void UpdateNCC(NhaCungCap ncc)
        {
            try
            {
                ConnectData.Instance.UpdateData("Update NhaCungCap set TenNCC=N'" + ncc.TenNCC + "',DiaChi=N'" + ncc.DiaChi +
                    "',SDT='" + ncc.SDT + "' where MaNCC='" + ncc.MaNCC + "'");
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công !!");
            }
            catch
            {
                MessageBox.Show("Sửa thông tin nhà cung cấp không thành công !!");
            }
        }

    }
}
