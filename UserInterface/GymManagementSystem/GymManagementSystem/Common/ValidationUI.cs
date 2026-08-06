using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace GymManagementSystem.Common
{
    public class ValidationUI
    {
        public static bool ValidateRequiredTextBoxes(params TextBox[] textBoxes)
        {
            bool isValid = true;

            foreach (TextBox textBox in textBoxes)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    isValid = false;
                }
            }
            if (!isValid)
            {
                DialogResult result = MessageBox.Show(
                    "Please fill in all the required fields.",
                    "Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                foreach (TextBox textBox in textBoxes)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.BackColor = Color.FromArgb(255, 240, 240); // Light red
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
            }

            return isValid;
        }
        public static int ClearTextBox(TextBox textBox,int count)
        {
            if (count == 0)
            {
                textBox.Clear();
                count++;
                return count;
            }
            return 1;
        }
    }
}
