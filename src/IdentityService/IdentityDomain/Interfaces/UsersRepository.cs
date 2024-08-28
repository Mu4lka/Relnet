using IdentityDomain.Entities;

namespace IdentityDomain.Interfaces;

public interface IUsersRepository
{
    Task CreateAsync(User user);
    Task<User> GetUserByUserNameAsync(string userName);
    Task<ICollection<User>> GetAllAsync();
    Task DeleteAsync(Guid id);
    Task UpdateAsync(User user);
}