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

            // Text Validation
            TextRequired,
            TextMustContainOnlyLetters,

            // Membership Plan Validation
            MembershipPlanNameRequired,
            MembershipPlanNameMustContainOnlyLettersAndNumbers,

            // Price Validation
            PriceRequired,
            PriceMustBeNumeric,
            PriceMustBeGreaterThanZero,

            // Description Validation
            DescriptionRequired,

            // Email Validation
            EmailRequired,
            InvalidEmail,

            // Duration Validation
            DurationRequired,
            DurationMustBeNumeric,
            DurationMustBeGreaterThanZero,
            InvalidDurationLength,
            DurationMustBeLessThan365Days,

            // Phone Validation
            PhoneNumberRequired,
            PhoneNumberMustBeNumeric,
            PhoneNumberMustBePositive,
            InvalidPhoneNumberLength
        }

        // Price Validation
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

        // Description Validation
        public static CommonValidationMessage ValidateDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return CommonValidationMessage.DescriptionRequired;

            return CommonValidationMessage.Valid;
        }

        // Email Validation
        public static CommonValidationMessage ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return CommonValidationMessage.EmailRequired;

            if (!email.Contains("@") || !email.Contains("."))
                return CommonValidationMessage.InvalidEmail;

            return CommonValidationMessage.Valid;
        }

        // Phone Number Validation
        public static CommonValidationMessage ValidatePhoneNumber(string phoneNumber)
        {
            // Check empty
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return CommonValidationMessage.PhoneNumberRequired;


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
            if (phoneNumber.Length != 10)
                return CommonValidationMessage.InvalidPhoneNumberLength;


            return CommonValidationMessage.Valid;
        }

        // Required Text Validation
        public static CommonValidationMessage ValidateRequiredText(string text)
        {
            foreach (char c in text)
            {
                if (!char.IsLetter(c) && c != ' ')
                    return CommonValidationMessage.TextMustContainOnlyLetters;
            }

            return CommonValidationMessage.Valid;
        }


        // Optional Text Validation (Middle Name)
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

        //Duration Days Valitation
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

       
        // Membership Plan Name Validation
        public static CommonValidationMessage ValidateMembershipPlanName(string membershipPlanName)
        {
            // Only letters, numbers and spaces are allowed
            if (!Regex.IsMatch(membershipPlanName.Trim(), @"^[A-Za-z0-9 ]+$"))
                return CommonValidationMessage.MembershipPlanNameMustContainOnlyLettersAndNumbers;

            return CommonValidationMessage.Valid;
        }

        // Validation Message
        public static string GetValidationMessage(CommonValidationMessage validationMessage)
        {
            switch (validationMessage)
            {
                case CommonValidationMessage.Valid:
                    return string.Empty;

                // Text Validation
                case CommonValidationMessage.TextRequired:
                    return "This field is required.";

                case CommonValidationMessage.TextMustContainOnlyLetters:
                    return "This field must contain only letters.";

                // Membership Plan Name Validation
                case CommonValidationMessage.MembershipPlanNameRequired:
                    return "Membership Plan Name is required.";

                case CommonValidationMessage.MembershipPlanNameMustContainOnlyLettersAndNumbers:
                    return "Membership Plan Name can contain only letters, numbers and spaces.";

                // Price Validation
                case CommonValidationMessage.PriceRequired:
                    return "Price is required.";

                case CommonValidationMessage.PriceMustBeNumeric:
                    return "Price must contain only numbers.";

                case CommonValidationMessage.PriceMustBeGreaterThanZero:
                    return "Price must be greater than zero.";

                // Description Validation
                case CommonValidationMessage.DescriptionRequired:
                    return "Description cannot be empty.";

                // Email Validation
                case CommonValidationMessage.EmailRequired:
                    return "Email is required.";

                case CommonValidationMessage.InvalidEmail:
                    return "Please enter a valid email address.";

                // Duration Validation
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

                // Phone Number Validation
                case CommonValidationMessage.PhoneNumberRequired:
                    return "Phone number is required.";

                case CommonValidationMessage.PhoneNumberMustBeNumeric:
                    return "Phone number must contain only numbers.";

                case CommonValidationMessage.PhoneNumberMustBePositive:
                    return "Phone number cannot be negative.";

                case CommonValidationMessage.InvalidPhoneNumberLength:
                    return "Phone number must be exactly 10 digits.";

                default:
                    return "Invalid data.";
            }
        }
    }

}
