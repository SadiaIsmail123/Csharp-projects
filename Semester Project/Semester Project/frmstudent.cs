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
    public partial class frmstudent : Form
    {
        Student s = new Student();
        public frmstudent()
        {
            InitializeComponent();
        }

        private void frmstudent_Load(object sender, EventArgs e)
        {
           

        }



















        private void frmstudent_Load_1(object sender, EventArgs e)
        {
            DBConnection.Connect();
            DisplayRecord();

        }
        void DisplayRecord()
        {
            dgv5.DataSource = s.GetStudentRecords();
            dgv5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv5.ReadOnly = true;
            dgv5.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("RollNo can not be null");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("name can not be null");
                return;

            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Address can not be null");
                return;


            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("ContactNo can not be null");
                return;
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("Deptid can not be null");
                return;
            }
            
            
              

            
            String RollNo = textBox7.Text;
            String Name = textBox8.Text;
            String Address = textBox9.Text;
            String ContactNo = textBox10.Text;
            String DeptId = textBox11.Text;
           
            if (s.FindStudent(RollNo))
            {
                MessageBox.Show("Student record already exit");
                return;

            }
            if (s.AddStudentRecord(RollNo, Name, Address, ContactNo, DeptId))
            {


                MessageBox.Show("Student Record Added successfully");

            }
            else
            {
                {
                    MessageBox.Show("Student  error adding record");
                }




            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgv5.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgv5.SelectedRows[0];
                textBox7.Text = dr.Cells[0].Value.ToString();
                textBox8.Text = dr.Cells[1].Value.ToString();
                textBox9.Text = dr.Cells[2].Value.ToString();
                textBox10.Text = dr.Cells[3].Value.ToString();
                textBox11.Text = dr.Cells[4].Value.ToString();
                




            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox7.ReadOnly = false;
            if (textBox7.Text == "")
            {
                MessageBox.Show("RollNo can not be null");
                return;
            }
            if (textBox8.Text == "")
            {
                MessageBox.Show("name can not be null");
                return;
            }
            if (textBox9.Text == "")
            {
                MessageBox.Show("Address can not be null");
                return;


            }
            if (textBox10.Text == "")
            {
                MessageBox.Show("ContactNo can not be null");
                return;
            }
            if (textBox11.Text == "")
            {
                MessageBox.Show("Deptid can not be null");
                return;

            }
            
            
               
               
            
            String RollNo = textBox7.Text;
            String Name = textBox8.Text;
            String Address = textBox9.Text;
            String ContactNo = textBox10.Text;
            String DeptId = textBox11.Text;
           
            if (!s.FindStudent(RollNo))
            {
                MessageBox.Show("Student record already exit");
                return;

            }
            if (s.UpdateStudentRecord(RollNo, Name, Address, ContactNo, DeptId))
            {
                DisplayRecord();
                MessageBox.Show("Student Record Updated successfully");

            }
            else
            {
                MessageBox.Show("Error updating record");

            }

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            
            if (textBox7.Text == "")
            {
                MessageBox.Show("RollNo can not be null");
                return;
            }
            
                
               


           
            
            String RollNo = textBox7.Text;
            String Name = textBox8.Text;
            String Address = textBox9.Text;
            String ContactNo = textBox10.Text;
            String DeptId = textBox11.Text;
            
            if (!s.FindStudent(RollNo))
            {
                MessageBox.Show("Student record already exit");
                return;

            }
            if (s.UpdateStudentRecord(RollNo, Name, Address, ContactNo, DeptId))
            {
                DisplayRecord();
                MessageBox.Show("Student Record Updated successfully");

            }
            else
            {
                MessageBox.Show("Error updating record");

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dgv5.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgv5.SelectedRows[0];
                string textBox7 = dr.Cells[0].Value.ToString();
                DialogResult r = MessageBox.Show("Do you want to delete this record?", "Delete  record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);


                if (r == DialogResult.Yes)
                {
                    {
                        if (s.DeleteStudentRecord(textBox7))
                        {
                            DisplayRecord();
                            MessageBox.Show("student record deleted successsfully");
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
}


       