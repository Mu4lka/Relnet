using DealApiContracts.Dto.Source;
using DealApp.Services.Interfaces;

namespace DealApp.Services;

public class SourcesService : ISourcesService
{
    public Task CreateAsync(CreateSourceDto realtor)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<ICollection<GetSourceDto>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(UpdateSourceDto realtor)
    {
        throw new NotImplementedException();
    }
}
