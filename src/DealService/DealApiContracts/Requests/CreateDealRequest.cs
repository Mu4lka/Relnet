namespace DealApiContracts.Requests;

public class CreateDealRequest
{
    public string? CustomerFullName { get; set; }
    public string CustomerPhoneNumber { get; set; } = default!;
    public string? CustomerCity { get; set; }
    public string? CustomerAddress { get; set; }
    public string? Provider { get; set; }
    public string? Tariff { get; set; }
    public string? AdditionalInformation { get; set; }
    public int? NumberOfServices { get; set; }
    public Guid? RealtorId { get; set; }
    public Guid SourceId { get; set; }
    public decimal Payment { get; set; }
    public Guid ResponsibleUserId { get; set; }
}
