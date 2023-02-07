using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT_3
{
    public partial class ADMIN_LOGIN : Form
    {
        public ADMIN_LOGIN()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_back_Click(object sender, EventArgs e)
        {
           /* admin_login al = new admin_login();
            al.Show();
            this.Hide();*/
            pharmacist_login pl = new pharmacist_login();
            pl.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_staff_login_Click(object sender, EventArgs e)
        {
            pharmacist_form av = new pharmacist_form();
            av.Show();
            this.Hide();

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
