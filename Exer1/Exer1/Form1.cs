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
    public partial class Form1 : Form
    {
        

        //static decimal result=0; // store temp result
        static bool firstnum=true; // if first number entered
        static bool firstdigit = true; // if first digit entered
        static bool prevOp = false; // if someone clicks two operations in a row
        static char op; // store previous operation clicked
        static string equation = ""; // equation to be evaluated

        /*void GetResult(char c)
        {
            switch (c)
            {
                case '+':
                    result += decimal.Parse(textBox1.Text);
                    break;
                case '-':
                    result -= decimal.Parse(textBox1.Text);
                    break;
                case '*':
                    result *= decimal.Parse(textBox1.Text);
                    break;
                case '/':
                    result /= decimal.Parse(textBox1.Text);
                    break;
                default:
                    break;
            }
        }*/
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
        public Form1()
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
                op = '+';
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "+";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
//                result = decimal.Parse(textBox1.Text);
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
//                GetResult(op);
            }
            op = '+';
            equation += "+";



        }

        // - button
        private void button11_Click(object sender, EventArgs e)
        {
            if (prevOp)
            {
                op = '-';
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "-";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
//                result = decimal.Parse(textBox1.Text);
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
                //GetResult(op);
            }
            op = '-';
            equation += "-";

        }

        // * button
        private void button12_Click(object sender, EventArgs e)
        {
            if (prevOp)
            {
                op = '*';
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "*";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
//                result = decimal.Parse(textBox1.Text);
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
  //              GetResult(op);
            }
            op = '*';
            equation += "*";

        }

        // / button
        private void button16_Click(object sender, EventArgs e)
        {
            if (prevOp)
            {
                op = '/';
                equation = equation.Trim(new char[] { '+', '-', '*', '/' });
                equation += "/";
                return;
            }
            prevOp = true;
            if (firstnum)
            {
//                result = decimal.Parse(textBox1.Text);
                firstnum = false;
                firstdigit = true;
            }
            else
            {
                firstdigit = true;
//                GetResult(op);
            }
            op = '/';
            equation += "/";

        }

        // = button
        private void button13_Click(object sender, EventArgs e)
        {
            if (prevOp)
                return;
            prevOp = true;


            //                GetResult(op);
            DataTable dt = new DataTable();

            double answer;
            object obj = dt.Compute(equation, "").ToString();

            answer = double.Parse(obj.ToString());

            textBox1.Text = equation + "=" +  answer;

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
                /*                textBox1.Text = "0.";
                                textBox1.RightToLeft = RightToLeft.No;*/
                textBox1.TextAlign = HorizontalAlignment.Right;
                textBox1.Text = "0.";
                equation += "0.";
                //textBox1.Text = textBox1.Text + ".";
            }
            else
            {
                textBox1.Text += ".";
                equation += ".";
            }
            //MessageBox.Show("textBox1.Text");

        }
    }
}
