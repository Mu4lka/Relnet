namespace IdentityDomain.Entities;

public class User
{
    public Guid Id { get; set; }
    public string FullName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
}
