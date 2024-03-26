using Microsoft.EntityFrameworkCore;
using WebAPITutorial.Models;

namespace WebAPITutorial.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
		base.OnModelCreating(modelBuilder);
		modelBuilder.Entity<Category>(c =>
		{
			c.HasKey(c => c.CategoryId);
			c.Property(c => c.CategoryName).IsRequired(true).HasMaxLength(40);
			c.Property(c => c.Description).IsRequired(false);
			c.HasMany(c => c.Products);
		});
		modelBuilder.Entity<Product>(p =>
		{
			p.HasKey(p => p.ProductId);
			p.Property(p => p.ProductName)
			.IsRequired(true)
			.HasMaxLength(40);
			p.Property(p => p.UnitPrice)
			.HasColumnType("money");
			p.Property(p => p.UnitsOnOrder)
			.HasColumnType("smallint");
			p.HasOne(p => p.Category);
		});
        modelBuilder.Entity<Category>().HasData(
			new Category { CategoryId = 1, CategoryName = "Electronics", Description = "Electronic Items" },
			new Category { CategoryId = 2, CategoryName = "Clothes", Description = "Dress Items" },
			new Category { CategoryId = 3, CategoryName = "Groceries", Description = "Grocery Items" }
		);
		modelBuilder.Entity<Product>().HasData(
			new Product { ProductId = 1, ProductName = "Laptop", Description = "Laptop", CategoryId = 1 },
			new Product { ProductId = 2, ProductName = "Mobile", Description = "Mobile", CategoryId = 1 },
			new Product { ProductId = 3, ProductName = "Shirt", Description = "Shirt", CategoryId = 2 },
			new Product { ProductId = 4, ProductName = "Jeans", Description = "Jeans", CategoryId = 2 },
			new Product { ProductId = 5, ProductName = "Rice", Description = "Rice", CategoryId = 3 },
			new Product { ProductId = 6, ProductName = "Wheat", Description = "Wheat", CategoryId = 3 }
		);
    }
}
