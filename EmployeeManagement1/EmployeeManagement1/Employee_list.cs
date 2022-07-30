using System;
using System.Data;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public partial class Employee_list : Form
    {
        public Employee_list()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            GridBind();

        }
        private void GridBind()
        {
            try
            {
                Employee_BL eb = new Employee_BL();
                dgv_employ_details.DataSource = eb.GetEmployee();
                //dgv_employ_details.Columns[0].HeaderText = "Employee No.";
                //dgv_employ_details.Columns[1].HeaderText = "First Name";
                //dgv_employ_details.Columns[2].HeaderText = "Last Name";
                //dgv_employ_details.Columns[3].HeaderText = "Gender";
                //dgv_employ_details.Columns[4].HeaderText = "Job";
                //dgv_employ_details.Columns[5].HeaderText = "Hire Date";
                //dgv_employ_details.Columns[6].HeaderText = "Salary";
                //dgv_employ_details.Columns[7].HeaderText = "Manager";
                //dgv_employ_details.Columns[8].HeaderText = "Department Name";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                Employee_Edit_New een = new Employee_Edit_New(Common.savemode.insert, "");
                if (een.ShowDialog() == DialogResult.OK)
                {
                    GridBind();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_employ_details.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgv_employ_details.Rows[index];

                Employee_Edit_New een = new Employee_Edit_New(Common.savemode.edit, selectedRow.Cells[0].Value.ToString());
                if (een.ShowDialog() == DialogResult.OK)
                {
                    GridBind();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_employ_details.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgv_employ_details.Rows[index];
                if (MessageBox.Show("Are you sure you want to delete record of " + selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[2].Value.ToString() + " ?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Employee_BL eb = new Employee_BL();
                    eb.DeleteEmployee(selectedRow.Cells[0].Value.ToString());
                    GridBind();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}