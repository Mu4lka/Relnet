using DealApiContracts.Dto.Deal;

namespace DealApiContracts.Requests;

public class CreateDealRequest
{
    public CreateDealDto Deal { get; set; } = default!;
}
