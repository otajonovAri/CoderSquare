using CoderSquare.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Type = CoderSquare.Domain.Entities.Type;

namespace CoderSquare.DataAccess.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<Problem> Problems { get; set; }
    public DbSet<ProblemType> ProblemTypes { get; set; }
    public DbSet<Type> Types { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}