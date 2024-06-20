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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmloginform frm = new frmloginform();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstudent frm = new frmstudent();
            frm.MdiParent = this;
            frm.Show();
           
            
            
        }

        private void updateSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdept frm = new frmdept();
            frm.MdiParent = this;
            frm.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmroomform frm = new frmroomform();
            frm.MdiParent = this;
            frm.Show();

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmroomallotment frm = new frmroomallotment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    } 
}
