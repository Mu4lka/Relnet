using DealApiContracts.Dto.Realtor;

namespace DealApp.Services.Interfaces;

/// <summary>
/// Сервис риелторов
/// </summary>
public interface IRealtorsService
{
    /// <summary>
    /// Создать
    /// </summary>
    Task CreateAsync(CreateRealtorDto realtor);

    /// <summary>
    /// Получить всех риэлторов
    /// </summary>
    Task<ICollection<GetRealtorDto>> GetAsync();

    /// <summary>
    /// Обновить
    /// </summary>
    Task UpdateAsync(UpdateRealtorDto realtor);

    /// <summary>
    /// Удалить
    /// </summary>
    Task DeleteAsync(Guid id);
}
