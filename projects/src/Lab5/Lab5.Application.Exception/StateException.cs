namespace Lab5.Application.Exception;

public class StateException : System.Exception
{
    public StateException()
        : base("The condition is unsuitable for this operation.")
    {
    }

    public StateException(string message)
        : base(message)
    {
    }

    public StateException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }
}