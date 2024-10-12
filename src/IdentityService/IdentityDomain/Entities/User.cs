namespace IdentityDomain.Entities;

/// <summary>
/// Пользователь
/// </summary>
public class User
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Имя пользователя
    /// </summary>
    public string UserName { get; set; } = default!;

    /// <summary>
    /// Хэшированный пароль
    /// </summary>
    public string PasswordHash { get; set; } = default!;
}
