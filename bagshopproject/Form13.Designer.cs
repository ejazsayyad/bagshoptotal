namespace bagshopproject
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bagsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet9 = new bagshopproject.bagshopDataSet9();
            this.bagsTableAdapter1 = new bagshopproject.bagshopDataSet9TableAdapters.bagsTableAdapter();
            this.bagsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet6 = new bagshopproject.bagshopDataSet6();
            this.bagsTableAdapter = new bagshopproject.bagshopDataSet6TableAdapters.bagsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bagtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet13 = new bagshopproject.bagshopDataSet13();
            this.bagsTableAdapter2 = new bagshopproject.bagshopDataSet13TableAdapters.bagsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet13)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.label2.Location = new System.Drawing.Point(238, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(432, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Available Bags";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.label3.Location = new System.Drawing.Point(312, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 69);
            this.label3.TabIndex = 4;
            this.label3.Text = "Buy Bag";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Choose bag type:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Choose bag brand:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(291, 231);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(410, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(138, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 37);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(435, 374);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 30);
            this.label9.TabIndex = 14;
            this.label9.Text = "Rs.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(27, 444);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Show Price";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(12, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "Choose bag id:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(291, 282);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(410, 28);
            this.comboBox3.TabIndex = 17;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(227, 444);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(276, 57);
            this.button3.TabIndex = 19;
            this.button3.Text = "Add To Cart";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(529, 444);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(172, 57);
            this.button4.TabIndex = 20;
            this.button4.Text = "Go to Cart";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bagsBindingSource1
            // 
            this.bagsBindingSource1.DataMember = "bags";
            this.bagsBindingSource1.DataSource = this.bagshopDataSet9;
            // 
            // bagshopDataSet9
            // 
            this.bagshopDataSet9.DataSetName = "bagshopDataSet9";
            this.bagshopDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagsTableAdapter1
            // 
            this.bagsTableAdapter1.ClearBeforeFill = true;
            // 
            // bagsBindingSource
            // 
            this.bagsBindingSource.DataMember = "bags";
            this.bagsBindingSource.DataSource = this.bagshopDataSet6;
            // 
            // bagshopDataSet6
            // 
            this.bagshopDataSet6.DataSetName = "bagshopDataSet6";
            this.bagshopDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagsTableAdapter
            // 
            this.bagsTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(104, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(655, 430);
            this.dataGridView1.TabIndex = 21;
            // 
            // bagtypeDataGridViewTextBoxColumn
            // 
            this.bagtypeDataGridViewTextBoxColumn.DataPropertyName = "bagtype";
            this.bagtypeDataGridViewTextBoxColumn.HeaderText = "bagtype";
            this.bagtypeDataGridViewTextBoxColumn.Name = "bagtypeDataGridViewTextBoxColumn";
            this.bagtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagbrandDataGridViewTextBoxColumn
            // 
            this.bagbrandDataGridViewTextBoxColumn.DataPropertyName = "bagbrand";
            this.bagbrandDataGridViewTextBoxColumn.HeaderText = "bagbrand";
            this.bagbrandDataGridViewTextBoxColumn.Name = "bagbrandDataGridViewTextBoxColumn";
            this.bagbrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagpriceDataGridViewTextBoxColumn
            // 
            this.bagpriceDataGridViewTextBoxColumn.DataPropertyName = "bagprice";
            this.bagpriceDataGridViewTextBoxColumn.HeaderText = "bagprice";
            this.bagpriceDataGridViewTextBoxColumn.Name = "bagpriceDataGridViewTextBoxColumn";
            this.bagpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagidDataGridViewTextBoxColumn
            // 
            this.bagidDataGridViewTextBoxColumn.DataPropertyName = "bagid";
            this.bagidDataGridViewTextBoxColumn.HeaderText = "bagid";
            this.bagidDataGridViewTextBoxColumn.Name = "bagidDataGridViewTextBoxColumn";
            this.bagidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagsBindingSource2
            // 
            this.bagsBindingSource2.DataMember = "bags";
            this.bagsBindingSource2.DataSource = this.bagshopDataSet13;
            // 
            // bagshopDataSet13
            // 
            this.bagshopDataSet13.DataSetName = "bagshopDataSet13";
            this.bagshopDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bagsTableAdapter2
            // 
            this.bagsTableAdapter2.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 221);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 38F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(915, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 91);
            this.label1.TabIndex = 7;
            this.label1.Text = "Shop";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(18)))));
            this.panel2.Location = new System.Drawing.Point(2, 850);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 175);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(196)))), ((int)(((byte)(113)))));
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(1004, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 539);
            this.panel3.TabIndex = 24;
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Name = "Form13";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.Form13_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet13)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private bagshopDataSet6 bagshopDataSet6;
        private System.Windows.Forms.BindingSource bagsBindingSource;
        private bagshopDataSet6TableAdapters.bagsTableAdapter bagsTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private bagshopDataSet9 bagshopDataSet9;
        private System.Windows.Forms.BindingSource bagsBindingSource1;
        private bagshopDataSet9TableAdapters.bagsTableAdapter bagsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bagshopDataSet13 bagshopDataSet13;
        private System.Windows.Forms.BindingSource bagsBindingSource2;
        private bagshopDataSet13TableAdapters.bagsTableAdapter bagsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}