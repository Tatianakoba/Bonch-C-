//Вариант 1. Даны три целых числа. Найдите их сумму и произведение.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumProizv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c, s;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            s = a + b + c;
            label4.Text = "" + s;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b, c, p;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            p = a * b * c;
            label5.Text = "" + p;
        }
    }
}
