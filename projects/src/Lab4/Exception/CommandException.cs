using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class CommandException : Exception
{
    public CommandException()
        : base("Command not found.")
    {
    }

    public CommandException(string message)
        : base(message)
    {
    }

    public CommandException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}