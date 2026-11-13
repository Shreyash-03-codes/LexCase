using LexCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LexCase.Infrastructure.Data.Configurations;

public class LawyerConfiguration : IEntityTypeConfiguration<Lawyer>
{
    public void Configure(EntityTypeBuilder<Lawyer> builder)
    {
        builder.HasKey(l => l.Id);

        builder.Property(l => l.Name).IsRequired().HasMaxLength(200);
        builder.Property(l => l.Email).IsRequired().HasMaxLength(256);
        builder.Property(l => l.BarNumber).IsRequired().HasMaxLength(50);
        builder.Property(l => l.Specialization).IsRequired().HasMaxLength(100);

        builder.HasIndex(l => l.BarNumber).IsUnique();

        builder.HasOne(l => l.User)
            .WithOne(u => u.Lawyer)
            .HasForeignKey<Lawyer>(l => l.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}