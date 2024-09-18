using DealDomain.Entities;
using DealDomain.Obstructions.Repositories;

namespace Infractucture.Persistance.Repositories;

internal class RealtorsRepository : IRealtorsRepository
{
    public Task CreateAsync(Realtor realtor)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Realtor>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Realtor realtor)
    {
        throw new NotImplementedException();
    }
}
