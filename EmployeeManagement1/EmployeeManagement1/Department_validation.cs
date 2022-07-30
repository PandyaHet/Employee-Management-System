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
    public partial class Department_validation : Form
    {
        Department_BL db = new Department_BL();
        string deptname;
        public Department_validation(string deptname)
        {
            InitializeComponent();
            this.deptname = deptname;  
        }

        private void Department_validation_Load(object sender, EventArgs e)
        {
            try
            {
                lb_warningmessage.Text = "The department you selected is used in Employee master table.If You want to delete this department.\nPlease assign other department to related employees.";
                DataTable dt1 = new DataTable();
                dt1 = db.GetDepartmentName(deptname);
                cmb_dept_name.DataSource = dt1;
                cmb_dept_name.DisplayMember = dt1.Columns[1].ToString();
                cmb_dept_name.ValueMember = dt1.Columns[0].ToString();
                cmb_dept_name.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
