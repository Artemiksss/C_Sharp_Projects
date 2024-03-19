using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class RenamingFiles : ICommand
{
    private readonly string _path;
    private readonly string _newName;
    public RenamingFiles(string path, string newName)
    {
        _path = path;
        _newName = newName;
    }

    public void Execute()
    {
        if (File.Exists(_path) == false) throw new PathFileException();
        string? directory = Path.GetDirectoryName(_path);
        if (directory is null) throw new PathFileException();
        File.Move(_path, Path.Combine(directory, _newName));
    }
}