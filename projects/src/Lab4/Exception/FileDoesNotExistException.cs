using System;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileDoesNotExistException : Exception
{
    public FileDoesNotExistException()
        : base("The file is not in the directory.")
    {
    }

    public FileDoesNotExistException(string message)
        : base(message)
    {
    }

    public FileDoesNotExistException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}