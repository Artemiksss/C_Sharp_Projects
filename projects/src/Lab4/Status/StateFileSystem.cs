namespace Itmo.ObjectOrientedProgramming.Lab4.Status;

public abstract class StateFileSystem
{
    public LocalFileSystemContext? Context { get; protected set; }
    public FilePath? CurrentPath { get; protected set; }

    public void SetContext(LocalFileSystemContext context)
    {
        this.Context = context;
    }

    public abstract void Connect(string path);
    public abstract void Disconnect();
    public abstract void FileShow(string path, string mode);
    public abstract void TreeGoTo(string path);
    public abstract void TreeList(string depth);
    public abstract void FileMove(string sourcePath, string destinationPath);
    public abstract void FileCopy(string sourcePath, string destinationPath);
    public abstract void FileDelete(string path);
    public abstract void FileRename(string path, string newName);
}