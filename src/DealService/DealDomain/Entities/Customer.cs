namespace DealDomain.Entities;

/// <summary>
/// Клиент
/// </summary>
public class Customer
{
    /// <summary>
    /// Идентификатор клиента
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Полное время
    /// </summary>
    public string? FullName { get; set; }
    
    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; } = default!;

    /// <summary>
    /// Город
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// Адрес
    /// </summary>
    public string? Address { get; set; }
}