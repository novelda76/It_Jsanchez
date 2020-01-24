using Common.Lib.Core;
using Common.Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.BL.Models
{
    public class Subject : Entity
    {
        public string Name { get; set; }

        public string TeacherName { get; set; }

        public override ValidationResult Validate()
        {
            var output = base.Validate();

            ValidateName(output);

            return output;
        }

        public SaveResult<Subject> Save()
        {
            var saveResult = base.Save<Subject>();
            return saveResult;
        }


        #region Domain Validations

        public void ValidateName(ValidationResult output)
        {
            var vr = ValidateName(this.Name);

            if (!vr.IsSuccess)
            {
                output.IsSuccess = false;
                output.Errors.AddRange(vr.Errors);
            }

        }

        #endregion

        #region Static Validations

        public static ValidationResult<string> ValidateName(string name)
        {
            var output = new ValidationResult<string>
            {
                IsSuccess = true
            };

            if (string.IsNullOrEmpty(name))
            {
                output.IsSuccess = false;
                output.Errors.Add("Ojo!! El nombre del profe no puede estar vacío.");
            }
            /*
            if (DbContext.Teachers.Values.Any(t => t.Name == name))
            {
                output.IsSuccess = false;
                output.Errors.Add($"Ojo!! Este profe ya está en nómina!");
            }
            */

            if (output.IsSuccess)
                output.ValidatedResult = name;

            return output;

        }

        #endregion

    }
}
