using Entities.Concrete;

namespace Bussiness.Abstract
{
    public interface ICategoryService
    {
        void Add(Category category);
        void DeleteById(int id);
        Category GetById(int id);
        List<Category> GetAll();
    }
}