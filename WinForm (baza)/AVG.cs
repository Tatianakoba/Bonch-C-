//Среднее арифметическое
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm__baza_
{
    public partial class AVG : Form
    {
        public AVG()
        {
            InitializeComponent();
        }
        //Среднее арифметическое
        private void button1_Click(object sender, EventArgs e)
        {
            ComboBox cB = new ComboBox();
            cB.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b, c, s;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            s = (a + b + c)/3;
            label4.Text = " Среднее арифметическое чисел " + a + ", " + b + ", " + c + ", равно: " + Math.Round(s,2);
        }
    }
}
