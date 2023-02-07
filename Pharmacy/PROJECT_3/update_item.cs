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
    public partial class update_item : Form
    {
        public update_item()
        {
            InitializeComponent();
        }

        private void phar_view_Load(object sender, EventArgs e)
        {
            SqlDataReader READER = items_class.ITEMS_NAMES_MET();
            while (READER.Read())
            {
                string NAME = READER["Item_Name"].ToString();
                cmb_previous_name.Items.Add(NAME);
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
            Billing_form pv = new Billing_form();
            pv.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_item_form ai = new add_item_form();
            ai.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            delete_item di = new delete_item();
            di.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.name_prop = cmb_previous_name.Text;
            string new_name;
            new_name = txt_update_name.Text;
            ic.update_item_name(new_name);
            MessageBox.Show("Item Updated Successfully!");
            cmb_previous_name.Text = "";
            txt_update_name.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.name_prop = cmb_previous_name.Text;
            ic.pur_price_prop = int.Parse(txt_update_pur_price.Text);

            ic.update_item_purchase_price();
            MessageBox.Show("Item Updated Successfully!");
            cmb_previous_name.Text = "";
            txt_update_pur_price.Clear();
        }

        private void btn_update_sal_price_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.name_prop = cmb_previous_name.Text;
            ic.sake_price_prop= int.Parse(txt_update_sell_price.Text);
            ic.update_item_sale_price();
            MessageBox.Show("Item Updated Successfully!");
            cmb_previous_name.Text = "";
            txt_update_sell_price.Clear();

        }

        private void btn_update_rack_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.name_prop = cmb_previous_name.Text;
            ic.rack_prop = int.Parse(txt_update_rack.Text);

            ic.update_item_rack();
            MessageBox.Show("Item Updated Successfully!");
            cmb_previous_name.Text = "";
            txt_update_rack.Clear();
        }

        private void btn_update_quantity_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.name_prop = cmb_previous_name.Text;
            ic.quantity_prop = int.Parse(txt_quantity.Text);

            ic.update_item_quantity();
            MessageBox.Show("Item Updated Successfully!");
            cmb_previous_name.Text = "";
            txt_quantity.Clear();
        }

        private void btn_update_expiry_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.name_prop = cmb_previous_name.Text;
            ic.date_prop =txt_update_expiry.Text;

            ic.update_item_expiry();
            MessageBox.Show("Item Updated Successfully!");
            cmb_previous_name.Text = "";
            txt_update_expiry.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Other_form of = new Other_form();
            of.Show();
            this.Hide();
        }
    }
}
