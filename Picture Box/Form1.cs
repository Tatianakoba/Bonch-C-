//Вариант 3.На форме имеется три кнопки: на одной написано — «воздушный транспорт»,
//    на другой — «наземный транспорт», на третьей — «водный транспорт». 
//    Нажатие каждой из этих кнопок должно сопровождаться отображением соответствующей иллюстрации.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\Picture Box\IMG\Plane.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\Picture Box\IMG\truck.jpg");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Tatiana\source\repos\Picture Box\IMG\ship.jpg");
        }
    }
}
