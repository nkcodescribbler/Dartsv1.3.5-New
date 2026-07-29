using SpecToCode1.Model;

namespace SpecToCode1.Services;

/// <summary>
/// Interface for Education Service to handle user education history operations.
/// </summary>
public interface IEducationService
{
    /// <summary>
    /// Retrieves the list of education history records for a specific user.
    /// </summary>
    /// <param name="userId">The ID of the user (Person ID).</param>
    /// <returns>A list of user education history records.</returns>
    Task<List<UserEducationHistory>> GetEducationListAsync(int userId);

    /// <summary>
    /// Creates a new education history record.
    /// </summary>
    /// <param name="education">The education history record to create.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task CreateEducationAsync(UserEducationHistory education);
}