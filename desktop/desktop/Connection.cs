using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop
{
    class Connection
    {
        public SqlConnection con;

        public Connection()
        {
            string conString = @"Data Source=.; initial catalog=DB_HOTEL; integrated security=true";
            con = new SqlConnection(conString);
        }

        public SqlConnection getConnection()
        {
            return con;
        }

        public void openCon()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }

        public void closeCon()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
