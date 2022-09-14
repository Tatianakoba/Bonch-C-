using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._07._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //вычислить значение y = sin(x)
            double y;
            listBox1.Items.Add(String.Format("{0,5}{1,25}", "x", "y"));
            listBox1.Items.Add("________________________________");
            for (double x = 0; x <=2; x+=0.2)
            {
                y = Math.Sin(x);
                listBox1.Items.Add(String.Format("\r\n {0,5:F1}{1,25:F4}", x, y));
            }
            listBox1.Items.Add("________________________________");
        }
    }
}
