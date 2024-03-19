using System;
using Itmo.ObjectOrientedProgramming.Lab4.CommandParser;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public class FileSystem
{
    private readonly Parser _parser = new Parser(0);
    public void StartProgram()
    {
        Console.WriteLine("------Welcome to the file system!------");
        bool stopProgram = true;
        while (stopProgram)
        {
            Console.WriteLine("Enter the command:");
            string? command = Console.ReadLine();
            if (command is null) throw new CommandException();
            if (command == "stop") stopProgram = false;
            _parser.Parsing(command);
        }

        Console.WriteLine("------The program is stopped!------");
    }
}