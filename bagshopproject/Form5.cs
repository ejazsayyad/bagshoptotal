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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=mysql");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string insertQuery = "insert into bagshop.employee(empname,empmobno,empmailid,empaddress,emppost) values('" + textBox2.Text + "'," + textBox3.Text + ",'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "' )";

                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Data Inserted Successfully!!!");
                while (reader.Read())
                {

                }
                connection.Close();


                displaydata();
            }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public void displaydata()
        {

            string Query = "select * from bagshop.employee";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
        private void Form5_Load(object sender, EventArgs e)
        {
           
           this.WindowState = FormWindowState.Maximized;
           displaydata();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string Query = "update bagshop.employee set empname='" + textBox2.Text + "',empmobno=" + textBox3.Text + ",empmailid='" + textBox4.Text + "',empaddress='" + textBox5.Text + "',emppost='" + textBox6.Text + "' where empname='" + textBox2.Text + "';";
                MySqlCommand command = new MySqlCommand(Query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Data Updated Successfully!!!");
                while (reader.Read())
                {

                }
                connection.Close();
                displaydata();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" )
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string deleteQuery = "delete from bagshop.employee where (empname = '" + textBox2.Text + "' and empmobno ='" + textBox3.Text + "');";

                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Data Deleted Successfully!!!");
                while (reader.Read())
                {

                }
                connection.Close();


                displaydata();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
