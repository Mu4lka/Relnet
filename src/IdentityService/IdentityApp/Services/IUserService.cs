using IdentityApp.Params;
using Infrastructure.Auth;
using Utils;

namespace IdentityApp.Services;

/// <summary>
/// Сервис пользователей
/// </summary>
public interface IUserService
{
    /// <summary>
    /// Зарегистрироваться
    /// </summary>
    Task<Result> RegisterAsync(RegisterParams @params);

    /// <summary>
    /// Авторизоваться
    /// </summary>
    Task<Result<AuthToken>> LoginAsync(LoginParams @params);

    /// <summary>
    /// Изменить пароль
    /// </summary>
    Task<Result> ChangePasswordAsync(ChangePasswordParams @params);
}
