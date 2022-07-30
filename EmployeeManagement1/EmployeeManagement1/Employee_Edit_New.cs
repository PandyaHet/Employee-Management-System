using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public partial class Employee_Edit_New : Form
    {
        Employee_BL eb = new Employee_BL();
        Department_BL db = new Department_BL();
        Common.savemode sm;
        string empno;
        bool Isduplicate;
        public Employee_Edit_New(Common.savemode sm,string empno)
        {
            InitializeComponent();
            this.sm = sm;
           this.empno = empno;
            if (sm == Common.savemode.insert)
            {
                this.Text += " (New)"; 
            }
            else
            {
                this.Text += " (Edit)";
            }
        }

        public Employee_Edit_New()
        {
            InitializeComponent();

        }
        private bool Validation()
        {
            try
            {
                if (txt_empno.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Employee Number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_empno.Focus();
                    return false;
                }
                else
                {
                    if (sm == Common.savemode.insert)
                    {
                        Isduplicate = Check_duplicate(txt_empno.Text);
                    }
                    else if (sm == Common.savemode.edit)
                    {
                        if (empno != txt_empno.Text.Trim())
                        {

                            Isduplicate = Check_duplicate(txt_empno.Text);
                        }
                    }
                    if (Isduplicate == true)
                    {
                        MessageBox.Show("Employee No Already taken", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Isduplicate = false;
                        return false;
                    }
                }

                if (txt_fname.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter First Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_fname.Focus();
                    return false;
                }
                else if (txt_lname.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Last Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_lname.Focus();
                    return false;
                }
                else if (cmb_gender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Your Gender", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_gender.Focus();
                    return false;
                }
                else if (cmb_job.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Your Job Designation", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_job.Focus();
                    return false;
                }
                else if (txt_salary.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Your Salary", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_salary.Focus();
                    return false;
                }
                else if (cmb_deptcode.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Your Department Code", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmb_deptcode.Focus();
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            
        }

        private bool Check_duplicate(string Employeeno)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = eb.GetEmployeeByNo(Employeeno);
                if (dt.Rows.Count != 0)
                {
                    return true;

                }
                dt.Dispose();
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation() == true)
                {
                    eb.EmployeeNo = txt_empno.Text.Trim();
                    eb.FirstName = txt_fname.Text.Trim();
                    eb.LastName = txt_lname.Text.Trim();
                    eb.Gender = cmb_gender.SelectedItem.ToString();
                    eb.Salary = Convert.ToInt32(txt_salary.Text.Trim());
                    eb.Job = cmb_job.SelectedItem.ToString();
                    eb.HireDate = dtp_hiredate.Value.ToString();
                    eb.DepartmentCode = cmb_deptcode.SelectedValue.ToString();
                    if (cmb_manager.SelectedIndex == -1)
                    {
                        eb.Manager = "";
                    }
                    else
                    {
                        eb.Manager = cmb_manager.SelectedValue.ToString();
                    }

                    if (sm == Common.savemode.insert)
                    {
                        eb.CreateUpdateEmployee(eb, Common.savemode.insert);
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (sm == Common.savemode.edit)
                    {
                        eb.CreateUpdateEmployee(eb, Common.savemode.edit);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void Employee_Edit_New_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = eb.GetManagers();
                DataTable dt1 = new DataTable();
                dt1 = db.GetDepartment();
                cmb_manager.DataSource = dt;
                cmb_manager.ValueMember = dt.Columns[0].ToString();
                cmb_manager.DisplayMember = dt.Columns[1].ToString();
                cmb_deptcode.DataSource = dt1;
                cmb_deptcode.DisplayMember = dt1.Columns[1].ToString();
                cmb_deptcode.ValueMember = dt1.Columns[0].ToString();

                if (sm == Common.savemode.insert)
                {
                    cmb_deptcode.SelectedIndex = -1;
                    cmb_manager.SelectedIndex = -1;
                }
                else if (sm == Common.savemode.edit)
                {
                    DataTable dt2 = new DataTable();
                    dt2 = eb.GetEmployeeByNo(empno);
                    txt_empno.Text = dt2.Rows[0]["EmployeeNo"].ToString();
                    txt_fname.Text = dt2.Rows[0]["FirstName"].ToString();
                    txt_lname.Text = dt2.Rows[0]["LastName"].ToString();
                    cmb_gender.Text = dt2.Rows[0]["Gender"].ToString();
                    cmb_job.Text = dt2.Rows[0]["Job"].ToString();
                    dtp_hiredate.Text = dt2.Rows[0]["HireDate"].ToString();
                    txt_salary.Text = dt2.Rows[0]["Salary"].ToString();
                    cmb_manager.SelectedValue = dt2.Rows[0]["Manager"].ToString();
                    cmb_deptcode.SelectedValue = dt2.Rows[0]["DepartmentCode"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            
        }

        private void txt_salary_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                char ch = e.KeyChar;
                if (!char.IsDigit(ch) && ch != 8 && ch != 46)
                {
                    e.Handled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}