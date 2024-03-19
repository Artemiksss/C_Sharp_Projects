using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Filter;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.MessageTopic;

public class Topic : ITopic
{
    private readonly IRecipient _recipient;
    private readonly FilterProxy _filterProxy;
    public Topic(IRecipient recipient, FilterProxy filterProxy)
    {
        _recipient = recipient;
        _filterProxy = filterProxy;
    }

    public void Send(IMessage message)
    {
        _filterProxy.SendMessage(message);
    }
}