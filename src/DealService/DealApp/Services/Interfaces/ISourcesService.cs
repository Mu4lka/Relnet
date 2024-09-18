using DealApiContracts.Dto.Source;

namespace DealApp.Services.Interfaces;

/// <summary>
/// Сервис источников
/// </summary>
public interface ISourcesService
{
    /// <summary>
    /// Создать
    /// </summary>
    Task CreateAsync(CreateSourceDto realtor);

    /// <summary>
    /// Получить все источники
    /// </summary>
    Task<ICollection<GetSourceDto>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(UpdateSourceDto realtor);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
