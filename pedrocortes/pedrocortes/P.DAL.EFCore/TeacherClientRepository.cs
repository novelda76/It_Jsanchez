using Common.Lib.Infrastructure;
using P.BL.Infraestructure.Interfaces;
using P.BL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P.DAL.EFCore.Context
{
    public class TeacherClientRepository : ClientRepositoryDA<Teacher>, ITeacherRepository
    {
        public Dictionary<string, Teacher> TeachersByName { get; set; } = new Dictionary<string, Teacher>();

        public override SaveResult<Teacher> Add(Teacher entity)
        {
            var output = base.Add(entity);

            if (output.IsSuccess)
                TeachersByName.Add(output.Entity.Name, output.Entity);

            return output;
        }

        public override SaveResult<Teacher> Update(Teacher entity)
        {
            var output = base.Update(entity);

            var existingTeacher = Find(entity.Id);
            var previousName = existingTeacher.Name;

            if (output.IsSuccess)
            {
                if (previousName != output.Entity.Name)
                {
                    TeachersByName.Remove(previousName);
                    TeachersByName.Add(output.Entity.Name, output.Entity);
                }
                else
                    TeachersByName[output.Entity.Name] = output.Entity;
            }

            return output;
        }

        public override SaveResult<Teacher> Delete(Teacher entity)
        {
            var output = base.Delete(entity);

            if (output.IsSuccess == true)
                TeachersByName.Remove(entity.Name);

            return output;
        }

        public override Teacher Find(Guid id)
        {
            return base.Find(id);
        }

        public Teacher FindByName(string name)
        {
            if (TeachersByName.ContainsKey(name))
                return TeachersByName[name];
            return null;
        }

        public int GetNumberTeachers()
        {
            return TeachersByName.Count;
        }

        public void AddFromDb(Teacher entity)
        {
            TeachersByName.Add(entity.Name, entity);
        }
    }
}
