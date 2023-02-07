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
    public partial class delete_item : Form
    {
        public delete_item()
        {
            InitializeComponent();
        }

        private void phar_view_Load(object sender, EventArgs e)
        {
            SqlDataReader READER = items_class.ITEMS_NAMES_MET();
            while (READER.Read())
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
            items_class ic = new items_class();
            ic.name_prop = cmb_item_name.Text;
            ic.delete_items();
            MessageBox.Show("Item Deleted Successfully!");
            cmb_item_name.Text = "";
            cmb_item_name.Items.Clear();
            SqlDataReader READER = items_class.ITEMS_NAMES_MET();
            while (READER.Read())
            {
                string NAME = READER["Item_Name"].ToString();
                cmb_item_name.Items.Add(NAME);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Other_form of = new Other_form();
            of.Show();
            this.Hide();
        }
    }
}
