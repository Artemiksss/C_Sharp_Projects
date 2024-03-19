using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

public class MessageStatusException : Exception
{
    public MessageStatusException()
        : base("The message has already been read.")
    {
    }

    public MessageStatusException(string message)
        : base(message)
    {
    }

    public MessageStatusException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}