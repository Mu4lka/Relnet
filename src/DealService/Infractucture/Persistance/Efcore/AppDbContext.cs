using DealDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance.Efcore;

internal class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Deal> Deals { get; set; }
    public DbSet<Realtor> Realtors { get; set; }
    public DbSet<Source> Sources { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("deal_service");
    }
}
