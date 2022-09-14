
//Вариант 2.Даны перечень единиц массы (миллиграмм, грамм, килограмм, центнер, тонна)
//    и масса тела в этих единицах (вещественное число). Найдите массу тела в килограммах.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massa_tela
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double x, a;
            x = double.Parse(textBox1.Text);

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        a = x;
                        textBox2.Text = a.ToString();
                        break;
                    }
                case 1:
                    {
                        a = x / 1000;
                        textBox2.Text = a.ToString();
                        break;
                    }
                case 2:
                    {
                        a = x / (1e+6);
                        textBox2.Text = a.ToString();
                        break;
                    }
                case 3:
                    {
                        a = x / (1e+8);

                        textBox2.Text = a.ToString();
                        break;
                    }
                case 4:
                    {
                        a = x / (1e+9);
                        textBox2.Text = a.ToString();
                        break;
                    }


            }
        }
    }
}
