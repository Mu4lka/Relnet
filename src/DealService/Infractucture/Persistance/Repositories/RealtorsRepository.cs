using DealDomain.Entities;
using DealDomain.Obstructions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance.Repositories;

internal class RealtorsRepository(DealsDbContext _dbContext) : IRealtorsRepository
{
    public async Task CreateAsync(Realtor realtor)
    {
        await _dbContext.Realtors.AddAsync(realtor);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
        => await _dbContext.Realtors
            .Where(r => r.Id == id)
            .ExecuteDeleteAsync();


    public async Task<ICollection<Realtor>> GetAsync()
        => await _dbContext.Realtors.ToListAsync();

    public async Task UpdateAsync(Realtor realtor)
    {
        await _dbContext.Realtors
             .Where(r => r.Id == realtor.Id)
             .ExecuteUpdateAsync(setters => setters
                 .SetProperty(r => r.Name, realtor.Name)
                 .SetProperty(r => r.PhoneNumber, realtor.PhoneNumber));
    }
}
