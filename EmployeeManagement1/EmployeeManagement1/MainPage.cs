using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_list f = new Employee_list();
            f.ShowDialog();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Department_list dl = new Department_list();
            dl.ShowDialog();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
