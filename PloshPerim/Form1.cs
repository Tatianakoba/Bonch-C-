//Вариант 2. Дана длина стороны квадрата. Найдите его периметр и площадь.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PloshPerim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, s;
            a = double.Parse(textBox1.Text);
            s = Math.Pow(a, 2);
            label2.Text = "" + s;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, p;
            a = double.Parse(textBox1.Text);
            p = 4*a;
            label3.Text = "" + p;

        }
    }
}
