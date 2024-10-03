namespace DealApiContracts.Requests;

public class CreateRealtorRequest
{
    public string Name { get; set; } = default!;
    public string? PhoneNumber { get; set; }
}
