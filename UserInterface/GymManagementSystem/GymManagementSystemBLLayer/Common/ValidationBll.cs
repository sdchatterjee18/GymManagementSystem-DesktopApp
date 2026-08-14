using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GymManagementSystemBLLayer.Common
{
    public class ValidationBll
    {
        public enum CommonValidationMessage
        {
            Valid,

            // =========================
            // Text Validation
            // =========================
            TextRequired,
            TextMustContainOnlyLetters,
            UserNameRequired,
            PasswordRequired,

            // =========================
            // Membership Plan Validation
            // =========================
            MembershipPlanNameRequired,
            AnyNameMustContainOnlyLetters,

            // =========================
            // Price Validation
            // =========================
            PriceRequired,
            PriceMustBeNumeric,
            PriceMustBeGreaterThanZero,

            // =========================
            // Description Validation
            // =========================
            DescriptionRequired,

            // =========================
            // Email Validation
            // =========================
            EmailRequired,
            InvalidEmail,

            // =========================
            // Duration Validation
            // =========================
            DurationRequired,
            DurationMustBeNumeric,
            DurationMustBeGreaterThanZero,
            InvalidDurationLength,
            DurationMustBeLessThan365Days,

            // =========================
            // Phone Validation
            // =========================
            PhoneNumberRequired,
            PhoneNumberMustBeNumeric,
            PhoneNumberMustBePositive,
            InvalidPhoneNumberLength,

            // =========================
            // Diet Plan - Calories Validation
            // =========================
            CaloriesMustBeGreaterThanZero,

            // =========================
            // Diet Plan - Condition Status Validation
            // =========================
            ConditionStatusRequired,
            ConditionStatusMustContainOnlyLetters,
            ConditionStatusTooShort,
            // =========================
            // Fitness Test Validation
            // =========================
            HeightRequired,
            HeightMustBeNumeric,
            HeightMustBeGreaterThanZero,

            WeightRequired,
            WeightMustBeNumeric,
            WeightMustBeGreaterThanZero,
            AgeRequired,
            AgeMustBeNumeric,
            AgeMustBeGreaterThanZero,
        }


        // =========================
        // Price Validation
        // =========================
        public static CommonValidationMessage ValidatePrice(string price)
        {
            if (string.IsNullOrWhiteSpace(price))
                return CommonValidationMessage.PriceRequired;

            decimal priceValue;

            if (!decimal.TryParse(price, out priceValue))
                return CommonValidationMessage.PriceMustBeNumeric;

            if (priceValue <= 0)
                return CommonValidationMessage.PriceMustBeGreaterThanZero;

            return CommonValidationMessage.Valid;
        }




        // =========================
        // Description Validation
        // =========================
        public static CommonValidationMessage ValidateDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return CommonValidationMessage.DescriptionRequired;

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Email Validation
        // =========================
        public static CommonValidationMessage ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return CommonValidationMessage.EmailRequired;

            if (!email.Contains("@") || !email.Contains("."))
                return CommonValidationMessage.InvalidEmail;

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Phone Number Validation
        // =========================
        public static CommonValidationMessage ValidatePhoneNumber(string phoneNumber)
        {
            // Check negative number
            if (phoneNumber.StartsWith("-"))
                return CommonValidationMessage.PhoneNumberMustBePositive;
            // Check only digits
            foreach (char c in phoneNumber)
            {
                if (c < '0' || c > '9')
                    return CommonValidationMessage.PhoneNumberMustBeNumeric;
            }
            // Check length (Indian mobile number = 10 digits)
            if(phoneNumber != "")
            {
                if (phoneNumber.Length != 10)
                    return CommonValidationMessage.InvalidPhoneNumberLength;
            }

            return CommonValidationMessage.Valid;
        }
        // =========================
        // Required Text Validation
        // =========================
        public static CommonValidationMessage ValidateRequiredText(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return CommonValidationMessage.TextMustContainOnlyLetters;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Optional Text Validation
        // =========================
        public static CommonValidationMessage ValidateOptionalText(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return CommonValidationMessage.Valid;

            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return CommonValidationMessage.TextMustContainOnlyLetters;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Duration Validation
        // =========================
        public static CommonValidationMessage ValidateDuration(string duration)
        {
            if (string.IsNullOrWhiteSpace(duration))
                return CommonValidationMessage.DurationRequired;

            int durationValue;

            if (!int.TryParse(duration, out durationValue))
                return CommonValidationMessage.DurationMustBeNumeric;

            if (durationValue <= 0)
                return CommonValidationMessage.DurationMustBeGreaterThanZero;

            if (duration.Length > 3)
                return CommonValidationMessage.InvalidDurationLength;

            if (durationValue >= 365)
                return CommonValidationMessage.DurationMustBeLessThan365Days;

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Membership Plan Name Validation
        // =========================
        public static CommonValidationMessage ValidateName(string Name)
        {
            foreach (char ch in Name)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return CommonValidationMessage.AnyNameMustContainOnlyLetters;
                }
            }

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Calories Validation
        // =========================
        public static CommonValidationMessage ValidateCalories(int calories)
        {
            if (calories <= 0)
                return CommonValidationMessage.CaloriesMustBeGreaterThanZero;

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Condition Status Validation
        // =========================
        public static CommonValidationMessage ValidateConditionStatus(string conditionStatus)
        {
            if (string.IsNullOrWhiteSpace(conditionStatus))
                return CommonValidationMessage.ConditionStatusRequired;

            foreach (char ch in conditionStatus)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return CommonValidationMessage
                        .ConditionStatusMustContainOnlyLetters;
                }
            }

            if (conditionStatus.Trim().Length < 3)
                return CommonValidationMessage.ConditionStatusTooShort;

            return CommonValidationMessage.Valid;
        }
        // =========================
        // UserName Validation
        // =========================
        public static CommonValidationMessage ValidateUserName(string userName)
        {
            if (string.IsNullOrWhiteSpace(userName))
                return CommonValidationMessage.UserNameRequired;

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Password Validation
        // =========================
        public static CommonValidationMessage ValidatePassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return CommonValidationMessage.PasswordRequired;

            return CommonValidationMessage.Valid;
        }
        // =========================
        // Height Validation
        // =========================
        public static CommonValidationMessage ValidateHeight(string height)
        {
            if (string.IsNullOrWhiteSpace(height))
                return CommonValidationMessage.HeightRequired;

            decimal heightValue;

            if (!decimal.TryParse(height, out heightValue))
                return CommonValidationMessage.HeightMustBeNumeric;

            if (heightValue <= 0)
                return CommonValidationMessage.HeightMustBeGreaterThanZero;

            return CommonValidationMessage.Valid;
        }
        // =========================
        // Weight Validation
        // =========================
        public static CommonValidationMessage ValidateWeight(string weight)
        {
            if (string.IsNullOrWhiteSpace(weight))
                return CommonValidationMessage.WeightRequired;

            decimal weightValue;

            if (!decimal.TryParse(weight, out weightValue))
                return CommonValidationMessage.WeightMustBeNumeric;

            if (weightValue <= 0)
                return CommonValidationMessage.WeightMustBeGreaterThanZero;

            return CommonValidationMessage.Valid;
        }
        // =========================
        // Age Validation
        // =========================
        public static CommonValidationMessage ValidateAge(string age)
        {
            if (string.IsNullOrWhiteSpace(age))
                return CommonValidationMessage.AgeRequired;

            int ageValue;

            if (!int.TryParse(age, out ageValue))
                return CommonValidationMessage.AgeMustBeNumeric;

            if (ageValue <= 0)
                return CommonValidationMessage.AgeMustBeGreaterThanZero;

            return CommonValidationMessage.Valid;
        }


        // =========================
        // Validation Message
        // =========================
        public static string GetValidationMessage(CommonValidationMessage validationMessage)
        {
            switch (validationMessage)
            {
                case CommonValidationMessage.Valid:
                    return string.Empty;


                // =========================
                // Text Validation
                // =========================
                case CommonValidationMessage.TextRequired:
                    return "This field is required.";

                case CommonValidationMessage.TextMustContainOnlyLetters:
                    return "This field must contain only letters.";


                // =========================
                // Membership Plan Name Validation
                // =========================
                case CommonValidationMessage.MembershipPlanNameRequired:
                    return "Membership Plan Name is required.";

                case CommonValidationMessage.AnyNameMustContainOnlyLetters:
                    return "Any Name can contain only letters";


                // =========================
                // Price Validation
                // =========================
                case CommonValidationMessage.PriceRequired:
                    return "Price is required.";

                case CommonValidationMessage.PriceMustBeNumeric:
                    return "Price must contain only numbers.";

                case CommonValidationMessage.PriceMustBeGreaterThanZero:
                    return "Price must be greater than zero.";


                // =========================
                // Description Validation
                // =========================
                case CommonValidationMessage.DescriptionRequired:
                    return "Description cannot be empty.";


                // =========================
                // Email Validation
                // =========================
                case CommonValidationMessage.EmailRequired:
                    return "Email is required.";

                case CommonValidationMessage.InvalidEmail:
                    return "Please enter a valid email address.";


                // =========================
                // Duration Validation
                // =========================
                case CommonValidationMessage.DurationRequired:
                    return "Duration is required.";

                case CommonValidationMessage.DurationMustBeNumeric:
                    return "Duration must contain only numbers.";

                case CommonValidationMessage.DurationMustBeGreaterThanZero:
                    return "Duration must be greater than zero.";

                case CommonValidationMessage.InvalidDurationLength:
                    return "Duration must contain 1 to 3 digits.";

                case CommonValidationMessage.DurationMustBeLessThan365Days:
                    return "Duration must be less than 365 days.";


                // =========================
                // Phone Number Validation
                // =========================
                case CommonValidationMessage.PhoneNumberRequired:
                    return "Phone number is required.";

                case CommonValidationMessage.PhoneNumberMustBeNumeric:
                    return "Phone number must contain only numbers.";

                case CommonValidationMessage.PhoneNumberMustBePositive:
                    return "Phone number cannot be negative.";

                case CommonValidationMessage.InvalidPhoneNumberLength:
                    return "Phone number must be exactly 10 digits.";


                // =========================
                // Diet Plan - Calories
                // =========================
                case CommonValidationMessage.CaloriesMustBeGreaterThanZero:
                    return "Calories Per Day must be greater than zero.";


                // =========================
                // Diet Plan - Condition Status
                // =========================
                case CommonValidationMessage.ConditionStatusRequired:
                    return "Condition Status is required.";

                case CommonValidationMessage.ConditionStatusMustContainOnlyLetters:
                    return "Condition Status must contain only letters.";

                case CommonValidationMessage.ConditionStatusTooShort:
                    return "Condition Status is too short.";

                // =========================
                // UserName Validation
                // =========================
                case CommonValidationMessage.UserNameRequired:
                    return "Username is required.";

                case CommonValidationMessage.PasswordRequired:
                    return "Password is required.";

                // =========================
                // Fitness Test Validation
                // =========================

                case CommonValidationMessage.HeightRequired:
                    return "Height is required.";

                case CommonValidationMessage.HeightMustBeNumeric:
                    return "Height must contain only numbers.";

                case CommonValidationMessage.HeightMustBeGreaterThanZero:
                    return "Height must be greater than zero.";


                case CommonValidationMessage.WeightRequired:
                    return "Weight is required.";

                case CommonValidationMessage.WeightMustBeNumeric:
                    return "Weight must contain only numbers.";

                case CommonValidationMessage.WeightMustBeGreaterThanZero:
                    return "Weight must be greater than zero.";


                case CommonValidationMessage.AgeRequired:
                    return "Age is required.";

                case CommonValidationMessage.AgeMustBeNumeric:
                    return "Age must contain only numbers.";

                case CommonValidationMessage.AgeMustBeGreaterThanZero:
                    return "Age must be greater than zero.";


                default:
                    return "Invalid data.";
            }
        }
    }
}