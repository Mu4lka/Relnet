namespace DealApiContracts.Dto;

public class GetDealDto
{
    public Guid Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public byte Status { get; set; }
    public string? CustomerFullName { get; set; }
    public string CustomerPhoneNumber { get; set; } = default!;
    public string? CustomerCity { get; set; }
    public string? CustomerAddress { get; set; }
    public string? Provider { get; set; }
    public string? Tariff { get; set; }
    public string? AdditionalInformation { get; set; }
    public int? NumberOfServices { get; set; }
    public GetRealtorDto? Realtor { get; set; }
    public GetSourceDto Source { get; set; } = default!;
    public decimal Payment { get; set; }
    public Guid ResponsibleUserId { get; set; }
}
