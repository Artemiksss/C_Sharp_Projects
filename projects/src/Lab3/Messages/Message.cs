namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public class Message : IMessage
{
    public Message(string header, string body, int levelOfImportance)
    {
        Header = header;
        Body = body;
        LevelOfImportance = levelOfImportance;
    }

    public string Header { get;  init; }
    public string Body { get;  init; }
    public int LevelOfImportance { get;  init; }

    public Message Direct()
    {
        var builder = new MessageBuilder();
        return builder.WithHeader(Header)
            .WithBody(Body)
            .WithLevelOfImportance(LevelOfImportance)
            .Build();
    }
}