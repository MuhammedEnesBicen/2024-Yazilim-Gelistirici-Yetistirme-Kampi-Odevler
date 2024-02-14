using Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface IInstructorService
    {
        void Add(Instructor instructor);
        void DeleteById(int id);
        Instructor GetById(int id);
        List<Instructor> GetAll();
    }
}