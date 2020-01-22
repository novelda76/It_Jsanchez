using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace AcademyFinal.App.WPF.AppValidations
{
    public class StudentValidation : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string studentName = value as string;

            if (string.IsNullOrEmpty(studentName))
                return new ValidationResult(false, "$el nombre del alumno no puede estar vacío, mensaje desde StudentValidation");
            return new ValidationResult(true, null);
        }

    }
}
