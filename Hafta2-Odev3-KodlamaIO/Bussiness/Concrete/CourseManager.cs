using Bussiness.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class CourseManager : ICourseService
    {
        private List<Course> Courses;

        public CourseManager(List<Course> courses)
        {
            Courses = courses;
        }
        public void Add(Course category)
        {
            Courses.Add(category);
        }

        public void DeleteById(int id)
        {
            Courses.Remove(Courses.FirstOrDefault(c => c.Id == id));
        }

        public List<Course> GetAll()
        {
            return Courses;
        }

        public Course GetById(int id)
        {
            return Courses.FirstOrDefault(c => c.Id == id);
        }
    }
}