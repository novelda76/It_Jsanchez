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
    public class StudentsController : ControllerBase
    {
        //private readonly AcademyDbContext _context;


        //public StudentsController(AcademyDbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Students
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            var repo = Entity.DepCon.Resolve<IStudentRepository>();
            var SudentsList = await repo.QueryAll().ToListAsync();
            return SudentsList;
           
            //return await _context.Students.ToListAsync();
        }

       

        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(Guid id)
        {
            return await Task.Run(() =>
            {
                var repo = Entity.DepCon.Resolve<IStudentRepository>();
                var student = repo.QueryAll().FirstOrDefault(x => x.Id == id);
                // var student = await _context.Students.FindAsync(id);

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
        [HttpPut]
        public async Task<ActionResult<SaveResult<Student>>> PutStudent(Student student)
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



            //_context.Students.Add(student);
            //await _context.SaveChangesAsync();

            //return CreatedAtAction("GetStudent", new { id = student.Id }, student);
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

    }
}
