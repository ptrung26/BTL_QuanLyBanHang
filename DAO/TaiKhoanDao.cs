using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDao
    {
        private static TaiKhoanDao instance;
        public static TaiKhoanDao Instance
        {
            get { if (instance == null) instance = new TaiKhoanDao(); return instance; }
            set => instance = value;
        }

        public TaiKhoanDao() { }

        public DataTable TimKiemTK(TaiKhoan tk)
        {
            DataTable dtTK = new DataTable();
            dtTK = ConnectData.Instance.ReadData("Select * from TaiKhoan where TenTK='" + tk.TenTK + "' and MatKhau='" + tk.MatKhau + "'");

            return dtTK;
        }

        public DataTable TimKiemTK_TK(string tk)
        {
            DataTable dtTK = new DataTable();
            dtTK = ConnectData.Instance.ReadData("Select * from TaiKhoan where TenTK='" + tk + "'");

            return dtTK;
        }

        public void UpdateTK(TaiKhoan tk)
        {
            ConnectData.Instance.UpdateData("Update TaiKhoan set MatKhau ='" + tk.MatKhau + "' where TenTK='" + tk.TenTK + "'");
        }
    }
}
