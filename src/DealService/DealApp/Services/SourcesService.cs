using DealApiContracts.Dto.Source;
using DealApp.Services.Interfaces;
using DealDomain.Obstructions.Repositories;
using DealDomain.Utils;

namespace DealApp.Services;

/// <summary>
/// Сервис источников
/// </summary>
public class SourcesService(ISourcesRepository _sourcesRepository) : ISourcesService
{
    public Task<Result> CreateAsync(CreateSourceDto realtor)
    {
        throw new NotImplementedException();
    }

    public Task<Result> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Result<ICollection<GetSourceDto>>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Result> UpdateAsync(UpdateSourceDto realtor)
    {
        throw new NotImplementedException();
    }
}
