//Создайте новый проект для вычисления значения функции f (х) .
//Fx={x2-3x+9   , при x≤3;   1x3+1   , при x >3. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Function
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x,y;
            x = Convert.ToDouble(textBox1.Text);
            if (x<=3)
            {
                y = Math.Pow(x, 2) - 3 * x + 9;
                label3.Text = Math.Round(y, 2).ToString();
            }
            else
            {
                y = 1/(Math.Pow(x, 3) + 1);
                label3.Text = Math.Round(y, 2).ToString();
            }
        }
    }
}
