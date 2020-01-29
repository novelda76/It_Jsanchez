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
using Common.Lib.Infrastructure;

namespace Academy.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //private readonly AcademyDbContext _context;
        //var repo = Entity.DepCon.Resolve<IStudentRepository>();

        public StudentsController()
        {
           
        }

        
        // GET: api/Students
        [HttpGet]
       
        public async Task<IEnumerable<Student>> GetStudents()
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            var StudentsList = await repo.QueryAll().ToListAsync();
            return repo.QueryAll();
            
        }
      

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(Guid id)
        {
            return await Task.Run(() =>
            {
                var repo = Entity.DepCon.Resolve<IStudentRepository>();
                var student= repo.QueryAll().FirstOrDefault(x => x.Id == id);

                if (student == null)
                {

                    return null;
                }

                return student;

            });
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<ActionResult<SaveResult<Student>>> PutStudent( Student student)
        {
            return await Task.Run(() =>
            {
                var sr = student.Save();
                return sr;
            });
        }

        // POST: api/Students
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<SaveResult<Student>>> PostStudent(Student student)
        {
            return await Task.Run(() =>
            {
                var sr = student.Save();
                return sr;
            });
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteResult<Student>>> DeleteStudent(Guid id)
        {
            return await Task.Run(() =>
            {
                var repo = Entity.DepCon.Resolve<IStudentRepository>();
                var student = repo.QueryAll().FirstOrDefault(x => x.Id == id);
                var ds = student.Delete();

                return ds;
            });
        }

        private bool StudentExists(Guid id)
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            var existingStudent = repo.QueryAll().Any(e => e.Id == id);
            return existingStudent;
        }
    }
}
