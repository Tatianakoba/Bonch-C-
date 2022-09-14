//Задание 4. Создайте проект, имитирующий выбор сигнала светофора.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svetofor
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
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\Svetofor\IMG\Red.jpg");
                        break;
                    }
                case 1:
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\Svetofor\IMG\Yellow.jpg");
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\Svetofor\IMG\Green.jpg");
                        break;
                    }
            }
        }
    }
}
