using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           int n1 = int.Parse(textBox1.Text);   
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string op = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int n2 = int.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            string op = textBox2.Text;
            double n2 = double.Parse(textBox3.Text);

            if (op == "+")
            {
                double n3 = n1 + n2;
                string n4 = n3.ToString();
                textBox4.Text = n4 ;
            }
            else if (op == "-")
            {
                double n3 = n1 - n2;
                string n4 = n3.ToString();
                textBox4.Text = n4;
            }
            else if (op == "*" || op == "x")
            {
                double n3 = n1 * n2;
                string n4 = n3.ToString();
                textBox4.Text = n4;
            }
            else if (op == "/")
            {
                double n3 = n1 / n2;
                string n4 = n3.ToString();
                textBox4.Text = n4;
            }
            else if (op == "%")
            {
                double n3 = n1 % n2;
                string n4 = n3.ToString();
                textBox4.Text = n4;
            }
            else
            {
                textBox4.Text = "algo deu errado";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}