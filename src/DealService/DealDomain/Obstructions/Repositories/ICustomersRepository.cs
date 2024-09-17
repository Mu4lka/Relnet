using DealDomain.Entities;

namespace DealDomain.Obstructions.Repositories;

/// <summary>
/// Репозиторий клиентов
/// </summary>
public interface ICustomersRepository
{
    /// <summary>
    /// Создать
    /// </summary>
    Task CreateAsync(Customer customer);

    /// <summary>
    /// Получить всех клиентов
    /// </summary>
    Task<ICollection<Customer>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(Customer customer);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
