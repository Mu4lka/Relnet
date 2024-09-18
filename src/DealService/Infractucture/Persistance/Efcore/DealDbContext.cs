using DealDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance.Efcore;

internal class DealDbContext : DbContext
{
    DbSet<Deal> Deals { get; set; }
    DbSet<Realtor> Realtors { get; set; }
    DbSet<Source> Sources { get; set; }
}
