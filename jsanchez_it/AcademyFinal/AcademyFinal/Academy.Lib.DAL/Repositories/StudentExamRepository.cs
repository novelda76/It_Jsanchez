using Academy.Lib.Models;
using Common.Lib.DAL.EFCore;
using Academy.Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Lib.DAL.Repositories
{
    public class StudentExamRepository : EfCoreRepository<StudentExam>, IStudentsExamRepository
    {
        public StudentExamRepository()
        {

        }

        public StudentExamRepository(AcademyDbContext dbcontext)
          : base(dbcontext)
        {

        }
    }
}
