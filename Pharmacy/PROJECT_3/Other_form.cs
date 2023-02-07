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
    public partial class Other_form : Form
    {
        public Other_form()
        {
            InitializeComponent();
        }

        private void phar_view_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = items_class.ITEMS_shortage_DETAILS();

            while (reader.Read())
            {
                string code = reader["Item_Code"].ToString();
                string name = reader["Item_Name"].ToString();
                string quantity = reader["Item_Quantity"].ToString();
                string expiry = reader["Expiry_Date"].ToString();
              grd_item_shortage_details.Rows.Add(code, name, quantity, expiry);
               grd_item_shortage_details.EnableHeadersVisualStyles = false;
               grd_item_shortage_details.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Billing_form pv = new Billing_form();
            pv.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_item_form ai = new add_item_form();
            ai.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_item ui = new update_item();
            ui.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
