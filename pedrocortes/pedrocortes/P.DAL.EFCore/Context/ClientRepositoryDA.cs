using Common.Lib.Core;
using Common.Lib.Core.Context;
using Common.Lib.DAL.EFCore;
using Common.Lib.Infrastructure;
using Microsoft.EntityFrameworkCore;
using P.BL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P.DAL.EFCore.Context
{
    public class ClientRepositoryDA<T> : ClientRepository<T> where T : Entity
    {
        //Sustituimos el diccionario tradicional por el DbSet que hemos creado con EFCore en el contexto
        //Para ello, creamos primero la referencia al AcademyDbContext.
        private AcademyDbContext DbContext { get; set; }
        private new DbSet<T> DbSet
        {
            get
            {
                return DbContext.Set<T>();
            }
        }


        //Creamos un constructor para que genere automáticamente un nuevo DbContext al invocarlo
        public ClientRepositoryDA()
        {
            DbContext = new AcademyDbContext();
        }



        //Definimos los métdos de la interfaz
        public override IQueryable<T> QueryAll()
        {
            return DbContext.Set<T>().AsQueryable<T>();
        }

        public override T Find(Guid id)
        {
            return DbContext.Set<T>().FirstOrDefault(x => x.Id == id);
        }

        public override SaveResult<T> Add(T entity)
        {
            var output = new SaveResult<T>()
            {
                Validation = new ValidationResult()

            };

            output.Validation.IsSuccess = true;

            if (entity.Id == default(Guid))
                entity.Id = Guid.NewGuid();

            if (DbSet.Contains<T>(entity))
            {
                output.IsSuccess = false;
                output.Validation.Errors.Add("Ojo!! Ya existe una entity con ese id");
            }

            if (output.IsSuccess)
            {
                DbSet.Add(entity);
                DbContext.SaveChanges();
                output.Entity = entity;
            }

            return output;
        }

        public override SaveResult<T> Update(T entity)
        {
            var output = new SaveResult<T>
            {
                Validation = new ValidationResult()
            };

            output.Validation.IsSuccess = true;

            if (entity.Id == default(Guid))
            {
                output.IsSuccess = false;
                output.Validation.Errors.Add("No se puede actualizar una entidad sin Id");
            }

            if (entity.Id != default(Guid) && !DbSet.Any(x => x.Id == entity.Id))
            {
                output.IsSuccess = false;
                output.Validation.Errors.Add("No existe una entity con ese id");
            }

            if (output.IsSuccess)
            {
                DbSet.Update(entity);
                DbContext.SaveChanges();

                output.Entity = entity;
            }

            return output;
        }

        public override SaveResult<T> Delete(T entity)
        {
            var output = new SaveResult<T>()
            {
                Validation = new ValidationResult(),
                IsSuccess = true
            };

            if (entity.Id == default(Guid))
            {
                output.IsSuccess = false;
                output.Validation.Errors.Add("No se puede eliminar una entidad sin Id");
            }

            if (DbSet.Find(entity.Id) == null)
            {
                output.IsSuccess = false;
                output.Validation.Errors.Add("Esta entidad no se encuentra en la base de datos.");
            }

            if (output.IsSuccess == true)
            {
                var stdDelete = this.Find(entity.Id);
                
                DbSet.Remove(stdDelete);
                DbContext.SaveChanges();
                output.Entity = stdDelete;
            }

            return output;
        }
    }
}
