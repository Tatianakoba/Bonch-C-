//Вариант 1.Дано двузначное число.Имеются ли в его записи цифры 3, 6 или 9?
//Вариант 2. Дано трехзначное число.Верно ли, что все его цифры одинаковы?

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dvuhzn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a,y,z;
            a = int.Parse(textBox1.Text);
            y = a / 10;
            z = a % 10;
            if ((y == 3) || (y == 6) || (y == 9))
            {
                label2.Text = "В числе " + a + " содержатся цифры 3,6 или 9";

            }
            else if ((z == 3) || (z == 6) || (z == 9))
            {
                label2.Text = "В числе " + a + " содержатся цифры 3,6 или 9";

            }
            else 
            {
                label2.Text = "В числе " + a + " нет цифр 3,6 или 9";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a;
            a = textBox2.Text;
            if (a.Length == 3)
            {
                
                    if ((a[0] == a[1])&&(a[1] == a[2]))
                    {

                    label4.Text = "Цифры в числе " + a + " равны";

                    }                    
                    else
                    {

                    label4.Text = "Цифры в числе " + a + " не равны"; 
                    }
                   
                

            }
            
            else
            {
                label4.Text = "Вы ввели неверное число. Повторите ввод";
            }
        }
    }
}
