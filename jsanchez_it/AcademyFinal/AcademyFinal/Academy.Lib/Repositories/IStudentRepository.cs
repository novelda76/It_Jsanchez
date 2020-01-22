using Academy.Lib.Models;
using Common.Lib.Core.Context;

namespace Academy.Lib.Repositories
{
    public interface IStudentRepository: IRepository<Student>
    {
        Student FindByDni(string dni);


    }
}
