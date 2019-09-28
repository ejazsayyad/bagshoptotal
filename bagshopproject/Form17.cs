using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bagshopproject
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 aa = new Form8();
            aa.MdiParent = this;
            aa.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bagsInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 bg1 = new Form3();
            bg1.MdiParent = this;
            bg1.Show();
        }

        private void buyBagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form13 aa = new Form13();
            aa.MdiParent = this;
            aa.Show();
        }

        private void employeeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 aa = new Form5();
            aa.MdiParent = this;
            aa.Show();
        }

        

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.MdiParent = this;
            f8.Show();
        }

        private void accountDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 aa = new Form19();
            aa.MdiParent = this;
            aa.Show();
        }

        private void accountLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form20 aa = new Form20();
            aa.MdiParent = this;
            aa.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form19 aa = new Form19();
            aa.MdiParent = this;
            aa.Show();
        }
    }
}
