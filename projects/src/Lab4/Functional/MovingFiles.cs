using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class MovingFiles : ICommand
{
    private readonly string _path;
    private readonly string _fileName;
    private readonly string _newPath;
    public MovingFiles(string path, string newPath)
    {
        _path = path;
        _fileName = Path.GetFileName(path);
        _newPath = newPath;
    }

    public void Execute()
    {
        if (File.Exists(_path) == false || Directory.Exists(_newPath) == false) throw new PathFileException();
        File.Move(_path, Path.Combine(_newPath, _fileName));
    }
}