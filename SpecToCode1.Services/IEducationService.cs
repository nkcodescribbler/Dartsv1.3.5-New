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
    /// Retrieves a specific education history record by ID and User ID for security.
    /// </summary>
    /// <param name="educationId">The ID of the education record.</param>
    /// <param name="userId">The ID of the user (Person ID).</param>
    /// <returns>The education history record or null if not found.</returns>
    Task<UserEducationHistory?> GetEducationByIdAsync(int educationId, int userId);

    /// <summary>
    /// Creates a new education history record.
    /// </summary>
    /// <param name="education">The education history record to create.</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task CreateEducationAsync(UserEducationHistory education);

    /// <summary>
    /// Updates an existing education history record.
    /// </summary>
    /// <param name="education">The education history record with updated values.
    /// </param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task UpdateEducationAsync(UserEducationHistory education);

    /// <summary>
    /// Deletes an education history record by ID and User ID for security.
    /// </summary>
    /// <param name="educationId">The ID of the education record.</param>
    /// <param name="userId">The ID of the user (Person ID).</param>
    /// <returns>A task representing the asynchronous operation.</returns>
    Task DeleteEducationAsync(int educationId, int userId);
}