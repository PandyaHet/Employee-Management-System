using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public class Employee_BL
    {
        DataAccess da = new DataAccess();

        public string EmployeeNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public string Job { get; set; }
        public string HireDate { get; set; }
        public string DepartmentCode { get; set; }
        public string Manager { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }


        public DataTable GetEmployee()
        {
            try
            {
                return da.Get_data("show_all_employee");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public void DeleteEmployee(string EmployeeNo)
        {
            try
            {
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                ArrParam.Add("EmployeeNo");
                Arrval.Add(EmployeeNo);

                da.crud_OPERATION("delete_sp", ArrParam, Arrval);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void CreateUpdateEmployee(Employee_BL emp, Common.savemode sm)
        {
            try{
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                ArrParam.Add("EmployeeNo");
                Arrval.Add(EmployeeNo);

                ArrParam.Add("FirstName");
                Arrval.Add(FirstName);

                ArrParam.Add("LastName");
                Arrval.Add(LastName);

                ArrParam.Add("Gender");
                Arrval.Add(Gender);

                ArrParam.Add("Salary");
                Arrval.Add(Salary);

                ArrParam.Add("Job");
                Arrval.Add(Job);

                ArrParam.Add("HireDate");
                Arrval.Add(HireDate);

                ArrParam.Add("DepartmentCode");
                Arrval.Add(DepartmentCode);

                ArrParam.Add("Manager");
                Arrval.Add(Manager);

                if (sm == Common.savemode.insert)
                    da.crud_OPERATION("insert_sp", ArrParam, Arrval);
                else if (sm == Common.savemode.edit)
                    da.crud_OPERATION("update_sp", ArrParam, Arrval);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public DataTable GetManagers()
        {
            try
            {
                return da.Get_data("manager_data");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        
        public DataTable GetEmployeeByNo(string EmployeeNo)
        {
            try
            {
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                ArrParam.Add("EmployeeNo");
                Arrval.Add(EmployeeNo);
                return da.All_data_by_Empno_deptno_deptname("select_by_emp", ArrParam, Arrval);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}