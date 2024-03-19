using System.Data;
namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class MessageBuilder : IMessageBuilder
{
    private string? _header;
    private string? _body;
    private int _levelOfImportance

    public MessageBuilder WithHeader(string header)
    {
        _header = header;
        return this;
    }

    public MessageBuilder WithBody(string body)
    {
        _body = body;
        return this;
    }

    public MessageBuilder WithLevelOfImportance(int levelOfImportance)
    {
        _levelOfImportance = levelOfImportance;
        return this;
    }

    public Messages.Message Build()
    {
        return new Messages.Message(
            _header ?? throw new DataException(),
            _body ?? throw new DataException(),
            _levelOfImportance);
    }
}