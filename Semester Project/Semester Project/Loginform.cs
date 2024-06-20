using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project
{
    public partial class frmloginform : Form
    {
        public frmloginform()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)

        {
            string userid = "Hello";
            string password = "123";

            if (txtlogin.Text == "")
            {
                MessageBox.Show("userid can not null");
                return;
            }
            if (txtpassword.Text == "")
            {
                MessageBox.Show("password can not null");
                return;
            }
            if(txtlogin.Text==userid&&txtpassword.Text==password)
            {
                MessageBox.Show("login successfully");
            }
            else
            {
                MessageBox.Show("not login");
            }

            
            
                
               
            
           
           
        }

        private void frmloginform_Load(object sender, EventArgs e)
        {

        }
    }
}
