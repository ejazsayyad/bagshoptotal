namespace bagshopproject
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bagtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet11 = new bagshopproject.bagshopDataSet11();
            this.bagsTableAdapter2 = new bagshopproject.bagshopDataSet11TableAdapters.bagsTableAdapter();
            this.bagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet = new bagshopproject.bagshopDataSet();
            this.bagsTableAdapter = new bagshopproject.bagshopDataSetTableAdapters.bagsTableAdapter();
            this.bagsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet2 = new bagshopproject.bagshopDataSet2();
            this.bagsTableAdapter1 = new bagshopproject.bagshopDataSet2TableAdapters.bagsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            resources.ApplyResources(this.fillBy1ToolStrip, "fillBy1ToolStrip");
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bagtypeDataGridViewTextBoxColumn,
            this.bagbrandDataGridViewTextBoxColumn,
            this.bagpriceDataGridViewTextBoxColumn,
            this.bagidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bagsBindingSource2;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // bagtypeDataGridViewTextBoxColumn
            // 
            this.bagtypeDataGridViewTextBoxColumn.DataPropertyName = "bagtype";
            resources.ApplyResources(this.bagtypeDataGridViewTextBoxColumn, "bagtypeDataGridViewTextBoxColumn");
            this.bagtypeDataGridViewTextBoxColumn.Name = "bagtypeDataGridViewTextBoxColumn";
            this.bagtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagbrandDataGridViewTextBoxColumn
            // 
            this.bagbrandDataGridViewTextBoxColumn.DataPropertyName = "bagbrand";
            resources.ApplyResources(this.bagbrandDataGridViewTextBoxColumn, "bagbrandDataGridViewTextBoxColumn");
            this.bagbrandDataGridViewTextBoxColumn.Name = "bagbrandDataGridViewTextBoxColumn";
            this.bagbrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagpriceDataGridViewTextBoxColumn
            // 
            this.bagpriceDataGridViewTextBoxColumn.DataPropertyName = "bagprice";
            resources.ApplyResources(this.bagpriceDataGridViewTextBoxColumn, "bagpriceDataGridViewTextBoxColumn");
            this.bagpriceDataGridViewTextBoxColumn.Name = "bagpriceDataGridViewTextBoxColumn";
            this.bagpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagidDataGridViewTextBoxColumn
            // 
            this.bagidDataGridViewTextBoxColumn.DataPropertyName = "bagid";
            resources.ApplyResources(this.bagidDataGridViewTextBoxColumn, "bagidDataGridViewTextBoxColumn");
            this.bagidDataGridViewTextBoxColumn.Name = "bagidDataGridViewTextBoxColumn";
            this.bagidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagsBindingSource2
            // 
            this.bagsBindingSource2.DataMember = "bags";
            this.bagsBindingSource2.DataSource = this.bagshopDataSet11;
            // 
            // bagshopDataSet11
            // 
            this.bagshopDataSet11.DataSetName = "bagshopDataSet11";
            this.bagshopDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagsTableAdapter2
            // 
            this.bagsTableAdapter2.ClearBeforeFill = true;
            // 
            // bagsBindingSource
            // 
            this.bagsBindingSource.DataMember = "bags";
            this.bagsBindingSource.DataSource = this.bagshopDataSet;
            // 
            // bagshopDataSet
            // 
            this.bagshopDataSet.DataSetName = "bagshopDataSet";
            this.bagshopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagsTableAdapter
            // 
            this.bagsTableAdapter.ClearBeforeFill = true;
            // 
            // bagsBindingSource1
            // 
            this.bagsBindingSource1.DataMember = "bags";
            this.bagsBindingSource1.DataSource = this.bagshopDataSet2;
            // 
            // bagshopDataSet2
            // 
            this.bagshopDataSet2.DataSetName = "bagshopDataSet2";
            this.bagshopDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagsTableAdapter1
            // 
            this.bagsTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(220)))), ((int)(((byte)(111)))));
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label4);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(208)))), ((int)(((byte)(63)))));
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private bagshopDataSet bagshopDataSet;
        private System.Windows.Forms.BindingSource bagsBindingSource;
        private bagshopDataSetTableAdapters.bagsTableAdapter bagsTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private bagshopDataSet2 bagshopDataSet2;
        private System.Windows.Forms.BindingSource bagsBindingSource1;
        private bagshopDataSet2TableAdapters.bagsTableAdapter bagsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bagshopDataSet11 bagshopDataSet11;
        private System.Windows.Forms.BindingSource bagsBindingSource2;
        private bagshopDataSet11TableAdapters.bagsTableAdapter bagsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}