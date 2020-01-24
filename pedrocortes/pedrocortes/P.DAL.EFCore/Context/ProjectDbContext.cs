using Common.Lib.Core;
using Microsoft.EntityFrameworkCore;
using P.BL.Models;
using System;

namespace P.DAL.EFCore.Context
{
    public class AcademyDbContext : DbContext
    {
        static string DbConnection = @"Data Source=Y:\Dropbox\Disco_duro\_PROYECTOS_PERSONALES\_PROY_2019\14_BA-DEVELOPER\05_FINALEXERCISE\academy.db; foreign keys=true";
        
        static string AssemblyName = "WPF.Start";


        private static DbContextOptionsBuilder _optionsBuidler;
        public static DbContextOptionsBuilder OptionsBuilder
        {
            get
            {
                if (_optionsBuidler == null)
                {
                    var optionsBuilder = new DbContextOptionsBuilder<AcademyDbContext>();
                    optionsBuilder.UseSqlite(DbConnection, b => b.MigrationsAssembly(AssemblyName));

                    _optionsBuidler = optionsBuilder;
                }

                return _optionsBuidler;
            }
            set
            {
                _optionsBuidler = value;
            }

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public AcademyDbContext()
            : base(OptionsBuilder.Options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Entity>()
                .Ignore(x => x.CurrentValidation);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(DbConnection, b => b.MigrationsAssembly(AssemblyName));

        }





    }
}
