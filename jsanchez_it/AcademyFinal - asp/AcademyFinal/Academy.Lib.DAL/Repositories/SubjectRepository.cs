using Academy.Lib.Models;
using Academy.Lib.Repositories;
using Common.Lib.DAL.EFCore;
using Common.Lib.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Lib.DAL.Repositories
{
    public class SubjectRepository : EfCoreRepository<Subject>, ISubjectsRepository
    {

        static Dictionary<string, Subject> SubjectByName { get; set; } = new Dictionary<string, Subject>();

        public SubjectRepository()
        {

        }

        public SubjectRepository(AcademyDbContext dbcontext)
          : base(dbcontext)
        {

        }
        public override SaveResult<Subject> Add(Subject entity)
        {
            var output = base.Add(entity);

            if (output.IsSuccess)
            {
                SubjectByName.Add(entity.Name, entity);
            }

            return output;
        }

        public override SaveResult<Subject> Update(Subject entity)
        {
            var output = base.Update(entity);

            if (output.IsSuccess)
            {
                SubjectByName[entity.Name] = entity;
            }

            return output;
        }

        public override DeleteResult<Subject> Delete(Subject entity)
        {
            var output = base.Delete(entity);

            if (output.IsSuccess)
            {
                SubjectByName.Remove(entity.Name);
            }

            return output;
        }



        public Subject GetSubjectByName(string name)
        {
            if (SubjectByName.ContainsKey(name))
                return SubjectByName[name];

            return null;
        }
    }
}
