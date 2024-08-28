using DealDomain.Entities;

namespace DealDomain.Interfaces;

public interface IDealsRepository
{
    Task CreateAsync(Deal deal);
    Task<ICollection<Deal>> GetDealsByTimeRange(DateTime start, DateTime end);
    Task UpdateAsync(Deal deal);
    Task DeleteAsync(Guid id);
}
