using System.ComponentModel.DataAnnotations;

namespace NewDataAnnotationsDemoInDotNet8.Models;

public class Product
{
    [Length(2, 30)]
    public string Name { get; set; }

    [Length(2, 255)]
    public string Description { get; set; }

    [Range(1, 1000, MinimumIsExclusive = true, MaximumIsExclusive = false)]
    public decimal Price { get; set; }

    [AllowedValues("S", "M", "L", "XL", "XXL")]
    public string Size { get; set; }

    [DeniedValues("Electronic", "Computers")]
    public string Category { get; set; }

    [Base64String]
    public string Image { get; set; }
}