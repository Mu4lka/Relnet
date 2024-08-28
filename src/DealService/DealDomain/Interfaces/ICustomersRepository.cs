using DealDomain.Entities;

namespace DealDomain.Interfaces;

public interface ICustomersRepository
{
    Task CreateAsync(Customer customer);
    Task<ICollection<Customer>> GetAllAsync();
    Task UpdateAsync(Customer customer);
    Task DeleteAsync(Guid id);
}
