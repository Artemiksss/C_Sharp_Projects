using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class RecipientGroup : IRecipient
{
    private readonly ICollection<IRecipient> _recipients;
    public RecipientGroup(ICollection<IRecipient> recipients)
    {
        _recipients = recipients;
    }

    public void SendMessage(IMessage message)
    {
        foreach (IRecipient recipient in _recipients)
        {
            recipient.SendMessage(message);
        }
    }
}