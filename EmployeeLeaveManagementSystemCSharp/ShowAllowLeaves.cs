using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeLeaveManagementSystemCSharp
{
    public partial class ShowAllowLeaves : Form
    {
        public ShowAllowLeaves()
        {
            InitializeComponent();
        }

        private void ShowAllowLeaves_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveDataSet2.aleave' table. You can move, or remove it, as needed.
            this.aleaveTableAdapter.Fill(this.leaveDataSet2.aleave);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\EmployeeLeaveManagementSystemCSharp\EmployeeLeaveManagementSystemCSharp\leave.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM aleave";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\EmployeeLeaveManagementSystemCSharp\EmployeeLeaveManagementSystemCSharp\leave.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM aleave where e_id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
