using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class HandlerException : Exception
{
    public HandlerException()
        : base("The handler doesn't matter.")
    {
    }

    public HandlerException(string message)
        : base(message)
    {
    }

    public HandlerException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}