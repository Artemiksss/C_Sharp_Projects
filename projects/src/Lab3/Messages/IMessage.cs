namespace Itmo.ObjectOrientedProgramming.Lab3.Messages;

public interface IMessage
{
    public string Header { get; protected init; }
    public string Body { get; protected init; }
    public int LevelOfImportance { get; protected init; }
    public Message Direct();
}