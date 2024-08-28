namespace DealDomain.Entities;

public class Deal
{
    public Guid Id { get; set; }
    public DateTime CreatedTime { get; set; }
    public string Status { get; set; } = default!;
    public Guid? CustomerId { get; set; }
    public Customer? Customer { get; set; }
    public string? Provider { get; set; }
    public string? Tariff { get; set; }
    public string? AdditionalInformation { get; set; }
    public int? NumberOfServices { get; set; }
    public Guid? RealtorId { get; set; }
    public Realtor? Realtor { get; set; }
    public Guid SourceId { get; set; }
    public Source Source { get; set; } = default!;
    public decimal Payment { get; set; }
    public Guid ResponsibleUserId { get; set; }
}
