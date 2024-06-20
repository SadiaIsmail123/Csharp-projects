using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project
{
    public class DBConnection
    {

        private static SqlConnection cn;
        public static void Connect()
        {
            String connectionString = @"Data Source=DESKTOP-Q5KR0VI;Initial Catalog=project practice1;Integrated Security=True";  

            cn = new SqlConnection(connectionString);
            try
            {
                cn.Open(); // perform connection to SQL Server DBMS
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Disconnect()
        {
            if (cn.State == ConnectionState.Open)
                cn.Close();
        }
        public static SqlConnection GetConnection()
        {
            return cn;
        }
    }
}

 





    

