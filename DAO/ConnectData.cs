using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{

    // Có nhiệm vụ tạo kết nối với CSDL và đưa dữ liệu ra
    public class ConnectData
    {

        // Xác định Database Server
        private string strConnect = "Data Source=HCNS1\\MSSQLSERVER01;Initial Catalog=QuanLyBanHang2;Integrated Security=True";
        private SqlConnection sqlCnn = null;

        // Design Partern Singleton
        private static ConnectData instance; // Ctrl + R + E

        public static ConnectData Instance 
        { 
            get { if (instance == null) instance = new ConnectData(); return ConnectData.instance; }
            private set => instance = value; // Chỉ nội bộ 
        }

        private ConnectData() { }

        // Connect Database

        // opening connect method
        void OpenConnect()
        {
            sqlCnn = new SqlConnection(strConnect);
            if (sqlCnn.State != ConnectionState.Open)
                sqlCnn.Open();
        }
        //Closing connect method
        void CloseConnect()
        {
            if (sqlCnn.State != ConnectionState.Closed)
            {
                sqlCnn.Close();
                sqlCnn.Dispose();
            }
        }
        //insert,update,delete data
        public void UpdateData(string sql)
        {
            OpenConnect();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = sqlCnn;
            sqlComm.CommandText = sql;
            sqlComm.ExecuteNonQuery();
            CloseConnect();
            sqlComm.Dispose();
        }
        //Select data to return a DataTable
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OpenConnect();
            SqlDataAdapter sqldata = new SqlDataAdapter(sqlSelect, sqlCnn);
            sqldata.Fill(dt);
            CloseConnect();
            sqldata.Dispose();
            return dt;
        }

        public void FillCombobox(ComboBox cb, DataTable dt, string displayMember, string valueMember)
        {
            cb.DataSource = dt;
            cb.DisplayMember = displayMember;
            cb.ValueMember = valueMember;
        }

        public string AutoIncrease(string tableName, string columnName, string startValue)
        {
            OpenConnect();

            int idx = 1;
            string ans = "";
            do
            {
                string endValue = idx < 10 ? "0" + idx.ToString() : idx.ToString();
                ans = startValue + endValue;
                DataTable dt = ReadData("Select * from " + tableName + " where " + columnName + "='" + ans + "'");
                if (dt.Rows.Count == 0)
                {
                    break;
                }
                else
                {
                    idx++;
                }
            } while (true);

            CloseConnect();

            return ans;
        }
     }
}
