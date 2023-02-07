using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PROJECT_3
{
    class CONNECTION
    {
        public static SqlConnection  getconnection()
        {
            string strconnect = @"Data Source= IM6882696577\SQLEXPRESS;Initial Catalog = Pharmacy_Project_P;Integrated Security=True";

            SqlConnection connection = new SqlConnection(strconnect);
            connection.Open();
            return connection;
        }
    }
}
