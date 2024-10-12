using IdentityApp.Params;
using Infrastructure.Auth;
using Utils;

namespace IdentityApp.Services;


public class UserService : IUserService
{
    public Task<Result> ChangePasswordAsync(ChangePasswordParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<Result<AuthToken>> LoginAsync(LoginParams @params)
    {
        throw new NotImplementedException();
    }

    public Task<Result> RegisterAsync(RegisterParams @params)
    {
        throw new NotImplementedException();
    }
}
