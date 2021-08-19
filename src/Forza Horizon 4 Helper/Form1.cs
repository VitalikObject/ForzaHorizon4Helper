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
            int front;
            double min;
            double max;
            Int32.TryParse(textBox1.Text, out front);
            Double.TryParse(textBox3.Text, out min);
            Double.TryParse(textBox4.Text, out max);

            if (front <= 0 || front > 100)
            {
                MessageBox.Show("Entered unusable number!", "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox2.Text = Calculator.Calculate(comboBox1, min, max, front).ToString();
        }
    }
}
