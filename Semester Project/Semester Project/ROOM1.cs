using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Semester_Project
{
    public class ROOM1

    {
        public bool FindRoom(String RoomNo)
        {
            bool Found = false;
            String query = "Select*from Student1 where RoomNo='" + RoomNo + ",";
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

        public bool DeleteRoomRecord(String RoomNo)
        {
            String query = "delete from student1  where RoomNo=@RoomNo";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
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

            public bool UpdateRoomRecord(String RoomNo, String Location, String CurrentAllocation, string MaxAlloc)
        {
            String query = "update Room set RoomNo=@RoomNo,Location=@Location,CurrentAllocation=@CurrentAllocation,MaxAlloc=@MaxAlloc";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@CurrentAllocation", CurrentAllocation);
            cmd.Parameters.AddWithValue("@Maxalloc", MaxAlloc);

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
            public bool AddRoomRecord(String RoomNo, String Location, String CurrentAlllocation, string Maxallocation)
        {
            String query = "Insert into Room (RoomNo,Location,CurrentAllocation,Maxallocation) values(@RoomNo,@Location,@CurrentAllocation,@Maxallocation)";
            {
                MessageBox.Show(query);
            }
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = DBConnection.GetConnection();
            cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
            cmd.Parameters.AddWithValue("@Location", Location);
            cmd.Parameters.AddWithValue("@CurrentAllocation", CurrentAlllocation);
            cmd.Parameters.AddWithValue("@Maxallocation", Maxallocation);

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
        public DataTable GetRoomRecords()
        {
            String query = "Select * from Room";
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

