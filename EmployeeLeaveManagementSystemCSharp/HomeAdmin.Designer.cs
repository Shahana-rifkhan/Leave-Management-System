namespace EmployeeLeaveManagementSystemCSharp
{
    partial class HomeAdmin
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
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestedLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllowedLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.requestedLeaveToolStripMenuItem,
            this.showAllowedLeaveToolStripMenuItem,
            this.showEmployeeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // requestedLeaveToolStripMenuItem
            // 
            this.requestedLeaveToolStripMenuItem.Name = "requestedLeaveToolStripMenuItem";
            this.requestedLeaveToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.requestedLeaveToolStripMenuItem.Text = "Requested Leave";
            this.requestedLeaveToolStripMenuItem.Click += new System.EventHandler(this.requestedLeaveToolStripMenuItem_Click);
            // 
            // showAllowedLeaveToolStripMenuItem
            // 
            this.showAllowedLeaveToolStripMenuItem.Name = "showAllowedLeaveToolStripMenuItem";
            this.showAllowedLeaveToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.showAllowedLeaveToolStripMenuItem.Text = "Show Allowed Leave";
            this.showAllowedLeaveToolStripMenuItem.Click += new System.EventHandler(this.showAllowedLeaveToolStripMenuItem_Click);
            // 
            // showEmployeeToolStripMenuItem
            // 
            this.showEmployeeToolStripMenuItem.Name = "showEmployeeToolStripMenuItem";
            this.showEmployeeToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.showEmployeeToolStripMenuItem.Text = "Show Employee";
            this.showEmployeeToolStripMenuItem.Click += new System.EventHandler(this.showEmployeeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeLeaveManagementSystemCSharp.Properties.Resources.kashipara;
            this.pictureBox1.Location = new System.Drawing.Point(616, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // HomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 454);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeAdmin";
            this.Text = "HomeAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestedLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllowedLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}