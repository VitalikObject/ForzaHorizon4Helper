using System;
using System.Windows.Forms;

namespace ForzaHorizon4Helper
{
    public static class Calculator
    {
        private static int _front { get; set; }

        public static void Calculate(TextBox textbox, ComboBox comboBox, double min, double max, string front)
        {
            _front = ToInt32(front);

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
            textbox.Text = Math.Round((max - min) * Format(_front) + min, 3).ToString();
        }

        private static void CalculateRearWeight(TextBox textbox, double min, double max, int front)
        {
            textbox.Text = Math.Round((max - min) * Format(100 - _front) + 1, 3).ToString();
        }

        private static int ToInt32(string value)
        {
            int number;
            if (!Int32.TryParse(value, out number))
                return -1;
            return number;
        }

        private static double Format(int front)
        {
            return Convert.ToDouble("0." + front.ToString());
        }

        private enum Side
        {
            Front = 0,
            Rear = 1
        }
    }
}
