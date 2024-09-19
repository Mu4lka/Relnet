namespace DealDomain.Enums;

/// <summary>
/// Статус сделки
/// </summary>
public enum DealStatus : byte
{
    /// <summary>
    /// Новая
    /// </summary>
    New = 0,

    /// <summary>
    /// В роботе
    /// </summary>
    InProgress,

    /// <summary>
    /// Позвонить позже
    /// </summary>
    CallLater,

    /// <summary>
    /// На доработку
    /// </summary>
    Finalize,

    /// <summary>
    /// Сделана
    /// </summary>
    Done,

    /// <summary>
    /// Заведена
    /// </summary>
    Started,

    /// <summary>
    /// Подключается
    /// </summary>
    Connects,

    /// <summary>
    /// Подключена
    /// </summary>
    Connected,

    /// <summary>
    /// Оплачена
    /// </summary>
    Paid,

    /// <summary>
    /// Удалена
    /// </summary>
    Deleted = 100
}