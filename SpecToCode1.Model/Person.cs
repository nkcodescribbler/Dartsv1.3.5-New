using System.ComponentModel.DataAnnotations;

namespace SpecToCode1.Model;

public class Person
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Username { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string Password { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    public DateTime? LastLogin { get; set; }

    public DateTime? DOB { get; set; }
    public string? ContactNumber { get; set; }

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
    public virtual ICollection<UserEducationHistory> EducationHistories { get; set; } = new List<UserEducationHistory>();
}