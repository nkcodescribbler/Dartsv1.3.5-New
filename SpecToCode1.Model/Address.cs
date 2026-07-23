using System.ComponentModel.DataAnnotations;

namespace SpecToCode1.Model;

public class Address
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public AddressType AddressType { get; set; }
    
    [Required]
    public string AddressLine1 { get; set; } = string.Empty;
    public string? AddressLine2 { get; set; }
    
    [Required]
    public string City { get; set; } = string.Empty;
    public string? State { get; set; }
    
    [Required]
    public string Zipcode { get; set; } = string.Empty;

    public virtual Person Person { get; set; } = null!;
}