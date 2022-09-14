using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxMin
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

            if (a > b)
            {
                label3.Text = "Максимальное число a = " + a + " Минимальное число b = " + b;
            }
            else if (a==b)
            {
                label3.Text = "a = b";
            }
            else
            {
                label3.Text = "Минимальное число a = " + a + " Максимальное число b = " + b;
            }
        }
    }
}
