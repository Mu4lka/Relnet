namespace Infrastructure.Auth;

public interface IPasswordHasher
{
    string Hash(string password);
    string Verify(string password, string passwordHash);
}
