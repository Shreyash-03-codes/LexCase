using LexCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LexCase.Infrastructure.Data.Configurations;

public class CaseLawyerConfiguration : IEntityTypeConfiguration<CaseLawyer>
{
    public void Configure(EntityTypeBuilder<CaseLawyer> builder)
    {
        builder.HasKey(cl => new { cl.CaseId, cl.LawyerId });

        builder.Property(cl => cl.Role).HasConversion<string>().HasMaxLength(20);

        builder.HasOne(cl => cl.Case)
            .WithMany(c => c.CaseLawyers)
            .HasForeignKey(cl => cl.CaseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(cl => cl.Lawyer)
            .WithMany(l => l.CaseLawyers)
            .HasForeignKey(cl => cl.LawyerId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}