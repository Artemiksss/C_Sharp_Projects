using System;

namespace Itmo.ObjectOrientedProgramming.Lab2;

public class ComputerComponentNullException : Exception
{
    public ComputerComponentNullException()
        : base("A computer component is null.")
    {
    }

    public ComputerComponentNullException(string message)
        : base(message)
    {
    }

    public ComputerComponentNullException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}