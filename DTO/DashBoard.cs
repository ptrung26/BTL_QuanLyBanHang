using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DashBoard
    {
        private static DashBoard instance = null;
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;

        public static DashBoard Instance
        {
            get { if (instance == null) instance = new DashBoard(); return instance; }
            set => instance = value;
        }
        public int SoLuongKH { get; set; }
        public int SoLuongNCC { get; set; }
        public int SoLuongSP { get;set; }
        public int TongSPBan { get; set; }
        public int TongDonHang { get; set; }

        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public int NumberDays { get => numberDays; set => numberDays = value; }

        public List<KeyValuePair<string, int>> TopProductsList { get; set; }
        public List<KeyValuePair<string, int>> GrossRevenueList { get; set; }
        public  int TotalRevenue { get; set; }
        public DashBoard() { }


    }
}
