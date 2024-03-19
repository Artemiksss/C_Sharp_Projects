using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.EndPointUser;

public interface IUser
{
    public void SendMessage(IMessage message);
}