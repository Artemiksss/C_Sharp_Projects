using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public interface IRecipient
{
    public void SendMessage(IMessage message);
}