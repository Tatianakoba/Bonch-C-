//Вариант 3. Дана длина ребра куба а. Найдите объем куба и площадь его полной поверхности.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, v, s;
            a = double.Parse(textBox1.Text);
            s = Math.Pow(a, 6);
            v = Math.Pow(a, 3);
            label2.Text = "" + "Объем куба = " + Math.Round(v,2) + ", площадь полной поверхности куба = " + Math.Round(s,2);
        }
    }
}
