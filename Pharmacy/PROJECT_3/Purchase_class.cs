using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
                                                                
namespace PROJECT_3
{
    class Purchase_class
    {
        private int receipt_id;
        private string receipt_date;
        private items_class items;
        private vendor_class vendors;


        public static SqlDataReader purchase_DETAILS_METHOD(string  date1,string date2)
        {
          

            string query = "Select * From PURCHASE_REPORT WHERE Purchase_Date >= @date1 and Purchase_Date <= @date2 ;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("date1", date1);
            COMMAND.Parameters.AddWithValue("date2", date2);

            SqlDataReader reader = COMMAND.ExecuteReader();
            return reader;


        }
        public int receipt_id_prop { get { return receipt_id; } set { receipt_id = value;} }
        public string receipt_date_prop { get { return receipt_date; } set { receipt_date = value; } }
        public void assign_items_to_purchase(items_class items)
        {
            this.items = items;
        }
        public void assign_vendor_purchase(vendor_class vendors)
        {
            this.vendors = vendors;
        }
        public void add_new_item()
        {

            string query = "exec Add_PURCHASE @receiptid =@receiptid2,@itemcode = @itemcode2, @vendorid = @vendorid2,@itemname = @itemname2,@quantity = @quantity2,@expiry = @expiry2,  @pur_price  = @pur_price2, @sal_price =  @sal_price2,@rack = @rack2,@vendorname = @vendorname2,@vendor_contact = @vendor_contact2;";
               SqlConnection CONNECT = CONNECTION.getconnection();
               SqlCommand COMMAND = new SqlCommand(query, CONNECT);
               COMMAND.Parameters.AddWithValue("receiptid2",receipt_id);
               COMMAND.Parameters.AddWithValue("vendorid2",vendors.vendor_id_prop );
               COMMAND.Parameters.AddWithValue("vendorname2", vendors.vendor_name_prop);
               COMMAND.Parameters.AddWithValue("vendor_contact2", vendors.vendor_contact_prop);
               COMMAND.Parameters.AddWithValue("itemcode2", items.code_prop);
               COMMAND.Parameters.AddWithValue("itemname2", items.name_prop);
               COMMAND.Parameters.AddWithValue("quantity2", items.quantity_prop);
               COMMAND.Parameters.AddWithValue("expiry2", items.date_prop);
               COMMAND.Parameters.AddWithValue("pur_price2", items.pur_price_prop);
               COMMAND.Parameters.AddWithValue("sal_price2", items.sake_price_prop);
               COMMAND.Parameters.AddWithValue("rack2", items.rack_prop);
               COMMAND.ExecuteNonQuery();
        }
        public void add_existing_item()
        {

            string query = "exec Add_PURCHASE_existing_item @receiptid =@receiptid2, @vendorid = @vendorid2,@itemname = @itemname2,@quantity = @quantity2,@vendorname = @vendorname2,@vendor_contact = @vendor_contact2;";
            SqlConnection CONNECT = CONNECTION.getconnection();
            SqlCommand COMMAND = new SqlCommand(query, CONNECT);
            COMMAND.Parameters.AddWithValue("receiptid2", receipt_id);
            COMMAND.Parameters.AddWithValue("vendorid2", vendors.vendor_id_prop);
            COMMAND.Parameters.AddWithValue("vendorname2", vendors.vendor_name_prop);
            COMMAND.Parameters.AddWithValue("vendor_contact2", vendors.vendor_contact_prop);
            COMMAND.Parameters.AddWithValue("itemname2", items.name_prop);
            COMMAND.Parameters.AddWithValue("quantity2", items.quantity_prop);

            COMMAND.ExecuteNonQuery();
        }
    }
}
