using System;
using System.Windows.Forms;

namespace ForzaHorizon4Helper
{
    public static class Calculator
    {
        public static void Calculate(TextBox textbox, ComboBox comboBox, double min, double max, string front)
        {
            int _front;
            Int32.TryParse(front, out _front);

            if (_front <= 0 || _front > 100)
            {
                MessageBox.Show("Entered unusable number!", "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch(comboBox.Items.IndexOf(comboBox.SelectedItem))
            {
                case (int)Side.Front:
                    CalculateFrontWeight(textbox, min, max, _front);
                    break;
                case (int)Side.Rear:
                    CalculateRearWeight(textbox, min, max, _front);
                    break;
                default:
                    MessageBox.Show("Selected type doesn't exist!", "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private static void CalculateFrontWeight(TextBox textbox, double min, double max, int front)
        {
            textbox.Text = Math.Round((max - min) * front / 100 + min, 3).ToString();
        }

        private static void CalculateRearWeight(TextBox textbox, double min, double max, int front)
        {
            textbox.Text = Math.Round((max - min) * (100 - front) / 100 + 1, 3).ToString();
        }

        private enum Side
        {
            Front = 0,
            Rear = 1
        }
    }
}
