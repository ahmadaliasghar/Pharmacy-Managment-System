using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_3
{
    class vendor_class
    {
        private int vendor_id;
        private string vendor_name;
        private string vendor_contact;


        /*public vendor_class(int company_num,string company_name,int company_contact)
        {
            this.company_num = company_num;
            this.company_name = company_name;
            this.company_contact = company_contact;

        }*/
        public static SqlDataReader company_DETAILS_MET()
        {
            string query = "Select * From Vendor_T;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;


        }
        public int vendor_id_prop { get { return vendor_id; } set { vendor_id = value; } }
        public string vendor_name_prop { get { return vendor_name; } set { vendor_name = value; } }

        public string vendor_contact_prop { get { return vendor_contact; } set { vendor_contact = value; } }


    }
}
