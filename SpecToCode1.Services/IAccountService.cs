using SpecToCode1.Model;

namespace SpecToCode1.Services;

public interface IAccountService
{
    Task<UserDto?> RegisterUserAsync(RegisterRequest request);
    Task<UserDto?> LoginUserAsync(LoginRequest request);
}
