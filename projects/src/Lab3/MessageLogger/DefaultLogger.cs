using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageLogger;

public abstract class DefaultLogger : IRecipient
{
    private readonly IRecipient _recipient;

    protected DefaultLogger(IRecipient recipient)
    {
        _recipient = recipient;
    }

    public void SendMessage(IMessage message)
    {
        _recipient.SendMessage(message);
        Logging($"Message {message.Header + message.Body} sent");
    }

    protected abstract void Logging(string message);
}