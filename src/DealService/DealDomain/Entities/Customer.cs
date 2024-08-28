namespace DealDomain.Entities;

public class Customer
{
    public Guid Id { get; set; }
    public string? FullName { get; set; }
    public string PhoneNumber { get; set; } = default!;
    public string? Address { get; set; }
    public string? City { get; set; }
}