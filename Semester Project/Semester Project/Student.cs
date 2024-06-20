using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Semester_Project
{
    public class Student
    {
        public bool FindStudent(String RollNo)
        {
            bool Found = false;
            String query = "Select * from Student where RollNo='" + RollNo + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Found = true;
                }
                else
                {
                    Found = false;
                }
            }
            catch (SqlException ex)
            {
                Found = false;
                MessageBox.Show(ex.Message);
            }
            return Found;

        }
        public bool DeleteStudentRecord(String RollNo)
        {
            String query = "delete from Student  where RollNo=@RollNo";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@RollNo", RollNo);
            bool success = false;
            try
            {
                // execute the query and return 
                // number of records inserted into n
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (SqlException ex)
            {
                success = false;
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public bool UpdateStudentRecord(String RollNo, String Name, String Address, string ContactNo, string DeptId)
        {
            String query = "update Student set RollNo=@RollNo,Name=@Name,Address=@Address,ContactNo=@ContactNO,DeptId=@DeptId";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@RollNo", RollNo);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@DeptId", DeptId);
            
            bool success = false;
            try
            {
                // execute the query and return 
                // number of records inserted into n
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (SqlException ex)
            {
                success = false;
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public bool AddStudentRecord(String RollNo, String Name, String Address, string ContactNo, string DeptId)
        {
            String query = "Insert into Student ( RollNo,Name,Address,ContactNo,DeptId) values (@RollNo,@Name,@Address,@ContactNo,@DeptId)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@RollNo", RollNo);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@ContactNo", ContactNo);
            cmd.Parameters.AddWithValue("@DeptId", DeptId);
            
            bool success = false;
            try
            {
                // execute the query and return 
                // number of records inserted into n
                int n = cmd.ExecuteNonQuery();
                if (n == 1)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (SqlException ex)
            {
                success = false;
                MessageBox.Show(ex.Message);
            }
            return success;


        }
        public DataTable GetStudentRecords()
        {
            String query = "Select * from Student";
            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());

            DataTable dt = new DataTable();
            try
            {
                // fetch records and fill in dt object
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return dt;
            }
            return dt;


        }
    }
}
