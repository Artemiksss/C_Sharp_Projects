using Itmo.ObjectOrientedProgramming.Lab4.Status;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

public interface ICommandHandler
{
    IFileSystemContext FileSystemContext { get; protected set; }
    ICommandHandler SetNext(ICommandHandler handler);
    void Handle(string[] commandParts);
}