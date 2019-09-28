namespace bagshopproject
{
    partial class Form18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form18));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bagtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagbrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet16 = new bagshopproject.bagshopDataSet16();
            this.cartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet14 = new bagshopproject.bagshopDataSet14();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cartTableAdapter = new bagshopproject.bagshopDataSet14TableAdapters.cartTableAdapter();
            this.cartTableAdapter1 = new bagshopproject.bagshopDataSet16TableAdapters.cartTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            this.bagidDataGridViewTextBoxColumn,
            this.bagpriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(50, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(674, 301);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // bagidDataGridViewTextBoxColumn
            // 
            this.bagidDataGridViewTextBoxColumn.DataPropertyName = "bagid";
            this.bagidDataGridViewTextBoxColumn.HeaderText = "bagid";
            this.bagidDataGridViewTextBoxColumn.Name = "bagidDataGridViewTextBoxColumn";
            this.bagidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagpriceDataGridViewTextBoxColumn
            // 
            this.bagpriceDataGridViewTextBoxColumn.DataPropertyName = "bagprice";
            this.bagpriceDataGridViewTextBoxColumn.HeaderText = "bagprice";
            this.bagpriceDataGridViewTextBoxColumn.Name = "bagpriceDataGridViewTextBoxColumn";
            this.bagpriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cartBindingSource1
            // 
            this.cartBindingSource1.DataMember = "cart";
            this.cartBindingSource1.DataSource = this.bagshopDataSet16;
            // 
            // bagshopDataSet16
            // 
            this.bagshopDataSet16.DataSetName = "bagshopDataSet16";
            this.bagshopDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartBindingSource
            // 
            this.cartBindingSource.DataMember = "cart";
            this.cartBindingSource.DataSource = this.bagshopDataSet14;
            // 
            // bagshopDataSet14
            // 
            this.bagshopDataSet14.DataSetName = "bagshopDataSet14";
            this.bagshopDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 49);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total Cart Price:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 37);
            this.label3.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label4.Location = new System.Drawing.Point(579, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 43);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rs.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label10.Location = new System.Drawing.Point(45, 702);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 30);
            this.label10.TabIndex = 27;
            this.label10.Text = "Choose Bag ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(32, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 57);
            this.button1.TabIndex = 28;
            this.button1.Text = "Show Total Price";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button2.Location = new System.Drawing.Point(752, 731);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(328, 45);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete this bag from Cart";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(438, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 57);
            this.button3.TabIndex = 30;
            this.button3.Text = "Pay";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(269, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(224)))), ((int)(((byte)(170)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(242, 364);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 57);
            this.button4.TabIndex = 32;
            this.button4.Text = "Go to Buy Page";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label5.Location = new System.Drawing.Point(214, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Want to add more items ?";
            // 
            // cartTableAdapter
            // 
            this.cartTableAdapter.ClearBeforeFill = true;
            // 
            // cartTableAdapter1
            // 
            this.cartTableAdapter1.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 292);
            this.panel1.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(708, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(415, 69);
            this.label2.TabIndex = 7;
            this.label2.Text = "My Smart Cart";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(153)))), ((int)(((byte)(84)))));
            this.panel2.Location = new System.Drawing.Point(1, 844);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 207);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(214)))), ((int)(((byte)(141)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(1175, 356);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 458);
            this.panel3.TabIndex = 50;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(315, 690);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 28);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label6.Location = new System.Drawing.Point(221, 690);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 30);
            this.label6.TabIndex = 52;
            this.label6.Text = "Type:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(315, 738);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(410, 28);
            this.comboBox2.TabIndex = 53;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label7.Location = new System.Drawing.Point(221, 738);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 30);
            this.label7.TabIndex = 54;
            this.label7.Text = "Brand:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label8.Location = new System.Drawing.Point(221, 781);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 30);
            this.label8.TabIndex = 56;
            this.label8.Text = "id:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(315, 787);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(410, 28);
            this.comboBox3.TabIndex = 55;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label9.Location = new System.Drawing.Point(47, 732);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 30);
            this.label9.TabIndex = 57;
            this.label9.Text = "To Delete";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label11.Location = new System.Drawing.Point(47, 762);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 30);
            this.label11.TabIndex = 58;
            this.label11.Text = "From Cart:";
            // 
            // Form18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form18";
            this.Text = "Total Cart Price:";
            this.Load += new System.EventHandler(this.Form18_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private bagshopDataSet14 bagshopDataSet14;
        private System.Windows.Forms.BindingSource cartBindingSource;
        private bagshopDataSet14TableAdapters.cartTableAdapter cartTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagbrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagpriceDataGridViewTextBoxColumn;
        private bagshopDataSet16 bagshopDataSet16;
        private System.Windows.Forms.BindingSource cartBindingSource1;
        private bagshopDataSet16TableAdapters.cartTableAdapter cartTableAdapter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;

    }
}