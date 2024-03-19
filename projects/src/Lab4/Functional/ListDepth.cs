using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class ListDepth : ICommand
{
    private readonly string _path;
    public ListDepth(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        string relativePath = Path.GetRelativePath(@"/Users/", _path);
        string[] pathComponents = relativePath.Split(Path.DirectorySeparatorChar);
        int depth = pathComponents.Length - 1;
        Console.WriteLine($"File depth: {depth}");
    }
}