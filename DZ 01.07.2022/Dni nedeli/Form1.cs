//Вариант 1. Создайте проект, позволяющий выводить название дня недели по его номеру, используя перечис¬ление.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dni_nedeli
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
                        pictureBox1.Visible = true;
                        label1.Text = "Понедельник";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Dni nedeli\IMG\Понедельник.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Вторник";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Dni nedeli\IMG\Вторник.jpg");
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Среда";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Dni nedeli\IMG\Среда.jpg");
                        break;
                    
                    }
                case 3:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Четверг";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Dni nedeli\IMG\Четверг.jpg");
                        break;
                    }
                case 4:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Пятница";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Dni nedeli\IMG\Пятница.jpg");
                        break;
                    }
                case 5:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Суббота";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Dni nedeli\IMG\Суббота.jpg");
                        break;
                    }
                case 6:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Воскресенье";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Dni nedeli\IMG\Воскресенье.jpg");
                        break;
                    }


            }
        }
    }
}
