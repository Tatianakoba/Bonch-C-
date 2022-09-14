using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shelchok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Red;
            button1.Text = "Привет!";
            textBox1.Text = "Этот цвет красный";
            textBox1.ForeColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Blue;
            button2.Text = "Привет!";
            textBox1.Text = "Этот цвет синий";
            textBox1.ForeColor = Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Yellow;   
            button3.Text = "Привет!";
            textBox1.Text = "Этот цвет желтый";
            textBox1.ForeColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Green;
            button4.Text = "Привет!";
            textBox1.Text = "Этот цвет зеленый";
            textBox1.ForeColor = Color.Green;
        }
    }
}
