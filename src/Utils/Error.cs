namespace Utils;

/// <summary>
/// Ошибка
/// </summary>
public class Error(string code, string description)
{
    /// <summary>
    /// Код ошибки
    /// </summary>
    public string Code { get; } = code;

    /// <summary>
    /// Описание
    /// </summary>
    public string Description { get; } = description;
}