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
        //ENUM FOR VALIDATION MESSEGE
        public enum ValidationResult
        {
            Valid,
            IsRequired
        }


        public static ValidationResult ValidateRequiredTextBox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                return ValidationResult.IsRequired;
            }

            return ValidationResult.Valid;
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

        public static ValidationResult ValidateRadioButtonSelection(
            params RadioButton[] radioButtons)
        {
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    return ValidationResult.Valid;
                }
            }

            return ValidationResult.IsRequired;
        }

        public static ValidationResult ValidateRequiredComboBox(ComboBox comboBox)
        {
            if (comboBox.SelectedIndex == -1)
            {
                return ValidationResult.IsRequired;
            }

            return ValidationResult.Valid;
        }
        public static void ClearDefaultPlaceholderText(TextBox textBox, int clickCount)
        {
            if (clickCount == 0)
            {
                textBox.Clear();
                clickCount++;
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
        public static string GetValidationMessage(ValidationResult result)
        {
            switch (result)
            {
                case ValidationResult.IsRequired:
                    return "is required.";

                case ValidationResult.Valid:
                    return "";

                default:
                    return "";
            }
        }
    }
}
