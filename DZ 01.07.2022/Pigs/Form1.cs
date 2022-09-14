//Вариант 2. Три поросенка — Ниф-Ниф, Нуф-Нуф и Наф-Наф — нашли под дубом желуди.
//Каждый из них набрал себе приличный запас на зиму (дано три числа).
//Составьте программу, которая бы определяла, какой по¬росенок поленился и набрал меньше всех.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pigs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,b,c;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            c = int.Parse(textBox3.Text);
            if ((a > b) && (c > b))
            {
                label4.Text = "Лентяй Наф-Наф";
            }
            if ((a > c) && (b > c))
            {
                label4.Text = "Лентяй Нуф-Нуф";
            }
            if ((a < c) && (b > a))
            {
                label4.Text = "Лентяй Ниф-Ниф";
            }
        }
    }
}
