using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    class Connect
    {
        public string StrCon = @"Data Source = DESKTOP-THSU5UG\SQLEXPRESS; Database = NabiBookStore; Integrated Security = true";
        public DataSet ds;
        public SqlCommand cmd;
        SqlDataAdapter sda;
        SqlConnection conn;
        public DataSet truyvan(String sql)
        {
            conn = new SqlConnection(StrCon);
            conn.Open();

            cmd = new SqlCommand(sql, conn);
            sda = new SqlDataAdapter(cmd);
            ds = new DataSet();
            sda.Fill(ds);

            conn.Close();
            return ds;
        }
        public bool CapNhatDB(string sql)
        {
            conn = new SqlConnection(StrCon);
            conn.Open();
            bool ck = false;
            cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                ck = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: Không cập nhật được!");
            }
            conn.Close();
            return ck;
        }

    }
}
