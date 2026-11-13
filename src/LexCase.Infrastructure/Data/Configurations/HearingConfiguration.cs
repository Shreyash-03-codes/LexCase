using LexCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LexCase.Infrastructure.Data.Configurations;

public class HearingConfiguration : IEntityTypeConfiguration<Hearing>
{
    public void Configure(EntityTypeBuilder<Hearing> builder)
    {
        builder.HasKey(h => h.Id);

        builder.Property(h => h.Location).IsRequired().HasMaxLength(200);
        builder.Property(h => h.Outcome).HasMaxLength(1000);
        builder.Property(h => h.Notes).HasMaxLength(2000);

        builder.HasIndex(h => h.ScheduledAt);

        builder.HasOne(h => h.Case)
            .WithMany(c => c.Hearings)
            .HasForeignKey(h => h.CaseId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}