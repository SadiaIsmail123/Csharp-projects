using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.Common;
using System.Text.RegularExpressions;
using System.IO;
namespace Semester_Project
{
    public class _1Dept
    {
        public bool FindDept(String DeptId)
        {
            bool Found = false;
            String query = "SELECT * FROM Department WHERE DeptId=@DeptId";
            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());
            da.SelectCommand.Parameters.AddWithValue("@DeptId", DeptId);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                Found = dt.Rows.Count == 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Found;
        }

        public bool DeleteDeptRecord(String DeptId)
        {
            String query = "DELETE FROM Department WHERE DeptId=@DeptId";
            SqlCommand cmd = new SqlCommand(query, DBConnection.GetConnection());
            cmd.Parameters.AddWithValue("@DeptId", DeptId);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                success = n == 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        public bool UpdateDeptRecord(String DeptId, String DeptName)
        {
            String query = "UPDATE Department SET DeptName=@DeptName WHERE DeptId=@DeptId";
            SqlCommand cmd = new SqlCommand(query, DBConnection.GetConnection());
            cmd.Parameters.AddWithValue("@DeptId", DeptId);
            cmd.Parameters.AddWithValue("@DeptName", DeptName);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                success = n == 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        public bool AddDeptRecord(String DeptId, String DeptName)
        {
            String query = "INSERT INTO Department (DeptId, DeptName) VALUES (@DeptId, @DeptName)";
            SqlCommand cmd = new SqlCommand(query, DBConnection.GetConnection());
            cmd.Parameters.AddWithValue("@DeptId", DeptId);
            cmd.Parameters.AddWithValue("@DeptName", DeptName);
            bool success = false;
            try
            {
                int n = cmd.ExecuteNonQuery();
                success = n == 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }

        public DataTable GetDeptRecords()
        {
            String query = "SELECT * FROM Department";
            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
    }
}







    

    
    





