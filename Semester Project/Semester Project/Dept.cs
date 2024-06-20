using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semester_Project
{
    public partial class frmdept : Form
    {
        _1Dept d = new _1Dept();
        public frmdept()
        {
            InitializeComponent();
        }

        private void DeptName_Load(object sender, EventArgs e)
        {
            DBConnection.Connect();
            DisplayRecord();

        }
        void DisplayRecord()
        {
            dgv2.DataSource = d.GetDeptRecords();
            dgv2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv2.ReadOnly = true;
            dgv2.Refresh();
        }
        public void ClearForm()
        {
            txtdeptid.Clear();
            txtdeptname.Clear();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (txtdeptid.Text == "")
            {
                MessageBox.Show("DeptId can not be null");
                return;
            }
            if (txtdeptname.Text == "")
            {
                MessageBox.Show("Deptname can not be null");
                return;
            }
            String DeptId = txtdeptid.Text;
            String DeptName = txtdeptname.Text;
            if (d.FindDept(DeptId))
            {
                MessageBox.Show("Room record already exit");
                return;

            }
            if (d.AddDeptRecord(DeptId, DeptName))
            {


                MessageBox.Show("Dept Record Added successfully");
            }
            else
            {
                MessageBox.Show("Error adding Dept record");
            }
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgv2.SelectedRows[0];
                txtdeptid.Text = dr.Cells[0].Value.ToString();
                txtdeptname.Text = dr.Cells[1].Value.ToString();



            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            txtdeptid.ReadOnly = false;

            if (txtdeptid.Text == "")
            {
                MessageBox.Show("Deptid can not be null");
                return;
            }
            if (txtdeptname.Text == "")
            {
                MessageBox.Show("Dept Name can not be null");
                return;
            }
            string DeptId = txtdeptid.Text;
            string DeptName = txtdeptname.Text;
            if (!d.FindDept(DeptId))
            {
                MessageBox.Show("Dept record does not exit");
                return;
            }
            if (d.UpdateDeptRecord(DeptId, DeptName))
            {
                DisplayRecord();
                ClearForm();

            }
            MessageBox.Show("Dept Record updated successfully");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv2.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgv2.SelectedRows[0];
                string txtRoomNo = dr.Cells[0].Value.ToString();
                DialogResult s = MessageBox.Show("Do you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (s == DialogResult.Yes)
                {
                    if (d.DeleteDeptRecord(txtRoomNo))
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
    
            
           









