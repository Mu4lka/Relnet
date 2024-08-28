using DealDomain.Entities;

namespace DealDomain.Interfaces;

public interface IRealtorsRepository
{
    Task CreateAsync(Realtor realtor);
    Task<ICollection<Realtor>> GetAllAsync();
    Task UpdateAsync(Realtor realtor);
    Task DeleteAsync(Guid id);
}
