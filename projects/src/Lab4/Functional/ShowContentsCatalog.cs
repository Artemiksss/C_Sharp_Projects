using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.Functional;

public class ShowContentsCatalog : ICommand
{
    private readonly string _path;
    public ShowContentsCatalog(string path)
    {
        _path = path;
    }

    public void Execute()
    {
        if (Directory.Exists(_path) == false) throw new PathFileException();
        foreach (string file in Directory.GetDirectories(_path))
        {
            if (file.Contains("/.", StringComparison.OrdinalIgnoreCase) == false)
            {
                Console.WriteLine("--- " + Path.GetFileName(file));
            }
        }

        foreach (string file in Directory.GetFiles(_path))
        {
            if (file.Contains("/.", StringComparison.OrdinalIgnoreCase) == false)
            {
                Console.WriteLine("--- " + Path.GetFileName(file));
            }
        }
    }
}