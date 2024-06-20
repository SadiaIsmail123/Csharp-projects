using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Semester_Project
{
    public partial class frmroomform : Form
    {
        ROOM1 r = new ROOM1();
        public frmroomform()
        {
            InitializeComponent();
        }

        private void frmroomform_Load(object sender, EventArgs e)
        {
            DBConnection.Connect();
            DisplayRecord();
        }
        private void DisplayRecord()
        {
            dgv1.DataSource = r.GetRoomRecords();
            // ACHA display karnay ka liya
            dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // column ma agar space ho to khud hi set ho jay
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.ReadOnly = true;
            dgv1.Refresh();
        }
        void ClearForm()
        {
            txtroomno.Clear();
            txtlocation.Clear();
            txtcurrentalloc.Clear();
            txtmaxalloc.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtroomno.Text == "")
            {
                MessageBox.Show("RoomNo can not be null");
                return;
            }
            if (txtlocation.Text == "")
            {
                MessageBox.Show("location can not be null");
                return;
            }
            if (txtcurrentalloc.Text == "")
            {
                MessageBox.Show("currentalloccan not be null");
                return;
            }
            if (txtmaxalloc.Text == "")
            {
                MessageBox.Show("maxalloc can not be null");
                return;

            }
            String RoomNo = txtroomno.Text;
            String Location = txtlocation.Text;
            String CurrentAllocation = txtcurrentalloc.Text;
            String MaxAllocation = txtmaxalloc.Text;

            if (r.FindRoom(RoomNo))
            {
                MessageBox.Show("Room record already exit");
                return;

            }
            if (r.AddRoomRecord(RoomNo, Location, CurrentAllocation, MaxAllocation))
            {


                MessageBox.Show("Room Record Added successfully");
            }
            else
            {
                MessageBox.Show("Error adding Room record");
            }

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgv1.SelectedRows[0];
                txtroomno.Text = dr.Cells[0].Value.ToString();
                txtlocation.Text = dr.Cells[1].Value.ToString();
                txtcurrentalloc.Text = dr.Cells[2].Value.ToString();
                txtmaxalloc.Text = dr.Cells[3].Value.ToString();

            }
        }
            
        

        private void button1_Click(object sender, EventArgs e)
        {
            txtroomno.ReadOnly = false;

            if (txtroomno.Text == "")
            {
                MessageBox.Show("RoomNo can not be null");
                return;
            }
            if (txtlocation.Text == "")
            {
                MessageBox.Show("Location can not be null");
                return;
            }
            if (txtcurrentalloc.Text == "")
            {
                MessageBox.Show("CurrentAllocation can not be null");
                return;
            }
            if (txtmaxalloc.Text == "")
            {
                MessageBox.Show("Maxalloc can not be null");
                return;
            }
            string RoomNo = txtroomno.Text;
            string location = txtlocation.Text;
            string currentalloc = txtcurrentalloc.Text;
            string Maxalloc = txtmaxalloc.Text;
            if (!r.FindRoom(RoomNo))
            {
                MessageBox.Show("Room record does not exit");
                return;
            }
            if (r.UpdateRoomRecord(RoomNo, location, currentalloc, Maxalloc))
            {
                DisplayRecord();
                ClearForm();
                MessageBox.Show("Room Record updated successfully");
            }
            else
            {
                MessageBox.Show("Error updating room record");






            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgv1.SelectedRows[0];
                string txtRoomNo = dr.Cells[0].Value.ToString();
                DialogResult s = MessageBox.Show("Do you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (s == DialogResult.Yes)
                {
                    if (r.DeleteRoomRecord(txtRoomNo))
                    {
                        DisplayRecord();
                        MessageBox.Show("Room record deleted successsfully");
                    }
                    else
                    {
                        MessageBox.Show("Room record not deleted");
                    }

                }
            }
        }
    }
}
    


