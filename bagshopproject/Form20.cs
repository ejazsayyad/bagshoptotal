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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("datasource=localhost;username=root;password=mysql;database=bagshop");


        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bagshopDataSet19.accountdetails' table. You can move, or remove it, as needed.
           // this.accountdetailsTableAdapter2.Fill(this.bagshopDataSet19.accountdetails);
            // TODO: This line of code loads data into the 'bagshopDataSet18.accountdetails' table. You can move, or remove it, as needed.
            //this.accountdetailsTableAdapter1.Fill(this.bagshopDataSet18.accountdetails);
            // TODO: This line of code loads data into the 'bagshopDataSet17.accountdetails' table. You can move, or remove it, as needed.
            //this.accountdetailsTableAdapter.Fill(this.bagshopDataSet17.accountdetails);
            this.WindowState = FormWindowState.Maximized;
            displaydata();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displaydata()
        {

            string Query = "select * from bagshop.accountdetails";
            MySqlCommand cmd = new MySqlCommand(Query, connection);
            connection.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            connection.Close();

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
