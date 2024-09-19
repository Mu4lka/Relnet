using DealApiContracts.Dto.Realtor;
using DealApp.Services.Interfaces;
using DealDomain.Obstructions.Repositories;
using DealDomain.Utils;

namespace DealApp.Services;

/// <summary>
/// Сервис риелторов
/// </summary>
public class RealtorsService(IRealtorsRepository _realtorsRepository) : IRealtorsService
{
    public Task<Result> CreateAsync(CreateRealtorDto realtor)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ICollection<GetRealtorDto>>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Result> UpdateAsync(UpdateRealtorDto realtor)
    {
        throw new NotImplementedException();
    }
}
