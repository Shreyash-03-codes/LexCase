using LexCase.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LexCase.Infrastructure.Data.Configurations;

public class CaseNoteConfiguration : IEntityTypeConfiguration<CaseNote>
{
    public void Configure(EntityTypeBuilder<CaseNote> builder)
    {
        builder.HasKey(n => n.Id);

        builder.Property(n => n.Content).IsRequired().HasMaxLength(4000);

        builder.HasOne(n => n.Case)
            .WithMany(c => c.CaseNotes)
            .HasForeignKey(n => n.CaseId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(n => n.AuthorUser)
            .WithMany()
            .HasForeignKey(n => n.AuthorUserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}