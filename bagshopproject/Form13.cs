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
    public partial class Form13 : Form
    {
        MySqlConnection cond = new MySqlConnection("datasource=localhost;username=root;password=mysql;database=bagshop");
        public static string sname, sname2, sname3, sname4, sname5, sname6, sname7, str;
        public Form13()
        {
            InitializeComponent();
            fillcombo();
        }
        


        private void Form13_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'bagshopDataSet13.bags' table. You can move, or remove it, as needed.
//this.bagsTableAdapter2.Fill(this.bagshopDataSet13.bags);
            displaydata();
            this.WindowState = FormWindowState.Maximized;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void displaydata()
        {

            string Query = "select * from bagshop.bags";
            MySqlCommand cmd = new MySqlCommand(Query, cond);
            cond.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cond.Close();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void fillcombo()
        {
            string Query = "select distinct bagtype from bagshop.bags";
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

        private void button2_Click(object sender, EventArgs e)
        {
            string Query = "insert into bagshop.buy(bagtype,bagbrand,bagid)values('" + sname3 + "','" + sname4 + "','" + sname5 + "'); ";

            MySqlCommand cmd = new MySqlCommand(Query, cond);
            MySqlDataReader reader3;

            cond.Open();
            reader3 = cmd.ExecuteReader();
            MessageBox.Show("Saved");
            while (reader3.Read())
            {

            }
            cond.Close();

            Form6 bg = new Form6();
            bg.MdiParent = this.MdiParent;
            bg.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sname3 = comboBox1.Text;
            string Query2 = "select distinct bagid from bagshop.bags  where bagtype='" + comboBox1.Text + "';";
            string Query1 = "select distinct bagbrand from bagshop.bags where (bagtype='" + comboBox1.Text + "');";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox3.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string bagid = comboBox3.Text;
                string Querycombo = "select bagprice from bagshop.bags where bagid='" + bagid + "'";
                MySqlCommand command = new MySqlCommand(Querycombo, cond);
                MySqlDataReader reader;
                cond.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {

                    label8.Text = reader["bagprice"].ToString();
                }
                cond.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            sname5 = comboBox3.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox3.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Any of the Fields cannot be Empty!!!");
            }
            else
            {
                string insertQuery = "insert into bagshop.cart(bagtype,bagbrand,bagid,bagprice) values('" + comboBox1.Text + "','" + comboBox2.Text + "'," + comboBox3.Text + "," + label8.Text + ")";

                MySqlCommand command = new MySqlCommand(insertQuery, cond);
                MySqlDataReader reader;
                cond.Open();
                reader = command.ExecuteReader();
                MessageBox.Show("Item Added To The Cart Successfully!!!");
                while (reader.Read())
                {

                }
                cond.Close();
                comboBox1.Text="";
                comboBox2.Text="";
                comboBox3.Text="";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 home = new Form18();
            home.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
