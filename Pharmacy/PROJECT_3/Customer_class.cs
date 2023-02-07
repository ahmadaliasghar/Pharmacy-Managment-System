using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;

namespace PROJECT_3
{
    class Customer_class
    {
      //  public static  int Customer_id = 400;
        private int customer_no;
            private string customer_name;
            private static int Assign_no;
            public int assignCustomer_no()
            {
                Assign_no = Assign_no + 1;
                return Assign_no;
            }
        public static SqlDataReader CUSTOMER_DETAILS_METHOD()
        {
            string query = "Select * From Customer_T;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;


        }
        public int customer_no_prop { get { return customer_no; } set { customer_no = value; } }
        public string customer_name_prop { get { return customer_name; } set { customer_name = value; } }
    }
}
