namespace Itmo.ObjectOrientedProgramming.Lab4.Status;

public interface IFileSystemContext
{
    public void TransitionTo(StateFileSystem state);
    public void RequestConnect(string path);
    public void RequestDisconnect();
    public void RequestFileShow(string path, string mode);
    public void RequestTreeGoTo(string path);
    public void RequestTreeList(string depth);
    public void RequestFileMove(string sourcePath, string destinationPath);
    public void RequestFileCopy(string sourcePath, string destinationPath);
    public void RequestFileDelete(string path);
    public void RequestFileRename(string path, string newName);
}