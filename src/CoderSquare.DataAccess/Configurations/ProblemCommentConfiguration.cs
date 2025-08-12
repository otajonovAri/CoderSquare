using CoderSquare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoderSquare.DataAccess.Configurations;

public class ProblemCommentConfiguration : IEntityTypeConfiguration<ProblemComment>
{
    public void Configure(EntityTypeBuilder<ProblemComment> builder)
    {
        builder
            .HasOne(pc => pc.Problem)
            .WithMany(p => p.Comments)
            .HasForeignKey(pc => pc.ProblemId);

        builder
            .HasOne(pc => pc.User)
            .WithMany(u => u.Comments)
            .HasForeignKey(pc => pc.UserId);
    }
}