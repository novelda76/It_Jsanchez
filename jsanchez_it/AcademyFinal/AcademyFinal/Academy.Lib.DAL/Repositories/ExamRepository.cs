using Academy.Lib.Models;
using Academy.Lib.Repositories;
using Common.Lib.DAL.EFCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Lib.DAL.Repositories
{
    public class ExamRepository : EfCoreRepository<Exam>, IExamsRepository
    {
        public ExamRepository()
        {
                
        }

        public ExamRepository(AcademyDbContext dbcontext)
          : base(dbcontext)
        {

        }
    }
}
