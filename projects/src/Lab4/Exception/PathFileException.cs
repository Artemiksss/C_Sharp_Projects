using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class PathFileException : Exception
{
    public PathFileException()
        : base("File opening error.")
    {
    }

    public PathFileException(string message)
        : base(message)
    {
    }

    public PathFileException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}