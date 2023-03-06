using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_GUI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Double firstnum, total;
        string operation;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Double secondnum = Convert.ToDouble(label1.Text);
            if (operation == "+")
            {
                total = firstnum + secondnum;
            }else if (operation == "-")
            {
                total = firstnum - secondnum;
            }else if (operation == "x")
            {
                total = firstnum * secondnum;
            }else if (operation == "/")
            {
                total = firstnum / secondnum;
            }
            label1.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            firstnum = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(label1.Text);
            label1.Text = "";
            operation = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(label1.Text);
            label1.Text = "";
            operation = "-";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(label1.Text);
            label1.Text = "";
            operation = "x";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstnum = Convert.ToDouble(label1.Text);
            label1.Text = "";
            operation = "/";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
