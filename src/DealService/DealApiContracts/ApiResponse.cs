namespace DealApiContracts;

public class ApiResponse
{
    public bool Success { get; set; }
    public string Code { get; set; }
    public ApiError[]? Errors { get; set; }

    public static ApiResponse Ok()
        => new() { Success = true };

    public static ApiResponse<TData> Ok<TData>(TData data)
        => new() { Success = true, Data = data };

    public static ApiResponse Fail(ApiError[] errors)
        => new() { Success = false, Errors = errors };
}

public class ApiResponse<TData> : ApiResponse
{
    public TData? Data { get; set; }
}