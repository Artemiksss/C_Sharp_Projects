using System.Data;

namespace Itmo.ObjectOrientedProgramming.Lab4.Status;

public class Disconnected : StateFileSystem
{
    public override void Connect(string path)
    {
        if (Context is null) throw new DataException();
        this.Context.TransitionTo(new Connected());
        if (CurrentPath is null) throw new PathFileException();
        CurrentPath.SetMainPath(path);
    }

    public override void Disconnect()
    {
        throw new ConnectionErrorException();
    }

    public override void FileShow(string path, string mode)
    {
        throw new ConnectionErrorException();
    }

    public override void TreeGoTo(string path)
    {
        throw new ConnectionErrorException();
    }

    public override void TreeList(string depth)
    {
        throw new ConnectionErrorException();
    }

    public override void FileMove(string sourcePath, string destinationPath)
    {
        throw new ConnectionErrorException();
    }

    public override void FileCopy(string sourcePath, string destinationPath)
    {
        throw new ConnectionErrorException();
    }

    public override void FileDelete(string path)
    {
        throw new ConnectionErrorException();
    }

    public override void FileRename(string path, string newName)
    {
        throw new ConnectionErrorException();
    }
}