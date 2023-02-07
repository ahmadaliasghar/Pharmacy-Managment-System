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
    public partial class add_item_form : Form
    {
        public add_item_form()
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billing_form pv = new Billing_form();
            pv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_item ui = new update_item();
            ui.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            delete_item di = new delete_item();
            di.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.code_prop=int.Parse(txt_item_code.Text);
            ic.name_prop=txt_item_name.Text;
                ic.quantity_prop=int.Parse(txt_item_quantity.Text);
                ic.date_prop=txt_item_expiry.Text;
                ic.pur_price_prop=int.Parse(txt_item_pur_price.Text);
                ic.sake_price_prop=int.Parse(txt_item_sale_price.Text);
                ic.rack_prop = int.Parse(txt_item_rack.Text);
                vendor_class vc = new vendor_class();
                vc.vendor_id_prop = int.Parse(txt_vendor_id.Text);
            vc.vendor_name_prop = txt_vendor_name.Text;
            vc.vendor_contact_prop =txt_vendor_contact.Text ;
            Purchase_class pc =  new Purchase_class();
            pc.receipt_id_prop = int.Parse(txt_receiptid_pur.Text);
            pc.assign_items_to_purchase(ic);
            pc.assign_vendor_purchase(vc);
               // ic.add_item();
            pc.add_new_item();
                MessageBox.Show("Items Added Successfully");

          
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_existing_item_Click(object sender, EventArgs e)
        {
            items_class ic = new items_class();
            ic.name_prop = cmb_item_name.Text;
            ic.quantity_prop = int.Parse(txt_quantity_exist.Text);
            vendor_class vc = new vendor_class();
            vc.vendor_id_prop = int.Parse(txt_vendorid_exist.Text);
            vc.vendor_name_prop = txt_vendor_name_exist.Text;
            vc.vendor_contact_prop = txt_vendor_contact_exist.Text;
            Purchase_class pc = new Purchase_class();
            pc.receipt_id_prop = int.Parse(txt_receiptid_exist.Text);
            pc.assign_items_to_purchase(ic);
            pc.assign_vendor_purchase(vc);
            // ic.add_item();
            pc.add_existing_item();
            MessageBox.Show("Items Added Successfully");

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Other_form of = new Other_form();
            of.Show();
            this.Hide();
        }
    }
}
