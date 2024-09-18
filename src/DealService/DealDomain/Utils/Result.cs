namespace DealDomain.Utils;

public class Result
{

}

public class Result<TData> : Result
{
    public TData Data { get; set; }
}
