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
    public partial class frmChiTietHDB : Form
    {
        public static string maHDB;
        public frmChiTietHDB()
        {
            InitializeComponent();
        }

        private void frmChiTietHDB_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            dgvHoaDon.DataSource = ChiTietHoaDonDao.Instance.LoadCTSP(maHDB);
            dgvHoaDon.Columns[0].HeaderText = "Mã hàng";
            dgvHoaDon.Columns[1].HeaderText = "Tên hàng";
            dgvHoaDon.Columns[2].HeaderText = "Đơn giá bán";
            dgvHoaDon.Columns[3].HeaderText = "Số lượng";
            dgvHoaDon.Columns[4].HeaderText = "Thành Tiền";

            DataTable dtHDB = HoaDonBanDao.Instance.TimKiemHDB_TYPE("MaHDB", maHDB);
            lblcontentMaHD.Text = maHDB;
            string maKH = dtHDB.Rows[0]["MaKH"].ToString();
            lblContentTenNV.Text = dtHDB.Rows[0]["TenNV"].ToString();
            lblContentTenKH.Text = dtHDB.Rows[0]["TenKH"].ToString();
            lblContentTongTien.Text = dtHDB.Rows[0]["TongTien"].ToString() + " VNĐ";
            lblContentNgayLap.Text = dtHDB.Rows[0]["NgayLap"].ToString();
            DataTable dtKH = KhachHangDAO.Instance.TimKiemKH_TYPE("MaKH", maKH);
            lblContentSoDT.Text = dtKH.Rows[0]["SDT"].ToString();
            lblContentDiaChi.Text = dtKH.Rows[0]["DiaChi"].ToString();

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

            // In hóa đơn
            Excel.Range title = (Excel.Range)exSheet.Cells[4, 3];
            title.Value = "Hóa đơn bán";
            title.Font.Bold = true;
            title.Font.Size = 15;
            title.Font.Color = Color.Red;

            // In các thông tin chung 
            exSheet.Range["A5:A9"].Font.Size = 13;
            exSheet.Range["A5"].Value = "Mã hóa đơn : " + lblcontentMaHD.Text;
            exSheet.Range["A6"].Value = "Tên khách hàng : " + lblContentTenKH.Text;
            exSheet.Range["A7"].Value = "Địa chỉ : " + lblContentDiaChi.Text;
            exSheet.Range["A8"].Value = "Số điện thoại:" + lblContentSoDT.Text;

            // In các dòng tiêu đề 
            exSheet.Range["A10:F10"].Font.Size = 12;
            exSheet.Range["C10"].ColumnWidth = 20;
            exSheet.Range["D10"].ColumnWidth = 20;
            exSheet.Range["F10"].ColumnWidth = 20;
            exSheet.Range["A10"].Value = "STT";
            exSheet.Range["B10"].Value = "Mã hàng";
            exSheet.Range["C10"].Value = "Tên hàng";
            exSheet.Range["D10"].Value = "Đơn giá bán";
            exSheet.Range["E10"].Value = "Số lượng";
            exRange.Range["F10"].Value = "Thành tiền";

            int dong = 11;
            for(int i = 0; i < dgvHoaDon.Rows.Count; ++i)
            {
                exSheet.Range["A" + (dong + i).ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[2].Value.ToString().Split(',')[0];
                exSheet.Range["E" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + (dong + i).ToString()].Value = dgvHoaDon.Rows[i].Cells[4].Value.ToString().Split(',')[0];
            }
            dong = dong + dgvHoaDon.Rows.Count + 1;
            exSheet.Range["E" + dong.ToString()].Value = "Tổng tiền:";
            exSheet.Range["F" + dong.ToString()].Value = lblContentTongTien.Text;
            exSheet.Range["E" + (dong + 2).ToString()].Value = "Nhân viên:";
            exSheet.Range["F" + (dong + 2).ToString()].Value = lblContentTenNV.Text;


            exSheet.Name = lblcontentMaHD.Text;
            exBook.Activate();

            // Lưu file 
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel 97-2002 Workbook|*.xls|Excel Workbook|*.slsx|All FIles|*.*";
            if(save.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(save.FileName.ToLower());
            }
            exApp.Quit();

        }
    }
}
