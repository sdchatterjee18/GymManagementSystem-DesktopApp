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

            DescriptionRequired
        }

        // Price Validation
        public CommonValidationMessage ValidatePrice(string price)
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
        public CommonValidationMessage ValidateDescription(string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return CommonValidationMessage.DescriptionRequired;

            return CommonValidationMessage.Valid;
        }

        // Validation Message
        public string GetValidationMessage(CommonValidationMessage validationMessage)
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

                default:
                    return "Invalid data.";
            }
        }
    }

}
