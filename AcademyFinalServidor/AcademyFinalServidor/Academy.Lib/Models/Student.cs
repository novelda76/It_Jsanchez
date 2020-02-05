using Academy.Lib.Repositories;
using Common.Lib.Core;
using Common.Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Academy.Lib.Models
{
    public class Student: Entity
    {
        public string Name { get; set; }

        public string Dni { get; set; }

        public int ChairNumber { get; set; }

        public string Email { get; set; }

        public Student()
        {

        }


        public Student(string name, string dni, int chairNumber)
        {
            Name = name;
            Dni = dni;
            ChairNumber = chairNumber;

        }


        public override string ToString()
        {
            return (Name + "     "+ Dni + "    " + ChairNumber).ToString();

        }


        #region Static Validations

        public static ValidationResult<string> ValidateDni(string dni, Guid currentId = default)
        {
            var output = new ValidationResult<string>()
            {
                IsSuccess = true
            };

            if (string.IsNullOrEmpty(dni))
            {
                output.IsSuccess = false;
                output.Errors.Add("el dni delalumno no puede estar vacío");
            }

            #region check duplication


            var repo = DepCon.Resolve<IStudentRepository>();
            var entityWithDni = repo.FindByDni(dni);
           
            //var repo = new Repository<Student>();
            //var entityWithDni = repo.QueryAll().FirstOrDefault(x => x.Dni == dni);

            //var repo = new StudentRepository();
            //var entityWithDni = repo.GetStudentByDni(dni);

            if (entityWithDni != null)
            {
                if (currentId == default && entityWithDni != null)
                {
                    // on create
                    output.IsSuccess = false;
                    output.Errors.Add("ya existe un alumno con ese dni");
                }
                else if (currentId != default && entityWithDni.Id != currentId)
                {
                    // on update
                    output.IsSuccess = false;
                    output.Errors.Add("ya existe un alumno con ese dni");
                }
            }

            #endregion

            if (output.IsSuccess)
                output.ValidatedResult = dni;
            return output;
        }

        public static ValidationResult<int> ValidateChairNumber(string chairNumberText, Guid currentId = default)
        {
            var output = new ValidationResult<int>()
            {
                IsSuccess = true
            };

            #region check null or empty
            if (string.IsNullOrEmpty(chairNumberText))
            {
                output.IsSuccess = false;
                output.Errors.Add("el número de la silla no puede estar vacío o nulo");
            }
            #endregion

            #region check format conversion

            var chairNumber = 0;
            var isConversionOk = false;

            isConversionOk = int.TryParse(chairNumberText, out chairNumber);

            if (!isConversionOk)
            {
                output.IsSuccess = false;
                output.Errors.Add($"no se puede convertir {chairNumber} en número");
            }

            #endregion

            #region check if the char is already in use
          
            var repoStudents = DepCon.Resolve<IStudentRepository>();
            var currentStudentInChair = repoStudents.QueryAll().FirstOrDefault(s => s.ChairNumber == chairNumber);

            if (currentStudentInChair != null && isConversionOk)
            {

                if (currentStudentInChair != null && currentId == default)
                {
                    output.IsSuccess = false;
                    output.Errors.Add($"ya hay un alumno {currentStudentInChair.Name} en la silla {chairNumber}");
                }
                else if (currentId != default && currentStudentInChair.Id != currentId)
                {
                    // on update
                    output.IsSuccess = false;
                    output.Errors.Add("ya existe un alumno con ese dni");
                }
            }

            #endregion

            if (output.IsSuccess)
                output.ValidatedResult = chairNumber;

            return output;

        }
        public static ValidationResult<string> ValidateName(string name)
        {
            var output = new ValidationResult<string>()
            {
                IsSuccess = true
            };

            if (string.IsNullOrEmpty(name))
            {
                output.IsSuccess = false;
                output.Errors.Add("el nombre delalumno no puede estar vacío");
            }

            if (output.IsSuccess)
                output.ValidatedResult = name;

            return output;
        }

        #endregion

       

        //public List<Exam> Exams
        //{
        //    get
        //    {

        //        var reporExams = DepCon.Resolve<StudentExam>();


        //        return reporExams.QueryAll().Where(e => e.student.Id == this.Id).ToList();

        //        //return DbContext.Exams.Values.Where(e => e.student.Id == this.Id).ToList();

        //    }
        //}

        public Guid Guid { get; private set; }

        #region Domain Validations

        public void ValidateName(ValidationResult validationResult)
        {
            var validateNameResult = ValidateName(this.Name);
            if (!validateNameResult.IsSuccess)
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.AddRange(validateNameResult.Errors);
            }
        }

        public void ValidateDni(ValidationResult validationResult)
        {
            var vr = ValidateDni(this.Dni, this.Id);

            if (!vr.IsSuccess)
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.AddRange(vr.Errors);
            }
        }

        public void ValidateChairNumber(ValidationResult validationResult)
        {
            var vr = ValidateChairNumber(this.ChairNumber.ToString(), this.Id);

            if (!vr.IsSuccess)
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.AddRange(vr.Errors);
            }
        }

        #endregion

        public SaveResult<Student> Save()
        {
            var saveResult = base.Save<Student>();
            return saveResult;
        }


        public DeleteResult<Student> Delete()
        {
            var deleteResult = base.Delete<Student>();
            return deleteResult;
        }


        public override ValidationResult Validate()
        {
            var output = base.Validate();

            // cambiar ValidateName para que sea igual que ValidateDni
            ValidateName(output);
            ValidateDni(output);
            ValidateChairNumber(output);

            return output;
        }

        public override T Clone<T>()
        {
            var output = base.Clone<T>() as Student;

            output.Name = this.Name;
            output.Dni = this.Dni;
            output.ChairNumber = this.ChairNumber;


            return output as T;
        }

        public Student Clone()
        {
            return Clone<Student>();
        }










    }
}
