using System;
using System.Windows.Forms;

namespace ForzaHorizon4Helper
{
    public static class Calculator
    {
        private static int _front { get; set; }

        public static void Calculate(TextBox textbox, ComboBox comboBox, double min, double max, string front)
        {
            if (comboBox.SelectedItem.ToString() == comboBox.Items[0].ToString())
            {
                CalculateFrontWeight(textbox, min, max, front);
            }
            else if (comboBox.SelectedItem.ToString() == comboBox.Items[1].ToString())
            {
                CalculateRearWeight(textbox, min, max, front);
            }
            else
            {
                MessageBox.Show("Selected type doesn't exist!", "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void CalculateFrontWeight(TextBox textbox, double min, double max, string front)
        {
            _front = ToInt32(front);

            textbox.Text = _front != -1 ? Math.Round((max - min) * Format(_front) + min, 3).ToString() : "";
        }

        private static void CalculateRearWeight(TextBox textbox, double min, double max, string front)
        {
            _front = ToInt32(front);

            textbox.Text = _front != -1 ? Math.Round((max - min) * Format(100 - _front) + min, 3).ToString() : "";
        }

        private static int ToInt32(string value)
        {
            int number;
            if (!Int32.TryParse(value, out number))
            {
                MessageBox.Show("Please enter an integer value!", "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            return number;
        }

        private static double Format(int front)
        {
            return Convert.ToDouble("0." + front.ToString());
        }
    }
}
