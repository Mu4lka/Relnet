using DealDomain;
using DealDomain.Abstractions.Repositories;
using DealDomain.Entities;
using DealDomain.Enums;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance.Repositories;

internal class DealsRepository(DealsDbContext _dbContext) : IDealsRepository
{
    public async Task<Guid> CreateAsync(Deal deal)
    {
        await _dbContext.Deals.AddAsync(deal);
        await _dbContext.SaveChangesAsync();
        return deal.Id;
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

    public async Task UpdateStatusAsync(Guid dealId, DealStatus status)
    {
        await _dbContext.Deals
            .Where(d => d.Id == dealId)
            .ExecuteUpdateAsync(
                setters => setters.SetProperty(d => d.Status, status)
                );
    }
}
