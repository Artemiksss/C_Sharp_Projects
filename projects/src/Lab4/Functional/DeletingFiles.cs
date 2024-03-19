using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class DeletingFiles : ICommand
{
    private readonly string _path;
    public DeletingFiles(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (File.Exists(_path) == false) throw new FileDoesNotExistException();
        File.Delete(_path);
    }
}