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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=mysql;database=bagshop");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bagshopDataSet11.bags' table. You can move, or remove it, as needed.
           // this.bagsTableAdapter2.Fill(this.bagshopDataSet11.bags);
           // this.WindowState = FormWindowState.Minimized;
           
            this.WindowState = FormWindowState.Maximized;
            displaydata();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
        public void displaydata()
        {

            string Query = "select * from bagshop.bags";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bagsTableAdapter.FillBy(this.bagshopDataSet.bags);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bagsTableAdapter.FillBy1(this.bagshopDataSet.bags);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text =="" || textBox3.Text  =="" || textBox4.Text =="")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string insertQuery = "insert into bagshop.bags(bagtype,bagbrand,bagprice) values('" + textBox2.Text + "','" + textBox3.Text + "'," + textBox4.Text + ")";

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

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string Query = "update bagshop.bags set bagtype='" + textBox2.Text + "',bagbrand='" + textBox3.Text + "',bagprice=" + textBox4.Text + " where bagtype='" + textBox2.Text + "';";
                MySqlCommand cmd = new MySqlCommand(Query, connection);
                MySqlDataReader Reader;
                connection.Open();
                Reader = cmd.ExecuteReader();
                MessageBox.Show("Data Updated Successfully!!!");
                while (Reader.Read())
                {

                }
                connection.Close();
                displaydata();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string deleteQuery = "delete from bagshop.bags where (bagtype = '" + textBox2.Text + "' and  bagbrand = '" + textBox3.Text + "' and bagprice = '" + textBox4.Text + "' );";

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

