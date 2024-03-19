using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class ShowContentsFiles : ICommand
{
    private readonly string _resultPath;
    public ShowContentsFiles(string path)
    {
        _resultPath = path;
    }

    public void Execute()
    {
        if (File.Exists(_resultPath) == false) throw new PathFileException();
        string? content = File.ReadAllText(_resultPath);
        Console.WriteLine(content);
    }
}