using DealDomain;
using DealDomain.Entities;
using DealDomain.Obstructions.Repositories;

namespace Infractucture.Persistance.Repositories;

internal class DealsRepository : IDealsRepository
{
    public Task CreateAsync(Deal deal)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<Deal>> GetByFilterAsync(DealFilter filter)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Deal deal)
    {
        throw new NotImplementedException();
    }
}
