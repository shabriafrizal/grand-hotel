using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop
{
    class Helper
    {
        Connection con = new Connection();

        public DataTable getTable(string query)
        {
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = con.getConnection();
            con.openCon();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            con.closeCon();

            return dt;
        }

        public DataTable getTableCmd(SqlCommand cmd)
        {
            cmd.Connection = con.getConnection();
            con.openCon();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            con.closeCon();

            return dt;
        }

        public int insert(string query)
        {
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = con.getConnection();
            con.openCon();
            var res = cmd.ExecuteNonQuery();
            con.closeCon();

            return res;
        }

        public int insertCmd(SqlCommand cmd)
        {
            cmd.Connection = con.getConnection();
            con.openCon();
            var res = cmd.ExecuteNonQuery();
            con.closeCon();

            return res;
        }
    }
}
