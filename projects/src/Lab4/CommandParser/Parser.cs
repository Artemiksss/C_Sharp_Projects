using Itmo.ObjectOrientedProgramming.Lab4.CommandParser.Handlers;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser;

public class Parser : IParser
{
    private CommandHandler? _handler;

    public Parser(int status)
    {
        if (status == 0)
        {
            InitializeHandlers();
        }
        else
        {
            CommandHandler.ActivateTest();
            InitializeHandlers();
        }
    }

    public void Parsing(string command)
    {
        if (command is null) throw new CommandException();
        if (_handler is null) throw new CommandException();
        string[] commandParts = command.Split(' ');
        _handler.Handle(commandParts);
    }

    private void InitializeHandlers()
    {
        var connectHandler = new ConnectHandler();
        var disconnectHandler = new DisconnectHandler();
        var fileCopyHandler = new FileCopyHandler();
        var fileDeleterHandler = new FileDeleteHandler();
        var fileMoveHandler = new FileMoveHandler();
        var fileRenameHandler = new FileRenameHandler();
        var fileShowHandler = new FileShowHandler();
        var treeGoToHandler = new TreeGoToHandler();
        var treeListHandler = new TreeListHandler();
        connectHandler.SetNext(disconnectHandler).SetNext(fileCopyHandler).SetNext(fileDeleterHandler).SetNext(fileMoveHandler).SetNext(fileRenameHandler).SetNext(fileShowHandler).SetNext(treeGoToHandler).SetNext(treeListHandler);

        _handler = connectHandler;
    }
}