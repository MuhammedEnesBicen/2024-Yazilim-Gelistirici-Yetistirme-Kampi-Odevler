using Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface ICourseService
    {
        void Add(Course course);
        void DeleteById(int id);
        Course GetById(int id);
        List<Course> GetAll();
    }
}