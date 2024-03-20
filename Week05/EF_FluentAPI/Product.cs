using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; } = null!;
    public int CategoryId { get; set; }
    public int UnitPrice { get; set; }
    public short UnitsOnOrder { get; set; }
    public Category Category { get; set; }
}
