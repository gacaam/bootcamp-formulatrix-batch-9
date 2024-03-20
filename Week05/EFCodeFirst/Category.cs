using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace EFCodeFirst;

public class Category
{
    //ClassNameId => automatically detects as primary key
    //to customize use attribute [Key]
    public int CategoryId { get; set; }
    [Required, MaxLength(15)]
    public string CategoryName { get; set; } = null!;
    [Column(TypeName = "ntext")]
    public string? Description { get; set; }
    [Column(TypeName = "image")]
    public string? Picture { get; set; } 
    public ICollection<Product> Products { get; set; }
    public Category()
    {
        Products = new HashSet<Product>();
    }

}
