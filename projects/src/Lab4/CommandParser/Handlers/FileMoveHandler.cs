namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

public class FileMoveHandler : CommandHandler
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
        if (commandParts[0] == "file" && commandParts[1] == "move" && commandParts.Length > 3)
        {
            _path = commandParts[2];
            ResultParsing(_path + " " + commandParts[3]);
            if (!TestParsing) GetFileSystemContext.RequestFileMove(commandParts[2], commandParts[3]);
        }
        else
        {
            if (_nextHandler is null) throw new HandlerException();
            _nextHandler.Handle(commandParts);
        }
    }
}