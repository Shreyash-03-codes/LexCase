using LexCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LexCase.Infrastructure.Data.Configurations;

public class CaseConfiguration : IEntityTypeConfiguration<Case>
{
    public void Configure(EntityTypeBuilder<Case> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.CaseNumber).IsRequired().HasMaxLength(20);
        builder.Property(c => c.Title).IsRequired().HasMaxLength(200);
        builder.Property(c => c.Description).HasMaxLength(4000);
        builder.Property(c => c.CourtName).IsRequired().HasMaxLength(200);

        builder.Property(c => c.Status).HasConversion<string>().HasMaxLength(20);
        builder.Property(c => c.Priority).HasConversion<string>().HasMaxLength(20);

        builder.HasIndex(c => c.CaseNumber).IsUnique();
        builder.HasIndex(c => c.Status);

        builder.HasOne(c => c.Client)
            .WithMany(cl => cl.Cases)
            .HasForeignKey(c => c.ClientId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}