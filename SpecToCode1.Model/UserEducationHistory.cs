using System.ComponentModel.DataAnnotations;

namespace SpecToCode1.Model;

public class UserEducationHistory
{
    public int Id { get; set; }

    [Required]
    [MaxLength(150)]
    public string EducationType { get; set; } = string.Empty;

    [Required]
    [MaxLength(150)]
    public string InstitutionName { get; set; } = string.Empty;

    [Required]
    [MaxLength(150)]
    public string InstitutionAddressLine1 { get; set; } = string.Empty;

    [MaxLength(150)]
    public string? InstitutionAddressLine2 { get; set; }

    [Required]
    [MaxLength(100)]
    public string InstitutionCity { get; set; } = string.Empty;

    [MaxLength(150)]
    public string? InstitutionState { get; set; }

    [Required]
    [MaxLength(15)]
    public string InstitutionPincode { get; set; } = string.Empty;

    public int UserId { get; set; }

    public virtual Person Person { get; set; } = null!;
}