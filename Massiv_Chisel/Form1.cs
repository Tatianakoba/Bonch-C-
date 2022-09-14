using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Massiv_Chisel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //подключаем генератор СЧ
            Random rand = new Random();
            //очистка листбокс при каждом нажатии кнопки
            listBox1.Items.Clear();
            //воод размерности и конвертация
            int n = Convert.ToInt32(textBox1.Text);
            // инициализация переменных
            int pol = 0;
            int otr = 0;
            int zer = 0;

            //цикл заполнения 
            for (int i = 0; i < n; i++)
            {
                //генерация с помощью СЧ из диапазона
                int a = rand.Next(-50, 50);
                // помещаем в коллекцию
                listBox1.Items.Add(a);
                if (a == 0)
                {
                    zer++;
                }
                if (a > 0)
                {
                    pol++;
                }
                if (a < 0)
                {
                    otr++;
                }
            }
            label2.Text = "Положительных чисел " + pol.ToString() + "\nОтрицательных чисел " + otr.ToString() + "\nКоличество чисел, равных нулю " + zer.ToString();
        }

    }

}


    


