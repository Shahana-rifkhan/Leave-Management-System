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
    public partial class ShowEmployee : Form
    {
        public ShowEmployee()
        {
            InitializeComponent();
        }

        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.leaveDataSet.employee);
            using (SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\Documents\Visual Studio 2015\Projects\EmployeeLeaveManagementSystemCSharp\EmployeeLeaveManagementSystemCSharp\leave.mdf;Integrated Security=True"))
            {

                string str2 = "SELECT * FROM employee";
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

                string str2 = "SELECT * FROM employee where id='" + textBox1.Text + "'";
                SqlCommand cmd2 = new SqlCommand(str2, con1);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = new BindingSource(dt, null);
            }
        }
    }
}
