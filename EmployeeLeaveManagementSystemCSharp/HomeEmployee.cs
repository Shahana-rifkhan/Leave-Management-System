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
    public partial class HomeEmployee : Form
    {
        public HomeEmployee()
        {
            InitializeComponent();
        }

        private void requestForLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetLeave obj = new EmployeeLeaveManagementSystemCSharp.GetLeave();
            obj.ShowDialog();
        }

        private void showLeavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAllowLeaves obj = new EmployeeLeaveManagementSystemCSharp.ShowAllowLeaves();
            obj.ShowDialog();
        }

        private void showEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowEmployee obj = new ShowEmployee();
            obj.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new EmployeeLeaveManagementSystemCSharp.Form1();
            obj.ShowDialog();
        }
    }
}
