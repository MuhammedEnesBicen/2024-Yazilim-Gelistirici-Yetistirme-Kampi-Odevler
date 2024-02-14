using Bussiness.Abstract;
using Entities.Concrete;

namespace Bussiness.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private List<Category> Categories;

        public CategoryManager(List<Category> categories)
        {
            Categories = categories;
        }
        public void Add(Category category)
        {
            Categories.Add(category);
        }

        public void DeleteById(int id)
        {
            Categories.Remove(Categories.FirstOrDefault(c => c.Id == id));
        }

        public List<Category> GetAll()
        {
            return Categories;
        }

        public Category GetById(int id)
        {
            return Categories.FirstOrDefault(c => c.Id == id);
        }
    }
}