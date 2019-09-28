using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using MySql.Data.MySqlClient;

namespace bagshopproject
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        MySqlConnection connection;

        private void Form22_Load(object sender, EventArgs e)
        {
            string sql = null;
            
            connection = new MySqlConnection("datasource=localhost;username=root;password=mysql;database=bagshop");
            connection.Open();
            sql = "select total, custname, paymethod, paymentid, paymentdate from payment";
            
            MySqlDataAdapter dscmd = new MySqlDataAdapter(sql, connection);
            connection.Close();
            DataSet1 ds = new DataSet1();
            dscmd.Fill(ds, "DataTable1");
            CrystalReport1 objRpt = new CrystalReport1();
            objRpt.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = objRpt;
            //objRpt.DataDefinition.FormulaFields["UnboundString1"].Text = total;
            //objRpt.DataDefinition.FormulaFields["UnboundString2"].Text = custname; 
            //objRpt.DataDefinition.FormulaFields["UnboundString3"].Text = paymethod;
            //objRpt.DataDefinition.FormulaFields["UnboundString4"].Text = paymentid;
            //objRpt.DataDefinition.FormulaFields["UnboundString5"].Text = paymentdate; 
            crystalReportViewer1.Refresh();
            this.WindowState = FormWindowState.Maximized;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
