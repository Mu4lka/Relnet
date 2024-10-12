using DealDomain.Abstractions.Repositories;
using DealDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infractucture.Persistance.Repositories;

internal class SourcesRepository(DealsDbContext _dbContext) : ISourcesRepository
{
    public async Task CreateAsync(Source source)
    {
        await _dbContext.Sources.AddAsync(source);
        await _dbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
        => await _dbContext.Sources
            .Where(s => s.Id == id)
            .ExecuteDeleteAsync();

    public async Task<ICollection<Source>> GetAsync()
        => await _dbContext.Sources.ToListAsync();

    public async Task UpdateAsync(Source source)
    {
        await _dbContext.Sources
            .Where(s => s.Id == source.Id)
            .ExecuteUpdateAsync(setters => setters
                .SetProperty(s => s.Url, source.Url)
                .SetProperty(s => s.Title, source.Title)
                );
    }
}
