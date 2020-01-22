using Academy.Lib.Repositories;
using Common.Lib.Core;
using Common.Lib.Core.Context;
using Common.Lib.Infrastructure;
using System;
using System.Linq;

namespace Academy.Lib.Models
{
    public class Subject: Entity
    {
        public string Name { get; set; }
        public string Teacher { get; set; }
        public Guid Guid { get; private set; }


        public Subject()
        {

        }


        

        #region Static Validations

        public static ValidationResult<string> ValidateName(string name, Guid currentId = default)
        {
            var output = new ValidationResult<string>()
            {
                IsSuccess = true
            };

            if (string.IsNullOrEmpty(name))
            {
                output.IsSuccess = false;
                output.Errors.Add("el nombre de la asignatura no puede estar vacío");
            }

            #region check duplication


            var repo = DepCon.Resolve<ISubjectsRepository>();
            var entityWithName = repo.QueryAll().FirstOrDefault(x => x.Name == name);


            // Aqui llamariamos directamente a memoria:

            //var repo = DepCon.Resolve<IRepository<Subject>>();
            // var entityWithName = repo.QueryAll().FirstOrDefault(x => x.Name == name);


            //var repo = new StudentRepository();
            //var entityWithDni = repo.GetStudentByDni(dni);
            if (entityWithName != null)
            {
                if (currentId == default && entityWithName != null)
                {
                    // on create
                    output.IsSuccess = false;
                    output.Errors.Add("ya existe una asignatura con ese nombre");
                }
                else if (currentId != default && entityWithName.Id != currentId)
                {
                    // on update
                    output.IsSuccess = false;
                    output.Errors.Add("ya existe una asignatura con ese nombre");
                }
            }
            #endregion

            if (output.IsSuccess)
                output.ValidatedResult = name;
            return output;
        }

        #endregion


        #region Domain Validations

        public void ValidateName(ValidationResult validationResult)
        {
            var vr = ValidateName(this.Name, this.Id);

            if (!vr.IsSuccess)
            {
                validationResult.IsSuccess = false;
                validationResult.Errors.AddRange(vr.Errors);
            }
        }

        #endregion

        public override ValidationResult Validate()
        {
            var validationResult = base.Validate();

            ValidateName(validationResult);

            return validationResult;
        }

        public SaveResult<Subject> Save()
        {
            var saveResult = base.Save<Subject>();
            return saveResult;
        }


        public override T Clone<T>()
        {
            var output = base.Clone<T>() as Subject;

            output.Name = this.Name;

            return output as T;
        }

        public Subject Clone()
        {
            return Clone<Subject>();
        }

    }
}
