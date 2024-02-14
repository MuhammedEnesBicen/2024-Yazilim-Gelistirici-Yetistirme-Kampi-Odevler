namespace Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Course> Courses { get; set; }
    }
}