using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tc,tk,tf;
            tc = textBox1.Text;
            tk = textBox3.Text;
            tf = textBox2.Text;
            double tc1, tk1, tf1;
            if ((tc !="") && (tk == "") && (tf == ""))
            {
                tc1 = double.Parse(textBox1.Text);
                tk1 = tc1 - 273.15;
                tf1 = ((tc1 * 9) / 5) + 32;
                textBox3.Text =  Math.Round(tk1, 0).ToString();
                textBox2.Text =  Math.Round(tf1,0).ToString();
            }
            if ((tk != "") && (tc == "") && (tf == ""))
            {
                tk1 = double.Parse(textBox3.Text);
                tc1 = tk1 + 273.15;
                tf1 = tc1 * 9 / 5 + 32;
                textBox1.Text =  Math.Round(tc1, 0).ToString();
                textBox2.Text =  Math.Round(tf1, 0).ToString();
            }
            if ((tf != "") && (tk == "") && (tc == ""))
            {
                tf1 = double.Parse(textBox2.Text);
                tc1 = ((tf1 - 32) * 5 / 9 );
                tk1 = tc1 - 273.15;
                
                textBox3.Text =  Math.Round(tk1, 0).ToString();
                textBox1.Text =  Math.Round(tc1, 0).ToString();
            }
        }
    }
}