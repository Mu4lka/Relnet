namespace Infrastructure.Auth;

public class AuthToken(string value)
{
    public string Value { get; } = value;
}