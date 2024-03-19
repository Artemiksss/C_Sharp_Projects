using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.EndPointUser;

public class User : IUser
{
    private readonly List<UserMessage> _messages = new List<UserMessage>();
    public User(string name)
    {
        Name = name;
        Id = Guid.NewGuid().ToString("N");
    }

    public IList<UserMessage> Messages => _messages;
    public string? Name { get; private set; }
    public string Id { get; private set; }

    public void SendMessage(IMessage message)
    {
        _messages.Add(new UserMessage(message));
    }

    public void Read(IMessage messageForRead)
    {
        int index = _messages.FindIndex(t => t.Message == messageForRead);
        if (_messages[index].GetMessageStatus == MessageStatus.Read) throw new MessageStatusException();
        _messages[index].Read();
    }
}