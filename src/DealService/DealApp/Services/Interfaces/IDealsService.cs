using DealApiContracts.Dto;
using DealApiContracts.Requests;
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
    Task<Result<Guid>> CreateAsync(CreateDealRequest request);

    /// <summary>
    /// Получить сделки по фильтру
    /// </summary>
    Task<Result<ICollection<GetDealDto>>> GetByFilterAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task<Result> UpdateAsync(UpdateDealRequest request);

    /// <summary>
    /// Обновить
    /// </summary>
    Task<Result> UpdateStatusAsync(UpdateDealStatusRequest request);

    /// <summary>
    /// Удалить
    /// </summary>
    Task<Result> DeleteAsync(Guid id);
}
