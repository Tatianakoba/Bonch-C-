//4.Напишите программный код для выполнения арифметических действий над двумя переменными (миникалькулятор)
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
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

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            double C = (a + b);

            label2.Text = "" + Math.Round(C, 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            double C = (a - b);

            label2.Text = "" + Math.Round(C, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            double C = (a * b);

            label2.Text = "" + Math.Round(C, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            double C = (a / b);

            if (b == 0)
            {
                label3.Text = "На 0 делить нельзя! Введите другое значение";
            }
            else
            {
                
                label2.Text = "" + Math.Round(C,2);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
