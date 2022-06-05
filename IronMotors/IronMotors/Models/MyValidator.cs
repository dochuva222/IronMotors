using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronMotors.Models
{
    //метод для проверки валидности объекты, он сравнивает введенные данные и условия которые записаны в метадате, если объект не валиден, то он записывает все ошибки в dishValidationResults после чего все ошибки записываются циклом в errorMessage, и если объект валидный, возращается true, иначе false
    //тип T означает что можно использовать разные типы данных, т.е. метод универсальный
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
