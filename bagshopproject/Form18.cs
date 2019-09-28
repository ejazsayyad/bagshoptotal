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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
            fillcombo();
        }
        void fillcombo()
        {
            string Query = "select distinct bagtype from bagshop.cart";
            MySqlCommand cmd = new MySqlCommand(Query, cond);
            MySqlDataReader reader;
            cond.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sname = reader.GetString("bagtype");
                comboBox1.Items.Add(sname);
            }
            cond.Close();

        }
        public static string sname, sname2, sname3, sname4, sname5, sname6, sname7, str;
        MySqlConnection cond = new MySqlConnection("datasource=localhost;username=root;password=mysql;database=bagshop");

        private void Form18_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bagshopDataSet16.cart' table. You can move, or remove it, as needed.
           // this.cartTableAdapter1.Fill(this.bagshopDataSet16.cart);
            // TODO: This line of code loads data into the 'bagshopDataSet14.cart' table. You can move, or remove it, as needed.
            //this.cartTableAdapter.Fill(this.bagshopDataSet14.cart);
            this.WindowState = FormWindowState.Maximized;
            displaydata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displaydata()
        {

            string Query = "select * from bagshop.cart";
            MySqlCommand cmd = new MySqlCommand(Query, cond);
            cond.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cond.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Querysum = " select sum(bagprice) from bagshop.cart ";
            MySqlCommand command = new MySqlCommand(Querysum, cond);
            MySqlDataReader reader;
            cond.Open();
            reader = command.ExecuteReader();

            while (reader.Read())
            {

                label3.Text = reader["sum(bagprice)"].ToString();
            }
            cond.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sname = comboBox3.Text;
            string Query2 = "select distinct bagid from bagshop.cart  where bagtype='" + comboBox3.Text + "';";
            MySqlCommand cmd2 = new MySqlCommand(Query2, cond);
            MySqlDataReader reader;
            cond.Open();
            reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                sname = reader.GetString("bagid");
                comboBox3.Items.Add(sname);
            }
            cond.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string deleteQuery = "delete from bagshop.cart where (bagid=" + comboBox3.Text + " and bagtype='" + comboBox1.Text + "' and bagbrand='" + comboBox2.Text + "' );";
            MySqlCommand command = new MySqlCommand(deleteQuery, cond);
            MySqlDataReader reader;
            cond.Open();
            reader = command.ExecuteReader();
            MessageBox.Show("Data Deleted From The Cart Successfully!!!");
            while (reader.Read())
            {

            }
            cond.Close();
            displaydata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label3.Text=="")
            {
                MessageBox.Show("Please click on show price first to show total price then click on payment!!!");
            }
            else
            {
                this.Hide();
                Form6.val1 = label3.Text;
                Form6 bg = new Form6();
                bg.MdiParent = this.MdiParent;
                bg.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form17 home = new Form17();
            home.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sname3 = comboBox1.Text;
            string Query2 = "select distinct bagid from bagshop.cart  where bagtype='" + comboBox1.Text + "';";
            string Query1 = "select distinct bagbrand from bagshop.cart where bagtype='" + comboBox1.Text + "';";
            MySqlCommand cmd1 = new MySqlCommand(Query1, cond);
            MySqlCommand cmd2 = new MySqlCommand(Query2, cond);
            MySqlDataReader reader1, reader2;
            cond.Open();
            reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                sname6 = reader1.GetString("bagbrand");
                if (!comboBox2.Items.Contains(sname6))
                    comboBox2.Items.Add(sname6);
            }

            cond.Close();
            cond.Open();
            reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                sname7 = reader2.GetString("bagid");
                if (!comboBox3.Items.Contains(sname7))
                    comboBox3.Items.Add(sname7);
            }

            cond.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sname4 = comboBox2.Text;
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sname5 = comboBox3.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
