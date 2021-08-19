using System;
using System.Windows.Forms;

namespace ForzaHorizon4Helper
{
    public static class Calculator
    {
        public static double? Calculate(ComboBox comboBox, double min, double max, double front)
        {
            switch(comboBox.Items.IndexOf(comboBox.SelectedItem))
            {
                case (int)Side.Front:
                    return CalculateFrontWeight(min, max, front);
                case (int)Side.Rear:
                    return CalculateRearWeight(min, max, front);
                default:
                    MessageBox.Show("Selected type doesn't exist!", "Error occurred!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            return null;
        }

        private static double CalculateFrontWeight(double min, double max, double front)
        {
            return Math.Round((max - min) * front / 100 + min, 3);
        }

        private static double CalculateRearWeight(double min, double max, double front)
        {
            return Math.Round((max - min) * (100 - front) / 100 + min, 3);
        }

        private enum Side
        {
            Front = 0,
            Rear = 1
        }
    }
}
