using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer1
{
    public partial class Calculator : Form
    {


        static bool firstnum = true; // if first number entered
        static bool firstdigit = true; // if first digit entered
        static bool prevOp = false; // if someone clicks two operations in a row
        static string equation = ""; // equation to be evaluated

        // add number to text box
        private void Add(decimal x)
        {
            prevOp = false;
            if (firstdigit)
            {
                textBox1.Text = "" + x;
                firstdigit = false;
            }
            else
            {
                textBox1.Text += x;
            }
            equation += x;
        }
        public Calculator()
        {
            InitializeComponent();
        }

        // 0 button
        private void button14_Click(object sender, EventArgs e)
        {
            Add(0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Add(7);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Add(8);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Add(9);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Add(4);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Add(5);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Add(6);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add(1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add(2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add(3);

        }

        // + button
        private void button10_Click(object sender, EventArgs e)
        {
            if (prevOp)
            {
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "+";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
            }
            equation += "+";



        }

        // - button
        private void button11_Click(object sender, EventArgs e)
        {
            if (prevOp)
            {
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "-";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
            }
            equation += "-";

        }

        // * button
        private void button12_Click(object sender, EventArgs e)
        {
            if (prevOp)
            {
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "*";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
            }
            equation += "*";

        }

        // / button
        private void button16_Click(object sender, EventArgs e)
        {
            if (prevOp)
            {
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "/";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
            }
            equation += "/";

        }

        // = button
        private void button13_Click(object sender, EventArgs e)
        {
            if (prevOp)
                return;
            prevOp = true;

            DataTable dt = new DataTable();

            double answer;
            object obj = dt.Compute(equation, "").ToString();

            answer = double.Parse(obj.ToString());

            textBox1.Text = equation + "=" + answer;

            equation = "";

            firstnum = true;
            firstdigit = true;

        }

        // . button
        private void button15_Click(object sender, EventArgs e)
        {
            if (firstdigit)
            {
                firstdigit = false;
                textBox1.TextAlign = HorizontalAlignment.Right;
                textBox1.Text = "0.";
                equation += "0.";
            }
            else
            {
                textBox1.Text += ".";
                equation += ".";
            }

        }
    }
}
