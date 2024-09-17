namespace DealDomain.Entities;

/// <summary>
/// Источник, откуда сделка пришла
/// </summary>
public class Source
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Название
    /// </summary>
    public string Title { get; set; } = default!;

    /// <summary>
    /// Ссылка
    /// </summary>
    public string? Url { get; set; }
}
