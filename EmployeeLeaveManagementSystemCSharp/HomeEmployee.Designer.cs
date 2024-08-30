namespace EmployeeLeaveManagementSystemCSharp
{
    partial class HomeEmployee
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
            this.requestForLeaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLeavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.requestForLeaveToolStripMenuItem,
            this.showLeavesToolStripMenuItem,
            this.showEmployeeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // requestForLeaveToolStripMenuItem
            // 
            this.requestForLeaveToolStripMenuItem.Name = "requestForLeaveToolStripMenuItem";
            this.requestForLeaveToolStripMenuItem.Size = new System.Drawing.Size(152, 20);
            this.requestForLeaveToolStripMenuItem.Text = "Request For Leave";
            this.requestForLeaveToolStripMenuItem.Click += new System.EventHandler(this.requestForLeaveToolStripMenuItem_Click);
            // 
            // showLeavesToolStripMenuItem
            // 
            this.showLeavesToolStripMenuItem.Name = "showLeavesToolStripMenuItem";
            this.showLeavesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.showLeavesToolStripMenuItem.Text = "Show Leaves";
            this.showLeavesToolStripMenuItem.Click += new System.EventHandler(this.showLeavesToolStripMenuItem_Click);
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
            this.pictureBox1.Location = new System.Drawing.Point(589, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // HomeEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "HomeEmployee";
            this.Text = "HomeEmployee";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem requestForLeaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLeavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}