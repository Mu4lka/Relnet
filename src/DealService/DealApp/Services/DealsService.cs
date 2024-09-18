using DealApiContracts.Dto.Deal;
using DealApp.Services.Interfaces;
using DealDomain;

namespace DealApp.Services;

public class DealsService : IDealsService
{
    public Task CreateAsync(CreateDealDto deal)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GetDealDto>> GetByFilterAsync(DealFilter filter)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateDealDto deal)
    {
        throw new NotImplementedException();
    }
}
