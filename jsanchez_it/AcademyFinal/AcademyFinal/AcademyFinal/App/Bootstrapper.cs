﻿using Academy.Lib.DAL;
using Academy.Lib.DAL.Repositories;
using Academy.Lib.Models;
using Academy.Lib.Repositories;
using AcademyFinal.App.WPF.DbContextFactory;
using Common.Lib.Core;
using Common.Lib.Core.Context;
using Common.Lib.DAL.EFCore;
using Common.Lib.Infrastructure;
using System;


namespace AcademyFinal.App.WPF
{
    //El bootstrapper lo lanzaremos desde App.xaml.cs, a través del método OnStartup
    public class Bootstrapper
    {
        public IDependencyContainer Init()
        {
            var depCon = new SimpleDependencyContainer();

            RegisterRepositories(depCon);

            Entity.DepCon = depCon;

            return depCon;
        }


        public void RegisterRepositories(IDependencyContainer depCon)
        {
            var studentRepoBuilder = new Func<object[], object>((parameters) =>
            {
                //return new StudentRepository(GetDbConstructor());
                return new EfCoreRepository<Student>(GetDbConstructor());
            });

            var subjectsRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<Subject>(GetDbConstructor());
            });

            var examsRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<Exam>(GetDbConstructor());
            });

            var studentsExamsRepoBuilder = new Func<object[], object>((parameters) =>
            {
                return new EfCoreRepository<StudentExam>(GetDbConstructor());
            });

            depCon.Register<IRepository<Student>, StudentRepository>(studentRepoBuilder);
            depCon.Register<IStudentRepository, StudentRepository>((parameters) => new StudentRepository(GetDbConstructor()));          
            depCon.Register<IRepository<Subject>, EfCoreRepository<Subject>>(subjectsRepoBuilder);
            depCon.Register<ISubjectsRepository, SubjectRepository>((parameters) => new SubjectRepository(GetDbConstructor()));
            depCon.Register<IRepository<Exam>, EfCoreRepository<Exam>>(examsRepoBuilder);
            depCon.Register<IExamsRepository, ExamRepository>((parameters) => new ExamRepository(GetDbConstructor()));
            depCon.Register<IRepository<StudentExam>, EfCoreRepository<StudentExam>>(studentsExamsRepoBuilder);
            depCon.Register<IStudentsExamRepository, StudentExamRepository>((parameters) => new StudentExamRepository(GetDbConstructor()));
        }

        private static AcademyDbContext GetDbConstructor()
        {
            var factory = new AcademyContextFactory();
            return factory.CreateDbContext(null);
        }

    }

}
