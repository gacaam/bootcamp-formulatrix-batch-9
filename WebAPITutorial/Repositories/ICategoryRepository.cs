using WebAPITutorial.Models;

namespace WebAPITutorial.Repositories;

public interface ICategoryRepository : IRepository<Category>
{
    void Update(Category category);
}
