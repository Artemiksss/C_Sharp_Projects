using Itmo.ObjectOrientedProgramming.Lab3.EndPointUser;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class RecipientUser : IRecipient
{
    private readonly User _user;
    public RecipientUser(User user)
    {
        _user = user;
    }

    public void SendMessage(IMessage message)
    {
        _user.SendMessage(message);
    }
}