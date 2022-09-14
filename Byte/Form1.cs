//Вариант 5. Дан размер файла в байтах. Переведите эту величину в килобайты.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(textBox1.Text);
            y = x / 1000;
            label2.Text = "Размер файла в килобайтах = " + y.ToString();
        }
    }
}
