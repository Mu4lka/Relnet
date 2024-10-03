namespace DealApiContracts.Requests;

public class UpdateRealtorRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? PhoneNumber { get; set; }
}