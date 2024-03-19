using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.ConsoleMessenger;

public interface IMessenger
{
    public void SendMessage(IMessage message);
    public void PrintMessage(IMessage message);
}