namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

public class TreeListHandler : CommandHandler
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
        if (commandParts[0] == "tree" && commandParts[1] == "list" && commandParts.Length > 3)
        {
            _path = commandParts[3];
            CommandHandler.GetFileSystemContext.RequestTreeList(_path);
        }
        else
        {
            if (_nextHandler is null) throw new HandlerException();
            _nextHandler.Handle(commandParts);
        }
    }
}