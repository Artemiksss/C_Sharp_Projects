using Itmo.ObjectOrientedProgramming.Lab3.DisplayForMessage;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class RecipientDisplay : IRecipient
{
    private readonly IDisplay _display;
    public RecipientDisplay(IDisplay display)
    {
        _display = display;
    }

    public void SendMessage(IMessage message)
    {
        _display.PrintMessage(message);
    }
}