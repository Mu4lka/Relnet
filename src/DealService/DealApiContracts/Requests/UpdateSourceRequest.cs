namespace DealApiContracts.Requests;

public class UpdateSourceRequest
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string? Url { get; set; }
}