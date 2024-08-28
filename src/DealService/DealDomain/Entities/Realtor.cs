namespace DealDomain.Entities;

public class Realtor
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? PhoneNumber { get; set; }
}
