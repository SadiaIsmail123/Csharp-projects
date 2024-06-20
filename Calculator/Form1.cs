using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
         int num1;
         int num2;
        string option;
        int result;

        private void btn1_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "1";
           
           
  
                    



        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txttotal.Text = txttotal.Text + "0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txttotal.Text);
            txttotal.Clear();
        }

        private void btnsubb_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txttotal.Text);
            txttotal.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txttotal.Text);
            txttotal.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txttotal.Text);
            txttotal.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txttotal.Text);
            if (option == ("+"))
                 result = num1 + num2;
           
            
            

            if (option == ("-"))
                result = num1 - num2;

            if (option == ("*"))
                result = num1 * num2;

            if (option == ("/"))
                result = num1 / num2;

            txttotal.Text = result + "";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txttotal.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }
    }
}





