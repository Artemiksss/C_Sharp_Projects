namespace Lab5.Application.Exception;

public class UserInDataBaseException : System.Exception
{
    public UserInDataBaseException()
        : base("The user is not in the database")
    {
    }

    public UserInDataBaseException(string message)
        : base(message)
    {
    }

    public UserInDataBaseException(string message, System.Exception innerException)
        : base(message, innerException)
    {
    }
}