using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public class Department_BL
    {
        DataAccess da = new DataAccess();

        public string DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }

        public DataTable GetDepartment()
        {
            try
            {
                return da.Get_data("show_all_department");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public void DeleteDepartment(string DepartmentCode, string n_DepartmentCode)
        {
            try
            {
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                if (n_DepartmentCode != "")
                {
                    ArrParam.Add("DepartmentCode");
                    Arrval.Add(DepartmentCode);

                    ArrParam.Add("DepartmentSelectedCode");
                    Arrval.Add(n_DepartmentCode);
                    da.crud_OPERATION("update_dept_name_delete", ArrParam, Arrval);
                }
                else
                {
                    ArrParam.Add("DepartmentCode");
                    Arrval.Add(DepartmentCode);

                    da.crud_OPERATION("delete_sp_dept", ArrParam, Arrval);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void CreateUpdateDepartment(Department_BL dept, Common.savemode sm)
        {
            try
            {
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                ArrParam.Add("DepartmentCode");
                Arrval.Add(DepartmentCode);

                ArrParam.Add("DepartmentName");
                Arrval.Add(DepartmentName);

                ArrParam.Add("Location");
                Arrval.Add(Location);

                if (sm == Common.savemode.insert)
                    da.crud_OPERATION("insert_sp_dept", ArrParam, Arrval);
                else if (sm == Common.savemode.edit)
                    da.crud_OPERATION("update_sp_dept", ArrParam, Arrval);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public DataTable GetDepartmentByCode(string DepartmentCode)
        {
            try
            {
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                ArrParam.Add("DepartmentCode");
                Arrval.Add(DepartmentCode);
                return da.All_data_by_Empno_deptno_deptname("select_by_dept", ArrParam, Arrval);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        public DataTable GetDepartmentName(string DeptName)
        {
            try
            {
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                ArrParam.Add("DepartmentName");
                Arrval.Add(DeptName);
                return da.All_data_by_Empno_deptno_deptname("get_department_name", ArrParam, Arrval);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public DataTable Get_data_by_deptnameInEmployee(string DepartmentCode)
        {
            try
            {
                ArrayList Arrval = new ArrayList();
                ArrayList ArrParam = new ArrayList();

                ArrParam.Add("DepartmentCode");
                Arrval.Add(DepartmentCode);
                return da.All_data_by_Empno_deptno_deptname("select_by_deptname_in_emp", ArrParam, Arrval);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
    }
}