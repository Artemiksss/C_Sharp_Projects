using System;
using Itmo.ObjectOrientedProgramming.Lab3.Addressees;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageLogger;

public class ConsoleLogger : DefaultLogger
{
    public ConsoleLogger(IRecipient recipient)
        : base(recipient)
    {
    }

    protected override void Logging(string message)
    {
        Console.WriteLine(message);
    }
}