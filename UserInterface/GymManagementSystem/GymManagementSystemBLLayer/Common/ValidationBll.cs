using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace GymManagementSystemBLLayer.Common
{
    public class ValidationBll
    {

        // =========================================================
        // VALIDATION ENUM
        // =========================================================
        public enum CommonValidationMessage
        {
            Valid,

            // =========================
            // General Text
            // =========================
            TextRequired,
            TextMustContainOnlyLetters,
            TextMustContainOnlyLettersAndNumbers,
            TextMustNotContainWhiteSpace,

            // =========================
            // Name
            // =========================
            NameMustContainOnlyLetters,

            // =========================
            // Email
            // =========================
            InvalidEmail,
            EmailMustContainOnlyLowercaseLetters,

            // =========================
            // Phone Number
            // =========================
            PhoneNumberMustBeNumeric,
            PhoneNumberMustBePositive,
            InvalidPhoneNumberLength,

            // =========================
            // Price
            // =========================
            PriceMustBeNumeric,
            PriceMustBeGreaterThanZero,

            // =========================
            // Duration
            // =========================
            DurationMustBeNumeric,
            DurationMustBeGreaterThanZero,
            InvalidDurationLength,
            DurationMustBeLessThan365Days,

            // =========================
            // Calories
            // =========================
            CaloriesMustBeNumeric,
            CaloriesMustBeGreaterThanZero,

            // =========================
            // Username
            // =========================
            InvalidUserName,

            // =========================
            // Password
            // =========================
            InvalidPassword,

            // =========================
            // Condition Status
            // =========================
            ConditionStatusMustContainOnlyLetters,
            ConditionStatusTooShort,

            // =========================
            // Membership Plan
            // =========================
            MembershipPlanNameMustContainOnlyLetters,

            // =========================
            // General Numeric
            // =========================
            NumberMustBeNumeric,
            NumberMustBeGreaterThanZero,

            LockerNumberMustContainOnlyLettersAndNumbers,
            TextMustContainOnlyLettersAndSpaces,

            // =========================
            // Date Of Birth
            // =========================
            DateOfBirthCannotBeFuture,
            EmployeeMustBeAtLeast18YearsOld,
            InvalidDateOfBirth,
        }


        // =========================================================
        // NAME VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidateName(string name)
        {
            foreach (char ch in name)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return CommonValidationMessage.NameMustContainOnlyLetters;
                }
            }

            return CommonValidationMessage.Valid;
        }
        // =========================================================
        // LettersAndSpaces VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidateOnlyLettersAndSpaces(string text)
        {
            foreach (char ch in text)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return CommonValidationMessage.TextMustContainOnlyLettersAndSpaces;
                }
            }

            return CommonValidationMessage.Valid;
        }
        // =========================================================
        // GENERAL TEXT VALIDATION
        // Letters and spaces only
        // =========================================================
        public static CommonValidationMessage ValidateLettersOnly(string text)
        {
            foreach (char ch in text)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return CommonValidationMessage.TextMustContainOnlyLetters;
                }
            }

            return CommonValidationMessage.Valid;
        }

        public static CommonValidationMessage ValidateDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth > DateTime.Today)
            {
                return CommonValidationMessage.DateOfBirthCannotBeFuture;
            }
            else
            {
                int age = DateTime.Today.Year - dateOfBirth.Year;

                if (dateOfBirth.Date > DateTime.Today.AddYears(-age))
                {
                    age--;
                }

                if (age < 18)
                {
                    return CommonValidationMessage.EmployeeMustBeAtLeast18YearsOld;
                }
                else
                {
                    return CommonValidationMessage.Valid;
                }
            }
        }
        // =========================================================
        // LETTERS AND NUMBERS ONLY
        // =========================================================
        public static CommonValidationMessage ValidateLettersAndNumbersOnly(string text)
        {
            foreach (char ch in text)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return CommonValidationMessage
                        .TextMustContainOnlyLettersAndNumbers;
                }
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // NO WHITE SPACE
        // =========================================================
        public static CommonValidationMessage ValidateNoWhiteSpace(string text)
        {
            foreach (char ch in text)
            {
                if (char.IsWhiteSpace(ch))
                {
                    return CommonValidationMessage
                        .TextMustNotContainWhiteSpace;
                }
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // EMAIL VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidateEmail(string email)
        {
            // Check if email contains uppercase letters
            if (email != email.ToLower())
            {
            return CommonValidationMessage.EmailMustContainOnlyLowercaseLetters;
            }
            else
            {
                string pattern =@"^[^@\s]+@[^@\s]+.[^@\s]+$";

                if (!Regex.IsMatch(email, pattern))
                {
                    return CommonValidationMessage.InvalidEmail;
                }
                else
                {
                    return CommonValidationMessage.Valid;
                }
            }

        }



        // =========================================================
        // PHONE NUMBER VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidatePhoneNumber(
            string phoneNumber)
        {
            if (phoneNumber.StartsWith("-"))
            {
                return CommonValidationMessage.PhoneNumberMustBePositive;
            }

            foreach (char ch in phoneNumber)
            {
                if (!char.IsDigit(ch))
                {
                    return CommonValidationMessage.PhoneNumberMustBeNumeric;
                }
            }

            if (phoneNumber.Length != 10)
            {
                return CommonValidationMessage.InvalidPhoneNumberLength;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // PRICE VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidatePrice(decimal price)
        {
            if (price <= 0)
            {
                return CommonValidationMessage.PriceMustBeGreaterThanZero;
            }

            return CommonValidationMessage.Valid;
        }

        // =========================================================
        // DURATION VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidateDuration(int duration)
        {
            if (duration <= 0)
            {
                return CommonValidationMessage.DurationMustBeGreaterThanZero;
            }

            if (duration >= 365)
            {
                return CommonValidationMessage.DurationMustBeLessThan365Days;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // CALORIES VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidateCalories(string calories)
        {
            int caloriesValue;

            if (!int.TryParse(calories, out caloriesValue))
            {
                return CommonValidationMessage.CaloriesMustBeNumeric;
            }

            if (caloriesValue <= 0)
            {
                return CommonValidationMessage.CaloriesMustBeGreaterThanZero;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // USERNAME VALIDATION
        // Letters, numbers and underscore
        // =========================================================
        public static CommonValidationMessage ValidateUserName(string userName)
        {
            foreach (char ch in userName)
            {
                if (!char.IsLetterOrDigit(ch) && ch != '_')
                {
                    return CommonValidationMessage.InvalidUserName;
                }
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // PASSWORD VALIDATION
        // At least 8 characters
        // =========================================================
        public static CommonValidationMessage ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return CommonValidationMessage.InvalidPassword;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // CONDITION STATUS VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidateConditionStatus(string conditionStatus)
        {
            foreach (char ch in conditionStatus)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return CommonValidationMessage
                        .ConditionStatusMustContainOnlyLetters;
                }
            }

            if (conditionStatus.Trim().Length < 3)
            {
                return CommonValidationMessage.ConditionStatusTooShort;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // MEMBERSHIP PLAN NAME
        // =========================================================
        public static CommonValidationMessage ValidateMembershipPlanName(string name)
        {
            foreach (char ch in name)
            {
                if (!char.IsLetter(ch) && ch != ' ')
                {
                    return CommonValidationMessage
                        .MembershipPlanNameMustContainOnlyLetters;
                }
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // GENERAL NUMBER VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidateNumber(string number)
        {
            decimal value;

            if (!decimal.TryParse(number, out value))
            {
                return CommonValidationMessage.NumberMustBeNumeric;
            }

            return CommonValidationMessage.Valid;
        }


        // =========================================================
        // POSITIVE NUMBER VALIDATION
        // =========================================================
        public static CommonValidationMessage ValidatePositiveNumber( string number)
        {
            decimal value;

            if (!decimal.TryParse(number, out value))
            {
                return CommonValidationMessage.NumberMustBeNumeric;
            }

            if (value <= 0)
            {
                return CommonValidationMessage.NumberMustBeGreaterThanZero;
            }

            return CommonValidationMessage.Valid;
        }

        public static CommonValidationMessage ValidateLockerNumber(string lockerNumber)
        {
            foreach (char ch in lockerNumber)
            {
                if (!char.IsLetterOrDigit(ch))
                {
                    return CommonValidationMessage
                        .LockerNumberMustContainOnlyLettersAndNumbers;
                }
            }

            return CommonValidationMessage.Valid;
        }
        // =========================================================
        // GET VALIDATION MESSAGE
        // =========================================================
        public static string GetValidationMessage( CommonValidationMessage validationMessage)
        {
            switch (validationMessage)
            {
                case CommonValidationMessage.Valid:
                    return string.Empty;


                // =========================
                // General Text
                // =========================
                case CommonValidationMessage.TextRequired:
                    return "This field is required.";

                case CommonValidationMessage.TextMustContainOnlyLetters:
                    return "This field must contain only letters.";

                case CommonValidationMessage.TextMustContainOnlyLettersAndNumbers:
                    return "This field must contain only letters and numbers.";

                case CommonValidationMessage.TextMustNotContainWhiteSpace:
                    return "This field must not contain white spaces.";

                case CommonValidationMessage.LockerNumberMustContainOnlyLettersAndNumbers:
                    return "Locker Number must contain only letters and numbers.";
                // =========================
                // Name
                // =========================
                case CommonValidationMessage.NameMustContainOnlyLetters:
                    return "Name must contain only letters.";


                // =========================
                // Email
                // =========================
                case CommonValidationMessage.InvalidEmail:
                    return "Please enter a valid email address.";

                case CommonValidationMessage.EmailMustContainOnlyLowercaseLetters:
                    return "Email must contain only lowercase letters.";

                // =========================
                // Phone
                // =========================
                case CommonValidationMessage.PhoneNumberMustBeNumeric:
                    return "Phone number must contain only numbers.";

                case CommonValidationMessage.PhoneNumberMustBePositive:
                    return "Phone number cannot be negative.";

                case CommonValidationMessage.InvalidPhoneNumberLength:
                    return "Phone number must be exactly 10 digits.";


                // =========================
                // Price
                // =========================
                case CommonValidationMessage.PriceMustBeNumeric:
                    return "Amount must contain only numbers.";

                case CommonValidationMessage.PriceMustBeGreaterThanZero:
                    return "Amount must be greater than zero.";

                    case CommonValidationMessage.DateOfBirthCannotBeFuture:
                        return "Date of birth cannot be today or a future date.";

                    case CommonValidationMessage.EmployeeMustBeAtLeast18YearsOld:
                        return "Employee must be at least 18 years old.";
                // =========================
                // Duration
                // =========================
                case CommonValidationMessage.DurationMustBeNumeric:
                    return "Duration must contain only numbers.";

                case CommonValidationMessage.DurationMustBeGreaterThanZero:
                    return "Duration must be greater than zero.";

                case CommonValidationMessage.InvalidDurationLength:
                    return "Duration must contain 1 to 3 digits.";

                case CommonValidationMessage.DurationMustBeLessThan365Days:
                    return "Duration must be less than 365 days.";

                case CommonValidationMessage.TextMustContainOnlyLettersAndSpaces:
                    return "should contain only letters and spaces.";
                // =========================
                // Calories
                // =========================
                case CommonValidationMessage.CaloriesMustBeNumeric:
                    return "Calories must contain only numbers.";

                case CommonValidationMessage.CaloriesMustBeGreaterThanZero:
                    return "Calories must be greater than zero.";


                // =========================
                // Username
                // =========================
                case CommonValidationMessage.InvalidUserName:
                    return "Username can contain only letters, numbers and underscore.";


                // =========================
                // Password
                // =========================
                case CommonValidationMessage.InvalidPassword:
                    return "Password must contain at least 8 characters.";


                // =========================
                // Condition Status
                // =========================
                case CommonValidationMessage.ConditionStatusMustContainOnlyLetters:
                    return "Condition Status must contain only letters.";

                case CommonValidationMessage.ConditionStatusTooShort:
                    return "Condition Status must contain at least 3 characters.";


                // =========================
                // Membership Plan
                // =========================
                case CommonValidationMessage
                    .MembershipPlanNameMustContainOnlyLetters:

                    return "Membership Plan Name must contain only letters.";


                // =========================
                // General Number
                // =========================
                case CommonValidationMessage.NumberMustBeNumeric:
                    return "This field must contain only numbers.";

                case CommonValidationMessage.NumberMustBeGreaterThanZero:
                    return "Value must be greater than zero.";


                default:
                    return "Invalid data.";
            }
        }
    }
}
    
