//Вариант 1. Даны натуральные числа х и у, определяю¬щие возраст двух друзей. Из данных чисел напечатайте те,
//которые обозначают «школьный» возраст, то есть от 7 до 16 лет.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vozrast
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y;
            x = int.Parse(textBox1.Text);
            y = int.Parse(textBox2.Text);
            if ((x >= 7) && (x <= 16))
            {
                label3.Text = "Друг 1, возраста " + x + " лет - школьник";
            }
            else
            {
                label3.Text = "Друг 1 не школьник";
            }
            if ((y >= 7) && (y <= 16))
            {
                label4.Text = "Друг 2, возраста " + y + " лет - школьник";
            }
            else
            {
                label4.Text = "Друг 2 не школьник";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
