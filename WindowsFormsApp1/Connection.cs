using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;

namespace WindowsFormsApp1

{
    class Connection
    {
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=LD;Initial Catalog=MyDatabase;Integrated Security=True";
            return con;
        }
    }
    
}
