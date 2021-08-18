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
            Calculator.Calculate(textBox2, comboBox1, 1, 65, textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculator.Calculate(textBox2, comboBox1, 56.6, 283.2, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            Calculator.Calculate(textBox2, comboBox1, 3, 20, textBox1.Text);
        }
    }
}
