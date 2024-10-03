namespace DealApiContracts.Requests;

public class UpdateDealStatusRequest
{
    public Guid DealId { get; set; }
    public byte DealStatus { get; set; }
}
