using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_3
{
    public partial class Billing_form : Form
    {
        public Billing_form()
        {
            InitializeComponent();
        }

        private void phar_view_Load(object sender, EventArgs e)
        {
            txt_total_price.Text = "0";
      
          
            
            grd_invoice_details.EnableHeadersVisualStyles = false;
            grd_invoice_details.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            SqlDataReader READER = items_class.ITEMS_NAMES_MET();
            while(READER.Read())
            {
                string NAME = READER["Item_Name"].ToString();
                cmb_item_name.Items.Add(NAME);
            }

           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            pharmacist_login pl = new pharmacist_login();
            pl.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_item_form ai = new add_item_form();
            ai.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_item di = new delete_item();
            di.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_item ui = new update_item();
            ui.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order_class oc = new Order_class();
            Customer_class ct = new Customer_class();
            pharmacist_class pt = new pharmacist_class();
            items_class it = new items_class();

            ct.customer_name_prop = txt_cus_name.Text;
            ct.customer_no_prop = int.Parse(txt_cus_id.Text);
            it.name_prop = cmb_item_name.Text;
            oc.invoice_no_prop = int.Parse(txt_invoice_num.Text);
            oc.order_quantity_prop = int.Parse(txt_order_quantity.Text);
            pt.id_prop = int.Parse(txt_pharmacist_id.Text);
            SqlDataReader reader = it.get_PRICE(cmb_item_name.Text);
            int price=0;
            while (reader.Read())
            {
                 price = reader["Sale_Price"].GetHashCode();
            }
            int totalprice = oc.order_quantity_prop * price;
            txt_total_price.Text = Convert.ToString(int.Parse(txt_total_price.Text) + totalprice);
            //int.Parse(txt_total_price.Text) = totalprice;
           // txt_total_price.Text = " JWCHIB WCDH WE";
            grd_invoice_details.Rows.Add(it.name_prop, price, oc.order_quantity_prop, totalprice);
            oc.assign_customer_order(ct);
            oc.assign_Items_order(it);
            oc.assign_pharmacist_order(pt);
            oc.add_new_item_in_order();
            txt_order_quantity.Clear();
            cmb_item_name.Text = "";
        }

        private void txt_pharmacist_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCUSTPHAR_Click(object sender, EventArgs e)
        {
            Customer_class ct = new Customer_class();
           //int num = ct.assignCustomer_no();
         //  txt_cus_id.Text = Convert.ToString(num);
            Order_class oc = new Order_class();
            //Customer_class ct = new Customer_class();
           // pharmacist_class pt = new pharmacist_class();
           // items_class it = new items_class();

            ct.customer_name_prop = txt_cus_name.Text;
            ct.customer_no_prop = int.Parse(txt_cus_id.Text);
           // it.name_prop = cmb_item_name.Text;
            oc.invoice_no_prop = int.Parse(txt_invoice_num.Text);
           // oc.order_quantity_prop = int.Parse(txt_order_quantity.Text);
           // pt.id_prop = int.Parse(txt_pharmacist_id.Text);
           // SqlDataReader reader = it.get_PRICE(cmb_item_name.Text);
          //  int price = 0;
          //  while (reader.Read())
         //   {
          //      price = reader["Sale_Price"].GetHashCode();
         //   }

            //
          //  grd_invoice_details.Rows.Add(it.name_prop, price, oc.order_quantity_prop, oc.order_quantity_prop * price);
            oc.assign_customer_order(ct);
         //   oc.assign_Items_order(it);
           // oc.assign_pharmacist_order(pt);
            oc.add_new_order();
        }

        private void cmb_item_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LBL_TOTALPRICE_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_submit_order_Click(object sender, EventArgs e)
        {
            txt_cus_id.Clear();
            txt_cus_name.Clear();
            txt_invoice_num.Clear();
            txt_pharmacist_id.Clear();
            txt_total_price.Text = "0";
            grd_invoice_details.Rows.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Other_form of = new Other_form();
            of.Show();
            this.Hide();
        }
    }
}
