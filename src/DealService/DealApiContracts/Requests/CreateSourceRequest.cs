namespace DealApiContracts.Requests;

public class CreateSourceRequest
{
    public string Title { get; set; } = default!;
    public string? Url { get; set; }
}
