using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Функция
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string CreateHoro()
       
        {
            String[] horoskop = {
                    "Не нужно торопиться. Вы добьетесь успеха, если будете действовать последовательно, избегать лишней суеты. " +
                    "Решайте самостоятельно, на чем вы сосредоточитесь сейчас, а что отложите на потом. Советы знакомых едва ли будут полезными," +
                    " а вот сбить вас с толку, к сожалению, могут.Ладить с окружающими может быть сложнее, чем обычно. Порой будет казаться, " +
                    "что они специально испытывают ваше терпение, стараются вывести из равновесия. Но если вы сохраните доброжелательность" +
                    " и чувство юмора, острых моментов и конфликтов удастся избежать.",
                    "Сегодня будет особенно важно не поддаваться на провокации и " +
                    "сохранять доброжелательный и оптимистичный настрой," +
                    " как бы ни складывались обстоятельства. " +
                    "Скорее всего, вам придется иметь дело с людьми, к которым непросто найти подход. " +
                    "Едва ли кто-то другой смог бы справиться с этим лучше.Возможны небольшие разногласия на работе и дома," +
                    " но вы быстро поймете, как сгладить острые углы. Будет возможность порадовать близких. " +
                    "Не забудьте поделиться с ними хорошими новостями. Не исключено, что появится повод для домашнего праздника, " +
                    "и он удастся на славу.",
                    "Действуйте быстро. Это особенно важно в первой половине дня: если не тратить время на пустяки, " +
                    "можно успеть очень многое. Вам будут помогать очень разные люди, даже те, от кого вы не ожидали ничего подобного. " +
                    "Не упустите возможность подружиться с теми, кто давно вам симпатичен. Вторая половина дня пройдет несколько спокойнее, " +
                    "но и она будет по-своему хороша. Вероятны успехи там, где требуются фантазия и творческий подход. ",
                    "День будет довольно насыщенным." +
                    " Важно правильно расставить приоритеты, не тратить слишком много времени на пустяки. "
                };
            
            Random rnd = new Random();
            int index = rnd.Next(0, horoskop.Length);

            string a = horoskop[index];
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            int a;
            a = int.Parse(textBox1.Text);
            if ((a >3)&&(a<10))
            {
                comboBox1.SelectedIndex = 0;
            }
            if ((a > 10) && (a < 15))
            {
                comboBox1.SelectedIndex = 2;
            }
            if ((a > 15) && (a < 20))
            {
                comboBox1.SelectedIndex = 3;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        this.label1.MaximumSize = new Size(600, 300);
                        label1.Text = CreateHoro();
                        break;
                    }
                case 1:
                    {
                        this.label1.MaximumSize = new Size(600, 300);
                        label1.Text = CreateHoro();
                        break;
                    }
                case 2:
                    {
                        this.label1.MaximumSize = new Size(600, 300);
                        label1.Text = CreateHoro();
                        break;
                    }
                    
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
