using System.Data;
using System.Globalization;
using Itmo.ObjectOrientedProgramming.Lab4.Functional;

namespace Itmo.ObjectOrientedProgramming.Lab4.Status;

public class Connected : StateFileSystem
{
    private readonly CommandInvoker _invoker = new CommandInvoker();
    public override void Connect(string path)
    {
        throw new ConnectionErrorException();
    }

    public override void Disconnect()
    {
        if (Context is null) throw new DataException();
        this.Context.TransitionTo(new Disconnected());
        CurrentPath = null;
    }

    public override void FileShow(string path, string mode)
    {
        if (mode == "console")
        {
            _invoker.SetCommand(new ShowContentsFiles(path));
            _invoker.ExecuteCommand();
        }
    }

    public override void TreeGoTo(string path)
    {
        if (CurrentPath is null) throw new PathFileException();
        CurrentPath.SetMainPath(path);
    }

    public override void TreeList(string depth)
    {
        if (CurrentPath is null) throw new PathFileException();
        CurrentPath.SetDepth(int.Parse(depth, new CultureInfo(depth)));
    }

    public override void FileMove(string sourcePath, string destinationPath)
    {
        _invoker.SetCommand(new MovingFiles(sourcePath, destinationPath));
        _invoker.ExecuteCommand();
    }

    public override void FileCopy(string sourcePath, string destinationPath)
    {
        _invoker.SetCommand(new CopyingFiles(sourcePath, destinationPath));
        _invoker.ExecuteCommand();
    }

    public override void FileDelete(string path)
    {
        _invoker.SetCommand(new DeletingFiles(path));
        _invoker.ExecuteCommand();
    }

    public override void FileRename(string path, string newName)
    {
        _invoker.SetCommand(new RenamingFiles(path, newName));
        _invoker.ExecuteCommand();
        if (CurrentPath is null) throw new PathFileException();
        CurrentPath.SetFileName(newName);
    }
}