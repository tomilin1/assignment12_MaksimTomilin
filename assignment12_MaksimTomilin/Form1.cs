using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace assignment12_MaksimTomilin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int number = (int)0;
            int shift = (int)0;
            decimal hourlyrate = (decimal)0;

            if (!string.IsNullOrEmpty(name) &&
                int.TryParse(textBox2.Text, out number) &&
                int.TryParse(textBox3.Text, out shift) &&
                decimal.TryParse(textBox4.Text, out hourlyrate))
            {
                ProductionWorker worker = new ProductionWorker(name, number, shift, hourlyrate);
                textBox5.Text = worker.ToString();
            }
            else
            {
                MessageBox.Show("Incorrect, try again");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
