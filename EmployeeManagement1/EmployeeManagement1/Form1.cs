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
    public partial class Form1 : Form
    {
        Employee_BL eb = new Employee_BL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GridBind();
        }
        public void GridBind()
        {
            dgv_employ_details.DataSource = eb.BL_bind();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee_Edit_New een = new Employee_Edit_New();
            een.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mp = new MainPage();
            mp.ShowDialog();
        }

        private void dgv_employ_details_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee_Edit_New een = new Employee_Edit_New();
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgv_employ_details.Rows[index];
            een.txt_empno.Text = selectedRow.Cells[0].Value.ToString();
            een.txt_fname.Text = selectedRow.Cells[1].Value.ToString();
            een.txt_lname.Text = selectedRow.Cells[2].Value.ToString();
            een.cmb_gender.Text = selectedRow.Cells[3].Value.ToString();
            een.cmb_job.Text = selectedRow.Cells[4].Value.ToString();
            een.dtp_hiredate.Text = selectedRow.Cells[5].Value;
            een.txt_salary.Text = selectedRow.Cells[6].Value.ToString();
            een.txt_manager.Text = selectedRow.Cells[7].Value.ToString();
            een.txt_deptcode.Text = selectedRow.Cells[8].Value.ToString();
            this.Hide();
            een.ShowDialog();
        }
    }
}
