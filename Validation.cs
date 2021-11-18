using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Chindris_Alexandru_Lab5
{
    //validator pentru camp required
    public class StringNotEmpty : ValidationRule
    {
        //mostenim din clasa ValidationRule
        //suprascriem metoda Validate ce returneaza un ValidationResult
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString == "")
                return new ValidationResult(false, "String cannot be empty");
            return new ValidationResult(true, null);
        }
    }
    //validator pentru lungime minima a string-ului
    public class StringMinLength : ValidationRule
    {
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length < 3)
                return new ValidationResult(false, "String must have at least 3 characters!");
        return new ValidationResult(true, null);
        }
    }
    public class StringNoDigits : ValidationRule
    {
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Any(char.IsDigit))
                return new ValidationResult(false, "String must not contain digits!");
            return new ValidationResult(true, null);
        }
    }
    public class StringMaxLength : ValidationRule
    {
        public override ValidationResult Validate(object value,
        System.Globalization.CultureInfo cultureinfo)
        {
            string aString = value.ToString();
            if (aString.Length > 25)
                return new ValidationResult(false, "String must have at most 25 characters!");
            return new ValidationResult(true, null);
        }
    }

}
