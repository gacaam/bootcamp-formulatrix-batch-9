using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace EFCodeFirst;

public class Northwind : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=mydatabase;Username=postgres;Password=postgres");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
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
    }
}
