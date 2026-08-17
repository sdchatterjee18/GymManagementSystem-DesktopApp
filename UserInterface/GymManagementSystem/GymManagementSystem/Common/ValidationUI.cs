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
                        textBox.BackColor = Color.FromArgb(255, 240, 240);
                    }
                    else
                    {
                        textBox.BackColor = Color.White;
                    }
                }
            }

            return isValid;
        }
        public static int ClearTextBoxWhenClicked(TextBox textBox,int count)
        {
            textBox.BackColor = Color.White;
            if (count == 0)
            {
                textBox.Clear();
                count++;
                return count;
            }
            return 1;
        }
        public static bool ValidateRadioButtonSelection(params RadioButton[] radioButtons)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return true;
                }
            }

            MessageBox.Show("Please Choose Locker Needed or not!",
                            "Validation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

            return false;
        }
        public static bool ValidateRequiredComboBoxes(params ComboBox[] comboBoxes)
        {
            bool isValid = true;

            foreach (ComboBox comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex == -1)
                {
                    comboBox.BackColor = Color.FromArgb(255, 240, 240);
                    isValid = false;
                }
                else
                {
                    comboBox.BackColor = Color.White;
                }
            }

            if (!isValid)
            {
                MessageBox.Show("Please select all required options.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            return isValid;
        }
        public static void ClearDefaultPlaceholderText(TextBox textBox, int clickCount)
        {
            if (clickCount == 0)
            {
                textBox.Clear();
            }
        }
        public static bool ValidateGenderRadioButtonSelection(params RadioButton[] radioButtons)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return true;
                }
            }

            MessageBox.Show(
                "Please choose a gender.",
                "Validation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }
    }
}
