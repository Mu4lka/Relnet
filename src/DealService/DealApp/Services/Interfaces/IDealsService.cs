using DealApiContracts.Dto.Deal;
using DealDomain;

namespace DealApp.Services.Interfaces;

/// <summary>
/// Сервис сделок
/// </summary>
public interface IDealsService
{
    /// <summary>
    /// Создать
    /// </summary>
    Task CreateAsync(CreateDealDto deal);

    /// <summary>
    /// Получить сделки по фильтру
    /// </summary>
    Task<ICollection<GetDealDto>> GetByFilterAsync(DealFilter filter);

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(UpdateDealDto deal);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
