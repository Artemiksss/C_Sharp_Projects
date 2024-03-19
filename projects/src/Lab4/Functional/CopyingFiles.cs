using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class CopyingFiles : ICommand
{
    private readonly string _path;
    private readonly string _newPath;
    public CopyingFiles(string path, string newPath)
    {
        _path = path;
        _newPath = newPath;
    }

    public void Execute()
    {
        if (File.Exists(_path) == false || File.Exists(_newPath) == false) throw new PathFileException();
        File.Copy(_path, _newPath, true);
    }
}