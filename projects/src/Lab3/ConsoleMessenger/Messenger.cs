using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.ConsoleMessenger;

public class Messenger : IMessenger
{
    private readonly ICollection<IMessage> _messages = new List<IMessage>();

    public void SendMessage(IMessage message)
    {
        _messages.Add(message);
    }

    public void PrintMessage(IMessage message)
    {
        Console.WriteLine("Messenger: " + message.Body);
    }
}