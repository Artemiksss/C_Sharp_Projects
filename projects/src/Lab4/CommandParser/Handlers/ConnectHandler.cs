using Itmo.ObjectOrientedProgramming.Lab4.Status;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser;

public class ConnectHandler : CommandHandler
{
    private CommandHandler? _nextHandler;

    public override CommandHandler SetNext(CommandHandler handler)
    {
        _nextHandler = handler ?? throw new HandlerException();
        return handler;
    }

    public override void Handle(string[] commandParts)
    {
        if (commandParts is null) throw new CommandException();
        if (commandParts[0] == "connect" && commandParts.Length > 1)
        {
            ResultParsing("Connected");
            if (!TestParsing) CommandHandler.GetFileSystemContext.TransitionTo(new Connected());
        }
        else
        {
            if (_nextHandler is null) throw new HandlerException();
            _nextHandler.Handle(commandParts);
        }
    }
}