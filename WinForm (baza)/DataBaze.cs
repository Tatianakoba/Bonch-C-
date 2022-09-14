//DataBaze
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
    public partial class DataBaze : Form
    {
        public DataBaze()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            Hide();

        }

        private void DataBaze_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "importDataSet1.billing". При необходимости она может быть перемещена или удалена.
            this.billingTableAdapter.Fill(this.importDataSet1.billing);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
