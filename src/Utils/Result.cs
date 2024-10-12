namespace Utils;

/// <summary>
/// Результат
/// </summary>
public class Result
{
    /// <summary>
    /// Успешен ли
    /// </summary>
    public bool Success { get; set; }

    /// <summary>
    /// Ошибки
    /// </summary>
    public Error[]? Errors { get; set; }

    public static Result Ok()
       => new() { Success = true };

    public static Result<TData> Ok<TData>(TData data)
        => new() { Success = true, Data = data };

    public static Result Fail(Error[] errors)
        => new() { Success = false, Errors = errors };

    public static Result<TData> Fail<TData>(Error[] errors)
        => new() { Success = false, Errors = errors };
}

/// <summary>
/// Результат с возращающими данными
/// </summary>
/// <typeparam name="TData">Данные</typeparam>
public class Result<TData> : Result
{
    /// <summary>
    /// Данные
    /// </summary>
    public TData? Data { get; set; }
}
