using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotorsService.Services
{
    public static class MyValidator
    {
        public static bool Validate<T>(T validationObject, out string errorMessage)
        {
            errorMessage = "";
            var context = new ValidationContext(validationObject);
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(validationObject, context, results, true))
            {
                foreach (var validationResult in results)
                {
                    errorMessage += $"{validationResult.ErrorMessage}\n";
                }
                return false;
            }
            else
                return true;
        }
    }
}
