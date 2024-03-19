using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageTopic;

public interface ITopic
{
    public void Send(IMessage message);
}