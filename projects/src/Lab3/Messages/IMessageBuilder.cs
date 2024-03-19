namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public interface IMessageBuilder
{
    public MessageBuilder WithHeader(string header);
    public MessageBuilder WithBody(string body);
    public MessageBuilder WithLevelOfImportance(int levelOfImportance);
    public Message Build();
}