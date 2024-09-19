using DealApiContracts.Dto.Deal;
using DealDomain;
using DealDomain.Utils;

namespace DealApp.Services.Interfaces;

/// <summary>
/// Сервис сделок
/// </summary>
public interface IDealsService
{
    /// <summary>
    /// Создать
    /// </summary>
    Task<Result> CreateAsync(CreateDealDto deal);

    /// <summary>
    /// Получить сделки по фильтру
    /// </summary>
    Task<Result<ICollection<GetDealDto>>> GetByFilterAsync(DealFilter filter);

    /// <summary>
    /// Обновить
    /// </summary>
    Task<Result> UpdateAsync(UpdateDealDto deal);

    /// <summary>
    /// Удалить
    /// </summary>
    Task<Result> DeleteAsync(Guid id);
}
