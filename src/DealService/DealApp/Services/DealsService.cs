using DealApiContracts.Dto.Deal;
using DealApp.Services.Interfaces;
using DealDomain;
using DealDomain.Obstructions.Repositories;
using DealDomain.Utils;

namespace DealApp.Services;

/// <summary>
/// Сервис сделок
/// </summary>
public class DealsService(IDealsRepository _dealsRepository) : IDealsService
{
    public Task<Result> CreateAsync(CreateDealDto deal)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ICollection<GetDealDto>>> GetByFilterAsync(DealFilter filter)
    {
        throw new NotImplementedException();
    }

    public Task<Result> UpdateAsync(UpdateDealDto deal)
    {
        throw new NotImplementedException();
    }
}
