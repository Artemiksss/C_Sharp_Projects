namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

public class FileDeleteHandler : CommandHandler
{
    private CommandHandler? _nextHandler;
    private string? _path;

    public override CommandHandler SetNext(CommandHandler handler)
    {
        _nextHandler = handler ?? throw new HandlerException();
        return handler;
    }

    public override void Handle(string[] commandParts)
    {
        if (commandParts is null) throw new CommandException();
        if (commandParts[0] == "file" && commandParts[1] == "delete" && commandParts.Length > 2)
        {
            _path = commandParts[2];
            ResultParsing(_path);
            if (!TestParsing) GetFileSystemContext.RequestFileDelete(commandParts[2]);
        }
        else
        {
            if (_nextHandler is null) throw new HandlerException();
            _nextHandler.Handle(commandParts);
        }
    }
}