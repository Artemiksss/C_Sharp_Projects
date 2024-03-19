using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Status;

namespace Itmo.ObjectOrientedProgramming.Lab4.CommandParser;

public abstract class CommandHandler
{
    private static IFileSystemContext _fileSystemContext = new LocalFileSystemContext(new Disconnected());
    private static List<string> _commands = new List<string>();

    public static IFileSystemContext GetFileSystemContext => _fileSystemContext;
    public static ICollection<string> Commands => _commands;
    public static bool TestParsing { get; private set; }
    public static void SetFileSystemContext(IFileSystemContext fileSystemContext)
    {
        _fileSystemContext = fileSystemContext;
    }

    public static void SetCommand(string command)
    {
        _commands.Add(command);
    }

    public static void ActivateTest()
    {
        TestParsing = true;
    }

    public static void ResultParsing(string command)
    {
        CommandHandler.SetCommand(command);
    }

    public abstract CommandHandler SetNext(CommandHandler handler);
    public abstract void Handle(string[] commandParts);
}