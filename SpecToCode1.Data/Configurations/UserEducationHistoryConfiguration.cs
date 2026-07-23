using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpecToCode1.Model;

namespace SpecToCode1.Data.Configurations;

public class UserEducationHistoryConfiguration : IEntityTypeConfiguration<UserEducationHistory>
{
    public void Configure(EntityTypeBuilder<UserEducationHistory> builder)
    {
        builder.ToTable("UserEducationHistory");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd();

        builder.Property(e => e.EducationType)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(e => e.InstitutionName)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(e => e.InstitutionAddressLine1)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(e => e.InstitutionAddressLine2)
            .HasMaxLength(150);

        builder.Property(e => e.InstitutionCity)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.InstitutionState)
            .HasMaxLength(150);

        builder.Property(e => e.InstitutionPincode)
            .IsRequired()
            .HasMaxLength(15);

        builder.HasOne(e => e.Person)
            .WithMany(p => p.EducationHistories)
            .HasForeignKey(e => e.UserId)
            .IsRequired();

        builder.HasIndex(e => e.UserId);
    }
}