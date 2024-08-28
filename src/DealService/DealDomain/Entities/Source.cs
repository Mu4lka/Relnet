namespace DealDomain.Entities;

public class Source
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string? Url { get; set; }
}
