using DealApiContracts.Dto;
using DealApiContracts.Requests;
using Utils;

namespace DealApp.Services.Interfaces;

/// <summary>
/// Сервис источников
/// </summary>
public interface ISourcesService
{
    /// <summary>
    /// Создать
    /// </summary>
    Task<Result> CreateAsync(CreateSourceRequest request);

    /// <summary>
    /// Получить все источники
    /// </summary>
    Task<Result<ICollection<GetSourceDto>>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task<Result> UpdateAsync(UpdateSourceRequest request);

    /// <summary>
    /// Удалить
    /// </summary>
    Task<Result> DeleteAsync(Guid id);
}
