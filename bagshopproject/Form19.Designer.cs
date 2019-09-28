namespace bagshopproject
{
    partial class Form19
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet15 = new bagshopproject.bagshopDataSet15();
            this.paymentTableAdapter = new bagshopproject.bagshopDataSet15TableAdapters.paymentTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet15)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.totalDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn,
            this.paymethodDataGridViewTextBoxColumn,
            this.paymentidDataGridViewTextBoxColumn,
            this.paymentdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(516, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(842, 352);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "custname";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "custname";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymethodDataGridViewTextBoxColumn
            // 
            this.paymethodDataGridViewTextBoxColumn.DataPropertyName = "paymethod";
            this.paymethodDataGridViewTextBoxColumn.HeaderText = "paymethod";
            this.paymethodDataGridViewTextBoxColumn.Name = "paymethodDataGridViewTextBoxColumn";
            this.paymethodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentidDataGridViewTextBoxColumn
            // 
            this.paymentidDataGridViewTextBoxColumn.DataPropertyName = "paymentid";
            this.paymentidDataGridViewTextBoxColumn.HeaderText = "paymentid";
            this.paymentidDataGridViewTextBoxColumn.Name = "paymentidDataGridViewTextBoxColumn";
            this.paymentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentdateDataGridViewTextBoxColumn
            // 
            this.paymentdateDataGridViewTextBoxColumn.DataPropertyName = "paymentdate";
            this.paymentdateDataGridViewTextBoxColumn.HeaderText = "paymentdate";
            this.paymentdateDataGridViewTextBoxColumn.Name = "paymentdateDataGridViewTextBoxColumn";
            this.paymentdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "payment";
            this.paymentBindingSource.DataSource = this.bagshopDataSet15;
            // 
            // bagshopDataSet15
            // 
            this.bagshopDataSet15.DataSetName = "bagshopDataSet15";
            this.bagshopDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 207);
            this.panel2.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(703, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(466, 69);
            this.label2.TabIndex = 7;
            this.label2.Text = "Payment Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(143)))), ((int)(((byte)(119)))));
            this.panel1.Location = new System.Drawing.Point(1, 842);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 207);
            this.panel1.TabIndex = 51;
            // 
            // Form19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form19";
            this.Text = "Form19";
            this.Load += new System.EventHandler(this.Form19_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet15)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bagshopDataSet15 bagshopDataSet15;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private bagshopDataSet15TableAdapters.paymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}