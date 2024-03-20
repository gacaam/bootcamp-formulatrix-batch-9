using System.Data;
using EntityFrameworkTutorial;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main()
    {
        using(Northwind db = new())
        {
            // check database connection
            bool isConnected = db.Database.CanConnect();
            Console.WriteLine("Connected: " + isConnected);

            // iterate through database items as list
            var categories = db.Categories.ToList();
            Console.WriteLine("Categories: ");
            foreach(var category in categories)
            {
                DisplayCategory(category);
            }

            // LINQ 
            Category? item1 = db.Categories.Find(1); //is set to nullable because data entry may be null
            Category? item3 = db.Categories.Where(item => item.CategoryID == 3) //.Where returns IEnumerable 
                            .FirstOrDefault(); // convert to Category by FirstOrDefault method
            Category? dairy = db.Categories.Where(item => item.CategoryName.Contains("Dairy")).FirstOrDefault();

            Console.WriteLine("\nLINQ search");
            DisplayCategory(item1);
            DisplayCategory(item3);
            DisplayCategory(dairy);
        
            // Create
            Category someCategory = new()
            {
                CategoryName = "Some Category"
            };
            // db.Categories.Add(someCategory);
            // db.SaveChanges();

            // Update
            Category? randomCategory = db.Categories.Where(item => item.CategoryName.Contains("Category")).FirstOrDefault();
            if(randomCategory is not null)
            {
                randomCategory.Description = "This is a category";
                // db.SaveChanges();
            }

            // Delete
            if(randomCategory is not null)
            {
                db.Categories.Remove(randomCategory);
                db.SaveChanges();
            }

            // Retrieving product items from category
            // Eager loading
            var seafoodProducts = db.Categories
                                .Where(item => item.CategoryName.Contains("Seafood"))
                                .Include(item => item.Products).ToList();

            Console.WriteLine("\nSeafood Products: ");                                
            foreach(var category in seafoodProducts)
            {            
                foreach(var product in category.Products)
                {
                    DisplayProduct(product);
                }
            }

            // Retrieving product item with supplier
            Product? product1 = db.Products.Find(1);
            Supplier? product1Supplier = db.Suppliers.Where(item => item.SupplierId == product1.SupplierId).FirstOrDefault();
            Category? product1Category = db.Categories.Where(item => item.CategoryID == product1.CategoryID).FirstOrDefault();
            
            Console.WriteLine($"\nProduct: {product1.ProductName}");
            Console.WriteLine($"Category: {product1Category.CategoryName}");
            Console.WriteLine($"Supplier: {product1Supplier.CompanyName}");
        }
    }

    static void DisplayCategory(Category category)
    {
        Console.WriteLine($"{category.CategoryID} {category.CategoryName}");
    }

    static void DisplayProduct(Product product)
    {
        Console.WriteLine($"{product.ProductId} {product.ProductName}");
    }
}