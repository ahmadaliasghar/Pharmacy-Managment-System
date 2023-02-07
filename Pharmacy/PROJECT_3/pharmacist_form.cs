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
    public partial class pharmacist_form : Form
    {
        public pharmacist_form()
        {
            InitializeComponent();
        }

        private void phar_view_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = pharmacist_class.pharmacist_DETAILS_METHOD();

            while (reader.Read())
            {
                string id = reader["PharmacistID"].ToString();
                string name = reader["Pharmacist_Name"].ToString();
                string salary = reader["Salary"].ToString();
                string age = reader["age"].ToString();


                       grd_pharmacist_details.Rows.Add(id, name, salary,age);
            }


             grd_pharmacist_details.EnableHeadersVisualStyles = false;
             grd_pharmacist_details.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
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
            pharmacist_class pc = new pharmacist_class();
            pc.id_prop =int.Parse(txt_id_pharmacist.Text);
            pc.name_prop = txt_name_pharmacist.Text;
                pc.salary_prop =int.Parse(txt_salary_pharmacist.Text);
                pc.age_PROP = int.Parse(txt_age_pharmacist.Text);
                pc.add_pharmacist();

            ///////////////////////////////////////////////////////////////////////
                SqlDataReader reader = pharmacist_class.pharmacist_DETAILS_METHOD();

                grd_pharmacist_details.Rows.Clear();
                while (reader.Read())
                {
                    string id = reader["PharmacistID"].ToString();
                    string name = reader["Pharmacist_Name"].ToString();
                    string salary = reader["Salary"].ToString();
                    string age = reader["age"].ToString();


                    grd_pharmacist_details.Rows.Add(id, name, salary, age);
                }
                txt_id_pharmacist.Clear();
                txt_name_pharmacist.Clear();
                txt_salary_pharmacist.Clear();
                txt_age_pharmacist.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pharmacist_class pc = new pharmacist_class();
            pc.id_prop = int.Parse(txt_del_pharmacist.Text);
            pc.delete_pharmacist();
            MessageBox.Show("Pharmacist Deleted Successfully!");
            txt_del_pharmacist.Clear();
            SqlDataReader reader = pharmacist_class.pharmacist_DETAILS_METHOD();

            grd_pharmacist_details.Rows.Clear();
            while (reader.Read())
            {
                string id = reader["PharmacistID"].ToString();
                string name = reader["Pharmacist_Name"].ToString();
                string salary = reader["Salary"].ToString();
                string age = reader["age"].ToString();


                grd_pharmacist_details.Rows.Add(id, name, salary, age);
            }
        }

    }
}
