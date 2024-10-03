using DealDomain.Entities;
using DealDomain.Enums;

namespace DealDomain.Obstructions.Repositories;

/// <summary>
/// Репозиторий сделок
/// </summary>
public interface IDealsRepository
{
    /// <summary>
    /// Создать
    /// </summary>
    Task<Guid> CreateAsync(Deal deal);

    /// <summary>
    /// Получить сделки по фильтру
    /// </summary>
    Task<ICollection<Deal>> GetByFilterAsync(DealFilter filter);

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(Deal deal);

    /// <summary>
    /// Обновить статус
    /// </summary>
    Task UpdateStatusAsync(Guid dealId, DealStatus status);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
