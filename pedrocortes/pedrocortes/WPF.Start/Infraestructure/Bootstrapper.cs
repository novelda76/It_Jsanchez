using Common.Lib.Core.Context;
using Common.Lib.Infrastructure;
using P.BL.Infraestructure.Interfaces;
using P.BL.Models;
using P.DAL.EFCore;
using P.DAL.EFCore.Context;

namespace WPF.Start.Infraestructure
{
    public class Bootstrapper
    {
        public Bootstrapper()
        {

        }

        public void Init(IDependencyContainer dp)
        {
            RegisterRepositories(dp);
        }

        void RegisterRepositories(IDependencyContainer dp)
        {
            dp.Register<IRepository<Student>, StudentClientRepository>();
            dp.Register<IStudentRepository, StudentClientRepository>();

            dp.Register<IRepository<Subject>, SubjectClientRepository>();
            dp.Register<ISubjectRepository, SubjectClientRepository>();

            dp.Register<IRepository<Teacher>, TeacherClientRepository>();
            dp.Register<ITeacherRepository, TeacherClientRepository>();

        }
    }
}
