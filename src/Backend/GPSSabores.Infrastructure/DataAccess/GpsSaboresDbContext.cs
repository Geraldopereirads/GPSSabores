using GPSSabores.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GPSSabores.Infrastructure.DataAccess;
public class GpsSaboresDbContext : DbContext
{
    public GpsSaboresDbContext(DbContextOptions options) : base(options) { }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(GpsSaboresDbContext).Assembly);
    }

}
