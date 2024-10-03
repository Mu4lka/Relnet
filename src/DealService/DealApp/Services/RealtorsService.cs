using DealApiContracts.Dto;
using DealApiContracts.Dto.Realtor;
using DealApiContracts.Requests;
using DealApp.Services.Interfaces;
using DealDomain.Obstructions.Repositories;
using DealDomain.Utils;

namespace DealApp.Services;

/// <summary>
/// Сервис риелторов
/// </summary>
public class RealtorsService(IRealtorsRepository _realtorsRepository) : IRealtorsService
{
    public Task<Result> CreateAsync(CreateRealtorRequest request)
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

    public Task<Result> UpdateAsync(UpdateRealtorRequest request)
    {
        throw new NotImplementedException();
    }
}
