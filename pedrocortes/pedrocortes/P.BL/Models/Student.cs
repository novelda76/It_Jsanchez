using Common.Lib.Core;
using Common.Lib.Infrastructure;
using P.BL.Infraestructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P.BL.Models
{
    public class Student : Entity
    {
        public string Dni { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; } = true;
        public int Chair { get; set; }

        /* Exams
        public List<Exam> Exams
        {
            get
            {
                return DbContext.Exams.Values.Where(e => e.Student.Id == this.Id).ToList();
            }
        }
        */

        /* AddSubjectToStudent
        public ValidationResult AddSubjectToStudent(string subject)
        {
            var subjectToAdd = DbContext.Subjects.Values.Single(s => s.Name == subject);

            var output = new ValidationResult
            {
                IsSuccess = true
            };

            if (DbContext.StudentBySubject[this.Dni].Any(e => e.Name == subjectToAdd.Name))
            {
                output.IsSuccess = false;
                output.Errors.Add("Ojo! El alumno ya está matriculado de esta asignatura!");
            }
            else
            {
                DbContext.AddSubjectToStudent(this.Dni, subjectToAdd);
            }


            return output;

        }
        */

        public override ValidationResult Validate()
        {
            var output = base.Validate();

            ValidateName(output);
            ValidateDni(output);
            ValidateChairNumber(output);

            return output;
        }
        
        public SaveResult<Student> Save()
        {
            var saveResult = base.Save<Student>();
            return saveResult;
        }

        public SaveResult<Student> Delete()
        {
            var saveResult = base.Delete<Student>();
            return saveResult;
        }

        public Student Clone()
        {
            return Clone<Student>();
        }

        public override T Clone<T>()
        {
            var output = base.Clone<T>() as Student;
            output.Name = this.Name;
            output.Dni = this.Dni;
            output.Chair = this.Chair;
            output.Status = this.Status;
            return output as T;
        }



        #region Domain validations

        public void ValidateName(ValidationResult output)
        {
            var vr = ValidateName(this.Name);

            if (!vr.IsSuccess)
            {
                output.IsSuccess = false;
                output.Errors.AddRange(vr.Errors);
            }

        }
        public void ValidateDni(ValidationResult output)
        {
            var vr = ValidateDni(this.Dni, this.Id);

            if (!vr.IsSuccess)
            {
                output.IsSuccess = false;
                output.Errors.AddRange(vr.Errors);
            }
        }
        public void ValidateChairNumber(ValidationResult output)
        {
            var vr = ValidateChair(this.Chair.ToString(), this.Id);

            if (!vr.IsSuccess)
            {
                output.IsSuccess = false;
                output.Errors.AddRange(vr.Errors);
            }
        }

        #endregion

        #region Static validations

        public static ValidationResult<string> ValidateDni(string dni, Guid currentId = default)
        {
            var output = new ValidationResult<string>
            {
                IsSuccess = true
            };

            if (string.IsNullOrEmpty(dni))
            {
                output.IsSuccess = false;
                output.Errors.Add("Ojo!! El dni del alumno no puede estar vacío.");
            }

            var repo = Entity.DepCon.Resolve<IStudentRepository>();

            if (currentId == default)
            {
                var currentStudentinRepo = repo.GetStudentByDni(dni);

                if (currentStudentinRepo != null)
                {
                    output.IsSuccess = false;
                    output.Errors.Add("Ojo!! Ya existe un alumno con este DNI en la lista!!");
                }

            }

            if (currentId != default)
            {
                var studentRepo = repo.Find(currentId);

                if (studentRepo == null)
                {
                    output.IsSuccess = false;
                    output.Errors.Add("Ojo!! El alumno no se encuentra en la base de datos.");
                }

            }

            if (output.IsSuccess == true)
                output.ValidatedResult = dni;

            return output;

        }

        public static ValidationResult<string> ValidateName(string name)
        {
            var output = new ValidationResult<string>
            {
                IsSuccess = true
            };

            if (string.IsNullOrEmpty(name))
            {
                output.IsSuccess = false;
                output.Errors.Add("Ojo!! El nombre del alumno no puede estar vacío.");
            }

            if (output.IsSuccess)
                output.ValidatedResult = name;

            return output;

        }

        public static ValidationResult<int> ValidateChair(string chairText, Guid currentId = default)
        {
            var output = new ValidationResult<int>
            {
                IsSuccess = true
            };

            if (String.IsNullOrEmpty(chairText))
            {
                output.IsSuccess = false;
                output.Errors.Add("Ojo!! El número de silla asignada no puede estar vacío.");
            }

            var chairNumber = 0;
            var isConversionOk = int.TryParse(chairText, out chairNumber);
            if (!isConversionOk)
            {
                output.IsSuccess = false;
                output.Errors.Add("Ojo!! El dato introducido no es un número correcto.");
            }

            if (isConversionOk)
            {
                var repo = Entity.DepCon.Resolve<IStudentRepository>();
                var studentInChair = repo.QueryAll().FirstOrDefault(s => s.Chair == chairNumber);

                if (studentInChair != default && studentInChair.Id != currentId)
                {
                    output.IsSuccess = false;
                    output.Errors.Add("Ojo!! Esta silla se encuentra ocupada por otro alumno.");
                }

            }

            if (output.IsSuccess)
                output.ValidatedResult = chairNumber;

            return output;

        }

        #endregion

    }
}
