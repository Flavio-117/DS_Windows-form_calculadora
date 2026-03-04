using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_WF
{
    public partial class Form1 : Form
    {
        bool first;
        bool second;
        double num1;
        double num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            //if (int.TryParse(textBox1.Text, out int num1))
            //{
            //    first = true;
            //}
            //else
            //{
            //    first = false;
            //    label3.Text = "somente números, por favor";
            //}
            //if (int.TryParse(textBox2.Text, out int num2))
            //{
            //    second = true;
            //}
            //else
            //{
            //    second = false;
            //    label3.Text = "somente números, por favor";
            //}
            if (first && second) 
            {
                label3.Text = (num1 + num2).ToString();
            }
            else 
            {
                label3.Text = "ensira dois valores válidos";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1))
            {
                first = true;
                label3.Text = num1.ToString();
            }
            else
            {
                first = false;
                label3.Text = "somente números, por favor";
            }
            ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            ////if (int.TryParse(textBox1.Text, out int num1))
            ////{
            ////    first = true;
            ////}
            ////else
            ////{
            ////    first = false;
            ////    label3.Text = "somente números, por favor";
            ////}
            //if (int.TryParse(textBox2.Text, out int num2))
            //{
            //    second = true;
            //}
            //else
            //{
            //    second = false;
            //    label3.Text = "somente números, por favor";
            //}
            if (first && second)
            {
                label3.Text = ((double)num1 - (double)num2).ToString();
            }
            else
            {
                label3.Text = "ensira dois valores válidos";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            //if (int.TryParse(textBox1.Text, out int num1))
            //{
            //    first = true;
            //}
            //else
            //{
            //    first = false;
            //    label3.Text = "somente números, por favor";
            //}
            //if (int.TryParse(textBox2.Text, out int num2))
            //{
            //    second = true;
            //}
            //else
            //{
            //    second = false;
            //    label3.Text = "somente números, por favor";
            //}
            if (first && second)
            {
                label3.Text = ((double)num1 * (double)num2).ToString();
            }
            else
            {
                label3.Text = "ensira dois valores válidos";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
            //if (int.TryParse(textBox1.Text, out int num1))
            //{
            //    first = true;
            //}
            //else
            //{
            //    first = false;
            //    label3.Text = "somente números, por favor";
            //}
            //if (int.TryParse(textBox2.Text, out int num2))
            //{
            //    second = true;
            //}
            //else
            //{
            //    second = false;
            //    label3.Text = "somente números, por favor";
            //}
            if (first && second)
            {
                label3.Text = ((double)num1 / (double)num2).ToString();
            }
            else
            {
                label3.Text = "ensira dois valores válidos";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num2))
            {
                second = true;
            }
            else
            {
                second = false;
                label3.Text = "somente números, por favor";
            }
            ;
        }
    }
}
