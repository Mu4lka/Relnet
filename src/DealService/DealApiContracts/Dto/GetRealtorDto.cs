namespace DealApiContracts.Dto;

public class GetRealtorDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    public string? PhoneNumber { get; set; }
}