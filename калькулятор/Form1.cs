using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender,EventArgs e)
        {
            chislo11.Clear(); chislo12.Clear(); chislo13.Clear(); chislo21.Clear(); chislo22.Clear();
            chislo23.Clear(); total1.Clear(); total2.Clear(); total3.Clear();
        }

        private void plus1_Click(object sender, EventArgs e)
        {
            double a, b, total;
            a = Convert.ToDouble(chislo11.Text);
            b = Convert.ToDouble(chislo21.Text);
            total = 0;
            if ((sender as Button).Text == "+")
            {
                total = a + b;
            }
            else if ((sender as Button).Text == "-")
            {
                total = a - b;
            }
            total1.Text = total.ToString();
        }
        private void minus1_Click(object sender, EventArgs e)
        {
            double a, b, total;
            a = Convert.ToDouble(chislo11.Text);
            b = Convert.ToDouble(chislo21.Text);
            total = a - b;
            total1.Text = total.ToString();
        }
        private void multy1_Click(object sender, EventArgs e)
        {
            double a, b, total;
            a = Convert.ToDouble(chislo11.Text);
            b = Convert.ToDouble(chislo21.Text);
            total = a * b;
            total1.Text = total.ToString();
        }
        private void divis1_Click(object sender, EventArgs e)
        {
            double a, b, total;
            a = Convert.ToDouble(chislo11.Text);
            b = Convert.ToDouble(chislo21.Text);
            total = a / b;
            total1.Text = total.ToString();
        }
        public string p = "";
        private void plus2_CheckedChanged(object sender, EventArgs e)
        {
            p = "+";
        }

        private void minus2_CheckedChanged(object sender, EventArgs e)
        {
            p = "-";
        }

        private void multy2_CheckedChanged(object sender, EventArgs e)
        {
            p = "*";
        }

        private void divis2_CheckedChanged(object sender, EventArgs e)
        {
            p = "/";
        }

        private void total22_Click(object sender, EventArgs e)
        {
            double a, b, total;
            a = Convert.ToDouble(chislo12.Text);
            b = Convert.ToDouble(chislo22.Text);
            switch (p)
            {
                case "+":
                    total = a + b;
                    total2.Text = total.ToString();
                break;
                case "-":
                    total = a - b;
                    total2.Text = total.ToString();
                break;
                case "*":
                    total = a * b;
                    total2.Text = total.ToString();
                break;
                case "/":
                    total = a / b;
                    total2.Text = total.ToString();
                break;
            }
        }

        private void total33_Click(object sender, EventArgs e)
        {
            double a, b, total;
            a = Convert.ToDouble(chislo13.Text);
            b = Convert.ToDouble(chislo23.Text);
            switch (deside.Text)
                {
                case "+":
                    total = a + b;
                    total3.Text = total.ToString();
                    break;
                case "-":
                    total = a - b;
                    total3.Text = total.ToString();
                    break;
                case "*":
                    total = a * b;
                    total3.Text = total.ToString();
                    break;
                case "/":
                    total = a / b;
                    total3.Text = total.ToString();
                    break;
            }
        }
    }
}
