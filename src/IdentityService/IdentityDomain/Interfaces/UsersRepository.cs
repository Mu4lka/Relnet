using IdentityDomain.Entities;

namespace IdentityDomain.Interfaces;

/// <summary>
/// Репозиторий <see cref="User"/>
/// </summary>
public interface IUsersRepository
{
    /// <summary>
    /// Создать
    /// </summary>
    /// <param name="user">Пользователь</param>
    Task CreateAsync(User user);

    /// <summary>
    /// Обновить пароль
    /// </summary>
    /// <param name="userId">Идентификатор <see cref="User"/></param>
    /// <param name="passwordHash">Новый пароль</param>
    Task UpdatePasswordAsync(Guid userId, string passwordHash);
}