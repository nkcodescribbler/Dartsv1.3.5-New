using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpecToCode1.Model;

namespace SpecToCode1.Data.Configurations;

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Username)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(p => p.Username)
            .IsUnique();

        builder.Property(p => p.Password)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(p => p.LastLogin)
            .IsRequired(false);

        builder.Property(p => p.DOB)
            .IsRequired(false);

        builder.Property(p => p.ContactNumber)
            .HasMaxLength(20)
            .IsRequired(false);
    }
}