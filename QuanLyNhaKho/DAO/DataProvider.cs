using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaKho.DAO
{
    public class DataProvider
    {
        //  public static string stringConnection = @"Data Source=HUNGTRAN;Initial Catalog=QuanLyNhaKho;Integrated Security=True";
        //public static string stringConnection = @"Data Source = DESKTOP-I324HJM\SQLEXPRESS; Initial Catalog=QuanLyNhaKho;Integrated Security=True";
        public static string stringConnection = @"Data Source = HMCHOAN-JLMSP5D\SQLEXPRESS; Initial Catalog=QuanLyNhaKho;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(stringConnection);
        public static int NonQuery(string query, params SqlParameter[] param)
        {
            con.Open();
            SqlCommand sc = new SqlCommand(query, con);
            int result = 0;
            if (param == null)
            {
                sc.CommandType = CommandType.Text;      
            }
            else
                sc.CommandType = CommandType.StoredProcedure;
                param.ToList().ForEach(x => sc.Parameters.Add(x));
            try
            {
                result = sc.ExecuteNonQuery();
                con.Close();
            } catch (SqlException e)
            {
                con.Close();
                return -1;
            }
            return result;
        }

        public static DataTable Query(string query, params SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = null;
            con.Open();
            if (param == null)
            {
                da = new SqlDataAdapter(query, con);
            }
            else
            {
                SqlCommand sc = new SqlCommand(query, con);
                sc.CommandType = CommandType.StoredProcedure;
                param.ToList().ForEach(x => sc.Parameters.Add(x));
                da = new SqlDataAdapter(sc);
            }
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
