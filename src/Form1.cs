using System;
using System.Windows.Forms;

namespace ForzaHorizon4Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator.Calculate(textBox2, comboBox1, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), textBox1.Text);
        }
    }
}
