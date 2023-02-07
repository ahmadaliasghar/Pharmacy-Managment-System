using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace PROJECT_3
{
    class Order_class
    {
        private int invoice_no;
        private string date;
        private int order_quantity;
        private items_class items;
        private Customer_class customers;
        private pharmacist_class pharmacist;

        public int invoice_no_prop { get { return invoice_no; } set { invoice_no = value; } }
        public int order_quantity_prop { get { return order_quantity; } set { order_quantity = value; } }

        public static SqlDataReader sales_DETAILS_METHOD(string date1, string date2)
        {
            string query = "Select * From SALES_REPORT WHERE Invoice_Date >= @date1 and Invoice_Date <= @date2 ;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("date1", date1);
            COMMAND.Parameters.AddWithValue("date2", date2);

            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;


        }
        public void assign_Items_order(items_class items)
        {
            this.items = items;
        }
        public void assign_customer_order(Customer_class customers)
        {
            this.customers = customers;
        }
        public void assign_pharmacist_order(pharmacist_class pharmacist)
        {
            this.pharmacist = pharmacist;
        }
        public void add_new_item_in_order()
        {

            string query = "exec billing @invoice# =@invoice2 ,@customer# =@customer2, @cust_name = @cusname2, @item_name =@item_name2,@order_quantity= @order_quantity2,@phar_id = @phar_id2;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("invoice2", invoice_no);
            COMMAND.Parameters.AddWithValue("customer2", customers.customer_no_prop);
            COMMAND.Parameters.AddWithValue("cusname2", customers.customer_name_prop);
            COMMAND.Parameters.AddWithValue("item_name2",items.name_prop);
            COMMAND.Parameters.AddWithValue("order_quantity2",order_quantity );
            COMMAND.Parameters.AddWithValue("phar_id2", pharmacist.id_prop);

            COMMAND.ExecuteNonQuery();
        }
        public void add_new_order()
        {

            string query = "exec billing_cust_invoice @invoice# =@invoice2 ,@customer#=@customer2,@cust_name =@cust_name2 ";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("invoice2", invoice_no);
            COMMAND.Parameters.AddWithValue("customer2", customers.customer_no_prop);
            COMMAND.Parameters.AddWithValue("cust_name2", customers.customer_name_prop);

            COMMAND.ExecuteNonQuery();
        }

    }
}
