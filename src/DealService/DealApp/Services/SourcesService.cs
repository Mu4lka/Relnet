using DealApiContracts.Dto;
using DealApiContracts.Requests;
using DealApp.Services.Interfaces;
using DealDomain.Abstractions.Repositories;
using Utils;


namespace DealApp.Services;

/// <summary>
/// Сервис источников
/// </summary>
public class SourcesService(ISourcesRepository _sourcesRepository) : ISourcesService
{
    public async Task<Result> CreateAsync(CreateSourceRequest request)
    {


        await _sourcesRepository.CreateAsync();
    }

    public async Task<Result> DeleteAsync(Guid id)
    {
        await _sourcesRepository.DeleteAsync(id);
        return Result.Ok();
    }

    public Task<Result<ICollection<GetSourceDto>>> GetAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Result> UpdateAsync(UpdateSourceRequest request)
    {
        throw new NotImplementedException();
    }
}
