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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=mysql;database=bagshop");


        private void Form19_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bagshopDataSet15.payment' table. You can move, or remove it, as needed.
            //this.paymentTableAdapter.Fill(this.bagshopDataSet15.payment);
            this.WindowState = FormWindowState.Maximized;
            displaydata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displaydata()
        {

            string Query = "select * from bagshop.payment";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            connection.Close();

        }
    }
}
