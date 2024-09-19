using DealDomain;
using DealDomain.Entities;
using DealDomain.Obstructions.Repositories;
using Infractucture.Persistance.Efcore;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance.Repositories;

internal class DealsRepository(AppDbContext _dbContext) : IDealsRepository
{
    public async Task CreateAsync(Deal deal)
    {
        await _dbContext.Deals.AddAsync(deal);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await _dbContext.Deals.Where(deal => deal.Id == id).ExecuteDeleteAsync();
    }

    public async Task<ICollection<Deal>> GetByFilterAsync(DealFilter filter)
    {
        return await _dbContext.Deals.ToListAsync();
    }

    public async Task UpdateAsync(Deal deal)
    {
        throw new NotImplementedException();
    }
}
