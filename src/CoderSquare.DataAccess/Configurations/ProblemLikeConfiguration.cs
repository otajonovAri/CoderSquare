using CoderSquare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoderSquare.DataAccess.Configurations;

public class ProblemLikeConfiguration : IEntityTypeConfiguration<ProblemLike>
{
    public void Configure(EntityTypeBuilder<ProblemLike> builder)
    {
        builder
            .HasOne(pl => pl.Problem)
            .WithMany(p => p.Likes)
            .HasForeignKey(pl => pl.ProblemId);

        builder
            .HasOne(pl => pl.User)
            .WithMany(u => u.LikedProblems)
            .HasForeignKey(pl => pl.UserId);
    }
}