
using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmThongTinSP : Form
    {
        public static int status = 0;
        public static string maHang = "";

        string fileAnh = "";

        public frmThongTinSP()
        {
            InitializeComponent();
            if(status == 0 || status == 3)
            {
                LoadData();
            }
            if(status == 1)
            {
                txtMaSP.Text = ConnectData.Instance.AutoIncrease("Hang", "MaHang", "H");
            }
            if(status == 3)
            {
                OnlyReadData();
            }
        }

        public void OnlyReadData()
        {
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtHangSanXuat.Enabled = false;
            txtRam.Enabled = false;
            txtOCung.Enabled = false;
            txtCardDoHoa.Enabled = false;
            txtCPU.Enabled = false;
            txtManHinh.Enabled = false;
            txtSoLuongTon.Enabled = false;
            txtThoiGianBH.Enabled = false;
            lblUpLoad.Visible = false;
            btnLuu.Visible = false;
        }
        public void LoadData()
        {
            DataTable dtHang = SanPhamDao.Instance.TimKiemSP_Type("MaHang", maHang);
            txtMaSP.Text = dtHang.Rows[0]["MaHang"].ToString();
            txtTenSP.Text = dtHang.Rows[0]["TenHang"].ToString();
            txtDonGiaNhap.Text = dtHang.Rows[0]["DonGiaNhap"].ToString();
            txtDonGiaBan.Text = dtHang.Rows[0]["DonGiaBan"].ToString();
            txtHangSanXuat.Text = dtHang.Rows[0]["HangSanXuat"].ToString();
            txtRam.Text = dtHang.Rows[0]["Ram"].ToString();
            txtOCung.Text = dtHang.Rows[0]["OCung"].ToString();
            txtCardDoHoa.Text = dtHang.Rows[0]["CardDoHoa"].ToString();
            txtCPU.Text = dtHang.Rows[0]["CPU"].ToString();
            txtManHinh.Text = dtHang.Rows[0]["ManHinh"].ToString();
            txtSoLuongTon.Text = dtHang.Rows[0]["SLTon"].ToString();
            txtThoiGianBH.Text = dtHang.Rows[0]["ThoiGianBaoHanh"].ToString();
            fileAnh = dtHang.Rows[0]["Anh"].ToString();
            try
            {
                picAnh.Image = Image.FromFile(Application.StartupPath + "\\Image\\Products\\" + fileAnh);
            } catch {

            }
            


        }

        private void lblUpLoad_Click(object sender, EventArgs e)
        {
            string[] image;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG Images|*.jpg|PNG Images|*.png|All files|*.*";
            openFile.FilterIndex = 1;
            openFile.InitialDirectory = Application.StartupPath;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(openFile.FileName);
                image = openFile.FileName.ToString().Split('\\');
                fileAnh = image[image.Length - 1];

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(status == 0)
            {
                try
                {
                    SanPhamDao.Instance.UpdateSP(new DTO.SanPham(txtMaSP.Text, txtTenSP.Text, txtDonGiaNhap.Text, txtDonGiaBan.Text, txtHangSanXuat.Text,
                    txtRam.Text, txtOCung.Text, txtCardDoHoa.Text, txtCPU.Text, txtManHinh.Text, txtSoLuongTon.Text, txtThoiGianBH.Text,fileAnh));
                    MessageBox.Show("Chỉnh sửa mặt hàng thành công !!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Chỉnh sửa mặt hành thật bại !!");
                }
            } else
            {
                try
                {
                     SanPhamDao.Instance.InsertData(new DTO.SanPham(txtMaSP.Text, txtTenSP.Text, txtDonGiaNhap.Text, txtDonGiaBan.Text, txtHangSanXuat.Text,
                    txtRam.Text, txtOCung.Text, txtCardDoHoa.Text, txtCPU.Text, txtManHinh.Text, txtSoLuongTon.Text, txtThoiGianBH.Text, fileAnh));
                    MessageBox.Show("Thêm mặt hàng mới thành công !!");
                } catch
                {
                    MessageBox.Show("Thêm mặt hàng mới thất bại ");

                }
            }
            
            
        }
    }
}
