namespace bagshopproject
{
    partial class Form20
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
            this.accountdetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet17 = new bagshopproject.bagshopDataSet17();
            this.accountdetailsTableAdapter = new bagshopproject.bagshopDataSet17TableAdapters.accountdetailsTableAdapter();
            this.bagshopDataSet18 = new bagshopproject.bagshopDataSet18();
            this.accountdetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accountdetailsTableAdapter1 = new bagshopproject.bagshopDataSet18TableAdapters.accountdetailsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.paidbyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountdetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bagshopDataSet19 = new bagshopproject.bagshopDataSet19();
            this.accountdetailsTableAdapter2 = new bagshopproject.bagshopDataSet19TableAdapters.accountdetailsTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.accountdetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountdetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountdetailsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet19)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // accountdetailsBindingSource
            // 
            this.accountdetailsBindingSource.DataMember = "accountdetails";
            this.accountdetailsBindingSource.DataSource = this.bagshopDataSet17;
            // 
            // bagshopDataSet17
            // 
            this.bagshopDataSet17.DataSetName = "bagshopDataSet17";
            this.bagshopDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountdetailsTableAdapter
            // 
            this.accountdetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bagshopDataSet18
            // 
            this.bagshopDataSet18.DataSetName = "bagshopDataSet18";
            this.bagshopDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountdetailsBindingSource1
            // 
            this.accountdetailsBindingSource1.DataMember = "accountdetails";
            this.accountdetailsBindingSource1.DataSource = this.bagshopDataSet18;
            // 
            // accountdetailsTableAdapter1
            // 
            this.accountdetailsTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paidbyidDataGridViewTextBoxColumn,
            this.paymentamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.accountdetailsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(791, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(366, 443);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // paidbyidDataGridViewTextBoxColumn
            // 
            this.paidbyidDataGridViewTextBoxColumn.DataPropertyName = "paidbyid";
            this.paidbyidDataGridViewTextBoxColumn.HeaderText = "paidbyid";
            this.paidbyidDataGridViewTextBoxColumn.Name = "paidbyidDataGridViewTextBoxColumn";
            this.paidbyidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentamountDataGridViewTextBoxColumn
            // 
            this.paymentamountDataGridViewTextBoxColumn.DataPropertyName = "paymentamount";
            this.paymentamountDataGridViewTextBoxColumn.HeaderText = "paymentamount";
            this.paymentamountDataGridViewTextBoxColumn.Name = "paymentamountDataGridViewTextBoxColumn";
            this.paymentamountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountdetailsBindingSource2
            // 
            this.accountdetailsBindingSource2.DataMember = "accountdetails";
            this.accountdetailsBindingSource2.DataSource = this.bagshopDataSet19;
            // 
            // bagshopDataSet19
            // 
            this.bagshopDataSet19.DataSetName = "bagshopDataSet19";
            this.bagshopDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountdetailsTableAdapter2
            // 
            this.accountdetailsTableAdapter2.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 207);
            this.panel2.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(703, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 69);
            this.label2.TabIndex = 7;
            this.label2.Text = "Shop Account Logs";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(201)))), ((int)(((byte)(176)))));
            this.panel1.Location = new System.Drawing.Point(0, 844);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 207);
            this.panel1.TabIndex = 50;
            // 
            // Form20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form20";
            this.Text = "Form20";
            this.Load += new System.EventHandler(this.Form20_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountdetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountdetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountdetailsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bagshopDataSet19)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private bagshopDataSet17 bagshopDataSet17;
        private System.Windows.Forms.BindingSource accountdetailsBindingSource;
        private bagshopDataSet17TableAdapters.accountdetailsTableAdapter accountdetailsTableAdapter;
        private bagshopDataSet18 bagshopDataSet18;
        private System.Windows.Forms.BindingSource accountdetailsBindingSource1;
        private bagshopDataSet18TableAdapters.accountdetailsTableAdapter accountdetailsTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private bagshopDataSet19 bagshopDataSet19;
        private System.Windows.Forms.BindingSource accountdetailsBindingSource2;
        private bagshopDataSet19TableAdapters.accountdetailsTableAdapter accountdetailsTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidbyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}