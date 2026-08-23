using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GymManagementSystemBLLayer.Common
{
    public class ValidationResult
    {
        public string FieldName { get; set; }

        public ValidationBll.CommonValidationMessage Result { get; set; }

        public string Message { get; set; }
    }
}
