using DealApiContracts.Dto.Source;
using DealDomain.Utils;

namespace DealApp.Services.Interfaces;

/// <summary>
/// Сервис источников
/// </summary>
public interface ISourcesService
{
    /// <summary>
    /// Создать
    /// </summary>
    Task<Result> CreateAsync(CreateSourceDto realtor);

    /// <summary>
    /// Получить все источники
    /// </summary>
    Task<Result<ICollection<GetSourceDto>>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task<Result> UpdateAsync(UpdateSourceDto realtor);

    /// <summary>
    /// Удалить
    /// </summary>
    Task<Result> DeleteAsync(Guid id);
}
