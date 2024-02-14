namespace Entities.Concrete
{
    public class Instructor : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public List<Course> Courses { get; set; }

    }
}