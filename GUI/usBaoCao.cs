using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usBaoCao : UserControl
    {
        DashBoard model = new DashBoard();
        public usBaoCao()
        {
            InitializeComponent();

            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            btnLast7Days.Checked = true;
            dgvDoanhThu.DataSource = ConnectData.Instance.ReadData("Select NgayLap as [Ngày lập] , SUM(TongTien) as [Doanh Thu] from HDBan where NgayLap between '" +
                dtpStartDate.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' group by NgayLap");
            LoadData();
        }

        public void LoadData()
        {
            model.StartDate = dtpStartDate.Value;
            model.EndDate = dtpEndDate.Value;
            DashBoardDao.Instance.LoadData(model);

            lblSLDH.Text = model.TongDonHang.ToString();
            lblSoSPB.Text = model.TongSPBan.ToString();
            lblTongDoanhThu.Text = model.TotalRevenue.ToString() + " VNĐ";
            chartDoanhThu.DataSource = model.GrossRevenueList.ToArray() ;
            chartDoanhThu.Series[0].XValueMember = "Key";
            chartDoanhThu.Series[0].YValueMembers = "Value";
            chartDoanhThu.DataBind();

            chartTopSell.DataSource = model.TopProductsList;
            chartTopSell.Series[0].XValueMember = "Key";
            chartTopSell.Series[0].YValueMembers = "Value";
            chartTopSell.DataBind();

        }

        public void disableButtonChecked()
        {
            btnLast7Days.Checked = false;
            btnCustom.Checked = false;
            btnNam.Checked = false;
            btnThang.Checked = false;
            btnToday.Checked = false;
        }

        private void btnCustom_Click(object sender, EventArgs e)
        {
            disableButtonChecked();
            btnCustom.Checked = true;
            LoadData();
            dgvDoanhThu.DataSource = ConnectData.Instance.ReadData("Select NgayLap as [Ngày lập] , SUM(TongTien) as [Doanh Thu] from HDBan where NgayLap between '" +
                dtpStartDate.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' group by NgayLap");
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            disableButtonChecked();
            btnToday.Checked = true;
            dtpStartDate.Value = DateTime.Today;
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            dgvDoanhThu.DataSource = ConnectData.Instance.ReadData("Select NgayLap as [Ngày lập] , SUM(TongTien) as [Doanh Thu] from HDBan where NgayLap between '" +
                dtpStartDate.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' group by NgayLap");
        }

        private void btnThang_Click(object sender, EventArgs e)
        {
            disableButtonChecked();
            btnThang.Checked = true;
            dtpStartDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            dgvDoanhThu.DataSource = ConnectData.Instance.ReadData("Select Month(NgayLap) as [Tháng] , SUM(TongTien) as [Doanh Thu] from HDBan where NgayLap between '" +
                dtpStartDate.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' group by Month(NgayLap)");
        }

        private void btnNam_Click(object sender, EventArgs e)
        {
            disableButtonChecked();
            btnNam.Checked = true;
            DashBoardDao.Instance.ThongKeNam(model);
            lblSLDH.Text = model.TongDonHang.ToString();
            lblSoSPB.Text = model.TongSPBan.ToString();
            lblTongDoanhThu.Text = model.TotalRevenue.ToString() + " VNĐ" ;
            chartDoanhThu.DataSource = model.GrossRevenueList.ToArray();
            chartDoanhThu.Series[0].XValueMember = "Key";
            chartDoanhThu.Series[0].YValueMembers = "Value";
            chartDoanhThu.DataBind();

            chartTopSell.DataSource = model.TopProductsList;
            chartTopSell.Series[0].XValueMember = "Key";
            chartTopSell.Series[0].YValueMembers = "Value";
            chartTopSell.DataBind();

            dgvDoanhThu.DataSource = ConnectData.Instance.ReadData("Select Year(NgayLap) as [Năm], SUM(TongTien) as [Doanh Thu] from HDBan group by Year(NgayLap)");

        }

        private void btnLast7Days_Click(object sender, EventArgs e)
        {
            disableButtonChecked();
            btnLast7Days.Checked = true;
            dtpStartDate.Value = DateTime.Today.AddDays(-7);
            dtpEndDate.Value = DateTime.Now;
            LoadData();
            dgvDoanhThu.DataSource = ConnectData.Instance.ReadData("Select NgayLap as [Ngày lập] , SUM(TongTien) as [Doanh Thu] from HDBan where NgayLap between '" +
               dtpStartDate.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEndDate.Value.ToString("yyyy-MM-dd") + "' group by NgayLap");
        }
    }
}
