using DealDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance;

internal class DealsDbContext(DbContextOptions<DealsDbContext> options) : DbContext(options)
{
    public DbSet<Deal> Deals { get; set; }
    public DbSet<Realtor> Realtors { get; set; }
    public DbSet<Source> Sources { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("deal_service");
    }
}
