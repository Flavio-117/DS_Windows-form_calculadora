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
        double primeiro;
        double segundo;
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
            if (first && second) 
            {
                label3.Text = (primeiro + segundo).ToString();
            }
            else 
            {
                label3.Text = "ensira dois valores válidos";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (first && second)
            {
                if(primeiro > segundo) 
                {
                    label3.Text = primeiro + " é maior do que " + segundo;
                }
                else 
                {
                    label3.Text = primeiro + " é menor do que " + segundo;
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1))
            {
                first = true;
                primeiro = num1;
                label3.Text = "resultado";
            }
            else if (textBox1.Text == "")
            {
                first = false;
                label3.Text = "insira um valor no primeiro campo";
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
            if (first && second)
            {
                label3.Text = (primeiro - segundo).ToString();
            }
            else
            {
                label3.Text = "ensira dois valores válidos";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            if (first && second)
            {
                label3.Text = (primeiro * segundo).ToString();
            }
            else
            {
                label3.Text = "ensira dois valores válidos";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
            if (first && second)
            {
                label3.Text = (primeiro / segundo).ToString();
            }
            else
            {
                label3.Text = "ensira dois valores válidos";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textBox2.Text, out double num2))
            {
                second = true;
                segundo = num2;
                label3.Text = "resultado";
            }
            else if (textBox2.Text == "")
            {
                second = false;
                label3.Text = "insira um valor no segundo campo";
            }
            else
            {
                second = false;
                label3.Text = "somente números, por favor";
            }
            ;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            if (first) 
            {
                if ((primeiro % 2) != 0)
                {
                    label3.Text += primeiro + " é ímpar";
                }
                else
                {
                    label3.Text += primeiro + " é par";
                }
            }
            if (first && second) 
            {
                label3.Text += ", e ";
            }
            if (second) 
            {
                if ((segundo % 2) != 0)
                {
                    label3.Text += segundo + " é ímpar";
                }
                else
                {
                    label3.Text += segundo + " é par";
                }
            }
            
        }
    }
}
