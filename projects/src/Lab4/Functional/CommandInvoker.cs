namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class CommandInvoker : ICommandInvoker
{
    private ICommand? _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void ExecuteCommand()
    {
        if (_command is null) throw new CommandException();
        _command.Execute();
    }
}