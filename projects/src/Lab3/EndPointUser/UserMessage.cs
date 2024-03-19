using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.EndPointUser;

public class UserMessage
{
    private MessageStatus _messageStatus;
    public UserMessage(IMessage message)
    {
        Message = message;
        _messageStatus = MessageStatus.Unread;
    }

    public MessageStatus GetMessageStatus => _messageStatus;
    public IMessage Message { get; }

    public void Read()
    {
        if (_messageStatus == MessageStatus.Read) throw new MessageStatusException();
        _messageStatus = MessageStatus.Read;
    }
}