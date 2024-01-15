using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Connect
    {
        private SqlConnection con = new SqlConnection(@"Data Source=MewTheDev\MEWTHEDEV;Initial Catalog=QLDA;Integrated Security=True;TrustServerCertificate=True");

        public DataTable Load(string sql)
        {
            con.Open();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable data = new DataTable();
            ad.Fill(data);
            con.Close();
            return data;
        }

        public DataTable Load(string sql, SqlParameter[] parameters)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            ad.Fill(data);
            con.Close();
            return data;
        }

        public void Execute(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Execute(string sql, SqlParameter[] parameters)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
