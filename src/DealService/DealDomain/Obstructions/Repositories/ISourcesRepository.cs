using DealDomain.Entities;

namespace DealDomain.Obstructions.Repositories;

/// <summary>
/// Репозиторий источников
/// </summary>
public interface ISourcesRepository
{
    /// <summary>
    /// Создать
    /// </summary>
    Task CreateAsync(Source source);

    /// <summary>
    /// Получить все источники
    /// </summary>
    Task<ICollection<Source>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(Source source);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
