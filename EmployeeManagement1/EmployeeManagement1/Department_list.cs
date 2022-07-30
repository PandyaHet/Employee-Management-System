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
    public partial class Department_list : Form
    {
        Department_BL db = new Department_BL();
        public Department_list()
        {
            InitializeComponent();
        }

        private void Department_list_Load(object sender, EventArgs e)
        {
            GridBind();
        }

        private void GridBind()
        {
            try
            {
                Department_BL db = new Department_BL();
                dgv_department_details.DataSource = db.GetDepartment();
                dgv_department_details.Columns[0].HeaderText = "Department Code";
                dgv_department_details.Columns[1].HeaderText = "Departement Name";
                dgv_department_details.Columns[2].HeaderText = "Location";
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
                Department_Edit_New den = new Department_Edit_New(Common.savemode.insert, "");
                if (den.ShowDialog() == DialogResult.OK)
                {
                    GridBind();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_department_details.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgv_department_details.Rows[index];
                Department_Edit_New den = new Department_Edit_New(Common.savemode.edit, selectedRow.Cells[0].Value.ToString());
                if (den.ShowDialog() == DialogResult.OK)
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

        private bool Check_reference(string deptcode)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = db.Get_data_by_deptnameInEmployee(deptcode);
                if (dt.Rows.Count != 0)
                {
                    return true;
                }
                dt.Dispose();
                return false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgv_department_details.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dgv_department_details.Rows[index];
                if (Check_reference(selectedRow.Cells[0].Value.ToString()) == true)
                {
                    Department_validation dv = new Department_validation(selectedRow.Cells[1].Value.ToString());
                    if (dv.ShowDialog() == DialogResult.OK)
                    {
                        db.DeleteDepartment(selectedRow.Cells[0].Value.ToString(), dv.cmb_dept_name.SelectedValue.ToString());
                        GridBind();
                    }
                }
                else
                {
                    if (MessageBox.Show("Are you sure you want to delete record of " + selectedRow.Cells[1].Value.ToString() + " Department?", "Delete Department", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.DeleteDepartment(selectedRow.Cells[0].Value.ToString(), "");
                        GridBind();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}