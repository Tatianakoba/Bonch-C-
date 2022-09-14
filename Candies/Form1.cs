//Вариант 4. Известно, что X кг конфет стоит А рублей. Определите, сколько стоит Y кг этих же конфет.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, a, b;
            x = double.Parse(textBox1.Text);
            a = double.Parse(textBox2.Text);
            y = double.Parse(textBox3.Text);

            b = a / x * y;
            textBox4.Text = b.ToString();


        }
    }
}
