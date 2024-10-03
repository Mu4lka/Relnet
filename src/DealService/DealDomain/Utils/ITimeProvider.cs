namespace DealDomain.Utils;

public interface ITimeProvider
{
    public DateTime UtcNow { get; }
}

public class TimeProvider : ITimeProvider
{
    public DateTime UtcNow { get => DateTime.UtcNow; }
}