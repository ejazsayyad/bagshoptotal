namespace bagshopproject
{
    partial class Form17
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bagsInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyBagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.bagsInventoryToolStripMenuItem,
            this.buyBagToolStripMenuItem,
            this.employeeInformationToolStripMenuItem,
            this.accountDetailsToolStripMenuItem,
            this.accountLogsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // bagsInventoryToolStripMenuItem
            // 
            this.bagsInventoryToolStripMenuItem.Name = "bagsInventoryToolStripMenuItem";
            this.bagsInventoryToolStripMenuItem.Size = new System.Drawing.Size(142, 29);
            this.bagsInventoryToolStripMenuItem.Text = "Bags Inventory";
            this.bagsInventoryToolStripMenuItem.Click += new System.EventHandler(this.bagsInventoryToolStripMenuItem_Click);
            // 
            // buyBagToolStripMenuItem
            // 
            this.buyBagToolStripMenuItem.Name = "buyBagToolStripMenuItem";
            this.buyBagToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.buyBagToolStripMenuItem.Text = "Buy Bag";
            this.buyBagToolStripMenuItem.Click += new System.EventHandler(this.buyBagToolStripMenuItem_Click);
            // 
            // employeeInformationToolStripMenuItem
            // 
            this.employeeInformationToolStripMenuItem.Name = "employeeInformationToolStripMenuItem";
            this.employeeInformationToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.employeeInformationToolStripMenuItem.Text = "Employee Information";
            this.employeeInformationToolStripMenuItem.Click += new System.EventHandler(this.employeeInformationToolStripMenuItem_Click);
            // 
            // accountDetailsToolStripMenuItem
            // 
            this.accountDetailsToolStripMenuItem.Name = "accountDetailsToolStripMenuItem";
            this.accountDetailsToolStripMenuItem.Size = new System.Drawing.Size(150, 29);
            this.accountDetailsToolStripMenuItem.Text = "Payment Details";
            this.accountDetailsToolStripMenuItem.Click += new System.EventHandler(this.accountDetailsToolStripMenuItem_Click);
            // 
            // accountLogsToolStripMenuItem
            // 
            this.accountLogsToolStripMenuItem.Name = "accountLogsToolStripMenuItem";
            this.accountLogsToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.accountLogsToolStripMenuItem.Text = "Account Logs";
            this.accountLogsToolStripMenuItem.Click += new System.EventHandler(this.accountLogsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 29);
            this.exitToolStripMenuItem.Text = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form17";
            this.Text = "Form17";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form17_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bagsInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyBagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}