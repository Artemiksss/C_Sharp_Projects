using Itmo.ObjectOrientedProgramming.Lab3.Addressees;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Filter;

public class FilterProxy : IRecipient
{
    private readonly IRecipient _recipient;
    private readonly int _importanceLevel;
    public FilterProxy(IRecipient recipient, int importanceLevel)
    {
        _recipient = recipient;
        _importanceLevel = importanceLevel;
    }

    public void SendMessage(IMessage message)
    {
        if (message.LevelOfImportance == _importanceLevel)
        {
            _recipient.SendMessage(message);
        }
    }
}