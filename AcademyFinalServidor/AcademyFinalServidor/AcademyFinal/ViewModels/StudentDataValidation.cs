using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace AcademyFinal.App.WPF.Views
{
    public class StudentDataValidation : ValidationRule
    {

        public int MinimunCharacters { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string charString = value as string;

            if (charString.Length < MinimunCharacters)
                return new ValidationResult(false, $"User al least { MinimunCharacters } Characters");

            return new ValidationResult(true, null);


        }
    }
}
