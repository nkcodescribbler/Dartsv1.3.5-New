using Microsoft.EntityFrameworkCore;
using SpecToCode1.Data;
using SpecToCode1.Model;

namespace SpecToCode1.Services;

public class AccountService : IAccountService
{
    private readonly ApplicationDbContext _context;

    public AccountService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<UserDto?> RegisterUserAsync(RegisterRequest request)
    {
        if (await _context.Persons.AnyAsync(p => p.Username == request.Username))
        {
            return null;
        }

        var person = new Person
        { 
            Username = request.Username, 
            Password = request.Password, 
            FirstName = request.FirstName, 
            LastName = request.LastName 
        };

        _context.Persons.Add(person);
        await _context.SaveChangesAsync();

        return new UserDto
        {
            Id = person.Id,
            Username = person.Username,
            FirstName = person.FirstName,
            LastName = person.LastName,
            LastLogin = person.LastLogin
        };
    }

    public async Task<UserDto?> LoginUserAsync(LoginRequest request)
    {
        var person = await _context.Persons
            .FirstOrDefaultAsync(p => p.Username == request.Username && p.Password == request.Password);

        if (person == null)
        {
            return null;
        }

        person.LastLogin = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return new UserDto
        {
            Id = person.Id,
            Username = person.Username,
            FirstName = person.FirstName,
            LastName = person.LastName,
            LastLogin = person.LastLogin
        };
    }
}
