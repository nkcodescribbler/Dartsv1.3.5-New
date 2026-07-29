using Microsoft.EntityFrameworkCore;
using SpecToCode1.Data;
using SpecToCode1.Model;

namespace SpecToCode1.Services;

/// <summary>
/// Service implementation for managing user education history.
/// </summary>
public class EducationService : IEducationService
{
    private readonly ApplicationDbContext _context;

    /// <summary>
    /// Initializes a new instance of the <see cref="EducationService"/> class.
    /// </summary>
    /// <param name="context">The database context.</param>
    public EducationService(ApplicationDbContext context)
    {        _context = context;
    }

    /// <summary>
    /// Retrieves the list of education history records for a specific user asynchronously.
    /// </summary>
    /// <param name="userId">The ID of the user (Person ID).</param>
    /// <returns>A list of user education history records. Returns an empty list if no records exist.</returns>
    public async Task<List<UserEducationHistory>> GetEducationListAsync(int userId)
    {        return await _context.UserEducationHistories
            .AsNoTracking()
            .Where(x => x.UserId == userId)
            .ToListAsync();
    }

    /// <summary>
    /// Creates a new education history record asynchronously.
    /// </summary>
    /// <param name="education">The education history record to create.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    public async Task CreateEducationAsync(UserEducationHistory education)
    {        if (education == null)
        {
            throw new ArgumentNullException(nameof(education));
        }

        // Trim all string properties before saving
        education.EducationType = education.EducationType?.Trim() ?? string.Empty;
        education.InstitutionName = education.InstitutionName?.Trim() ?? string.Empty;
        education.InstitutionAddressLine1 = education.InstitutionAddressLine1?.Trim() ?? string.Empty;
        education.InstitutionAddressLine2 = education.InstitutionAddressLine2?.Trim();
        education.InstitutionCity = education.InstitutionCity?.Trim() ?? string.Empty;
        education.InstitutionState = education.InstitutionState?.Trim();
        education.InstitutionPincode = education.InstitutionPincode?.Trim() ?? string.Empty;

        _context.UserEducationHistories.Add(education);
        await _context.SaveChangesAsync();
    }
}