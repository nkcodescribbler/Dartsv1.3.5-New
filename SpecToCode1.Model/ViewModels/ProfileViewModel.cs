using System.ComponentModel.DataAnnotations;

namespace SpecToCode1.Model.ViewModels;

public class ProfileViewModel
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime? DOB { get; set; }

    [Required]
    [Display(Name = "Contact Number")]
    public string? ContactNumber { get; set; }

    public AddressViewModel PermanentAddress { get; set; } = new();
    public AddressViewModel CommunicationAddress { get; set; } = new();
}