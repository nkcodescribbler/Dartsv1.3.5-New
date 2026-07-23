using System.ComponentModel.DataAnnotations;

namespace SpecToCode1.Model.ViewModels;

public class AddressViewModel
{
    [Required]
    [Display(Name = "Address Line 1")]
    public string AddressLine1 { get; set; } = string.Empty;
    
    [Display(Name = "Address Line 2")]
    public string? AddressLine2 { get; set; }
    
    [Required]
    public string City { get; set; } = string.Empty;
    
    public string? State { get; set; }
    
    [Required]
    public string Zipcode { get; set; } = string.Empty;
}