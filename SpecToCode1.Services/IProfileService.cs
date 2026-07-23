using SpecToCode1.Model.ViewModels;

namespace SpecToCode1.Services;

public interface IProfileService
{
    Task<ProfileViewModel?> GetProfileAsync(int userId);
    Task<bool> UpdateProfileAsync(ProfileViewModel model, int userId);
}