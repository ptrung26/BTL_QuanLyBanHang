using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DashBoardDao
    {
        private static DashBoardDao instance;
        public static DashBoardDao Instance
        {
            get { if (instance == null) instance = new DashBoardDao(); return instance; }
            set => instance = value;
        }

        public void GetNumberItems(DashBoard model)
        {
            try
            {
                DataTable dtKH = ConnectData.Instance.ReadData("Select Count(MaKH) as SL from KhachHang");
                model.SoLuongKH = int.Parse(dtKH.Rows[0]["SL"].ToString());
                DataTable dtNCC = ConnectData.Instance.ReadData("Select Count(MaNCC) as SL from NhaCungCap");
                model.SoLuongNCC = int.Parse(dtNCC.Rows[0]["SL"].ToString());
                DataTable dtSP = ConnectData.Instance.ReadData("Select Count(MaHang) as SL from Hang ");
                model.SoLuongSP = int.Parse(dtSP.Rows[0]["SL"].ToString());
                DataTable dtHDB = ConnectData.Instance.ReadData("Select Count(*) as SL from HDBan where NgayLap between '" + model.StartDate.ToString("yyyy-MM-dd") + "' and '" + model.EndDate.ToString("yyyy-MM-dd") + "'");
                model.TongDonHang = int.Parse(dtHDB.Rows[0]["SL"].ToString());
                DataTable dtSPB = ConnectData.Instance.ReadData("Select Sum(SoLuong) as SL from ChiTietHDB inner join HDBan on ChiTietHDB.MaHDB = HDBan.MaHDB where NgayLap between '" + model.StartDate.ToString("yyyy-MM-dd") + "' and '" + model.EndDate.ToString("yyyy-MM-dd") + "'");
                model.TongSPBan = int.Parse(dtSPB.Rows[0]["SL"].ToString());
            } catch
            {
                model.SoLuongKH = model.SoLuongNCC = model.SoLuongSP = model.TongDonHang = model.TongSPBan = 0;
            }
           
        }

        public void GetRevenueAnlisys(DashBoard model)
        {
            model.GrossRevenueList = new List<KeyValuePair<string, int>>();
            model.TotalRevenue = 0;
            var resultTable = new List<KeyValuePair<DateTime, int>>();
            DataTable dt = ConnectData.Instance.ReadData("Select NgayLap, sum(TongTien) from HDBan where NgayLap between '" + model.StartDate.ToString("yyyy-MM-dd")+ "' and '" + model.EndDate.ToString("yyyy-MM-dd") + "' group by NgayLap");
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                resultTable.Add(new KeyValuePair<DateTime, int>((DateTime)dt.Rows[i][0], int.Parse(dt.Rows[i][1].ToString())));
                model.TotalRevenue += int.Parse(dt.Rows[i][1].ToString());
            }

            // Group by Days 
            if (model.NumberDays <= 30)
            {
                foreach (var item in resultTable)
                {
                    model.GrossRevenueList.Add(new KeyValuePair<string, int>
                    (
                       item.Key.ToString("dd MMM"),
                       item.Value
                    ));

                }
            }

            // Group by Months
            else if (model.NumberDays < (365 * 2))
            {
                bool isYear = model.NumberDays <= 365 ? true : false;
                model.GrossRevenueList = (from orderlist in resultTable
                                          group orderlist by orderlist.Key.ToString("MMM yyyy")
                                          into order
                                          select new KeyValuePair<string, int>
                                          (
                                              isYear? order.Key.Substring(0,order.Key.IndexOf(" ")) : order.Key,
                                              order.Sum(amount => amount.Value)
                                          )).ToList();
            }

            // Group by Years 
            else
            {
                model.GrossRevenueList = (from orderlist in resultTable
                                          group orderlist by orderlist.Key.ToString("yyyy")
                                         into order
                                          select new KeyValuePair<string, int>
                                          (
                                                order.Key,
                                                order.Sum(amount => amount.Value)
                                          )).ToList();
            }
        }

        public void GetProductAnalisys(DashBoard model)
        {
            model.TopProductsList = new List<KeyValuePair<string, int>>();
            DataTable dtTop = ConnectData.Instance.ReadData("select top(5) TenHang, SUM(SoLuong) as SL from ChiTietHDB inner join Hang " +
                "on ChiTietHDB.MaHang = Hang.MaHang inner join HDBan on ChiTietHDB.MaHDB = HDBan.MaHDB where NgayLap between '" + model.StartDate.ToString("yyyy-MM-dd") + "' and '" + model.EndDate.ToString("yyyy-MM-dd") + "' group by ChiTietHDB.MaHang, TenHang order by SL DESC ");
            for(int i = 0; i < dtTop.Rows.Count; ++i)
            {
                model.TopProductsList.Add(new KeyValuePair<string, int>(dtTop.Rows[i][0].ToString(), (int)dtTop.Rows[i][1]));
            }
        }

        public void LoadData(DashBoard model)
        {
            model.NumberDays = (model.EndDate - model.StartDate).Days;

            GetNumberItems(model);
            GetProductAnalisys(model);
            GetRevenueAnlisys(model);
        }

        public void ThongKeNam(DashBoard model)
        {
            model.GrossRevenueList = new List<KeyValuePair<string, int>>();
            model.TotalRevenue = 0;
            DataTable dtThongKeDT = ConnectData.Instance.ReadData("select Year(NgayLap), Sum(TongTien) from HDBan group by Year(NgayLap) ");
            for(int i = 0; i < dtThongKeDT.Rows.Count; ++i)
            {
                model.GrossRevenueList.Add(new KeyValuePair<string, int>(dtThongKeDT.Rows[i][0].ToString(), int.Parse(dtThongKeDT.Rows[i][1].ToString())));
                model.TotalRevenue += int.Parse(dtThongKeDT.Rows[i][1].ToString());
            }

            DataTable dtThongKeSP = ConnectData.Instance.ReadData("select Top 5 TenHang, SUM(SoLuong)  from ChiTietHDB cthdb inner join Hang h on cthdb.MaHang = h.MaHang inner join HDBan hdb on cthdb.MaHDB = hdb.MaHDB group by Year(NgayLap),TenHang order by SUM(SoLuong) DESC");

            model.TopProductsList = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < dtThongKeSP.Rows.Count; ++i)
            {
                model.TopProductsList.Add(new KeyValuePair<string, int>(dtThongKeSP.Rows[i][0].ToString(), int.Parse(dtThongKeSP.Rows[i][1].ToString())));
            }

            DataTable dtSPB = ConnectData.Instance.ReadData("select SUM(SoLuong) from ChiTietHDB ");
            model.TongSPBan = int.Parse(dtSPB.Rows[0][0].ToString());
            DataTable dtHDB = ConnectData.Instance.ReadData("Select Count(*) from HDBan");
            model.TongDonHang = int.Parse(dtHDB.Rows[0][0].ToString());
        }

    }
}
