using DealDomain.Entities;

namespace DealDomain.Obstructions.Repositories;

/// <summary>
/// Репозиторий сделок
/// </summary>
public interface IDealsRepository
{
    /// <summary>
    /// Создать
    /// </summary>
    Task CreateAsync(Deal deal);

    /// <summary>
    /// Получить сделки по фильтру
    /// </summary>
    Task<ICollection<Deal>> GetByFilterAsync(DealFilter filter);

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(Deal deal);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
