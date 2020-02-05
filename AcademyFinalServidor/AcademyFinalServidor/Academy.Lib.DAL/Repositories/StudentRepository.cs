using Academy.Lib.Models;
using Academy.Lib.Repositories;
using Common.Lib.Core;
using Common.Lib.DAL.EFCore;
using Common.Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Lib.DAL.Repositories
{
    public class StudentRepository : EfCoreRepository<Student>, IStudentRepository
    {

        static Dictionary<string, Student> StudentsByDni { get; set; } = new Dictionary<string, Student>();

        public StudentRepository()
        {

        }

        public StudentRepository(AcademyDbContext dbcontext)
          : base(dbcontext)
        {

        }
        public override SaveResult<Student> Add(Student entity)
        {
            var output = base.Add(entity);

            if (output.IsSuccess)
            {
                StudentsByDni.Add(entity.Dni, entity);
            }

            return output;
        }

        public override SaveResult<Student> Update(Student entity)
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            var original = repo.Find(entity.Id);

            var output = base.Update(entity);

            if (output.IsSuccess)
            {
                if (original.Dni != entity.Dni)
                {
                    if (StudentsByDni.ContainsKey(original.Dni))
                        StudentsByDni.Remove(original.Dni);

                    StudentsByDni.Add(entity.Dni, entity);
                }
                else
                {
                    if (StudentsByDni.ContainsKey(entity.Dni))
                        StudentsByDni[entity.Dni] = entity;
                    else

                        StudentsByDni.Add(entity.Dni, entity);
                }
            }

            return output;
        }

        public override DeleteResult<Student> Delete(Student entity)
        {
            var output = base.Delete(entity);

            if (output.IsSuccess)
            {
                StudentsByDni.Remove(entity.Dni);
            }

            return output;
        }



        public Student FindByDni(string dni)
        {
            if (StudentsByDni.ContainsKey(dni))
                return StudentsByDni[dni];

            return null;
        }
    }
}
