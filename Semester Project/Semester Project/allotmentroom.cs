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
    public class allotmentroom
    {
        public bool FindAlloc(String AllocId)
        {
            bool found = false;
            String query = String.Format("Select * from Roomallotment1 where AllocId = '{0}'", AllocId);
            SqlDataAdapter da = new SqlDataAdapter(query, DBConnection.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    found = true;
                }
                else
                {
                    found = false;
                }

            }
            catch (SqlException ex)
            {
                found = false;
                MessageBox.Show(ex.Message);
            }
            return found;



        }
        public bool AddAllocRecord(String AllocId, DateTime Date)
        {


            String Query = "insert into Roomallotment1(AllocId,Date)values(@AllocId, @Date)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = Query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("AllocId", AllocId);
            cmd.Parameters.AddWithValue("Date", Date);

            bool success = false;
            try
            {
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
        public DataTable GetAllocRecords()
        {
            String query = "Select * from Roomallotment1";
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

            }
            return dt;
        }
    }
}
            

