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
            textBox2.Text = Calculator.Calculate(comboBox1, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsAllowedSymbol(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsAllowedSymbol(e);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsAllowedSymbol(e);
        }

        private void IsAllowedSymbol(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44 && number != 46)
            {
                e.Handled = true;
            }
        }
    }
}
