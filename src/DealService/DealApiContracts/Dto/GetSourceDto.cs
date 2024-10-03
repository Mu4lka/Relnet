namespace DealApiContracts.Dto;

public class GetSourceDto
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public string? Url { get; set; }
}