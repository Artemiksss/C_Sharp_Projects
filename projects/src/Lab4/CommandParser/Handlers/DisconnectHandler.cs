using Itmo.ObjectOrientedProgramming.Lab4.Status;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

public class DisconnectHandler : CommandHandler
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
        if (commandParts[0] == "disconnect")
        {
            ResultParsing("Disconnected");
            if (!TestParsing) GetFileSystemContext.TransitionTo(new Disconnected());
        }
        else
        {
            if (_nextHandler is null) throw new HandlerException();
            _nextHandler.Handle(commandParts);
        }
    }
}