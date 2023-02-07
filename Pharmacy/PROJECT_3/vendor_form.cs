using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROJECT_3
{
    public partial class vendor_form : Form
    {
        public vendor_form()
        {
            InitializeComponent();
        }

        private void phar_view_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = vendor_class.company_DETAILS_MET();

            while(reader.Read())
            {
                string id = reader["VendorID"].ToString();
                string name = reader["Vendor_Name"].ToString();
                string contact = reader["Vendor_Contact"].ToString();
                grd_company_details.Rows.Add(id, name, contact);
            }
           

            grd_company_details.EnableHeadersVisualStyles = false;
            grd_company_details.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;

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
            sales_report_form sr = new sales_report_form();
            sr.Show();
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
            pharmacist_form av = new pharmacist_form();
            av.Show();
            this.Hide();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
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

        private void grd_items_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
