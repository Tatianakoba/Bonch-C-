using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\ComboBox\Images\Зима.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\ComboBox\Images\Весна.jpg");
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\ComboBox\Images\Лето.jpg");
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\ComboBox\Images\Осень.jpg");
                        break;
                    }

            }
        }
    }
}
