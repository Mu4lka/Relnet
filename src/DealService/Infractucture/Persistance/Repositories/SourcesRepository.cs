using DealDomain.Entities;
using DealDomain.Obstructions.Repositories;
using Infractucture.Persistance.Efcore;

namespace Infractucture.Persistance.Repositories;

internal class SourcesRepository(AppDbContext _dbContext) : ISourcesRepository
{
    public Task CreateAsync(Source source)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Source>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Source source)
    {
        throw new NotImplementedException();
    }
}
