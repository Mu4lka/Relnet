using DealApiContracts.Dto.Realtor;
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
    Task<Result> CreateAsync(CreateRealtorDto realtor);

    /// <summary>
    /// Получить всех риэлторов
    /// </summary>
    Task<Result<ICollection<GetRealtorDto>>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task<Result> UpdateAsync(UpdateRealtorDto realtor);

    /// <summary>
    /// Удалить
    /// </summary>
    Task<Result> DeleteAsync(Guid id);
}
