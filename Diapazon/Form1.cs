//3.Проверить, принадлежит ли число, введенное с клавиатуры, интервалу (a, b), интервал так же вводится с клавиатуры.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diapazon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            if (a > b)
            {
                label4.Text = "Вы ввели неверный диапазон";

            }
            else
            {
                if ((c >= a) && (c <= b))
                {
                    label4.Text = "Число " + c + " входит в диапазон от " + a + " до " + b;
                }
                else
                {
                    label4.Text = "Число " + c + " не входит в диапазон от " + a + " до " + b;
                }
            }
    }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
