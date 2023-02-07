using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_3
{
    class items_class
    {
        private int i_code;
        private string name;
        private int quantity;
        private string date;
        private int purchase_price;
        private int sale_price;
        private int rack;

        public static SqlDataReader ITEMS_DETAILS_MET()
        {
            string query = "Select * From Item_T";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query,CONNECT);
            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;
            

        }
        public static SqlDataReader ITEMS_shortage_DETAILS()
        {
            string query = "select Item_Code, Item_Name,Item_Quantity,Expiry_Date from Item_T where Item_Quantity<=5;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;


        }
        public SqlDataReader  get_PRICE(string n)
        {
            string QUERY = "SELECT Sale_Price FROM Item_T WHERE Item_Name = @name;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(QUERY, CONNECT);
            COMMAND.Parameters.AddWithValue("name", n);
            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;
            

        }
        public static SqlDataReader ITEMS_NAMES_MET()
        {
            string query = "Select Item_Name From Item_T";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;


        }
        public void delete_items()
        {
            string query = "delete from Item_T where Item_Name =@Name ;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("Name", name);
          
            COMMAND.ExecuteNonQuery();
        }
        public void update_item_name(string Name)
        {
            string query = "update Item_T set Item_Name =@Name where Item_Name=@Name2";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("Name", Name);
            COMMAND.Parameters.AddWithValue("Name2", name);

            COMMAND.ExecuteNonQuery();
        }
        public void update_item_quantity()
        {
            string query = "update Item_T set Item_Quantity =@Quantity where Item_Name=@Name";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("Name", name);
            COMMAND.Parameters.AddWithValue("Quantity", quantity);

            COMMAND.ExecuteNonQuery();
        }
        public void update_item_expiry()
        {
            string query = "update Item_T set Expiry_Date =@expiry where Item_Name=@name";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("name", name);
            COMMAND.Parameters.AddWithValue("expiry", date);


            COMMAND.ExecuteNonQuery();
        }
        public void update_item_purchase_price()
        {
            string query = "update Item_T set Purchase_Price = @pur_price where Item_Name=@Name";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("Name", name);
            COMMAND.Parameters.AddWithValue("pur_price", purchase_price);


            COMMAND.ExecuteNonQuery();
        }
        public void update_item_sale_price()
        {
            string query = "update Item_T set Sale_Price =@sal_price where Item_Name=@Name";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("Name", name);
            COMMAND.Parameters.AddWithValue("sal_price", sale_price);


            COMMAND.ExecuteNonQuery();

        }
        public void update_item_rack()
        {
            string query = "update Item_T set Item_Rack =@rack where Item_Name=@name";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("name", name);
            COMMAND.Parameters.AddWithValue("rack", rack);


            COMMAND.ExecuteNonQuery();
        }
        public int code_prop { get { return i_code; } set { i_code = value; } }
        public string name_prop { get { return name; } set { name = value; } }
        public int quantity_prop { get { return quantity; } set { quantity = value; } }
        public string date_prop { get { return date; } set { date = value; } }
        public int pur_price_prop { get { return purchase_price; } set { purchase_price = value; } }
        public int sake_price_prop { get { return sale_price; } set { sale_price = value; } }
        public int rack_prop { get { return rack; } set { rack = value; } }

      
    }
}
