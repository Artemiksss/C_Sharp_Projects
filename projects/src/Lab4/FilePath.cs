using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FilePath : IFilePath
{
    public FilePath(string path)
    {
        MainPath = path;
        FileName = Path.GetFileName(path);
        RelativePath = Path.GetRelativePath(@"/Users/", path);
    }

    public string MainPath { get; private set; }
    public string FileName { get; private set; }
    public int Depth { get; private set; }
    public string RelativePath { get; private set; }
    public void SetMainPath(string path)
    {
        MainPath = path;
    }

    public void SetFileName(string fileName)
    {
        FileName = fileName;
    }

    public void SetDepth(int depth)
    {
        Depth = depth;
    }

    public void SetRelativePath(string relativePat)
    {
        RelativePath = relativePat;
    }
}