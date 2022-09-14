//2. Клиент внес в банк K рублей. Каждый месяц эта сумма увеличивается на Y процентов. Составьте таблицу ежемесячных выплат клиенту.

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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBaze dB = new DataBaze();
            dB.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();
        }

        private void ListBox_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b,sum, y;
            sum = 0;
            
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
           
            listBox1.Items.Add(String.Format("Ежемесячные выплаты"));
            listBox1.Items.Add(String.Format("{0,5}{1,25}", "Месяц ", "Сумма "));

            listBox1.Items.Add("________________________________");

            for (int i = 1; i <= 12; i ++)
            {
                a += a*b/100;
                
                listBox1.Items.Add(String.Format("\r\n {0,5:F0}{1,25:F2}",i, a));
                sum+=a;
            }
            listBox1.Items.Add("________________________________");
            listBox1.Items.Add(String.Format("{0,5}{1,0:F2}","Итого сумма=",  sum));



        }
    }
}
