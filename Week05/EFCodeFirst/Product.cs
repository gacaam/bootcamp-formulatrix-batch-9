using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirst;

public class Product
{
    public int ProductId { get; set; }
    [Required, MaxLength(40)]
    public string ProductName { get; set; } = null!;
    public int CategoryId { get; set; }
    [Column(TypeName = "money")]
    public int UnitPrice { get; set; }
    [Column(TypeName = "smallint")]
    public short UnitsOnOrder { get; set; }
}
