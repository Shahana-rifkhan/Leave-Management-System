using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeLeaveManagementSystemCSharp
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee obj = new EmployeeLeaveManagementSystemCSharp.AddEmployee();
            obj.ShowDialog();
        }

        private void requestedLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllowLeave obj1 = new AllowLeave();
            obj1.ShowDialog();
        }

        private void showAllowedLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllowLeaves obj22 = new EmployeeLeaveManagementSystemCSharp.ShowAllowLeaves();
            obj22.ShowDialog();
        }

        private void showEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployee obj3 = new ShowEmployee();
            obj3.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new EmployeeLeaveManagementSystemCSharp.Form1();
            obj.ShowDialog();
        }
    }
}
