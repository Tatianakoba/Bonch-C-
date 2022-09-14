//ComboBox
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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListBox lB = new ListBox();
            lB.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\WinForm (baza)\IMG\Зима.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\WinForm (baza)\IMG\Весна.jpg");
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\WinForm (baza)\IMG\Лето.jpg");
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\WinForm (baza)\IMG\Осень.jpg");
                        break;
                    }

            }
        }
    }
}
