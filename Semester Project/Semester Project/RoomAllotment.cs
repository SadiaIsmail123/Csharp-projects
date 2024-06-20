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
    public partial class frmroomallotment : Form
    {
        allotmentroom a = new allotmentroom();
        Student s = new Student();
        ROOM1 r = new ROOM1();


        public frmroomallotment()
        {
            InitializeComponent();
        }
        public void FillRollNoCombo()
        {
            cbrollno.DataSource = s.GetStudentRecords();
            cbrollno.DisplayMember = "rollno";
            cbrollno.ValueMember = "rollno";
        }
        public void FillRoomCombo()
        {
            cbroomno.DataSource = r.GetRoomRecords();
            cbroomno.DisplayMember = "roomno";
            cbroomno.ValueMember = "roomno";
        }
        void DisplayRecord()
        {
            dgv6.DataSource = a.GetAllocRecords();
            dgv6.ReadOnly = true;
            dgv6.Refresh();

        }
            private void RoomAllotment_Load(object sender, EventArgs e)
        {
            DBConnection.Connect();
            DisplayRecord();
            dgv6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FillRollNoCombo();
            FillRoomCombo();
            DisplayRecord();



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtallocid.Text == "")
            {
                MessageBox.Show("error");
                return;
            }
            String allocid = txtallocid.Text;
            DateTime date = dtp1.Value;



            if (a.FindAlloc(allocid))
            {
                MessageBox.Show("Room already exist");
                return;
            }
            if (a.AddAllocRecord(allocid, date))
            {
                DisplayRecord();

                MessageBox.Show("Record Entered Successfully");
            }
            else
            {
                MessageBox.Show("Error");

            }


        }
    }
}
