namespace Itmo.ObjectOrientedProgramming.Lab4.Status;

public class LocalFileSystemContext : IFileSystemContext
{
    private StateFileSystem _state;

    public LocalFileSystemContext(StateFileSystem state)
    {
        _state = state;
    }

    public void TransitionTo(StateFileSystem state)
    {
        this._state = state;
        this._state.SetContext(this);
    }

    public void RequestConnect(string path)
    {
        this._state.Connect(path);
    }

    public void RequestDisconnect()
    {
        this._state.Disconnect();
    }

    public void RequestFileShow(string path, string mode)
    {
        this._state.FileShow(path, mode);
    }

    public void RequestTreeGoTo(string path)
    {
        this._state.TreeGoTo(path);
    }

    public void RequestTreeList(string depth)
    {
        this._state.TreeList(depth);
    }

    public void RequestFileMove(string sourcePath, string destinationPath)
    {
        this._state.FileMove(sourcePath, destinationPath);
    }

    public void RequestFileCopy(string sourcePath, string destinationPath)
    {
        this._state.FileCopy(sourcePath, destinationPath);
    }

    public void RequestFileDelete(string path)
    {
        this._state.FileDelete(path);
    }

    public void RequestFileRename(string path, string newName)
    {
        this._state.FileRename(path, newName);
    }
}