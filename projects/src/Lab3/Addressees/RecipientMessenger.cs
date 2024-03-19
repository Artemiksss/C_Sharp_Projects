using Itmo.ObjectOrientedProgramming.Lab3.ConsoleMessenger;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class RecipientMessenger : IRecipient
{
    private readonly IMessenger _messenger;

    public RecipientMessenger(IMessenger messenger)
    {
        _messenger = messenger;
    }

    public void SendMessage(IMessage message)
    {
        _messenger.SendMessage(message);
    }
}