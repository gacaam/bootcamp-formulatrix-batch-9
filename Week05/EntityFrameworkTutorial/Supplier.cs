namespace EntityFrameworkTutorial;

public class Supplier
{
    public int SupplierId { get; set; }
    public string CompanyName { get; set; } 
    public ICollection<Product> Products { get; set; }
    public Supplier()
    {
        Products = new HashSet<Product>();
    }
}
