using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class ConnectionErrorException : Exception
{
    public ConnectionErrorException()
        : base("File system connection error.")
    {
    }

    public ConnectionErrorException(string message)
        : base(message)
    {
    }

    public ConnectionErrorException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}