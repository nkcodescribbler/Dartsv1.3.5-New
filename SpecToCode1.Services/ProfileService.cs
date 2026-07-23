using Microsoft.EntityFrameworkCore;
using SpecToCode1.Data;
using SpecToCode1.Model;
using SpecToCode1.Model.ViewModels;

namespace SpecToCode1.Services;

public class ProfileService : IProfileService
{
    private readonly ApplicationDbContext _context;

    public ProfileService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ProfileViewModel?> GetProfileAsync(int userId)
    {
        var person = await _context.Persons
            .Include(p => p.Addresses)
            .FirstOrDefaultAsync(p => p.Id == userId);

        if (person == null) return null;

        var permanent = person.Addresses.FirstOrDefault(a => a.AddressType == AddressType.Permanent);
        var communication = person.Addresses.FirstOrDefault(a => a.AddressType == AddressType.Communication);

        return new ProfileViewModel
        {
            FirstName = person.FirstName,
            LastName = person.LastName,
            Username = person.Username,
            DOB = person.DOB,
            ContactNumber = person.ContactNumber,
            PermanentAddress = MapToViewModel(permanent),
            CommunicationAddress = MapToViewModel(communication)
        };
    }

    public async Task<bool> UpdateProfileAsync(ProfileViewModel model, int userId)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var person = await _context.Persons
                .Include(p => p.Addresses)
                .FirstOrDefaultAsync(p => p.Id == userId);

            if (person == null) return false;

            person.DOB = model.DOB;
            person.ContactNumber = model.ContactNumber;

            UpdateOrAddAddress(person, model.PermanentAddress, AddressType.Permanent);
            UpdateOrAddAddress(person, model.CommunicationAddress, AddressType.Communication);

            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
            return true;
        }
        catch
        {
            await transaction.RollbackAsync();
            return false;
        }
    }

    private void UpdateOrAddAddress(Person person, AddressViewModel vm, AddressType type)
    {
        var address = person.Addresses.FirstOrDefault(a => a.AddressType == type);
        if (address == null)
        {
            address = new Address { AddressType = type, PersonId = person.Id };
            person.Addresses.Add(address);
        }

        address.AddressLine1 = vm.AddressLine1;
        address.AddressLine2 = vm.AddressLine2;
        address.City = vm.City;
        address.State = vm.State;
        address.Zipcode = vm.Zipcode;
    }

    private AddressViewModel MapToViewModel(Address? address)
    {
        if (address == null) return new AddressViewModel();
        return new AddressViewModel
        {
            AddressLine1 = address.AddressLine1,
            AddressLine2 = address.AddressLine2,
            City = address.City,
            State = address.State,
            Zipcode = address.Zipcode
        };
    }
}