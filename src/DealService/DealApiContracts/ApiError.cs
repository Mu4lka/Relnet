namespace DealApiContracts;

public class ApiError(string message, string desctiption)
{
    public string Message { get; set; } = message;
    public string Desctiption { get; set; } = desctiption;
}