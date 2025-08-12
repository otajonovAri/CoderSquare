using CoderSquare.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoderSquare.DataAccess.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Language> Languages { get; set; }
    public DbSet<Problem> Problems { get; set; }
    public DbSet<ProblemComment> ProblemComments { get; set; }
    public DbSet<ProblemLike> ProblemLikes { get; set; }
    public DbSet<ProblemNote> ProblemNotes { get; set; }
    public DbSet<RefreshToken> RefreshTokens { get; set; }
    public DbSet<Submission> Submissions { get; set; }
    public DbSet<TestCase> TestCases { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserConfirme> UserConfirms { get; set; }
    public DbSet<UserProblemSuggestion> UserProblemSuggestions { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }
    public DbSet<UserStats> UserStats { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}