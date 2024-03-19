namespace Itmo.ObjectOrientedProgramming.Lab4;

public interface IFilePath
{
    public void SetMainPath(string path);
    public void SetFileName(string fileName);
    public void SetDepth(int depth);
    public void SetRelativePath(string relativePat);
}