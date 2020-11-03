using System;
using System.Windows.Forms;
using WindowsFormsApp7;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp8
{
    public partial class create2 : Form
    {
        public create2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void ord_person_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void shop_name_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void shop_price_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void shop_number_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void re_person_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void phone_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void address_box_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            String ord_name = this.ord_person_box.Text;
            Database2 db= new Database2();
            MySqlConnection conn = db.getConn();
            String shop_name = this.shop_name_box.Text;
            String shop_price = this.shop_price_box.Text;
            String shop_number = this.shop_number_box.Text;
            String person = this.re_person_box.Text;
            String phone = this.phone_box.Text;
            String address = this.address_box.Text;
        }

        private void close_Click(object sender, EventArgs e)
        {
           this.Close();

        }
    }
}