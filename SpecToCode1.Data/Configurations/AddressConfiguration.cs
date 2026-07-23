using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpecToCode1.Model;

namespace SpecToCode1.Data.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.AddressLine1).IsRequired();
        builder.Property(a => a.AddressLine2).IsRequired(false);
        builder.Property(a => a.City).IsRequired();
        builder.Property(a => a.State).IsRequired(false);
        builder.Property(a => a.Zipcode).IsRequired();

        builder.HasOne(a => a.Person)
               .WithMany(p => p.Addresses)
               .HasForeignKey(a => a.PersonId);
    }
}