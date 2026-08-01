using System.ComponentModel.DataAnnotations;

namespace SpecToCode1.Model.ViewModels;

/// <summary>
/// ViewModel for displaying and creating education history records.
/// </summary>
public class EducationViewModel
{
    /// <summary>
    /// The unique identifier for the education record.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The type of education (e.g., High School, Bachelor's, etc.).
    /// </summary>
    [Required(ErrorMessage = "Education Type is required.")]
    [Display(Name = "Education Type")]
    public string EducationType { get; set; } = string.Empty;

    /// <summary>
    /// The name of the educational institution.
    /// </summary>
    [Required(ErrorMessage = "Institution Name is required.")]
    [Display(Name = "Institution Name")]
    public string InstitutionName { get; set; } = string.Empty;

    /// <summary>
    /// The first line of the institution's address.
    /// </summary>
    [Required(ErrorMessage = "Institution Address Line 1 is required.")]
    [Display(Name = "Institution Address Line 1")]
    public string AddressLine1 { get; set; } = string.Empty;

    /// <summary>
    /// The second line of the institution's address.
    /// </summary>
    [Display(Name = "Institution Address Line 2")]
    public string? AddressLine2 { get; set; }

    /// <summary>
    /// The city where the institution is located.
    /// </summary>
    [Required(ErrorMessage = "Institution City is required.")]
    [Display(Name = "Institution City")]
    public string City { get; set; } = string.Empty;

    /// <summary>
    /// The state where the institution is located.
    /// </summary>
    [Display(Name = "Institution State")]
    public string? State { get; set; }

    /// <summary>
    /// The pincode of the institution's location.
    /// </summary>
    [Required(ErrorMessage = "Institution Pincode is required.")]
    [Display(Name = "Institution Pincode")]
    public string Pincode { get; set; } = string.Empty;
}