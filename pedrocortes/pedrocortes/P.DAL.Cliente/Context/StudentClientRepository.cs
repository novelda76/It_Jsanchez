using Common.Lib.DAL.EFCore;
using Common.Lib.Infrastructure;
using P.BL.Infraestructure.Interfaces;
using P.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.DAL.Cliente.Context
{
    public class StudentClientRepository : ClientRepository<Student>, IStudentRepository
    {
        public static Dictionary<string, Student> StudentsByDni { get; set; } = new Dictionary<string, Student>();

        public override SaveResult<Student> Add(Student entity)
        {

            var output = base.Add(entity);

            if (output.IsSuccess)
            {
                StudentsByDni.Add(output.Entity.Dni, output.Entity);
            }

            return output;
        }

        public override SaveResult<Student> Update(Student entity)
        {
            var existingStudent = Find(entity.Id);

            var previousDni = existingStudent.Dni;

            var output = base.Update(entity);

            if (output.IsSuccess)
            {
                if (previousDni != output.Entity.Dni)
                {
                    StudentsByDni.Remove(previousDni);
                    StudentsByDni.Add(output.Entity.Dni, output.Entity);
                }
                else
                {
                    StudentsByDni[output.Entity.Dni] = output.Entity;
                }
            }

            return output;
        }

        public override SaveResult<Student> Delete(Student entity)
        {
            var output = base.Delete(entity);

            if (entity.Status == false)
            {
                output.IsSuccess = false;
                output.Validation.Errors.Add("Este alumno ya ha sido eliminado previamente.");
            }

            if (output.IsSuccess == true)
            {
                entity.Status = false;
                output.Entity = entity;
            }

            return output;
        }

        public override Student Find(Guid id)
        {
            return base.Find(id);
        }

        public Student GetStudentByDni(string dni)
        {
            if (StudentsByDni.ContainsKey(dni))
            {
                var studentForUpdate = StudentsByDni[dni];
                return studentForUpdate;
            }

            return null;
        }
    }
}
