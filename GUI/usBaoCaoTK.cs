using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace GUI
{
    public partial class usBaoCaoTK : UserControl
    {
        public static string maNV = "";
        public usBaoCaoTK()
        {
            InitializeComponent();
            rdoThang.Checked = true;

        }

        public void TinhTien(int type)
        {
            int TienNhap = 0, TienBan = 0;
            if(type == 1)
            {
                TienNhap = int.Parse(ConnectData.Instance.ReadData("Select SUM(TongTien) from HDNhap where month(NgayNhap) = Month(GetDate()) ").Rows[0][0].ToString());
                TienBan = int.Parse(ConnectData.Instance.ReadData("Select SUM(TongTien) from HDBan where month(NgayLap) = Month(GetDate())").Rows[0][0].ToString());
            }
            if(type == 2)
            {
                TienNhap = int.Parse(ConnectData.Instance.ReadData("select SUM(TongTien) from HDNhap where DatePart(QUARTER , NgayNhap) = DatePart(QUARTER , getDate())").Rows[0][0].ToString());
                TienBan = int.Parse(ConnectData.Instance.ReadData("select SUM(TongTien) from HDBan where DatePart(QUARTER , NgayLap) = DatePart(QUARTER , getDate())").Rows[0][0].ToString());
            }
            if(type == 3)
            {
                TienNhap = int.Parse(ConnectData.Instance.ReadData("select SUM(TongTien) from HDNhap where Year(NgayNhap) = Year(Getdate())").Rows[0][0].ToString());
                TienBan = int.Parse(ConnectData.Instance.ReadData("select SUM(TongTien) from HDBan where Year(NgayLap) = Year(Getdate())").Rows[0][0].ToString());
            }
            lblTienNhap.Text = TienNhap.ToString() + " VNĐ";
            lblTienBan.Text = TienBan.ToString() + " VNĐ";
            lblTienLai.Text = TienBan - TienNhap < 0 ? "0" : (TienBan - TienNhap).ToString() + " VNĐ";
            lblTienLo.Text = TienBan - TienNhap < 0 ? (TienNhap - TienBan).ToString() + " VNĐ": "0";
        }
        private void rdoThang_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien(1);
        }

        private void guna2RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien(2);
        }

        private void guna2RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TinhTien(3);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application(); // chương trình excel
            // Workbook (file .xls làm việc, có nhiều workbook trong app)
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            // Worksheet ( các trang bảng tính trong file .xls, có nhiều worksheet trong workbook)
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            // Range (Là một khối ô làm việc của Excel - nó cũng có thể chỉ là một ô) 
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1]; // Đưa con trỏ vào ô A1
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "Cửa hàng bán siêu máy tinh NXT";

            Excel.Range diaChi = (Excel.Range)exSheet.Cells[2, 1];
            diaChi.Value = "Số 129 phố Lê Thanh Nghị, Phường Đồng Tâm, Quận Hai Bà Trưng, Hà Nội";
            diaChi.Font.Size = 13;

            Excel.Range title = (Excel.Range)exSheet.Cells[4, 3];
            title.Value = "Thống kê doanh thu";
            title.Font.Bold = true;
            title.Font.Size = 15;
            title.Font.Color = Color.Red;

            exSheet.Range["A5:A9"].Font.Size = 10;
            exSheet.Range["A5:A9"].ColumnWidth = 18;
            exSheet.Range["A5"].Value = "Tiền nhập hàng:";
            exSheet.Range["B5"].Value = lblTienNhap.Text;
            exSheet.Range["A6"].Value = "Tiền bán hàng:";
            exSheet.Range["B6"].Value = lblTienBan.Text;
            exSheet.Range["A7"].Value = "Tiền lãi:";
            exSheet.Range["B7"].Value = lblTienLai.Text;
            exSheet.Range["A8"].Value = "Tiền lỗ:";
            exSheet.Range["B8"].Value = lblTienLo.Text;

            DataTable dtNV = NhanVienDao.Instance.TimKiemNV_MaNV(maNV);
            exSheet.Range["B10"].Value = "Nhân viên lập:";
            exSheet.Range["C10"].Value = dtNV.Rows[0]["TenNV"];
            exSheet.Range["B11"].Value = "Ngày lập:";
            exSheet.Range["C11"].Value = DateTime.Now.ToString();
            exBook.Activate();

            // Lưu file 
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2002 Workbook|*.xls|Excel Workbook|*.slsx|All FIles|*.*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }
            exApp.Quit();
        }
    }
}
