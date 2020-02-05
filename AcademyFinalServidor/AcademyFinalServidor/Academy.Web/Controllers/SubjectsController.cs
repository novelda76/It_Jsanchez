using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Academy.Lib.DAL;
using Academy.Lib.Models;
using Common.Lib.Core;
using Academy.Lib.Repositories;
using Common.Lib.Infrastructure;

namespace Academy.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
       

        // GET: api/Subjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subject>>> GetSubjects()
        {
            var repo = Entity.DepCon.Resolve<ISubjectsRepository>();
            var subjectList = await repo.QueryAll().ToListAsync();
            return subjectList;

        }

        // GET: api/Subjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Subject>> GetSubject(Guid id)
        {
            return await Task.Run(() =>
            {
                var repo = Entity.DepCon.Resolve<ISubjectsRepository>();
                var subject= repo.QueryAll().FirstOrDefault(x => x.Id == id);

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
        public async Task<ActionResult<SaveResult<Subject>>> PutSubject(Guid id, Subject subject)
        {
            return await Task.Run(() =>
            {
                var subResult = subject.Save();

                return subResult;
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
                var subResult = subject.Save();

                return subResult;
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
                var delSubject = subject.Delete();


                return delSubject;


            });
        }

       
    }
}
