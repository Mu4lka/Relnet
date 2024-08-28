using DealDomain.Entities;

namespace DealDomain.Interfaces;

public interface ISourcesRepository
{
    Task CreateAsync(Source source);
    Task<ICollection<Source>> GetAllAsync();
    Task UpdateAsync(Source source);
    Task DeleteAsync(Guid id);
}
