using DealApiContracts.Dto;
using DealApiContracts.Requests;
using DealDomain.Utils;

namespace DealApp.Services.Interfaces;

/// <summary>
/// Сервис риелторов
/// </summary>
public interface IRealtorsService
{
    /// <summary>
    /// Создать
    /// </summary>
    Task<Result> CreateAsync(CreateRealtorRequest request);

    /// <summary>
    /// Получить всех риэлторов
    /// </summary>
    Task<Result<ICollection<GetRealtorDto>>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task<Result> UpdateAsync(UpdateRealtorRequest request);

    /// <summary>
    /// Удалить
    /// </summary>
    Task<Result> DeleteAsync(Guid id);
}
