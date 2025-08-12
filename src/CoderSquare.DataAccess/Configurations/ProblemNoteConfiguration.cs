using CoderSquare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoderSquare.DataAccess.Configurations;

public class ProblemNoteConfiguration : IEntityTypeConfiguration<ProblemNote>
{
    public void Configure(EntityTypeBuilder<ProblemNote> builder)
    {
        builder
            .HasOne(pn => pn.Problem)
            .WithMany(p => p.Notes)
            .HasForeignKey(pn => pn.ProblemId);

        builder
            .HasOne(pn => pn.User)
            .WithMany(u => u.Notes)
            .HasForeignKey(pn => pn.UserId);
    }
}