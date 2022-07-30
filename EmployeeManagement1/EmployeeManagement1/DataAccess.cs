using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Windows.Forms;

namespace EmployeeManagement1
{
    public class DataAccess
    {
         SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
         SqlCommand cmd = new SqlCommand();

        public DataTable Get_data(string qry)
        {
            try
            {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = qry;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    return ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
        public void crud_OPERATION(string qry,ArrayList ArrParam,ArrayList Arrval)
        {
            try
            {
                using (cmd.Connection = con)
                {
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = qry;
                    for (int i = 0; i < ArrParam.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + ArrParam[i], Arrval[i]);
                    }
                    cmd.ExecuteNonQuery();
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        public DataTable All_data_by_Empno_deptno_deptname(string qry, ArrayList ArrParam, ArrayList Arrval)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < ArrParam.Count; i++)
                    {
                        cmd.Parameters.AddWithValue("@" + ArrParam[i], Arrval[i]);
                    }
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    return ds.Tables[0];
              
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

    }

}

//public DataTable All_data_by_Empno(string EmployeeNo)
//{
//    SqlCommand cmd = new SqlCommand("select_by_emp", con);
//    cmd.CommandType = CommandType.StoredProcedure;
//    cmd.Parameters.AddWithValue("@EmployeeNo",EmployeeNo);
//    SqlDataAdapter sda = new SqlDataAdapter(cmd);
//    DataSet ds = new DataSet();
//    sda.Fill(ds);
//    return ds.Tables[0];
//}
//public DataTable All_data_by_deptcode(string DepartmentCode)
//{
//    SqlCommand cmd = new SqlCommand("select_by_dept", con);
//    cmd.CommandType = CommandType.StoredProcedure;
//    cmd.Parameters.AddWithValue("@DepartmentCode", DepartmentCode);
//    SqlDataAdapter sda = new SqlDataAdapter(cmd);
//    DataSet ds = new DataSet();
//    sda.Fill(ds);
//    return ds.Tables[0];
//}
//public DataTable All_data_by_deptname(string DepartmentCode)
//{
//    SqlCommand cmd = new SqlCommand("select_by_deptname_in_emp", con);
//    cmd.CommandType = CommandType.StoredProcedure;
//    cmd.Parameters.AddWithValue("@DepartmentCode", DepartmentCode);
//    SqlDataAdapter sda = new SqlDataAdapter(cmd);
//    DataSet ds = new DataSet();
//    sda.Fill(ds);
//    return ds.Tables[0];
//}
//public DataTable get_deptname(string DepartmentName)
//{
//    SqlCommand cmd = new SqlCommand("get_department_name", con);
//    cmd.CommandType = CommandType.StoredProcedure;
//    cmd.Parameters.AddWithValue("@DepartmentName", DepartmentName);
//    SqlDataAdapter sda = new SqlDataAdapter(cmd);
//    DataSet ds = new DataSet();
//    sda.Fill(ds);
//    return ds.Tables[0];
//}