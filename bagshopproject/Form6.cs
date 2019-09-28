using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace bagshopproject
{
    public partial class Form6 : Form
    {
        
        public Form6()
        {
            InitializeComponent();
            textBox2.Text = val1;
           
        }
        public static string val1;
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=mysql");

        private void button1_Click(object sender, EventArgs e)
        {

        }

       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string insertQuery = "insert into bagshop.payment(total,custname,paymethod,paymentdate) values(" + textBox2.Text + ",'" + textBox3.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "')";
                string truncatequery = "truncate bagshop.cart";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Payment Done Successfully!!! Thanks For Using ");
                while (reader.Read())
                {

                }
                reader.Close();
                MySqlCommand cmd = new MySqlCommand(truncatequery, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
                this.Close();
            }
        }
    }
}
