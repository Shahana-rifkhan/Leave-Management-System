namespace EmployeeLeaveManagementSystemCSharp
{
    partial class ShowAllowLeaves
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.leaveDataSet2 = new EmployeeLeaveManagementSystemCSharp.leaveDataSet2();
            this.aleaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aleaveTableAdapter = new EmployeeLeaveManagementSystemCSharp.leaveDataSet2TableAdapters.aleaveTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desigDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ldaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavestatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aleaveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(292, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 22);
            this.textBox1.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Employee Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(193, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 45;
            this.label2.Text = "Search Employee Leaves";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(278, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 28);
            this.button2.TabIndex = 65;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EmployeeLeaveManagementSystemCSharp.Properties.Resources.kashipara;
            this.pictureBox1.Location = new System.Drawing.Point(488, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.eidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobDataGridViewTextBoxColumn,
            this.desigDataGridViewTextBoxColumn,
            this.ldaysDataGridViewTextBoxColumn,
            this.descrDataGridViewTextBoxColumn,
            this.leavestatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.aleaveBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 238);
            this.dataGridView1.TabIndex = 67;
            // 
            // leaveDataSet2
            // 
            this.leaveDataSet2.DataSetName = "leaveDataSet2";
            this.leaveDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aleaveBindingSource
            // 
            this.aleaveBindingSource.DataMember = "aleave";
            this.aleaveBindingSource.DataSource = this.leaveDataSet2;
            // 
            // aleaveTableAdapter
            // 
            this.aleaveTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eidDataGridViewTextBoxColumn
            // 
            this.eidDataGridViewTextBoxColumn.DataPropertyName = "e_id";
            this.eidDataGridViewTextBoxColumn.HeaderText = "e_id";
            this.eidDataGridViewTextBoxColumn.Name = "eidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // mobDataGridViewTextBoxColumn
            // 
            this.mobDataGridViewTextBoxColumn.DataPropertyName = "mob";
            this.mobDataGridViewTextBoxColumn.HeaderText = "mob";
            this.mobDataGridViewTextBoxColumn.Name = "mobDataGridViewTextBoxColumn";
            // 
            // desigDataGridViewTextBoxColumn
            // 
            this.desigDataGridViewTextBoxColumn.DataPropertyName = "desig";
            this.desigDataGridViewTextBoxColumn.HeaderText = "desig";
            this.desigDataGridViewTextBoxColumn.Name = "desigDataGridViewTextBoxColumn";
            // 
            // ldaysDataGridViewTextBoxColumn
            // 
            this.ldaysDataGridViewTextBoxColumn.DataPropertyName = "l_days";
            this.ldaysDataGridViewTextBoxColumn.HeaderText = "l_days";
            this.ldaysDataGridViewTextBoxColumn.Name = "ldaysDataGridViewTextBoxColumn";
            // 
            // descrDataGridViewTextBoxColumn
            // 
            this.descrDataGridViewTextBoxColumn.DataPropertyName = "descr";
            this.descrDataGridViewTextBoxColumn.HeaderText = "descr";
            this.descrDataGridViewTextBoxColumn.Name = "descrDataGridViewTextBoxColumn";
            // 
            // leavestatusDataGridViewTextBoxColumn
            // 
            this.leavestatusDataGridViewTextBoxColumn.DataPropertyName = "leave_status";
            this.leavestatusDataGridViewTextBoxColumn.HeaderText = "leave_status";
            this.leavestatusDataGridViewTextBoxColumn.Name = "leavestatusDataGridViewTextBoxColumn";
            // 
            // ShowAllowLeaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ShowAllowLeaves";
            this.Text = "ShowAllowLeaves";
            this.Load += new System.EventHandler(this.ShowAllowLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aleaveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private leaveDataSet2 leaveDataSet2;
        private System.Windows.Forms.BindingSource aleaveBindingSource;
        private leaveDataSet2TableAdapters.aleaveTableAdapter aleaveTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desigDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ldaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavestatusDataGridViewTextBoxColumn;
    }
}