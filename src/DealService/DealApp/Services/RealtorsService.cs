using DealApiContracts.Dto.Realtor;
using DealApp.Services.Interfaces;

namespace DealApp.Services;

public class RealtorsService : IRealtorsService
{
    public Task CreateAsync(CreateRealtorDto realtor)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GetRealtorDto>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateRealtorDto realtor)
    {
        throw new NotImplementedException();
    }
}
