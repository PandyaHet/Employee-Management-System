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
    public partial class Department_Edit_New : Form
    {
        Department_BL db = new Department_BL();
        Common.savemode sm;
        string deptcode;
        bool Isduplicate;
        public Department_Edit_New(Common.savemode sm, string deptcode)
        {
            InitializeComponent();
            this.sm = sm;
            this.deptcode = deptcode;
            if (sm == Common.savemode.insert)
            {
                this.Text += " (New)";
            }
            else
            {
                this.Text += " (Edit)";
            }
        }
        public Department_Edit_New()
        {
            InitializeComponent();
        }
        private bool Validation()
        {
            try
            {
                if (txt_dept_code.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Department Code", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_dept_code.Focus();
                    return false;
                }
                else
                {
                    if (sm == Common.savemode.insert)
                    {
                        Isduplicate = Check_duplicate(txt_dept_code.Text);
                    }
                    else if (sm == Common.savemode.edit)
                    {
                        if (deptcode != txt_dept_code.Text.Trim())
                        {

                            Isduplicate = Check_duplicate(txt_dept_code.Text);
                        }
                    }
                    if (Isduplicate == true)
                    {
                        MessageBox.Show("Department Code Already taken", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Isduplicate = false;
                        return false;
                    }
                }

                if (txt_dept_name.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Departement Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_dept_name.Focus();
                    return false;
                }
                else if (txt_dept_location.Text.Trim() == "")
                {
                    MessageBox.Show("Please Enter Location", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_dept_location.Focus();
                    return false;
                }
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private bool Check_duplicate(string DepartmentCode)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = db.GetDepartmentByCode(DepartmentCode);
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
        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validation() == true)
                {
                    db.DepartmentCode = txt_dept_code.Text.ToString();
                    db.DepartmentName = txt_dept_name.Text.ToString();
                    db.Location = txt_dept_location.Text.ToString();
                    if (sm == Common.savemode.insert)
                    {
                        db.CreateUpdateDepartment(db, Common.savemode.insert);
                        this.DialogResult = DialogResult.OK;
                    }
                    else if (sm == Common.savemode.edit)
                    {
                        db.CreateUpdateDepartment(db, Common.savemode.edit);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    this.DialogResult = DialogResult.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void Department_Edit_New_Load(object sender, EventArgs e)
        {   
            try
            {
                if (sm == Common.savemode.edit)
                {
                    DataTable dt2 = new DataTable();
                    dt2 = db.GetDepartmentByCode(deptcode);
                    txt_dept_code.Text = dt2.Rows[0]["DepartmentCode"].ToString();
                    txt_dept_name.Text = dt2.Rows[0]["DepartmentName"].ToString();
                    txt_dept_location.Text = dt2.Rows[0]["Location"].ToString();
                    dt2.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}