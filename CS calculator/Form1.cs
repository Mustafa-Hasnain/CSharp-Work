using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
       string Operator = " ";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Operator = "divide";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox2.Text = "9";
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)

        { if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox2.Text = "9";
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox2.Text = "8";
            }
        }
        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
             if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else if (Operator == "")
            {
                textBox1.Text = textBox1.Text + "2";
            }
            else
            {
                textBox2.Text = "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Operator = "multiply";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else if(Operator == "")
            {
                textBox1.Text = textBox1.Text + "1";
            }
            else
            {
                textBox2.Text = "1";
            }

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox2.Text = "3";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox2.Text = "4";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox2.Text = "5";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox2.Text = "6";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox2.Text = "0";
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Operator = "plus";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operator = "minus";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int result = 0 ;

            if(Operator == "plus")
            {
                result = a + b;
            }
            else if (Operator == "minus")
            {
                result = a - b;
            }
            else if (Operator == "multiply")
            {
                result = a * b;
            }
            else if (Operator == "divide")
            {
                result = a / b;
            }

            textBox1.Text = "";
            textBox2.Text = "";

            textBox2.Text = Convert.ToString(result);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
