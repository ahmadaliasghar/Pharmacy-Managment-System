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
    public partial class sales_report_form : Form
    {
        public sales_report_form()
        {
            InitializeComponent();
        }

        private void phar_view_Load(object sender, EventArgs e)
        {

            grd_sales_details.EnableHeadersVisualStyles = false;
            grd_sales_details.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
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
            pharmacist_form av = new pharmacist_form();
            av.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            purchase_report_form pr = new purchase_report_form();
            pr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vendor_form mc = new vendor_form();
            mc.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customers_FORM c = new Customers_FORM();
            c.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Items_FORM id = new Items_FORM();
            id.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string a = txt_start_date__sales.Text;
            string b = txt_end_date_sales.Text;
            SqlDataReader reader = Order_class.sales_DETAILS_METHOD(a, b);

            while (reader.Read())
            {
                string invoice = reader["Invoice_Number"].ToString();
                string date = reader["Invoice_Date"].ToString();
                string item_code = reader["Item_Code"].ToString();
                string item_name = reader["Item_Name"].ToString();
                string cust_id = reader["CustomerID"].ToString();
                string cust_name = reader["Customer_Name"].ToString();
                string phar_id = reader["PharmacistID"].ToString();
                string phar_name = reader["Pharmacist_Name"].ToString();




                grd_sales_details.Rows.Add(invoice, date, item_code, item_name, cust_id, cust_name, phar_id, phar_name);
            }
        }
    }
}
