//Вариант 2. Создайте проект, позволяющий по дате рождения определить знак зодиака и увидеть картинку этого знака (использовать перечисление).
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zodiak
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
                        label1.Text = "Овен";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\Овен.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Телец";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\телец.jpg");
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Близнецы";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\близнецы.jpg");
                        break;

                    }
                case 3:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Рак";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\рак.jpg");
                        break;
                    }
                case 4:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Лев";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\Лев.jpg");
                        break;
                    }
                case 5:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Дева";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\дева.jpg");
                        break;
                    }
                case 6:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Весы";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\Весы.jpg");
                        break;
                    }
                case 7:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Скорпион";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\скорпион.jpg");
                        break;
                    }
                case 8:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Стрелец";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\стрелец.jpg");
                        break;
                    }
                case 9:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Козерог";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\козерог.jpg");
                        break;
                    }
                case 10:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Водолей";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\водолей.jpg");
                        break;
                    }
                case 11:
                    {
                        pictureBox1.Visible = true;
                        label1.Text = "Рыбы";
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\DZ 01.07.2022\Zodiak\IMG\рыбы.jpg");
                        break;
                    }
            }


            }
        }
}
