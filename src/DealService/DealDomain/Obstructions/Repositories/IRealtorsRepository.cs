using DealDomain.Entities;

namespace DealDomain.Obstructions.Repositories;

/// <summary>
/// Репозиторий риэлторов
/// </summary>
public interface IRealtorsRepository
{
    /// <summary>
    /// Создать
    /// </summary>
    Task CreateAsync(Realtor realtor);

    /// <summary>
    /// Получить всех риэлторов
    /// </summary>
    Task<ICollection<Realtor>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(Realtor realtor);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
