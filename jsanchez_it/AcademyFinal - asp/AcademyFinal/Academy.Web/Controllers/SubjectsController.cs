using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Academy.Lib.DAL;
using Academy.Lib.Models;
using Academy.Lib.Repositories;
using Common.Lib.Core;
using Academy.Lib.DAL.Repositories;
using Common.Lib.Infrastructure;

namespace Academy.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        //private readonly AcademyDbContext _context;

        public SubjectsController()
        {

        }

        // GET: api/Subjects
        [HttpGet]

        public async Task<IEnumerable<Subject>> GetSubjects()
        {
            var repo = Entity.DepCon.Resolve<SubjectRepository>();
            var SubjectsList = await repo.QueryAll().ToListAsync();
            return repo.QueryAll();

        }

        

        // GET: api/Subjects/5
        [HttpGet("{id}")]

        public async Task<ActionResult<Subject>> GetSubject(Guid id)
        {
            return await Task.Run(() =>
            {
                var repo = Entity.DepCon.Resolve<ISubjectsRepository>();
                var subject = repo.QueryAll().FirstOrDefault(x => x.Id == id);

                if (subject == null)
                {

                    return null;
                }

                return subject;

            });
        }

        // PUT: api/Subjects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]

        public async Task<ActionResult<SaveResult<Subject>>> PutSubject(Subject subject)
        {
            return await Task.Run(() =>
            {
                var sr = subject.Save();
                return sr;
            });
        }
        

        // POST: api/Subjects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]

        public async Task<ActionResult<SaveResult<Subject>>> PostSubject(Subject subject)
        {
            return await Task.Run(() =>
            {
                var sr = subject.Save();
                return sr;
            });
        }
        

        // DELETE: api/Subjects/5
        [HttpDelete("{id}")]

        public async Task<ActionResult<DeleteResult<Subject>>> DeleteSubject(Guid id)
        {
            return await Task.Run(() =>
            {
                var repo = Entity.DepCon.Resolve<ISubjectsRepository>();
                var subject = repo.QueryAll().FirstOrDefault(x => x.Id == id);
                var ds = subject.Delete();

                return ds;
            });
        }

        private bool SubjectExists(Guid id)
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            var existingSubject = repo.QueryAll().Any(e => e.Id == id);
            return existingSubject;
        }
       
    }
}
