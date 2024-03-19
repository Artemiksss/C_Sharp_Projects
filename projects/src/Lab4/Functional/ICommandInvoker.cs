namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public interface ICommandInvoker
{
    public void SetCommand(ICommand command);
    public void ExecuteCommand();
}