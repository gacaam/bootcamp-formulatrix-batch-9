using Microsoft.EntityFrameworkCore;
using WebAPITutorial.Data;
using WebAPITutorial.Models;

namespace WebAPITutorial.Repositories;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    private readonly DataContext _db;
    public CategoryRepository(DataContext db) : base(db)
    {
        _db = db;
    }


    public void Update(Category category)
    {
        _db.Categories.Update(category);
    }

}
