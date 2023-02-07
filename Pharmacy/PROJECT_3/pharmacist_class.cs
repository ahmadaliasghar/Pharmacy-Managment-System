using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PROJECT_3
{
    class pharmacist_class
    {
        private  int id;
        private string name;
        private int salary;
        private int age;


        public static SqlDataReader pharmacist_DETAILS_METHOD()
        {
            string query = "Select * From Pharmacist_T;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;


        }

        public int id_prop { get { return id; } set { id = value; } }
        public string name_prop { get { return name; } set { name = value; } }
        public int salary_prop { get { return salary; } set { salary = value; } }
        public int age_PROP { get { return age; } set { age = value; } }

        public  void add_pharmacist()
        {
            string query = "INSERT INTO Pharmacist_T VALUES(@id,@name,@salary,@age);";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("id", id);
            COMMAND.Parameters.AddWithValue("name", name);
            COMMAND.Parameters.AddWithValue("salary", salary);
            COMMAND.Parameters.AddWithValue("age", age);
            COMMAND.ExecuteNonQuery();
        }
        public void delete_pharmacist()
        {
            string query = "delete from Pharmacist_T where PharmacistID =@id";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("id", id);

            COMMAND.ExecuteNonQuery();
        }
    }
}
