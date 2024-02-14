using Bussiness.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class InstructorManager : IInstructorService
    {
        private List<Instructor> Instructors;

        public InstructorManager(List<Instructor> instructors)
        {
            Instructors = instructors;
        }
        public void Add(Instructor instructor)
        {
            Instructors.Add(instructor);
        }


        public void DeleteById(int id)
        {
            Instructors.Remove(Instructors.FirstOrDefault(c => c.Id == id));
        }

        public List<Instructor> GetAll()
        {
            return Instructors;
        }

        public Instructor GetById(int id)
        {
            return Instructors.FirstOrDefault(c => c.Id == id);
        }
    }
}