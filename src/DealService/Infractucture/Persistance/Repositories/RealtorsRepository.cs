using DealDomain.Entities;
using DealDomain.Obstructions.Repositories;
using Infractucture.Persistance.Efcore;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance.Repositories;

internal class RealtorsRepository(AppDbContext _dbContext) : IRealtorsRepository
{
    public async Task CreateAsync(Realtor realtor)
    {
        await _dbContext.Realtors.AddAsync(realtor);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        await _dbContext.Realtors.Where(r => r.Id == id).ExecuteDeleteAsync();
    }

    public async Task<ICollection<Realtor>> GetAsync()
    {
        return await _dbContext.Realtors.ToListAsync();
    }

    public Task UpdateAsync(Realtor realtor)
    {
        throw new NotImplementedException();
    }
}
