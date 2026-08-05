using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymManagementSystemBLLayer.Common
{
    public class ValidationBll
    {
        public enum CommonValidationMessage
        {
            Valid,

            PriceRequired,
            PriceMustBeNumeric,
            PriceMustBeGreaterThanZero,

            DescriptionRequired,

            EmailRequired,
            InvalidEmail,

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

        // Validation Message
        public static string GetValidationMessage(CommonValidationMessage validationMessage)
        {
            switch (validationMessage)
            {
                case CommonValidationMessage.PriceRequired:
                    return "Price is required.";

                case CommonValidationMessage.PriceMustBeNumeric:
                    return "Price must contain only numbers.";

                case CommonValidationMessage.PriceMustBeGreaterThanZero:
                    return "Price must be greater than zero.";

                case CommonValidationMessage.DescriptionRequired:
                    return "Description cannot be empty.";

                case CommonValidationMessage.Valid:
                    return string.Empty;
                case CommonValidationMessage.EmailRequired:
                    return "Email is required.";

                case CommonValidationMessage.InvalidEmail:
                    return "Please enter a valid email address.";

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
